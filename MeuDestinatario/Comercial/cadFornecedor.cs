using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuDestinatario
{
    public partial class cadFornecedor : Form
    {
        DateTime data = DateTime.Now;

        Conexao conex = new Conexao();

        public cadFornecedor()
        {
            InitializeComponent();
            
            data.ToString("yyyy-MM-dd HH:mm:ss");
            maskedTextBox1.Mask = "00/00/0000";

            string query = "SELECT DateTime FROM fornecedores WHERE id_fornecedor = 1 ORDER BY id_fornecedor ASC";
            conex.SqldataReaderTempo(conex.execCommand(query, conex.conecta()), textBox1, "DateTime");
            conex.SqldataReaderTempo(conex.execCommand(query, conex.conecta()), dateTimePicker1, "DateTime");



            
        }

        void encherData()
        {/*
            ModelFornecedores model = new ModelFornecedores();
            Conexao conex = new Conexao();
           // model.DateTime = data;

            //dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            string format = "yyyy-MM-dd HH:mm:ss";
            string data = dateTimePicker1.Value.ToString(format);
            
            string query= "INSERT into fornecedores (DateTime) values('" + data + "')";

            conex.cadFornecedores(model,query);
            conex.desconecta();
          * */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encherData();

        }

        private void encherData2()
        {
           

            DataGridViewRow dtrow = new DataGridViewRow();

            DataRow dtro = conex.GetFornecedores().Rows[0];


            Console.WriteLine(dtro["Date"]);

            //textBox2.Text = dtro("Date");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            encherData2();
        }
    }
}
