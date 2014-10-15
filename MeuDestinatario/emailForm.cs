using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

using System.Web;
using System.Net.Mail;

namespace MeuDestinatario
{
    public partial class emailForm : Form
    {
        public emailForm()
        {
            InitializeComponent();
            
            textBox6.PasswordChar = '*';
            
        }

        private void botEnviar_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(textBox1.Text,textBox2.Text,textBox3.Text,richTextBox1.Text);
            //mail.Attachments.Add(new Attachment(textBox7.Text));
            //mail.Attachments.Add(new Attachment(textBox8.Text));

            SmtpClient client = new SmtpClient(textBox4.Text);

            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(textBox5.Text, textBox6.Text);
            client.EnableSsl = false;
            client.Send(mail);
            MessageBox.Show("E-mail enviado com sucesso", "Sucess", MessageBoxButtons.OK);
        }

        private void botAnexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string arqPath = fileDialog.FileName.ToString();
                textBox7.Text = arqPath;
            }
        }

        private void botAnexar2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string arqPath = fileDialog.FileName.ToString();
                textBox8.Text = arqPath;
            }

        }
    }
}
