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
    public partial class addBanco : Form
    {
        public addBanco()
        {
            InitializeComponent();
        }
        public void salvar()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo do nome é obrigatório!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Model.Mod.ModelBancos ba = new Model.Mod.ModelBancos();
                Conexao con = new Conexao();

                ba.nome = txtNome.Text;
                ba.idbanco = txtID.Text;

                string query0 = "INSERT INTO bancos (nome)VALUES('" + ba.nome + "')";
                con.cadBancos(ba, query0);
                MessageBox.Show("Novo banco salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void limpar()
        {
            txtID.Text = "";
            txtNome.Text = "";
        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            salvar();
            limpar();   
        }
        public void fill()
        {

        }
    }
}
