using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuDestinatario.Configuracao
{
    public partial class addUsuarios : Form
    {
        public addUsuarios()
        {
            InitializeComponent();
            pegaCodigo();
        }

        public void salvar()
        {

            if (txtNome.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Os campos do Nome e Senha são obrigatórios", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        /*    if (txtNome.Text == "")
            {
                MessageBox.Show("Os campos do Nome é obrigatório", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtSenha.Text != "")
            {
                MessageBox.Show("Os campos da Senha é obrigatório", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            else
            {
                Modelos mo = new Modelos();
                Conexao co = new Conexao();
                mo.Codigo = "";
                mo.Nome = txtNome.Text;
                mo.Email = txtEmail.Text;
                mo.Endereco = txtEndereco.Text;
                mo.Numero = txtNumero.Text;
                mo.Complemento = txtComplemento.Text;
                mo.Senha = txtSenha.Text;

                string query = "INSERT INTO usuarios(Codigo, Nome, Email, Endereco, Numero, Complemento, Senha)values('" + mo.Codigo + "','" + mo.Nome + "','" + mo.Email + "','" + mo.Endereco +
                        "','" + mo.Numero + "','" + mo.Complemento + "','" + mo.Senha + "')";
                co.cadUsuarios(mo, query);
                co.desconecta();
                MessageBox.Show("Pedido Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpar();
                pegaCodigo();
            }
        }

        public void limpar()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtSenha.Text = "";
        }

        public void pegaCodigo()
        {
            string query0 = "SELECT COdigo FROM usuarios";
            Conexao co = new Conexao();
            int a = 1;
            int b = Convert.ToInt32(co.SqldataReaderString(co.execCommand(query0, co.conecta()), "Codigo"));
            int c = b + 1;
            txtCodigo.Text = c.ToString();

        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void TSB_NovoPedido_Click(object sender, EventArgs e)
        {
            limpar();
            pegaCodigo();
        }

        private void TSB_Listar_Click(object sender, EventArgs e)
        {

        }
    }
}
