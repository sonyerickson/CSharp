using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuDestinatario.Financeiro
{
    public partial class addConta : Form
    {
        Conexao co = new Conexao();
        public addConta()
        {
            InitializeComponent();

            string query0 = "SELECT nome FROM bancos";
            co.SqldataReader(co.execCommand(query0, co.conecta()), cmbBanco, "nome");
        }
        public void salvar()
        {
            if (txtNome.Text == "" || txtCC.Text == "" || txtAgencia.Text == "")
            {
                MessageBox.Show("Preencha os dados corretamente.!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Model.Mod.ModelContas mo = new Model.Mod.ModelContas();
                mo.idbanco = txtID.Text;
                mo.nome = txtNome.Text;
                mo.idconta = txtCC.Text;
                mo.nagencia = txtAgencia.Text;

                string query0 = "INSERT INTO contas (nome, id_banco, n_conta, n_agencia)VALUES('" + mo.nome + "', (SELECT id_banco FROM bancos WHERE nome = '" + cmbBanco.Text + "'), "
                + "'" + mo.idconta + "', '" + mo.nagencia + "')";
                co.cadContas(mo, query0);
                MessageBox.Show("Nova conta salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void limpar()
        {

        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            salvar();
            limpar();
        }
    }
}
