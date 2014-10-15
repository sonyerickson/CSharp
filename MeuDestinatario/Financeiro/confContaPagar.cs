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
    public partial class confContaPagar : Form
    {
        private decimal parcela;
        private decimal vlrparcela;
        private decimal vlrtotal;
        private DateTime dtVencimento;
        private DateTime dtCompra;
        private int days;

        private Conexao co = new Conexao();
        private DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        private DataGridViewRow dtvRow;
        private Model.ModContasPagar.ModeladdConta mod1;

        public confContaPagar(Model.ModContasPagar.ModeladdConta mod)
        {
            InitializeComponent();

            //txtFornecedor.Text = mod.fornecedores;
            //MessageBox.Show(mod.fornecedores);
            mod1 = mod;
            fill();

        }

        public void fill()
        {
            txtCodigo.Text = mod1.codigo.ToString();
            txtFornecedor.Text = mod1.fornecedores;
            txtValorTotal.Text = mod1.vlrTotal.ToString();
            txtConta.Text = mod1.conta;
            txtFormPgto.Text = mod1.formPgto;
            dtVencimento = mod1.dtVencimento;
            dtCompra = mod1.dtCompra;
            days = mod1.qntDias;

            string query9 = "SELECT descricao FROM desp_cond_pagto ORDER BY id_desp_cond_pgto";
            co.SqldataReader(co.execCommand(query9, co.conecta()), cmbCondPgto, "descricao");

            string query6 = "SELECT nome FROM pc_categoria ORDER BY id_categoria ASC";
            co.SqldataReader(co.execCommand(query6, co.conecta()), cmbCategoria, "nome");

            string query7 = "SELECT nome FROM pc_grupo ORDER BY id_pc_grupo ASC";
            co.SqldataReader(co.execCommand(query7, co.conecta()), cmbGrupo, "nome");

            string query8 = "SELECT nome FROM pc_sub_grupo WHERE id_pc_grupo != 28 ORDER BY id_sub_grupo ASC";
            co.SqldataReader(co.execCommand(query8, co.conecta()), cmbSubGrupo, "nome");

            cmbCondPgto.Text = mod1.condPgto;
            cmbCategoria.Text = mod1.categoria;
            cmbGrupo.Text = mod1.grupo;
            cmbSubGrupo.Text = mod1.subgrupo;

            string format = "dd/MM/yyyy";

            parcela = mod1.qntParcela;
            vlrparcela = mod1.vlrParcela;
            vlrtotal = mod1.vlrTotal;

            DataGridViewColumn cl = new DataGridViewColumn();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nº Parcela";
            dataGridView1.Columns[1].Name = "Valor da Parcela";
            dataGridView1.Columns[2].Name = "Data de Vencimento";
            dataGridView1.Rows.Add((1), vlrparcela.ToString(), dtCompra.ToString(format));

            // dataGridView1.Rows.Add("zero", "one", "two");
            //dataGridView1.Rows.Insert(0, "one", "two");


            for (int i = 1; i < parcela; i++)
            {

                dataGridView1.Rows.Add((i + 1), vlrparcela.ToString(), dtCompra.AddDays(i * days).ToString(format));
                //   MessageBox.Show(parcela.ToString());
            }




            try
            {
                DateTime dt0 = DateTime.Now;
                DateTime dt1 = DateTime.Now.AddDays(7);

                MessageBox.Show(dt1.ToString());
                string query10 = "SELECT SUM(SaldoFat) AS Soma FROM fat_apagar INNER JOIN fornecedores ON fat_apagar.id_fornecedor = fornecedores.id_fornecedor   "
+ " WHERE DATE(DataDeVencimento) between '" + dt0 + "' AND '" + dt1 + "' AND  fornecedores.Nome = '" + mod1.fornecedores + "'";
                co.SqldataReader(co.execCommand(query10, co.conecta()), lblVSem, "Soma");
            }
            catch(Exception err)
            {
                MessageBox.Show("Erro:\n'" + err.Message + "'");
            }


        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        public void salvar()
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            try
            {
                string txt = txtValorTotal.Text.ToString().Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim();
                string datePgto = mod1.dtCompra.ToString(format);
                //MessageBox.Show(txt);

                Model.Mod.ModelDespCondPgto ds = new Model.Mod.ModelDespCondPgto();
                //string query3 = "SELECT qnt_parc FROM desp_cond_pagto WHERE descricao = '" + cmbCondPgto.Text + "'";
                // parcela = Convert.ToInt32(co.SqldataReaderString(co.execCommand(query3, co.conecta()), "qnt_parc"));

                string query0 = "INSERT INTO despesas (id_nomeFornecedor, DataDeCompra, DataDeVencimento, ValorTotal, qnt_parcelas, id_desp_stat, id_cond_pgto, id_categoria, id_grupo, id_subgrupo, ValorPago)VALUES("
                + "(SELECT id_fornecedor FROM fornecedores WHERE Nome = '" + mod1.fornecedores + "'),'" + datePgto + "',"
                + "'" + mod1.dtVencimento.ToString(format) + "', '" + mod1.vlrTotal.ToString().Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim() + "',"
                + "'" + parcela.ToString() + "', '1' , (SELECT id_desp_cond_pgto FROM desp_cond_pagto WHERE descricao = '" + mod1.condPgto + "'), "
                + " (SELECT id_categoria FROM pc_categoria WHERE nome = '" + mod1.categoria + "'), (SELECT id_pc_grupo FROM pc_grupo WHERE "
                + " nome = '" + mod1.grupo + "'), (SELECT id_sub_grupo FROM pc_sub_grupo WHERE nome = '" + mod1.subgrupo + "'), '0.00')";
                co.Insert(query0);

                /*  
                 * 
                 * 
                 * */
                try
                {
                    string query2 = "SELECT MAX(id_despesas) AS 'Conta' FROM despesas";
                    string cod = co.SqldataReaderString(co.execCommand(query2, co.conecta()), "Conta");

                    string query5 = "INSERT INTO fat_apagar (id_despesas, valor, id_conta, DataDeVencimento, id_fornecedor, id_form_pgto, n_parcela, fat_stat)VALUES "
    + "('" + cod + "', '" + vlrparcela.ToString().Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim() + "',(SELECT id_contas FROM contas WHERE "
     + "nome = '" + mod1.conta + "'), '" + mod1.dtVencimento.ToString(format) + "', (SELECT id_fornecedor FROM fornecedores WHERE Nome = '" + mod1.fornecedores + "'), "
     + " (SELECT id_form_pagto FROM form_pagto WHERE nome = '" + mod1.formPgto + "'), '" + '1' + "', (SELECT id_fat_apagar_stat FROM fat_apagar_stat WHERE nome = 'Aberto'))";
                    co.Insert(query5);

                    try
                    {
                        for (int i = 1; i < parcela; i++)
                        {
                            string dateven = mod1.dtVencimento.AddDays(i * days).ToString(format);
                            string dateven1 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            


                            string query1 = "INSERT INTO fat_apagar (id_despesas, valor, id_conta, DataDeVencimento, id_fornecedor, id_form_pgto, n_parcela, fat_stat)VALUES "
        + "('" + cod + "', '" + vlrparcela.ToString().Replace("$", "").Replace("R", "").Replace(".", "").Replace(",", ".").Trim() + "',(SELECT id_contas FROM contas WHERE "
        + "nome = '" + mod1.conta + "'), '" + dateven + "', (SELECT id_fornecedor FROM fornecedores WHERE Nome = '" + mod1.fornecedores + "'), (SELECT id_form_pagto FROM form_pagto WHERE nome = '" + mod1.formPgto + "'), '" + (i + 1) + "',"
                            + " (SELECT id_desp_stat FROM desp_stat WHERE desp_desc = 'Aberta'))";
                            co.Insert(query1);
                        }
                        MessageBox.Show("Despesa gravada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("erro 1 \n'" + erro + "'");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("erro 2 \n'" + erro + "'");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro 3 \n'" + erro + "'");
            }
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            if (cmbCategoria.Text != "")
            {
                cmbGrupo.Items.Clear();
                string query0 = "SELECT nome FROM pc_grupo WHERE id_categoria = (SELECT id_categoria FROM pc_categoria WHERE"
            + " nome = '" + cmbCategoria.Text + "' ORDER BY id_pc_grupo)";
                co.SqldataReader(co.execCommand(query0, co.conecta()), cmbGrupo, "nome");
            }
            else
            {
                MessageBox.Show("Selecione uma Categoria.", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cmbCategoria.Text != "")
            {
                cmbCategoria.Items.Clear();
                string query0 = "SELECT nome FROM pc_grupo WHERE id_categoria = (SELECT id_categoria FROM pc_categoria WHERE"
            + " nome = '" + cmbCategoria.Text + "' ORDER BY id_pc_grupo)";
                co.SqldataReader(co.execCommand(query0, co.conecta()), cmbGrupo, "nome");
            }
            else
            {
                MessageBox.Show("Selecione uma Categoria.", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void cmbGrupo_MouseClick(object sender, MouseEventArgs e)
        {/*
            if (cmbCategoria.Text != "")
            {
                cmbGrupo.Items.Clear();
                string query0 = "SELECT nome FROM pc_grupo WHERE id_categoria = (SELECT id_categoria FROM pc_categoria WHERE"
            + " nome = '" + cmbCategoria.Text + "' ORDER BY id_pc_grupo)";
                co.SqldataReader(co.execCommand(query0, co.conecta()), cmbGrupo, "nome");
            }
            else
            {
                MessageBox.Show("Selecione uma Categoria.", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        public void edit()
        {
            foreach (DataGridViewRow dt0 in dataGridView1.Rows)
            {
                dt0.Cells[2].Value.ToString();

                
            }
        }
    }

}
