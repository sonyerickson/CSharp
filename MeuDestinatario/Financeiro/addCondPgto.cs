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
    public partial class addCondPgto : Form
    {
        Conexao co = new Conexao();

        public addCondPgto()
        {
            InitializeComponent();
            fill();
        }
        public void fill()
        {
            string query1 = "SELECT id_desp_cond_pgto FROM desp_cond_pagto";
            txtID.Text = co.SqldataReaderString(co.execCommand(query1, co.conecta()), "id_desp_cond_pgto");
        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            salvar();
            limpar();
        }
        public void salvar()
        {
            if (txtDescricao.Text == "" || txtDias.Text == "" || txtParcelas.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro no preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Model.Mod.ModelDespCondPgto mo = new Model.Mod.ModelDespCondPgto();
                mo.descricao = txtDescricao.Text;
                mo.qntparcela = txtParcelas.Text;
                mo.qntdias = txtDias.Text;
                string query0 = "INSERT INTO desp_cond_pagto (descricao, qnt_parc, qnt_dias)VALUES ('" + mo.descricao + "', '" + mo.qntparcela + "', '" + mo.qntdias + "')";
                co.Insert(query0);
                MessageBox.Show("Despesa gravada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void limpar()
        {
            txtDescricao.Text = "";
            txtDias.Text = "";
            txtParcelas.Text = "";
            fill();
        }

        private void TSB_NovoPedido_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
