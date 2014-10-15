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
    public partial class addCliente : Form
    {
        Conexao con = new Conexao();
        public addCliente()
        {
            InitializeComponent();
            fill();
        }

        public void salvar()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo do nome é obrigatório!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Model.Mod.ModelClientes mo = new Model.Mod.ModelClientes();
                mo.Nome = txtNome.Text;
                mo.idclientes = txtID.Text;
                mo.Endereco = txtEndereco.Text;
                mo.Telefone = txtTelefone.Text;
                mo.Email = txtEmail.Text;

                string query0 = "INSERT INTO clientes (Nome, Endereço, Telefone, Email)VALUES('" + mo.Nome + "', '" + mo.Endereco + "', '" + mo.Telefone + "',"
                + "'" + mo.Email + "')";
                
                con.insertGlobal(mo, query0);
                MessageBox.Show("Cliente Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                fill();

            }
                        
        }
        public void limpar()
        {
            txtNome.Text = "";
            txtID.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtNome.Focus();
        }

        private void TSB_NovoPedido_Click(object sender, EventArgs e)
        {
            limpar();
            fill();
        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            salvar();
        }
        private void fill()
        {
            string query0 = "SELECT id_clientes FROM clientes";
            int a = 1;
            int b = Convert.ToInt32(con.SqldataReaderString(con.execCommand(query0, con.conecta()), "id_clientes"));
            int c = a + b;
            txtID.Text = c.ToString();
        }
    }
}
