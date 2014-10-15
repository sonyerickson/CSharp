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
    public partial class pgContasPagar : Form
    {
        Conexao co = new Conexao();
        DataGridViewRow gd = new DataGridViewRow();
        Model.ModContasPagar.ModeladdConta mo = new Model.ModContasPagar.ModeladdConta();
        DataGridViewRow dtrow = new DataGridViewRow();
        DataView dt = new DataView();
        DataView dt1 = new DataView();

        int qnt_parc = 0;
        int fat_stat = 1;

        public pgContasPagar()
        {
            InitializeComponent();
            fill();
        }

        public void salvar()
        {

        }

        public void fill()
        {
            panel4.Enabled = false;
            bloquear();
            string query0 = "SELECT nome FROM form_pagto ORDER BY nome ASC";
            co.SqldataReader(co.execCommand(query0, co.conecta()), cmbFormPgto, "nome");
            string query1 = "SELECT nome FROM pc_categoria ORDER BY";
        }

        public void limpar()
        {

        }

        private void pgContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.DataTable'. Você pode movê-la ou removê-la conforme necessário.
            //this.dataTableTableAdapter.Fill(this.dataSet1.DataTable);

        }

        private void TSB_Listar_Click(object sender, EventArgs e)
        {
            try
            {

                Financeiro.consDespPag cons = new consDespPag();
                cons.ShowDialog();
                string format0 = "dddd/MM/yy";

                if (cons.DialogResult == DialogResult.OK)
                {
                    gd = cons.DGRow();
                    lblCodigo.Text = gd.Cells[0].Value.ToString();
                    lblFornecedor.Text = gd.Cells[1].Value.ToString();
                    lblValorTotal.Text = gd.Cells[2].Value.ToString();
                    lblVlrPago.Text = gd.Cells[3].Value.ToString();
                    qnt_parc = Convert.ToInt32(gd.Cells[4].Value.ToString());
                    lblCondPgto.Text = gd.Cells[5].Value.ToString();
                    lblDtCompra.Text = gd.Cells[6].Value.ToString();
                    mo.dtCompra = Convert.ToDateTime(gd.Cells[6].Value);
                    cmbCategoria.Text = gd.Cells[9].Value.ToString();
                    cmbGrupo.Text = gd.Cells[10].Value.ToString();
                    cmbSubGrupo.Text = gd.Cells[11].Value.ToString();


                    dt.Table = co.GetGlobal("SELECT * FROM v_fat_apagar_a ORDER BY 'N.Fatura ASC'");
                    dt1.Table = co.GetGlobal("SELECT  `N.Despesa`, `N.Fatura`, `N.Parcela`, `Valor`, `Data de Vencimento` FROM `v_fat_apagar_a` ORDER BY `N.Fatura`");
                    dt.RowFilter = string.Format("N.Despesa = '{0}'", gd.Cells[0].Value.ToString());
                    dt1.RowFilter = string.Format("N.Despesa = '{0}'", gd.Cells[0].Value.ToString());
                    
                    dataGridView1.DataSource = dt1;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    panel4.Enabled = true;
                }
                if (cons.DialogResult == DialogResult.Cancel)
                {

                }
            }
            catch (Exception erro1)
            {
                MessageBox.Show("Erro Interno. \n '" +  erro1.Message + "'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int Fat(string Cod)
        {
            int num = 0;
            if(Cod == "A")
            {
                num = 1;
            }
            if(Cod == "C")
            {
                num = 2;
            }
            if(Cod == "P")
            {
                num = 3;
            }

            return num;
        }

        public void Refill()
        {
            
            dt1.Table.Clear();
            dt1.Table = co.GetGlobal("SELECT  `N.Despesa`, `N.Fatura`, `N.Parcela`, `Valor`, `Data de Vencimento` FROM `v_fat_apagar_a` ORDER BY `N.Fatura`");
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dt1.RowFilter = string.Format("N.Despesa = '{0}'", gd.Cells[0].Value.ToString());
            string query1 = "SELECT ValorPago FROM despesas WHERE id_despesas = '" + lblCodigo.Text + "'";
            lblVlrPago.Text = co.SqldataReaderString(co.execCommand(query1, co.conecta()), "ValorPago");
        }

        private void pagar()
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            DateTime dtPag = dtPagamento.Value;

            try
            {
                if (cmbFormPgto.Text == "Dinheiro")
                {
                    try
                    {
                        if (txtVlrPago.Text != "" && dtrow.Cells.Count > 0)
                        {
                            string vlPago = txtVlrPago.Text;
                            decimal vlrPago = Convert.ToDecimal(vlPago);
                            string codigoFat = dtrow.Cells[1].Value.ToString();
                            string codigoDesp = dtrow.Cells[0].Value.ToString();

                            string query3 = "SELECT ValorPago FROM despesas WHERE id_despesas = '" + codigoDesp + "'";
                            decimal vlrPago0 = Convert.ToDecimal(co.SqldataReaderString(co.execCommand(query3, co.conecta()), "ValorPago"));

                            decimal vlrPgTotal = vlrPago0 + vlrPago;
                            decimal vlrparc = Convert.ToDecimal(gd.Cells[2].Value.ToString()) / qnt_parc;
                            decimal vlrParcela = Math.Round(vlrparc, 2);
                            MessageBox.Show(vlrParcela.ToString());
                            

                            try
                            {
                                if (vlrPago > vlrParcela)
                                {
                                    MessageBox.Show("O valor do pagamento é maior que o valor da parcela.\n\n Deseja lançar crédito no fornecedor ?", "Pagar Conta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                }
                                if (vlrPago == vlrParcela)
                                {
                                    string query1 = "UPDATE fat_apagar SET valorPago = '" + vlrPago.ToString().Replace(",", ".") + "', dataPagamento = '" + dtPag.ToString(format) + "', fat_stat = '3'"
                                    + " WHERE id_fat_apagar = '" + codigoFat + "'";
                                    // string query5 = "UPDATE fat_apagar SET dataPagamento = '" + dtPag.ToString(format) + "' WHERE id_fat_apagar = '" + codigoFat + "'";
                                    // string query2 = "UPDATE despesas SET ValorPago = ('" + vlrPgTotal.ToString().Replace(",", ".") + "') WHERE id_despesas = '" + codigoDesp + "'";
                                    string query4 = "INSERT INTO ccorrente (tipo, id_conta, dtrans, id_origem, id_Forn_CLi, n_documento, vlrTrans, VlrSaldo) VALUES"
                                    + "('2', )";
                                    co.Insert(query1);
                                    MessageBox.Show("Despesa paga com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Refill();
                                    
                                    
                                }
                                if (vlrPago < vlrParcela)
                                {
                                    MessageBox.Show("O valor do pagamento é menor que o valor da parcela.\n\nDeseja reparcelar a fatura ?", "Pagar Conta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                }
                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show("Erro\n '" + erro.Message + "'");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha os campos corretamente!", "Erro no preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (MySql.Data.MySqlClient.MySqlException er)
                    {
                        MessageBox.Show("Eroo\n '" + er.Message + "'");
                    }
                }
                if (cmbFormPgto.Text == "Cartão de Crédito")
                {

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException er)
            {
                MessageBox.Show("Erro Interno.\n '" + er.Message + "'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFormPgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormPgto.Text == "" || cmbFormPgto.Text == null)
            {

            }
            else
            {
                try
                {
                    if (cmbFormPgto.Text == "Dinheiro")
                    {
                        desbloquear();
                        string query0 = "SELECT nome FROM contas ORDER BY nome ASC";
                        co.SqldataReader(co.execCommand(query0, co.conecta()), cmbCC, "nome");
                        //LABEL CONTA
                        this.lblConta.Visible = true;
                        this.lblConta.AutoSize = true;
                        this.lblConta.Location = new System.Drawing.Point(104, 36);
                        this.lblConta.Name = "lblConta";
                        this.lblConta.Size = new System.Drawing.Size(38, 13);
                        this.lblConta.TabIndex = 20;
                        this.lblConta.Text = "Conta:";

                        // COMBO CONTA CORRENTE

                        this.cmbCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        this.cmbCC.FormattingEnabled = true;
                        this.cmbCC.ItemHeight = 13;
                        this.cmbCC.Location = new System.Drawing.Point(148, 33);
                        this.cmbCC.Name = "cmbCC";
                        this.cmbCC.Size = new System.Drawing.Size(121, 21);
                        this.cmbCC.TabIndex = 4;

                        // LABEL VALOR TOTAL
                        /*
                        this.lblValorTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblValorTotal.Location = new System.Drawing.Point(160, 63);
                        this.lblValorTotal.Name = "lblValorTotal";
                        this.lblValorTotal.Size = new System.Drawing.Size(214, 23);
                        this.lblValorTotal.TabIndex = 106;
                        */
                        // TXT VALOR TOTAL

                        this.txtVlrPago.Location = new System.Drawing.Point(148, 60);
                        this.txtVlrPago.Name = "txtVlrPago";
                        this.txtVlrPago.Size = new System.Drawing.Size(121, 20);
                        this.txtVlrPago.TabIndex = 12;

                        // LBL DATA DE PAGAMENTO

                        this.lblDataPgto.AutoSize = true;
                        this.lblDataPgto.Location = new System.Drawing.Point(43, 90);
                        this.lblDataPgto.Name = "lblDataPgto";
                        this.lblDataPgto.Size = new System.Drawing.Size(105, 13);
                        this.lblDataPgto.TabIndex = 15;
                        this.lblDataPgto.Text = "Data de Pagamento:";

                        // DATE TIME DATA DE PAGAMENTO

                        this.dtPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
                        this.dtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                        this.dtPagamento.Location = new System.Drawing.Point(148, 87);
                        this.dtPagamento.Name = "dtPagamento";
                        this.dtPagamento.Size = new System.Drawing.Size(121, 20);
                        this.dtPagamento.TabIndex = 14;
                    }
                    if (cmbFormPgto.Text == "Cartão de Crédito")
                    {
                        desbloquear();
                        //LABEL CONTA
                        this.lblConta.Visible = true;
                        this.lblConta.AutoSize = true;
                        this.lblConta.Location = new System.Drawing.Point(104, 36);
                        this.lblConta.Name = "lblConta";
                        this.lblConta.Size = new System.Drawing.Size(38, 13);
                        this.lblConta.TabIndex = 20;
                        this.lblConta.Text = "Cartão:";

                        // COMBO CONTA CORRENTE

                        this.cmbCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        this.cmbCC.FormattingEnabled = true;
                        this.cmbCC.ItemHeight = 13;
                        this.cmbCC.Location = new System.Drawing.Point(148, 33);
                        this.cmbCC.Name = "cmbCC";
                        this.cmbCC.Size = new System.Drawing.Size(121, 21);
                        this.cmbCC.TabIndex = 4;

                        // LABEL VALOR TOTAL
                        /*
                        this.lblValorTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblValorTotal.Location = new System.Drawing.Point(160, 63);
                        this.lblValorTotal.Name = "lblValorTotal";
                        this.lblValorTotal.Size = new System.Drawing.Size(214, 23);
                        this.lblValorTotal.TabIndex = 106;
                        */
                        // TXT VALOR TOTAL

                        this.txtVlrPago.Location = new System.Drawing.Point(148, 60);
                        this.txtVlrPago.Name = "txtVlrPago";
                        this.txtVlrPago.Size = new System.Drawing.Size(121, 20);
                        this.txtVlrPago.TabIndex = 12;

                        // LBL DATA DE PAGAMENTO

                        this.lblDataPgto.AutoSize = true;
                        this.lblDataPgto.Location = new System.Drawing.Point(43, 90);
                        this.lblDataPgto.Name = "lblDataPgto";
                        this.lblDataPgto.Size = new System.Drawing.Size(105, 13);
                        this.lblDataPgto.TabIndex = 15;
                        this.lblDataPgto.Text = "Data de Pagamento:";

                        // DATE TIME DATA DE PAGAMENTO

                        this.dtPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
                        this.dtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                        this.dtPagamento.Location = new System.Drawing.Point(148, 87);
                        this.dtPagamento.Name = "dtPagamento";
                        this.dtPagamento.Size = new System.Drawing.Size(121, 20);
                        this.dtPagamento.TabIndex = 14;

                    }
                    if (cmbFormPgto.Text == "Cheque")
                    {
                        desbloquear();
                        //LABEL CONTA
                        this.lblConta.Visible = true;
                        this.lblConta.AutoSize = true;
                        this.lblConta.Location = new System.Drawing.Point(104, 36);
                        this.lblConta.Name = "lblConta";
                        this.lblConta.Size = new System.Drawing.Size(38, 13);
                        this.lblConta.TabIndex = 20;
                        this.lblConta.Text = "Cheque:";

                        // COMBO CONTA CORRENTE

                        this.cmbCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        this.cmbCC.FormattingEnabled = true;
                        this.cmbCC.ItemHeight = 13;
                        this.cmbCC.Location = new System.Drawing.Point(148, 33);
                        this.cmbCC.Name = "cmbCC";
                        this.cmbCC.Size = new System.Drawing.Size(121, 21);
                        this.cmbCC.TabIndex = 4;

                        // LABEL VALOR TOTAL
                        /*
                        this.lblValorTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblValorTotal.Location = new System.Drawing.Point(160, 63);
                        this.lblValorTotal.Name = "lblValorTotal";
                        this.lblValorTotal.Size = new System.Drawing.Size(214, 23);
                        this.lblValorTotal.TabIndex = 106;
                        */
                        // TXT VALOR TOTAL

                        this.txtVlrPago.Location = new System.Drawing.Point(148, 60);
                        this.txtVlrPago.Name = "txtVlrPago";
                        this.txtVlrPago.Size = new System.Drawing.Size(121, 20);
                        this.txtVlrPago.TabIndex = 12;

                        // LBL DATA DE PAGAMENTO

                        this.lblDataPgto.AutoSize = true;
                        this.lblDataPgto.Location = new System.Drawing.Point(43, 90);
                        this.lblDataPgto.Name = "lblDataPgto";
                        this.lblDataPgto.Size = new System.Drawing.Size(105, 13);
                        this.lblDataPgto.TabIndex = 15;
                        this.lblDataPgto.Text = "Data de Pagamento:";

                        // DATE TIME DATA DE PAGAMENTO

                        this.dtPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
                        this.dtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                        this.dtPagamento.Location = new System.Drawing.Point(148, 87);
                        this.dtPagamento.Name = "dtPagamento";
                        this.dtPagamento.Size = new System.Drawing.Size(121, 20);
                        this.dtPagamento.TabIndex = 14;
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro no changebox");
                }
            }
        }

        private void desbloquear()
        {

            this.lblConta.Visible = true;
            this.cmbCC.Visible = true;
            this.lblValorPago.Visible = true;
            this.txtVlrPago.Visible = true;
            this.lblDataPgto.Visible = true;
            this.dtPagamento.Visible = true;
            this.button1.Visible = true;
        }

        private void bloquear()
        {
            panel4.Enabled = false;
            this.lblConta.Visible = false;
            this.cmbCC.Visible = false;
            this.lblValorPago.Visible = false;
            this.txtVlrPago.Visible = false;
            this.lblDataPgto.Visible = false;
            this.dtPagamento.Visible = false;
            this.button1.Visible = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtrow = dataGridView1.Rows[e.RowIndex];
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtrow = dataGridView1.Rows[e.RowIndex];
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pagar();
        }




    }
}
