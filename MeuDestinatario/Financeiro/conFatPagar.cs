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
    public partial class conFatPagar : Form
    {
        Conexao co = new Conexao();
        DataSet ds = new DataSet();
        DataView dtview = new DataView();
        DataGridViewRow DTRowPedidos = new DataGridViewRow();

        public conFatPagar()
        {
            InitializeComponent();
            fill();
            limparFiltros();
        }

        public void fill()
        {
            string query2 = "SELECT * FROM V_FAT_APAGAR";
            dataGridView1.DataSource = co.GetGlobal(query2);
            lblSomaTotal.Text = somaTotais().ToString();
            string query0 = "SELECT Nome FROM fornecedores ORDER BY Nome ASC";
            string query1 = "SELECT nome FROM fat_apagar_stat ORDER BY nome ASC";
            co.SqldataReader(co.execCommand(query0, co.conecta()), cmbFornecedor, "Nome");
            co.SqldataReader(co.execCommand(query1, co.conecta()), cmbStatus, "nome");
            cmbStatus.Text = "Aberto";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void limparFiltros()
        {
            txtCodigo.Text = "1";
            txtCodigo2.Text = "9999";
            cmbFornecedor.Text = "";
            cmbStatus.Text = "Aberto";
            dateVen1.Value = DateTime.Now;
            dateVen2.Value = DateTime.Parse("01/01/2050");
            datePgto1.Value = DateTime.Parse("01/01/2000");
            datePgto2.Value = DateTime.Parse("01/01/2000");
        }

        public void pesquisar()
        {
            string format = "yyyyMMdd";

            dtview.Table = co.GetFatAPagar();
            /*
            dtview.RowFilter = string.Format("Nome LIKE '%{0}%' AND Status LIKE '%{1}%'"
            + "AND Rastreamento LIKE '%{2}'", comboBox2.Text, cmbStatus.Text, txtCodigo.Text);
            dataGridView1.DataSource = dtview;
             */

            string dateven1 = dateVen1.Value.ToString(format);
            string dateven2 = dateVen2.Value.ToString(format);
            string datepgto1 = datePgto1.Value.ToString(format);
            string datepgto2 = datePgto2.Value.ToString(format);


            string query1 = "SELECT id_despesas AS 'Nº Despesa', id_fat_apagar AS 'Nº Fatura', fornecedores.Nome AS Fornecedor, valor AS Valor, valorPago AS 'Valor Pago', contas.nome AS Conta, DataDeVencimento AS 'Data de Vencimento'"
                + " , fat_apagar_stat.nome AS Status, dataPagamento AS 'Data de Pagamento' FROM (fat_apagar, contas, form_pagto, fat_apagar_stat) "
                + " INNER JOIN meudestina.fornecedores ON fornecedores.id_fornecedor = fat_apagar.id_fornecedor AND contas.id_contas = fat_apagar.id_conta AND form_pagto.id_form_pagto = fat_apagar.id_form_pgto AND fat_apagar_stat.id_fat_apagar_stat = fat_apagar.fat_stat"
            + " WHERE DATE(DataDeVencimento) BETWEEN '" + dateven1 + "' AND '" + dateven2 + "' AND DATE(dataPagamento) BETWEEN '" + datepgto1 + "' AND '" + datepgto2 + "' AND ((id_despesas)>='" + txtCodigo.Text + "') AND ((id_despesas)<='" + txtCodigo2.Text + "') "
            + " AND ((fornecedores.Nome) Like '%" + cmbFornecedor.Text + "%') AND ((fat_apagar_stat.nome) Like '%" + cmbStatus.Text + "%') ORDER BY 'Nº Fatura' ASC";

            DataView dt;

            // dtview.RowFilter = string.Format("'Nº Despesa' >= '%{0}%' ", txtCodigo.Text);
            dtview.RowFilter = string.Format("");
            //dtview.RowFilter = "'Data de Vencimento' >= " + dateven1 + "AND 'Data de Vencimento' <= " + dateven2;
            // dt = new DataView(co.GetFatAPagar().DataSet.Tables[0], "CDespesa >= '" + txtCodigo.Text + "' AND CDespesa <= '" + txtCodigo2.Text + "' AND DataDeVencimento >= '" + dateven1 + "'"
            //    + "AND DataDeVencimento <= '" + dateven2 + "'", "CDespesa Desc", DataViewRowState.CurrentRows);
            //dataGridView1.DataSource = dt;
            dataGridView1.DataSource = co.GetGlobal(query1);

            lblSomaTotal.Text = somaTotais().ToString();
        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        public decimal somaTotais()
        {
            decimal soma = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //MessageBox.Show(dataGridView1.Rows[i].Cells[3].Value.ToString().Replace(",", "."));
                soma = soma + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

            }
            return soma;
        }

        private void TSB_Limpar_Click(object sender, EventArgs e)
        {
            limparFiltros();
        }

        private void cancelFat()
        {
            string query0 = "UPDATE fat_apagar SET fat_stat = (SELECT id_fat_apagar_stat FROM fat_apagar_stat WHERE nome = 'Cancelada') "
            + " WHERE '" + DTRowPedidos.Cells[1].Value.ToString() + "' = id_fat_apagar";
            co.Insert(query0);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           // DTRowPedidos = dataGridView1.Rows[e.RowIndex];
        }

        private void TSB_Cancelar_Click(object sender, EventArgs e)
        {
            if (DTRowPedidos == null)
            {
                MessageBox.Show("Selecione uma fatura para cancelar.", "Erro no preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Tem certeza que deseja cadastrar a fatura ?", "Salvar ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result1 == DialogResult.Yes)
                {
                    cancelFat();
                    MessageBox.Show("Fatura cancelada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (result1 == DialogResult.Cancel)
                {

                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != 0)
            {
                DTRowPedidos = dataGridView1.Rows[e.RowIndex];
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            contasPagar co = new contasPagar();
            co.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
