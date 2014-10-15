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
    public partial class Login : Form
    {
        private Conexao conex = new Conexao();
        
        private string UsuarioAtivo;
        public Login()
        {
            InitializeComponent();
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtSenha.PasswordChar = '*';
            txtSenha.CharacterCasing = CharacterCasing.Lower;
            txtSenha.TextAlign = HorizontalAlignment.Center;
        }

        public string userAtivo
        {
            get { return UsuarioAtivo; }
            set { UsuarioAtivo = value; }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            
            string query1 = "SELECT Nome FROM usuarios WHERE Nome = '" + txtUsuario.Text + "'";
            string query0 = "SELECT Senha FROM usuarios WHERE Nome = '" + txtUsuario.Text + "'";

            try
            {
                if (txtUsuario.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("O usuário não existe.", "Usuário incorreto!", MessageBoxButtons.OK);
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                }
                else
                {
                    try
                    {
                        if (txtUsuario.Text == conex.SqldataReaderString(conex.execCommand(query1, conex.conecta()), "Nome"))
                        {
                            UsuarioAtivo = txtUsuario.Text;
                            //conex.SqldataReaderString(conex.execCommand(query0, conex.conecta()), senha, "Senha");
                            if (txtSenha.Text == conex.SqldataReaderString(conex.execCommand(query0, conex.conecta()), "Senha"))
                            {
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("A senha digitada está incorreta.", "Senha incorreta!", MessageBoxButtons.OK);
                                this.DialogResult = System.Windows.Forms.DialogResult.None;
                            }
                        }
                        else
                        {
                            MessageBox.Show("O usuário não existe.", "Usuário incorreto!", MessageBoxButtons.OK);
                            this.DialogResult = System.Windows.Forms.DialogResult.None;
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("erro 1\n '" + erro.Message + "'");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro 1\n '" + erro.Message + "'");
            }
        }


        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string query1 = "SELECT Nome FROM usuarios WHERE Nome = '" + txtUsuario.Text + "'";
                string query0 = "SELECT Senha FROM usuarios WHERE Nome = '" + txtUsuario.Text + "'";

                try
                {
                    if (txtUsuario.Text == "" || txtSenha.Text == "")
                    {
                        MessageBox.Show("O usuário não existe.", "Usuário incorreto!", MessageBoxButtons.OK);
                        this.DialogResult = System.Windows.Forms.DialogResult.None;
                    }
                    else
                    {
                        try
                        {
                            if (txtUsuario.Text == conex.SqldataReaderString(conex.execCommand(query1, conex.conecta()), "Nome"))
                            {
                                UsuarioAtivo = txtUsuario.Text;
                                //conex.SqldataReaderString(conex.execCommand(query0, conex.conecta()), senha, "Senha");
                                if (txtSenha.Text == conex.SqldataReaderString(conex.execCommand(query0, conex.conecta()), "Senha"))
                                {
                                    DialogResult = System.Windows.Forms.DialogResult.OK;
                                }
                                else
                                {
                                    MessageBox.Show("A senha digitada está incorreta.", "Senha incorreta!", MessageBoxButtons.OK);
                                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                                }
                            }
                            else
                            {
                                MessageBox.Show("O usuário não existe.", "Usuário incorreto!", MessageBoxButtons.OK);
                                this.DialogResult = System.Windows.Forms.DialogResult.None;
                            }
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("erro 1\n '" + erro.Message + "'");
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("erro 1\n '" + erro.Message + "'");
                }
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                string query1 = "SELECT Nome FROM usuarios WHERE Nome = '" + txtUsuario.Text + "'";
                string query0 = "SELECT Senha FROM usuarios WHERE Nome = '" + txtUsuario.Text + "'";


                try
                {
                    if (txtUsuario.Text == "" || txtSenha.Text == "")
                    {
                        MessageBox.Show("O usuário não existe.", "Usuário incorreto!", MessageBoxButtons.OK);
                        this.DialogResult = System.Windows.Forms.DialogResult.None;
                    }
                    else
                    {
                        try
                        {
                            if (txtUsuario.Text == conex.SqldataReaderString(conex.execCommand(query1, conex.conecta()), "Nome"))
                            {
                                UsuarioAtivo = txtUsuario.Text;
                                //conex.SqldataReaderString(conex.execCommand(query0, conex.conecta()), senha, "Senha");
                                if (txtSenha.Text == conex.SqldataReaderString(conex.execCommand(query0, conex.conecta()), "Senha"))
                                {
                                    DialogResult = System.Windows.Forms.DialogResult.OK;
                                }
                                else
                                {
                                    MessageBox.Show("A senha digitada está incorreta.", "Senha incorreta!", MessageBoxButtons.OK);
                                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                                }
                            }
                            else
                            {
                                MessageBox.Show("O usuário não existe.", "Usuário incorreto!", MessageBoxButtons.OK);
                                this.DialogResult = System.Windows.Forms.DialogResult.None;
                            }
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("erro 1\n '" + erro.Message + "'");
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("erro 1\n '" + erro.Message + "'");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }



    }
}
