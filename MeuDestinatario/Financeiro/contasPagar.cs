using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace MeuDestinatario.Financeiro
{
    public partial class contasPagar : Form
    {
        Conexao co = new Conexao();
        int num = 0;

        public contasPagar()
        {
            InitializeComponent();
            fill();
            /*
            DateTime dt = DateTime.Now;
            DateTime an = dt.AddMonths(1);
            dateDataVencimento.Value = an;
             * */
        }

        public void fill()
        {
            try
            {
                string query3 = "SELECT Nome FROM fornecedores ORDER BY Nome ASC";
                string query4 = "SELECT nome FROM contas ORDER BY Nome ASC";
                string query5 = "SELECT MAX(id_despesas) AS 'Soma' FROM despesas";
                co.SqldataReader(co.execCommand(query3, co.conecta()), cmbFornecedor, "Nome");
                co.SqldataReader(co.execCommand(query4, co.conecta()), cmbCC, "Nome");
                num = Convert.ToInt32(co.SqldataReaderString(co.execCommand(query5, co.conecta()), "Soma"));
                num = num + 1;
                txtCodigo.Text = num.ToString();
                string query2 = "SELECT descricao FROM desp_cond_pagto";
                co.SqldataReader(co.execCommand(query2, co.conecta()), cmbCondPgto, "descricao");
                string query1 = "SELECT nome FROM form_pagto";
                co.SqldataReader(co.execCommand(query1, co.conecta()), cmbFormPgto, "nome");

                /*
                string query6 = "SELECT MAX(valor) AS 'Conta' FROM fat_apagar";
                string codd = co.SqldataReaderString(co.execCommand(query6, co.conecta()), "Conta");
                cmbCategoria.Text = string.Format("{0:C}", Convert.ToDecimal(codd.Replace(".", ",")));
                string.Format("{0:C}", Convert.ToDecimal(txtValorTotal.Text.Replace(".", ",")));
                 */

                string query6 = "SELECT nome FROM pc_categoria ORDER BY id_categoria ASC";
                co.SqldataReader(co.execCommand(query6, co.conecta()), cmbCategoria, "nome");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro no preenchimento dos campos '" + erro.Message + "'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void salvar()
        {

            Model.Mod.ModelContasPagar mo = new Model.Mod.ModelContasPagar();
            string format = "yyyy-MM-dd HH:mm:ss";
            decimal vlrparcela = 0;
            decimal parcela = 0;

            Model.Mod.ModelFatPagar mop = new Model.Mod.ModelFatPagar();

            if (cmbFornecedor.Text == "" || txtValorTotal.Text == "" || cmbCondPgto.Text == "" || cmbCC.Text == "" || cmbFormPgto.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro no preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string txt = txtValorTotal.Text.ToString().Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim();
                    //MessageBox.Show(txt);

                    Model.Mod.ModelDespCondPgto ds = new Model.Mod.ModelDespCondPgto();
                    string query3 = "SELECT qnt_parc FROM desp_cond_pagto WHERE descricao = '" + cmbCondPgto.Text + "'";
                    parcela = Convert.ToInt32(co.SqldataReaderString(co.execCommand(query3, co.conecta()), "qnt_parc"));

                    mo.idcontapagar = txtCodigo.Text;
                    mo.idfornecedor = cmbFornecedor.Text;
                    mo.datadecompra = dateDataDeCompra.Value.ToString(format);
                    mo.datadevencimento = dateDataVencimento.Value.ToString(format);
                    mo.valorTotal = Convert.ToDecimal(txtValorTotal.Text);
                    // mop.datavencimento = mo.datadevencimento;

                    string query0 = "INSERT INTO despesas (id_nomeFornecedor, DataDeCompra, DataDeVencimento, ValorTotal, qnt_parcelas, id_desp_stat,"
                    + " id_categoria, Grupo, ValorPago)VALUES("
                    + "(SELECT id_fornecedor FROM fornecedores WHERE Nome = '" + cmbFornecedor.Text + "'),"
                    + "'" + mo.datadecompra + "','" + mo.datadevencimento + "', '" + txtValorTotal.Text.ToString().Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim() + "',"
                    + "'" + parcela.ToString() + "', '1', '0.00' )";
                    // co.cadDespesas(mo, query0);

                    try
                    {
                        //parcela = Convert.ToInt32(cmbCondPgto.Text);
                        vlrparcela = mo.valorTotal / parcela;
                        mop.vlrparcela = vlrparcela;

                        string query2 = "SELECT MAX(id_despesas) AS 'Conta' FROM despesas";
                        string cod = co.SqldataReaderString(co.execCommand(query2, co.conecta()), "Conta");
                        string query5 = "INSERT INTO fat_apagar (id_despesas, valor, id_conta, DataDeVencimento, id_fornecedor, id_form_pgto, n_parcela, fat_stat)VALUES "
        + "('" + cod + "', '" + vlrparcela.ToString().Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim() + "',(SELECT id_contas FROM contas WHERE "
         + "nome = '" + cmbCC.Text + "'), '" + mo.datadevencimento + "', (SELECT id_fornecedor FROM fornecedores WHERE Nome = '" + cmbFornecedor.Text + "'), "
         + " (SELECT id_form_pagto FROM form_pagto WHERE nome = '" + cmbFormPgto.Text + "'), '" + parcela + "', (SELECT id_desp_stat FROM desp_stat WHERE desp_desc = 'Aberta'))";
                        //  co.Insert(query5);

                        string query6 = "SELECT qnt_dias FROM desp_cond_pagto WHERE descricao = '" + cmbCondPgto.Text + "'";
                        int days = Convert.ToInt32(co.SqldataReaderString(co.execCommand(query6, co.conecta()), "qnt_dias"));

                        Model.ModContasPagar.ModeladdConta mod = new ModContasPagar.ModeladdConta();
                        mod.fornecedores = cmbFornecedor.Text;
                        mod.vlrParcela = vlrparcela;
                        mod.vlrTotal = mo.valorTotal;
                        mod.qntParcela = Convert.ToInt32(co.SqldataReaderString(co.execCommand(query3, co.conecta()), "qnt_parc"));
                        mod.qntDias = days;
                        mod.dtVencimento = dateDataVencimento.Value;
                        mod.dtCompra = dateDataDeCompra.Value;
                        mod.condPgto = cmbCondPgto.Text;
                        mod.formPgto = cmbFormPgto.Text;
                        mod.conta = cmbCC.Text;
                        mod.categoria = cmbCategoria.Text;
                        mod.grupo = cmbGrupo.Text;
                        mod.subgrupo = cmbSubGrupo.Text;
                        mod.codigo = num - 1;

                        confContaPagar conf = new confContaPagar(mod);
                        conf.ShowDialog();
                        if (conf.DialogResult == System.Windows.Forms.DialogResult.OK)
                        {
                            limpar();

                        }
                        else
                        {

                        }
                        for (int i = 1; i < parcela; i++)
                        {
                            mop.datavencimento = dateDataVencimento.Value.AddDays(i * days).ToString(format);

                            string query1 = "INSERT INTO fat_apagar (id_despesas, valor, id_conta, DataDeVencimento, id_fornecedor, id_form_pgto, n_parcela, fat_stat)VALUES "
        + "('" + cod + "', '" + vlrparcela.ToString().Replace("$", "").Replace("R", "").Replace(".", "").Replace(",", ".").Trim() + "',(SELECT id_contas FROM contas WHERE "
        + "nome = '" + cmbCC.Text + "'), '" + mop.datavencimento + "', (SELECT id_fornecedor FROM fornecedores WHERE Nome = '" + cmbFornecedor.Text + "'), (SELECT id_form_pagto FROM form_pagto WHERE nome = '" + cmbFormPgto.Text + "'), '" + i + "',"
                            + " (SELECT id_desp_stat FROM desp_stat WHERE desp_desc = 'Aberta'))";
                            // co.Insert(query1);

                            /*
                            MessageBox.Show(parcela.ToString());
                            MessageBox.Show(Convert.ToString(vlrparcela));
                            MessageBox.Show(mop.vlrparcela.ToString());
                            //mo.value = parcela;
                             * */
                        }
                        //MessageBox.Show("Despesa gravada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //   limpar();

                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Erro no segundo For \n '" + er.Message + "'");
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Algo deu errado no primeiro! '" + erro.Message + "'");
                }

            }
        }

        public void save()
        {
            Model.Mod.ModelContasPagar mo = new Model.Mod.ModelContasPagar();
            string format = "yyyy-MM-dd HH:mm:ss";
            decimal vlrparcela = 0;
            decimal parcela = 0;

            Model.Mod.ModelFatPagar mop = new Model.Mod.ModelFatPagar();

            if (cmbFornecedor.Text == "" || txtValorTotal.Text == "" || cmbCondPgto.Text == "" || cmbCC.Text == "" || cmbFormPgto.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro no preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string txt = txtValorTotal.Text.ToString().Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim();
                    MessageBox.Show(txt);

                    Model.Mod.ModelDespCondPgto ds = new Model.Mod.ModelDespCondPgto();
                    string query3 = "SELECT qnt_parc FROM desp_cond_pagto WHERE descricao = '" + cmbCondPgto.Text + "'";
                    parcela = Convert.ToInt32(co.SqldataReaderString(co.execCommand(query3, co.conecta()), "qnt_parc"));

                    mo.idcontapagar = txtCodigo.Text;
                    mo.idfornecedor = cmbFornecedor.Text;
                    mo.datadecompra = dateDataDeCompra.Value.ToString(format);
                    mo.datadevencimento = dateDataVencimento.Value.ToString(format);
                    mo.valorTotal = Convert.ToDecimal(txtValorTotal.Text);
                    // mop.datavencimento = mo.datadevencimento;

                    string query0 = "INSERT INTO despesas (id_nomeFornecedor, DataDeCompra, DataDeVencimento, ValorTotal, qnt_parcelas, id_desp_stat)VALUES("
                    + "(SELECT id_fornecedor FROM fornecedores WHERE Nome = '" + cmbFornecedor.Text + "'),"
                    + "'" + mo.datadecompra + "','" + mo.datadevencimento + "', '" + txtValorTotal.Text.ToString().Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim() + "',"
                    + "'" + parcela.ToString() + "', '1' )";
                    co.cadDespesas(mo, query0);

                    try
                    {
                        //parcela = Convert.ToInt32(cmbCondPgto.Text);
                        vlrparcela = mo.valorTotal / parcela;
                        mop.vlrparcela = vlrparcela;

                        string query2 = "SELECT MAX(id_despesas) AS 'Conta' FROM despesas";
                        string cod = co.SqldataReaderString(co.execCommand(query2, co.conecta()), "Conta");
                        string query5 = "INSERT INTO fat_apagar (id_despesas, valor, id_conta, DataDeVencimento, id_fornecedor, id_form_pgto, n_parcela, fat_stat)VALUES "
        + "('" + cod + "', '" + vlrparcela.ToString().Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim() + "',(SELECT id_contas FROM contas WHERE "
         + "nome = '" + cmbCC.Text + "'), '" + mo.datadevencimento + "', (SELECT id_fornecedor FROM fornecedores WHERE Nome = '" + cmbFornecedor.Text + "'), "
         + " (SELECT id_form_pagto FROM form_pagto WHERE nome = '" + cmbFormPgto.Text + "'), '" + parcela + "', (SELECT id_desp_stat FROM desp_stat WHERE desp_desc = 'Aberta'))";
                        co.Insert(query5);

                        int days = 15;
                        for (int i = 1; i < parcela; i++)
                        {
                            mop.datavencimento = dateDataVencimento.Value.AddDays(i * days).ToString(format);

                            string query1 = "INSERT INTO fat_apagar (id_despesas, valor, id_conta, DataDeVencimento, id_fornecedor, id_form_pgto, n_parcela, fat_stat)VALUES "
        + "('" + cod + "', '" + vlrparcela.ToString().Replace("$", "").Replace("R", "").Replace(".", "").Replace(",", ".").Trim() + "',(SELECT id_contas FROM contas WHERE "
        + "nome = '" + cmbCC.Text + "'), '" + mop.datavencimento + "', (SELECT id_fornecedor FROM fornecedores WHERE Nome = '" + cmbFornecedor.Text + "'), (SELECT id_form_pagto FROM form_pagto WHERE nome = '" + cmbFormPgto.Text + "'), '" + i + "',"
                            + " (SELECT id_desp_stat FROM desp_stat WHERE desp_desc = 'Aberta'))";
                            co.Insert(query1);

                            /*
                            MessageBox.Show(parcela.ToString());
                            MessageBox.Show(Convert.ToString(vlrparcela));
                            MessageBox.Show(mop.vlrparcela.ToString());
                            //mo.value = parcela;
                             * */
                        }
                        MessageBox.Show("Despesa gravada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Erro no segundo For \n '" + er.Message + "'");
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Algo deu errado no primeiro! '" + erro.Message + "'");
                }

            }

        }

        public void verificaParcelas()
        {

            // int parc = Convert.ToInt32(cmbParcelas.Text);
            //MessageBox.Show(parc.ToString());
        }

        public void limpar()
        {
            txtValorTotal.Text = "";
            cmbFormPgto.Text = "";
            cmbFormPgto.Items.Clear();
            cmbFornecedor.Text = "";
            cmbFornecedor.Items.Clear();
            cmbCC.Text = "";
            cmbCC.Items.Clear();
            cmbGrupo.Text = "";
            cmbGrupo.Items.Clear();
            cmbCondPgto.Text = "";
            cmbCondPgto.Items.Clear();
            cmbCategoria.Text = "";
            cmbCategoria.Items.Clear();
            cmbSubGrupo.Text = "";
            cmbSubGrupo.Items.Clear();

            dateDataDeCompra.Value = DateTime.Now;
            dateDataVencimento.Value = DateTime.Now;
            fill();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            //txtValorTotal.Text = string.Format("{0:C}", Convert.ToDecimal(txtValorTotal.Text));
        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void TSB_NovoPedido_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void TSB_Listar_Click(object sender, EventArgs e)
        {
            conFatPagar co = new conFatPagar();
            co.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comercial.addFornecedor fo = new Comercial.addFornecedor();
            fo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Financeiro.addCondPgto co = new addCondPgto();
            co.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Financeiro.addConta ne = new addConta();
            ne.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Financeiro.addFormPgto fm = new addFormPgto();
            fm.ShowDialog();
        }

        private void cmbCondPgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtValorTotal.Text == "" || txtValorTotal.Text == "0")
            {
                MessageBox.Show("Voçe precisa preenchar o compo do valor total.", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal parcela = 0;
                decimal vlrTotal = 0;
                decimal vlrparcela = 0;
                string query3 = "SELECT qnt_parc FROM desp_cond_pagto WHERE descricao = '" + cmbCondPgto.Text + "'";
                parcela = Convert.ToInt32(co.SqldataReaderString(co.execCommand(query3, co.conecta()), "qnt_parc"));
                vlrTotal = Convert.ToDecimal(txtValorTotal.Text);


                string query6 = "SELECT qnt_dias FROM desp_cond_pagto WHERE descricao = '" + cmbCondPgto.Text + "'";
                int days = Convert.ToInt32(co.SqldataReaderString(co.execCommand(query6, co.conecta()), "qnt_dias"));


                vlrparcela = vlrTotal / parcela;


                txtVlrParcela.Text = vlrparcela.ToString();
            }

        }

        private void cmbCategoria_TextChanged(object sender, EventArgs e)
        {

            cmbGrupo.Items.Clear();
            string query0 = "SELECT nome FROM pc_grupo WHERE id_categoria = (SELECT id_categoria FROM pc_categoria WHERE"
        + " nome = '" + cmbCategoria.Text + "')";
            co.SqldataReader(co.execCommand(query0, co.conecta()), cmbGrupo, "nome");

        }

        private void cmbGrupo_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbCategoria.Text != "")
            {
                cmbGrupo.Items.Clear();
                string query0 = "SELECT nome FROM pc_grupo WHERE id_categoria = (SELECT id_categoria FROM pc_categoria WHERE"
            + " nome = '" + cmbCategoria.Text + "')";
                co.SqldataReader(co.execCommand(query0, co.conecta()), cmbGrupo, "nome");
            }
            else
            {
                MessageBox.Show("Selecione uma Categoria.", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbSubGrupo_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbCategoria.Text != "" && cmbGrupo.Text != "")
            {
                cmbSubGrupo.Items.Clear();
                string query0 = "SELECT nome FROM pc_sub_grupo WHERE id_categoria = (SELECT id_categoria FROM pc_categoria WHERE"
            + " nome = '" + cmbCategoria.Text + "') AND id_pc_grupo = (SELECT id_pc_grupo FROM pc_grupo WHERE nome = '" + cmbGrupo.Text + "')";
                co.SqldataReader(co.execCommand(query0, co.conecta()), cmbSubGrupo, "nome");
            }
            else
            {
                MessageBox.Show("Selecione uma Categoria e um Grupo.", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
