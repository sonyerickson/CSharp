using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuDestinatario.Comercial
{
    public partial class addFornecedor : Form
    {
        Conexao con = new Conexao();
        public addFornecedor()
        {
            InitializeComponent();
            fill();
        }
        public void Salvar()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo do nome é obrigatório!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Model.Mod.ModelFornecedores mo = new Model.Mod.ModelFornecedores();
                
                mo.id_fornecedor = txtID.Text;
                mo.nome = txtNome.Text;
                mo.Cnpj = txtCNPJ.Text;

                string query0 = "INSERT INTO fornecedores (Nome, Cnpj)VALUES ('" + mo.nome + "', '" + mo.Cnpj + "')";
                con.cadFornecedores(mo, query0);
                MessageBox.Show("Novo Fornecedor Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        public void limpar()
        {
            txtNome.Text = "";
            txtCNPJ.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtNome.Focus();
        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            Salvar();
            limpar();
        }

        private void TSB_NovoPedido_Click(object sender, EventArgs e)
        {
            limpar();
            fill();
        }
        private void fill()
        {
            string query0 = "SELECT id_fornecedor FROM fornecedores";

            int a = 1;
            int b = Convert.ToInt32(con.SqldataReaderString(con.execCommand(query0, con.conecta()), "id_fornecedor"));
            int c = a + b;
            txtID.Text = c.ToString();
        }
    }
}
