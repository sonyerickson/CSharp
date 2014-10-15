using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;



namespace MeuDestinatario
{
    public class Conexao
    {

        string strConexao = System.Configuration.ConfigurationManager.AppSettings["StringConexao"];


        //private MySqlConnection conexao;
        private MySqlConnection conexao1;
        private MySqlConnection conexao2;
        private MySqlDataReader dataReader;
        private MySqlDataAdapter dataAdapter;


        // usa connect 1


        public void cadUsuarios(Modelos mo, string query)
        {
            Criptografar.Chave = "128";
            MySqlConnection conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
            try
            {
                conexao.Open();
                MySqlCommand comandos = new MySqlCommand(query, conexao);
                comandos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void cadPedidos(ModelPedidos model, string query)
        {
            Criptografar.Chave = "128";
            MySqlConnection conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
            try
            {
                Criptografar.Chave = "128";
                conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
                conexao.Open();

                MySqlCommand comandos = new MySqlCommand(query, conexao);
                comandos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void insertGlobal(Model.Mod.ModelClientes mod, string query)
        {
            Criptografar.Chave = "128";
            MySqlConnection conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
            try
            {
                Criptografar.Chave = "128";
                conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
                conexao.Open();

                MySqlCommand comandos = new MySqlCommand(query, conexao);
                comandos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void cadFornecedores(Model.Mod.ModelFornecedores mo, string query)
        {
            Criptografar.Chave = "128";
            MySqlConnection conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
            try
            {
                Criptografar.Chave = "128";
                conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
                conexao.Open();

                MySqlCommand comandos = new MySqlCommand(query, conexao);
                comandos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void cadBancos(Model.Mod.ModelBancos mo, string query)
        {
            Criptografar.Chave = "128";
            MySqlConnection conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
            try
            {
                Criptografar.Chave = "128";
                conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
                conexao.Open();

                MySqlCommand comandos = new MySqlCommand(query, conexao);
                comandos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void cadContas(Model.Mod.ModelContas mo, string query)
        {
            Criptografar.Chave = "128";
            MySqlConnection conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
            try
            {
                Criptografar.Chave = "128";
                conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
                conexao.Open();

                MySqlCommand comandos = new MySqlCommand(query, conexao);
                comandos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void cadDespesas(Model.Mod.ModelContasPagar mo, string query)
        {
            Criptografar.Chave = "128";
            MySqlConnection conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
            try
            {
                Criptografar.Chave = "128";
                conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
                conexao.Open();

                MySqlCommand comandos = new MySqlCommand(query, conexao);
                comandos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Insert(string query)
        {
            Criptografar.Chave = "128";
            MySqlConnection conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
            try
            {
                Criptografar.Chave = "128";
                conexao = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
                conexao.Open();

                MySqlCommand comandos = new MySqlCommand(query, conexao);
                comandos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void selPedidos(Modelos mo, string query)
        {
            try
            {
                Criptografar.Chave = "128";
                conexao1 = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));
                conexao1.Open();


                MySqlCommand comandos = new MySqlCommand(query, conexao1);
                comandos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }

        public void desconecta()
        {
            // conexao.Close();
        }

        // usa connect 2

        public MySqlConnection conecta()
        {
            try
            {
                Criptografar.Chave = "128";
                conexao2 = new MySqlConnection(Criptografar.DescriptografaSenha(strConexao));

                conexao2.Open();
                return conexao2;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);

            }
            finally
            {
                // conexao2.Close();
            }
        }
        public void desconecta2()
        {
            conexao2.Close();
        }

        public MySqlCommand execCommand(string query, MySqlConnection connection)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                return command;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comando: " + ex.Message);
            }
            finally
            {
                // conexao2.Close();
            }
        }

        public void SqldataReader(MySqlCommand command, ComboBox combobox, string coluna1)
        {
            try
            {
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string sVar = dataReader.GetString(coluna1);
                    combobox.Items.Add(sVar);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comando: " + ex.Message);
            }
            finally
            {
                conexao2.Close();
            }
        }
        public void SqldataReader(MySqlCommand command, ListBox ListBox, string coluna1, string coluna2)
        {
            try
            {
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string sVar = dataReader.GetString(coluna1);

                    ListBox.Items.Add(sVar);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comando: " + ex.Message);
            }
            finally
            {
                conexao2.Close();
            }
        }
        public void SqldataReader(MySqlCommand command, Label label, string coluna1)
        {
            try
            {
                //Int32 count = (Int32)command.ExecuteScalar();
                //Int32 count = Convert.ToInt32(command.ExecuteScalar());
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Convert.ToInt32(dataReader.GetInt32(coluna1));
                    label.Text = dataReader.GetInt32(dataReader.GetOrdinal(coluna1)).ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comando: " + ex.Message);
            }
            finally
            {
                conexao2.Close();
            }
        }
        public void SqldataReaderTempo(MySqlCommand command, TextBox combobox, string nomeDaColuna1)
        {
            try
            {
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    //  DateTime sVar = ;
                    string format = "dd MM yy HH:mm:ss";
                    //yyyy-MM-dd HH:mm:ss
                    //   combobox.(dataReader.GetDateTime(dataReader.GetOrdinal(nomeDaColuna1)));
                    Convert.ToString(dataReader.GetDateTime(dataReader.GetOrdinal(nomeDaColuna1)));
                    combobox.Text = dataReader.GetDateTime(dataReader.GetOrdinal(nomeDaColuna1)).ToString(format);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comando: " + ex.Message);
            }
            finally
            {
                conexao2.Close();
            }
        }
        public void SqldataReaderTempo(MySqlCommand command, DateTimePicker combobox, string nomeDaColuna1)
        {
            try
            {
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    //  DateTime sVar = ;
                    string format = "yyyy-MM-dd HH:mm:ss";
                    //yyyy-MM-dd HH:mm:ss
                    //   combobox.(dataReader.GetDateTime(dataReader.GetOrdinal(nomeDaColuna1)));
                    Convert.ToString(dataReader.GetDateTime(dataReader.GetOrdinal(nomeDaColuna1)));
                    combobox.Text = dataReader.GetDateTime(dataReader.GetOrdinal(nomeDaColuna1)).ToString(format);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comando: " + ex.Message);
            }
            finally
            {
                conexao2.Close();
            }
        }
        public string SqldataReaderString(MySqlCommand command, string coluna1)
        {
            string string1 = "";
            try
            {
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string1 = dataReader.GetString(coluna1);
                }
                return string1;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro de comando: " + ex.Message);
            }
            finally
            {
                conexao2.Close();
            }
        }

        private DataTable SqlDataTable(string query)
        {
            Conexao conex = new Conexao();
            try
            {
                DataSet dataset = new DataSet();
                dataAdapter = new MySqlDataAdapter(query, conex.conecta());
                dataAdapter.Fill(dataset);

                return dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAdapter.Dispose();
                conex.desconecta2();
            }
            return null;
        }

        public DataTable GetPedidos()
        {
            string query = "SELECT pedidos.IDPedido AS 'Codigo', usuarios.Nome, pedidos.CRastreamento AS 'Rastreamento', tipo_status.descricao AS 'Status'"
                + ", pedidos.DataPedido AS 'Data Pedido', pedidos.QntEst AS 'Qnt. Estimada', pedidos.ListaItens AS 'Items', pedidos.QntFinal AS 'Qnt. Final'"
                + ", pedidos.DataChegada AS 'Data Chegada', pedidos.DataRetirada AS 'Data Retirada', pedidos.ValorEst, pedidos.ValorPago, pedidos.Cancelado "
                + " FROM pedidos INNER JOIN (usuarios, tipo_status) ON pedidos.id_nome = usuarios.Codigo AND pedidos.id_status = tipo_status.id_status ORDER BY pedidos.IDPedido ASC;";
            DataTable dataTable;
            try
            {
                dataTable = SqlDataTable(query);


                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable GetPedidos(string query)
        {
            DataTable dataTable;
            try
            {
                dataTable = SqlDataTable(query);

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable GetUsuarios()
        {
            string query = "SELECT Codigo, Nome, Email, Endereco, Numero, Complemento, Senha FROM usuarios ORDER BY Codigo ASC";
            DataTable dataTable;

            try
            {
                dataTable = SqlDataTable(query);

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public DataTable GetUsuarios(string query)
        {
            DataTable dataTable;

            try
            {
                dataTable = SqlDataTable(query);

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public DataTable GetFornecedores()
        {
            string query = "SELECT * FROM fornecedores order by id_fornecedor ASC";
            DataTable dataTable;
            try
            {
                dataTable = SqlDataTable(query);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable GetFornecedores(string query)
        {
            DataTable dataTable;
            try
            {
                dataTable = SqlDataTable(query);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable GetGlobal(string query)
        {
            DataTable dataTable;
            try
            {
                dataTable = SqlDataTable(query);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable GetFatAPagar()
        {
            Model.ModContasPagar.ModeladdConta mo = new Model.ModContasPagar.ModeladdConta();
            DataTable dataTable;
            try
            {
                string query = "SELECT id_despesas AS 'Nº Despesa', id_fat_apagar AS 'Nº Fatura', fornecedores.Nome AS Fornecedor, valor AS Valor, valorPago AS 'Valor Pago', contas.nome AS Conta, DataDeVencimento AS 'Data de Vencimento' , dataPagamento AS 'Data de Pagamento' FROM (fat_apagar, contas, form_pagto) "
                + " INNER JOIN meudestina.fornecedores ON fornecedores.id_fornecedor = fat_apagar.id_fornecedor AND contas.id_contas = fat_apagar.id_conta AND form_pagto.id_form_pagto = fat_apagar.id_form_pgto ORDER BY fat_apagar.id_fat_apagar ASC";
                dataTable = SqlDataTable(query);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable FatAPagar()
        {
            Model.ModContasPagar.ModeladdConta mo = new Model.ModContasPagar.ModeladdConta();
            
            DataTable dataTable;
            try
            {
                string query = "SELECT id_despesas AS 'Nº Despesa', id_fat_apagar AS 'Nº Fatura', fornecedores.Nome AS Fornecedor, valor AS Valor, valorPago AS 'Valor Pago', contas.nome AS Conta, DataDeVencimento AS 'Data de Vencimento' , dataPagamento AS 'Data de Pagamento' FROM (fat_apagar, contas, form_pagto) "
                + " INNER JOIN meudestina.fornecedores ON fornecedores.id_fornecedor = fat_apagar.id_fornecedor AND contas.id_contas = fat_apagar.id_conta AND form_pagto.id_form_pagto = fat_apagar.id_form_pgto ORDER BY fat_apagar.id_fat_apagar ASC";
                dataTable = SqlDataTable(query);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }






    }
}
