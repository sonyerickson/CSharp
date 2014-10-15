using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MeuDestinatario
{
    public partial class CadUsuario : Form
    {

        public CadUsuario()
        {
            InitializeComponent();
            fillListView();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void botCadastrarUser_Click(object sender, EventArgs e)
        {
            Modelos mo = new Modelos();
            Conexao Conex = new Conexao();

            if (txtNome.Text == "")
            {
                MessageBox.Show("O Nome deve ser preenchido.");
            }
            else
            {

                mo.Codigo = txtCodigo.Text;
                mo.Nome = txtNome.Text;
                mo.Email = txtEmail.Text;
                mo.Endereco = txtEndereco.Text;
                mo.Numero = txtNumero.Text;
                mo.Complemento = txtComplemento.Text;
                mo.Senha = txtSenha.Text;

                string query = "INSERT INTO usuarios(Codigo, Nome, Email, Endereco, Numero, Complemento, Senha)values('" + mo.Codigo + "','" + mo.Nome + "','" + mo.Email + "','" + mo.Endereco +
                        "','" + mo.Numero + "','" + mo.Complemento + "','" + mo.Senha + "')";

                Conex.cadUsuarios(mo, query);

                txtCodigo.Text = "";
                txtNome.Text = "";
                txtEmail.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtComplemento.Text = "";
                txtSenha.Text = "";

                MessageBox.Show("Cadastro efetuado com sucesso!");
                fillListView();
                Conex.desconecta();
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Home.ActiveForm.Show();
            //this.Close();
            this.Dispose();
            
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "SERVER=dbmy0101.whservidor.com;DATABASE=meudestina;UID=meudestina;PASSWORD=LS45JU!@joao;";
            string query = "SELECT Codigo FROM meudestina.usuarios where nome='" + listView1 + "'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sCodigo = myReader.GetString("Codigo").ToString();
                    string sNome = myReader.GetString("Nome").ToString();
                    string sEmail = myReader.GetString("Email").ToString();
                    txtCodigo.Text = sEmail;
                    txtNome.Text = sNome;
                    txtEmail.Text = sEmail;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillListView()
        {
            listView1.Items.Clear();

            string constring = "SERVER=dbmy0101.whservidor.com;DATABASE=meudestina;UID=meudestina;PASSWORD=LS45JU!@joao;";
            string query = "SELECT * FROM meudestina.usuarios;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {

                    ListViewItem itens = new ListViewItem(myReader["Codigo"].ToString());
                    itens.SubItems.Add(myReader["Nome"].ToString());
                    itens.SubItems.Add(myReader["Email"].ToString());
                    itens.SubItems.Add(myReader["Endereco"].ToString());
                    itens.SubItems.Add(myReader["Numero"].ToString());
                    itens.SubItems.Add(myReader["Complemento"].ToString());
                    itens.SubItems.Add(myReader["Senha"].ToString());

                    listView1.Items.Add(itens);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conDataBase.Close();
            }
        }


        
    }
}
