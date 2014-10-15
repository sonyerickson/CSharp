using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuDestinatario
{
    public partial class editUsuarios : Form
    {
        DataGridViewRow dtrow = new DataGridViewRow();
        public editUsuarios()
        {
            InitializeComponent();


        }
        public editUsuarios(DataGridViewRow datagridviewrow)
        {
            InitializeComponent();

            txtCodigo.Text = datagridviewrow.Cells[0].Value.ToString();
            txtNome.Text = datagridviewrow.Cells[1].Value.ToString();
            txtEmail.Text = datagridviewrow.Cells[2].Value.ToString();
            txtEndereco.Text = datagridviewrow.Cells[3].Value.ToString();
            txtNumero.Text = datagridviewrow.Cells[4].Value.ToString();
            txtComplemento.Text = datagridviewrow.Cells[5].Value.ToString();
            txtSenha.Text = datagridviewrow.Cells[6].Value.ToString();

            datagridviewrow = dtrow;

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
            MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK);
        }
        private void Salvar()
        {
            Conexao conex = new Conexao();
            Modelos mo = new Modelos();

            mo.Codigo = txtCodigo.Text;
            mo.Complemento = txtComplemento.Text;
            mo.Email = txtEmail.Text;
            mo.Endereco = txtEndereco.Text;
            mo.Nome = txtNome.Text;
            mo.Numero = txtNumero.Text;
            mo.Senha = txtSenha.Text;

            string query = "UPDATE usuarios SET Codigo = '" + mo.Codigo + "', Complemento = '" + mo.Complemento + "', Email = '" + mo.Email + "', Endereco = '" + mo.Endereco + "',"
                +"Nome = '" + mo.Nome + "', Numero = '" + mo.Numero + "', Senha = '" + mo.Senha + "' WHERE Codigo = '" + mo.Codigo + "'";
            conex.cadUsuarios(mo,query);
            conex.desconecta();
        }

        private void salvarEFecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
            MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK);
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = dtrow.Cells[0].Value.ToString();
            txtNome.Text = dtrow.Cells[1].Value.ToString();
            txtEmail.Text = dtrow.Cells[2].Value.ToString();
            txtEndereco.Text = dtrow.Cells[3].Value.ToString();
            txtNumero.Text = dtrow.Cells[4].Value.ToString();
            txtComplemento.Text = dtrow.Cells[5].Value.ToString();
            txtSenha.Text = dtrow.Cells[6].Value.ToString();

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
