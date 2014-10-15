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
    public partial class consDespPag : Form
    {
        Conexao co = new Conexao();
        DataGridViewRow dtgvrow = new DataGridViewRow();

        public consDespPag()
        {
            InitializeComponent();
            fill();
        }
        public void fill()
        {
            dataGridView1.DataSource = co.GetGlobal("SELECT * from V_DESPESAS_A");
            string query0 = "SELECT Nome FROM fornecedores ORDER BY Nome ASC";            
            co.SqldataReader(co.execCommand(query0, co.conecta()), cmbFornecedor, "Nome");

            

            
        }
        public void seleciona()
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtgvrow = dataGridView1.Rows[e.RowIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public DataGridViewRow DGRow()
        {
            return dtgvrow;
        }
    }
}
