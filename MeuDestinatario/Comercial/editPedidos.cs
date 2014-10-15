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
    public partial class editPedidos : Form
    {
        string strConexao = System.Configuration.ConfigurationManager.AppSettings["StringConexao"];
        MySqlDataReader myReader;

        DataGridViewRow datarow = new DataGridViewRow();
        //private events teste;

        public editPedidos(DataGridViewRow datagridviewrow)
        {
            InitializeComponent();
            string query = "SELECT Nome FROM usuarios order by Nome ASC";
            string query2 = "SELECT descricao FROM tipo_status";

            Conexao con = new Conexao();

            con.SqldataReader(con.execCommand(query, con.conecta()), comboBox1, "Nome");
            con.SqldataReader(con.execCommand(query2,con.conecta()),cmbStatus, "descricao");
            con.desconecta2();     
            
            

            txt_idpedido.Text = datagridviewrow.Cells[0].Value.ToString();
            comboBox1.Text = datagridviewrow.Cells[1].Value.ToString();
            txtCodRastreamento.Text = datagridviewrow.Cells[2].Value.ToString();
            cmbStatus.Text = datagridviewrow.Cells[3].Value.ToString();
            dateTimePicker1.Text = datagridviewrow.Cells[4].Value.ToString();
            txtQntEst.Text = datagridviewrow.Cells[5].Value.ToString();
            txtListaItens.Text = datagridviewrow.Cells[6].Value.ToString();
            txtQntFin.Text = datagridviewrow.Cells[7].Value.ToString();
            dateTimePicker2.Text = datagridviewrow.Cells[8].Value.ToString();
            dateTimePicker3.Text = datagridviewrow.Cells[9].Value.ToString();
            txtValorEst.Text = datagridviewrow.Cells[10].Value.ToString();
            txtValorPago.Text = datagridviewrow.Cells[11].Value.ToString();

            datarow = datagridviewrow;

        }




        public editPedidos()
        {
            InitializeComponent();
            string query = "SELECT Nome FROM usuarios order by Nome ASC";
            string query2 = "SELECT descricao FROM tipo_status";
            //   fillCmbNome(query, comboBox1, "Nome");
            Conexao con = new Conexao();

            con.SqldataReader(con.execCommand(query, con.conecta()), comboBox1, "Nome");
            con.SqldataReader(con.execCommand(query2, con.conecta()), cmbStatus, "descricao");
            con.desconecta2();

        }

        public editPedidos(DataGridView datagrid)
        {
            InitializeComponent();
            string query = "SELECT Nome FROM usuarios order by Nome ASC";
            string query2 = "SELECT descricao FROM tipo_status";
            //   fillCmbNome(query, comboBox1, "Nome");
            Conexao con = new Conexao();

            con.SqldataReader(con.execCommand(query, con.conecta()), comboBox1, "Nome");
            con.SqldataReader(con.execCommand(query2, con.conecta()), cmbStatus, "descricao");
            con.desconecta2();

        }

        private void Salvar()
        {
            ModelPedidos moPedidos = new ModelPedidos();
            Conexao conex = new Conexao();
            string format = "yyyy-MM-dd HH:mm:ss";

            moPedidos.IDPedido = txt_idpedido.Text;
            moPedidos.CRastreamento = txtCodRastreamento.Text;
            moPedidos.ListaItens = txtListaItens.Text;
            moPedidos.DataPedido = dateTimePicker1.Value.ToString(format);
            moPedidos.DataChegada = dateTimePicker2.Value.ToString(format);
            moPedidos.DataRetirada = dateTimePicker3.Value.ToString(format);
            moPedidos.QntEst = txtQntEst.Text;
            moPedidos.QntFin = txtQntFin.Text;
            moPedidos.ValorEst = txtValorEst.Text;
            moPedidos.ValorPago = txtValorPago.Text;
            

            string query = "UPDATE pedidos set CRastreamento = '" + moPedidos.CRastreamento + "', ListaItens = '" + moPedidos.ListaItens + "',"
+ "id_nome = (SELECT Codigo FROM usuarios WHERE usuarios.Nome = '" + comboBox1.Text + "'), id_status = (SELECT id_status FROM tipo_status WHERE tipo_status.descricao = '" + cmbStatus.Text + "'),"
+ "DataPedido = '" + moPedidos.DataPedido + "', QntEst = '" + moPedidos.QntEst + "', QntFinal = '" + moPedidos.QntFin + "', DataChegada = '" + moPedidos.DataChegada + "',"
+ "DataRetirada = '" + moPedidos.DataRetirada + "', ValorEst = '" + moPedidos.ValorEst + "', ValorPago = '" + moPedidos.ValorPago + "' WHERE IDPedido  = '" + txt_idpedido.Text + "'";

            conex.cadPedidos(moPedidos, query);

            MessageBox.Show("Dados alterados com sucesso!", "Sucesso", MessageBoxButtons.OK);

            conex.desconecta();
        }

        void fillCmbNome(string query, ComboBox combobox, string nomeColuna)
        {
            Conexao conex = new Conexao();                     

            try
            {             
                myReader = conex.execCommand(query,conex.conecta()).ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString(nomeColuna);

                    combobox.Items.Add(sName);
                }
                conex.desconecta2();            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
          
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarEFecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
            this.Dispose();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_idpedido.Text = datarow.Cells[0].Value.ToString();
            comboBox1.Text = datarow.Cells[1].Value.ToString();
            txtCodRastreamento.Text = datarow.Cells[2].Value.ToString();
            cmbStatus.Text = datarow.Cells[3].Value.ToString();
            dateTimePicker1.Text = datarow.Cells[4].Value.ToString();
            txtQntEst.Text = datarow.Cells[5].Value.ToString();
            txtListaItens.Text = datarow.Cells[6].Value.ToString();
            txtQntFin.Text = datarow.Cells[7].Value.ToString();
            dateTimePicker2.Text = datarow.Cells[8].Value.ToString();
            dateTimePicker3.Text = datarow.Cells[9].Value.ToString();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void cancelarPedido(DataGridViewRow dtrow)
        {
            Conexao conex = new Conexao();
            ModelPedidos mo = new ModelPedidos();

            if (dtrow.Cells.Count == 0)
            {
                MessageBox.Show("É necessário escolha uma linha para cancelar o pedido.", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                string query = "UPDATE pedidos set Cancelado = true where IDpedido = '" + dtrow.Cells[0].Value.ToString() + "'";

                conex.cadPedidos(mo, query);
                MessageBox.Show("Pedido cancelado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                conex.desconecta();
            }

        }

        private void editPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  teste.UmMetodo();
        }
         
        
    }
}
