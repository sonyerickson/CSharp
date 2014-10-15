using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace MeuDestinatario
{
    class dataTable
    {
        string strConexao = System.Configuration.ConfigurationManager.AppSettings["StringConexao"];
        MySqlConnection connection;
        MySqlDataAdapter adapter;
      //  DataTable DTPedidos;

        public DataTable GetPedidos()
        {
            try
            {
                connection = new MySqlConnection(strConexao);

                string query = "SELECT pedidos.IDPedido, usuarios.Nome, pedidos.CRastreamento, tipo_status.descricao, pedidos.DataPedido, pedidos.QntEst, pedidos.ListaItens, pedidos.QntFinal, pedidos.DataChegada, pedidos.DataRetirada, pedidos.ValorEst, pedidos.ValorPago FROM pedidos INNER JOIN (usuarios, tipo_status) ON pedidos.id_nome = usuarios.Codigo AND pedidos.id_status = tipo_status.id_status ;";
                adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                
                return dataSet.Tables[0];
                
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adapter.Dispose();
            }
            return null;
        }

        public DataTable GetUsuarios()
        {
            try
            {
                connection = new MySqlConnection(strConexao);

                string query = "SELECT Codigo, Nome, Email, Endereco, Numero, Complemento, Senha FROM usuarios";
                adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adapter.Dispose();
            }
            return null;
        }

    }
}
