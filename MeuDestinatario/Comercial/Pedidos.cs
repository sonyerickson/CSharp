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
    public partial class Pedidos : Form
    {
        string strConexao = System.Configuration.ConfigurationManager.AppSettings["StringConexao"];
        MySqlConnection connection;
        MySqlDataAdapter adapter;
        DataTable DTPedidos;
        
        public Pedidos()
        {
            InitializeComponent();
            fillPedidos();
            fillComboBox();
            bloquear();

            connection = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
            DTPedidos = GetPedidos();
            //connection.Close();


            dataGridView1.DataSource = DTPedidos;

            //   txt_idpedido.DataBindings.Add("Text", DTPedidos, "IDPedido");
            
        }

        void fillComboBox()
        {
            string constring = "SERVER=dbmy0101.whservidor.com;DATABASE=meudestina;UID=meudestina;PASSWORD=LS45JU!@joao;";
            string query = "SELECT Nome FROM usuarios";
            string query2 = "SELECT descricao FROM tipo_status";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);

            

            MySqlDataReader myReader;
            MySqlDataReader myReader2;

            


            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("Nome");
                    
                    comboBox1.Items.Add(sName);                   
                }
                conDataBase.Close();
                conDataBase.Open();
                MySqlCommand cmdDataBase2 = new MySqlCommand(query2, conDataBase);
                myReader2 = cmdDataBase2.ExecuteReader();
                
                while (myReader2.Read())
                {
                    string sStatus = myReader2.GetString("descricao");
                    cmbStatus.Items.Add(sStatus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillPedidos()
        {
            string constring = "SERVER=dbmy0101.whservidor.com;DATABASE=meudestina;UID=meudestina;PASSWORD=LS45JU!@joao;";
            string query = "SELECT usuarios.Nome FROM pedidos INNER JOIN usuarios ON pedidos.id_nome = usuarios.Codigo";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                   // string sName = myReader.GetString("Nome");

                  //  datatable.Rows.Add(myReader["Nome"].ToString());
                  // listBox1.Items.Add(sName);
                  // listBox1.Items.Add("Nome");
                    
                                      
                }
             //   DataRow[] dtRow = datatable.Select(texto);

                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillList2()
        {
       //     string texto = "Nome";

            DataTable datatable = new DataTable();
            // datatable.Columns.Add("Nome", typeof(string));


        }

        private void limpar()
        {
            txt_idpedido.Text = "";
            comboBox1.Text = "";
            txtCodRastreamento.Text = "";
            cmbStatus.Text = "";
            dateTimePicker1.Text = "";
            txtQntEst.Text = "";
            txtListaItens.Text = "";
            dateTimePicker2.Text = "";
            txtQntFin.Text = "";
            dateTimePicker3.Text = "";
        }
        
        private void bloquear()
        {
            this.txt_idpedido.Enabled = false;
            this.comboBox1.Enabled = false;
            this.txtCodRastreamento.Enabled = false;
            this.cmbStatus.Enabled = false;
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
            this.txtQntEst.Enabled = true;
            this.txtValorEst.Enabled = true;
            this.txtListaItens.Enabled = true;
            this.txtQntFin.Enabled = true;
            this.txtValorPago.Enabled = true;
        }

        private void carregar()
        {
            /*
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

        public DataTable GetPedidos()
        {
            try
            {
                string query = "SELECT pedidos.IDPedido, usuarios.Nome, pedidos.CRastreamento, tipo_status.descricao, pedidos.DataPedido, pedidos.QntEst, pedidos.ListaItens, pedidos.QntFinal, pedidos.DataChegada, pedidos.DataRetirada FROM pedidos INNER JOIN (usuarios, tipo_status) ON pedidos.id_nome = usuarios.Codigo AND pedidos.id_status = tipo_status.id_status ;";
                adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                

                //SET UPDATE AND PARAMETERS
                adapter.UpdateCommand = new MySqlCommand(
                    "UPDATE pedidos SET CRastreamento=@CRastreamento, ListaItens=@ListaItens, QntEst=@QntEst, QntFinal=@QntFinal WHERE IDPedido=@IDPedido;", connection);
                adapter.UpdateCommand.Parameters.Add("@IDPedido", MySqlDbType.Int16, 10, "IDPedido");
                adapter.UpdateCommand.Parameters.Add("@CRastreamento", MySqlDbType.VarChar, 13, "CRastreamento");
                adapter.UpdateCommand.Parameters.Add("@ListaItens", MySqlDbType.Text, 300, "ListaItens");
                adapter.UpdateCommand.Parameters.Add("@QntEst", MySqlDbType.Int16, 5, "QntEst");
                adapter.UpdateCommand.Parameters.Add("@QntFinal", MySqlDbType.Int16, 5, "QntFinal");
                adapter.UpdateCommand.Parameters.Add("@Status", MySqlDbType.VarChar, 20, "");

                adapter.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                //SET DELET AND PARAMETERS
                adapter.DeleteCommand = new MySqlCommand(
                    "DELETE FROM pedidos WHERE IDPedido=@IDPedido;", connection);
                adapter.DeleteCommand.Parameters.Add("@IDPedido", MySqlDbType.Int16, 12, "IDPedido");

                adapter.DeleteCommand.UpdatedRowSource = UpdateRowSource.None;

                //SET INSERT AND PARAMETERS
                adapter.InsertCommand = new MySqlCommand(
                    "", connection);
                adapter.InsertCommand.Parameters.Add("@CRastreamento", MySqlDbType.Int16, 10, "CRastreamento");

                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        //MÉTODOS PRONTOS

        private void Pedidos_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
            DTPedidos = GetPedidos();
            //connection.Close();
        

            dataGridView1.DataSource = DTPedidos;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

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

            Binding testebin = new Binding("Text", DTPedidos, "IDPedido", true, DataSourceUpdateMode.OnPropertyChanged);           
          */
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow DTRow = new DataGridViewRow();
            DTRow = dataGridView1.Rows[e.RowIndex];

            txt_idpedido.Text = DTRow.Cells[0].Value.ToString();
            comboBox1.Text = DTRow.Cells[1].Value.ToString();
            cmbStatus.Text = DTRow.Cells[3].Value.ToString();
            txtCodRastreamento.Text = DTRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = DTRow.Cells[4].Value.ToString();
            txtListaItens.Text = DTRow.Cells[6].Value.ToString();
            txtQntEst.Text = DTRow.Cells[5].Value.ToString();
            txtQntFin.Text = DTRow.Cells[7].Value.ToString();
            dateTimePicker2.Text = DTRow.Cells[8].Value.ToString();
            dateTimePicker3.Text = DTRow.Cells[9].Value.ToString();
        }

        // BOTÕES

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(DTPedidos);
                DTPedidos = GetPedidos();
                dataGridView1.DataSource = DTPedidos;
                MessageBox.Show("Pedidos alterados com sucesso...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                adapter.Update(DTPedidos);

                DTPedidos = GetPedidos();
                dataGridView1.DataSource = DTPedidos;
                MessageBox.Show("O item selecionado foi excluído...");
            }
            else
            {
                MessageBox.Show("É necessário selecionar a linha inteira para excluir o pedido.");
            }
        }

        private void botNovoPedido_Click(object sender, EventArgs e)
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
                       
            string query = "INSERT INTO pedidos (CRastreamento, ListaItens, id_nome, id_status, DataPedido, QntEst, QntFinal, DataChegada, DataRetirada) "
            + "values('" + moPedidos.CRastreamento + "', '" + moPedidos.ListaItens + "', (SELECT Codigo FROM usuarios WHERE usuarios.Nome = '" + comboBox1.Text + "'),"
            + " (SELECT id_status FROM tipo_status WHERE tipo_status.descricao = '" + cmbStatus.Text + "'), '" + moPedidos.DataChegada + "', '" + moPedidos.QntEst + "',"
            + " '" + moPedidos.QntFin + "', '" + moPedidos.DataChegada + "', '" + moPedidos.DataRetirada + "')";
            
            conex.cadPedidos(moPedidos, query);

            conex.desconecta();
            limpar();
            bloquear();

            DTPedidos = GetPedidos();
            dataGridView1.DataSource = DTPedidos;

        }

        private void botAtualizar_Click(object sender, EventArgs e)
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

           // string query = "UPDATE pedidos set CRastreamento = '" + moPedidos.CRastreamento + "', id_nome = (SELECT Codigo FROM usuarios WHERE usuarios.Nome = '" + comboBox1.Text + "') WHERE IDPedido  = '" + txt_idpedido.Text + "'";

            string query = "UPDATE pedidos set CRastreamento = '" + moPedidos.CRastreamento + "', ListaItens = '" + moPedidos.ListaItens + "',"
+ "id_nome = (SELECT Codigo FROM usuarios WHERE usuarios.Nome = '" + comboBox1.Text + "'), id_status = (SELECT id_status FROM tipo_status WHERE tipo_status.descricao = '" + cmbStatus.Text + "'),"
+ "DataPedido = '" + moPedidos.DataPedido + "', QntEst = '" + moPedidos.QntEst + "', QntFinal = '" + moPedidos.QntFin + "', DataChegada = '" + moPedidos.DataChegada + "',"
+ "DataRetirada = '" + moPedidos.DataRetirada + "', ValorEst = '" + moPedidos.ValorEst + "', ValorPago = '" + moPedidos.ValorPago + "' WHERE IDPedido  = '" + txt_idpedido.Text + "'";
            

            conex.cadPedidos(moPedidos, query);

            MessageBox.Show("Dados alterados com sucesso!", "Sucesso", MessageBoxButtons.OK);

            conex.desconecta();
            limpar();
            bloquear();
            


            DTPedidos = GetPedidos();
            dataGridView1.DataSource = DTPedidos;

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
        {
            DataView DV = new DataView(DTPedidos);
            DV.RowFilter = string.Format("Nome LIKE '%{0}%'", txtSearchNome.Text);
            dataGridView1.DataSource = DV;
        }






    }
}


