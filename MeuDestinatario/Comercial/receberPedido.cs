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
using System.IO;
using System.Configuration;


namespace MeuDestinatario
{
    public partial class receberPedido : Form
    {
        string strConexao = System.Configuration.ConfigurationManager.AppSettings["StringConexao"];
        //MySqlConnection connection;
        //MySqlDataAdapter adapter;
        //DataTable DTreceberPedido;

      
        
        public receberPedido()
        {
            InitializeComponent();
            bloquear();

           
            
        }




        private void limpar()
        {
            txt_idpedido.Text = "";
            comboBox1.Text = "";
            txtCodRastreamento.Text = "";
            cmbStatus.Text = "";
            txtDataPedido.Text = "";
            txtQntEst.Text = "";
            txtListaItens.Text = "";
            txtDataRetirada.Text = "";
            txtQntFin.Text = "";
            txtDataChegada.Text = "";
        }
        
        private void bloquear()
        {
            this.txt_idpedido.Enabled = false;
            this.comboBox1.Enabled = false;
            this.txtCodRastreamento.Enabled = false;
            this.cmbStatus.Enabled = false;
            this.txtDataPedido.Enabled = false;
            this.txtQntEst.Enabled = false;
            this.txtValorEst.Enabled = false;
            this.txtListaItens.Enabled = false;            
            this.txtQntFin.Enabled = false;
            this.txtValorPago.Enabled = false;

        }

        private void desbloquear()
        {
            this.txt_idpedido.Enabled = true;
            this.comboBox1.Enabled = true;
            this.txtCodRastreamento.Enabled = true;
            this.cmbStatus.Enabled = true;
            this.txtDataPedido.Enabled = true;
            this.txtQntEst.Enabled = true;
            this.txtValorEst.Enabled = true;
            this.txtListaItens.Enabled = true;
            this.txtQntFin.Enabled = true;
            this.txtValorPago.Enabled = true;
        }

        private void carregar()
        {/*
            
            DataSet dataset = new DataSet();

            if (System.IO.File.Exists(@"c:\Users\Comp2\Documents\strconex.txt"))
            {
                StreamReader lerArq = new StreamReader(@"c:\Users\Comp2\Documents\strconex.txt");
                try
                {
                    string strConexao = lerArq.ReadLine();
                    MySqlConnection con = new MySqlConnection(strConexao);
                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        MySqlDataAdapter myAdapter = new MySqlDataAdapter("SELECT Nome FROM usuarios", con);

                        myAdapter.Fill(dataset, "Nome");
                        listBox1.DataSource = dataset;
                        MessageBox.Show("Deu Certo a leitura dos arquivos.");

                    }

                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }



        //MÉTODOS PRONTOS

        private void receberPedido_Load(object sender, EventArgs e)
        {

            

        }
        
        // DATAGRIDVIEW 1

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { /*
            DataGridViewRow DTRow = new DataGridViewRow();
            DTRow = dataGridView1.Rows[e.RowIndex];

            txt_idpedido.Text = DTRow.Cells[0].Value.ToString();
            comboBox1.Text = DTRow.Cells[1].Value.ToString();
            cmbStatus.Text = DTRow.Cells[3].Value.ToString();
            txtCodRastreamento.Text = DTRow.Cells[2].Value.ToString();
            txtDataPedido.Text = DTRow.Cells[4].Value.ToString();
            txtListaItens.Text = DTRow.Cells[6].Value.ToString();
            txtQntEst.Text = DTRow.Cells[5].Value.ToString();
            txtQntFin.Text = DTRow.Cells[7].Value.ToString();
            txtDataChegada.Text = DTRow.Cells[8].Value.ToString();
            txtDataRetirada.Text = DTRow.Cells[9].Value.ToString();

            Binding testebin = new Binding("Text", DTreceberPedido, "IDPedido", true, DataSourceUpdateMode.OnPropertyChanged);           
          */
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {/*
            DataGridViewRow DTRow = new DataGridViewRow();
            DTRow = dataGridView1.Rows[e.RowIndex];

            txt_idpedido.Text = DTRow.Cells[0].Value.ToString();
            comboBox1.Text = DTRow.Cells[1].Value.ToString();
            cmbStatus.Text = DTRow.Cells[3].Value.ToString();
            txtCodRastreamento.Text = DTRow.Cells[2].Value.ToString();
            txtDataPedido.Text = DTRow.Cells[4].Value.ToString();
            txtListaItens.Text = DTRow.Cells[6].Value.ToString();
            txtQntEst.Text = DTRow.Cells[5].Value.ToString();
            txtQntFin.Text = DTRow.Cells[7].Value.ToString();
            txtDataChegada.Text = DTRow.Cells[8].Value.ToString();
            txtDataRetirada.Text = DTRow.Cells[9].Value.ToString();
          * */
        }

        // BOTÕES

        private void button2_Click(object sender, EventArgs e)
        {/*
            try
            {
                adapter.Update(DTreceberPedido);
                DTreceberPedido = GetreceberPedido();
                dataGridView1.DataSource = DTreceberPedido;
                MessageBox.Show("receberPedido alterados com sucesso...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void botSair_Click(object sender, EventArgs e)
        {

            this.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {/*
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                adapter.Update(DTreceberPedido);

                DTreceberPedido = GetreceberPedido();
                dataGridView1.DataSource = DTreceberPedido;
                MessageBox.Show("O item selecionado foi excluído...");
            }
            else
            {
                MessageBox.Show("É necessário selecionar a linha inteira para excluir o pedido.");
            }*/
        }

        private void botNovoPedido_Click(object sender, EventArgs e)
        {/*
            ModelreceberPedido moreceberPedido = new ModelreceberPedido();
            Conexao conex = new Conexao();

            moreceberPedido.IDPedido = txt_idpedido.Text;
            moreceberPedido.CRastreamento = txtCodRastreamento.Text;
            moreceberPedido.ListaItens = txtListaItens.Text;
            moreceberPedido.DataPedido = txtDataPedido.Text;
            moreceberPedido.DataChegada = txtDataChegada.Text;
            moreceberPedido.DataRetirada = txtDataRetirada.Text;
            moreceberPedido.QntEst = txtQntEst.Text;
            moreceberPedido.QntFin = txtQntFin.Text;

            string query = "INSERT INTO receberPedido (CRastreamento, ListaItens, id_nome, id_status, DataPedido, QntEst, QntFinal, DataChegada, DataRetirada) "
            + "values('" + moreceberPedido.CRastreamento + "', '" + moreceberPedido.ListaItens + "', (SELECT Codigo FROM usuarios WHERE usuarios.Nome = '" + comboBox1.Text + "'),"
            + " (SELECT id_status FROM tipo_status WHERE tipo_status.descricao = '" + cmbStatus.Text + "'), '" + moreceberPedido.DataPedido + "', '" + moreceberPedido.QntEst + "',"
            + " '" + moreceberPedido.QntFin + "', '" + moreceberPedido.DataChegada + "', '" + moreceberPedido.DataRetirada + "')";

            conex.cadreceberPedido(moreceberPedido, query);

            conex.desconecta();
            limpar();
            bloquear();

            DTreceberPedido = GetreceberPedido();
            dataGridView1.DataSource = DTreceberPedido;
            */
        }

        private void botAtualizar_Click(object sender, EventArgs e)
        {/*
            ModelreceberPedido moreceberPedido = new ModelreceberPedido();
            Conexao conex = new Conexao();

            moreceberPedido.IDPedido = txt_idpedido.Text;
            moreceberPedido.CRastreamento = txtCodRastreamento.Text;
            moreceberPedido.ListaItens = txtListaItens.Text;
            moreceberPedido.DataPedido = txtDataPedido.Text;
            moreceberPedido.DataChegada = txtDataChegada.Text;
            moreceberPedido.DataRetirada = txtDataRetirada.Text;
            moreceberPedido.QntEst = txtQntEst.Text;
            moreceberPedido.QntFin = txtQntFin.Text;
            moreceberPedido.ValorEst = txtValorEst.Text;
            moreceberPedido.ValorPago = txtValorPago.Text;

           // string query = "UPDATE receberPedido set CRastreamento = '" + moreceberPedido.CRastreamento + "', id_nome = (SELECT Codigo FROM usuarios WHERE usuarios.Nome = '" + comboBox1.Text + "') WHERE IDPedido  = '" + txt_idpedido.Text + "'";

            string query = "UPDATE receberPedido set CRastreamento = '" + moreceberPedido.CRastreamento + "', ListaItens = '" + moreceberPedido.ListaItens + "',"
+ "id_nome = (SELECT Codigo FROM usuarios WHERE usuarios.Nome = '" + comboBox1.Text + "'), id_status = (SELECT id_status FROM tipo_status WHERE tipo_status.descricao = '" + cmbStatus.Text + "'),"
+ "DataPedido = '" + moreceberPedido.DataPedido + "', QntEst = '" + moreceberPedido.QntEst + "', QntFinal = '" + moreceberPedido.QntFin + "', DataChegada = '" + moreceberPedido.DataChegada + "',"
+ "DataRetirada = '" + moreceberPedido.DataRetirada + "', ValorEst = '" + moreceberPedido.ValorEst + "', ValorPago = '" + moreceberPedido.ValorPago + "' WHERE IDPedido  = '" + txt_idpedido.Text + "'";
            

            conex.cadreceberPedido(moreceberPedido, query);

            MessageBox.Show("Dados alterados com sucesso!", "Sucesso", MessageBoxButtons.OK);

            conex.desconecta();
            limpar();
            bloquear();
            


            DTreceberPedido = GetreceberPedido();
            dataGridView1.DataSource = DTreceberPedido;*/

        }

        private void botAlterar_Click(object sender, EventArgs e)
        {
            desbloquear();
        }

        private void botIncluir_Click(object sender, EventArgs e)
        {
            desbloquear();
            limpar();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {/*
            DataView DV = new DataView(DTreceberPedido);
            DV.RowFilter = string.Format("Nome LIKE '%{0}%'", txtSearchNome.Text);
            dataGridView1.DataSource = DV;
          * */
        }






    }
}


