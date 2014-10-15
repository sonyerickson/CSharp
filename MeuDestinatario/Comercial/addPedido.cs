using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControlLibrary;

namespace MeuDestinatario.Comercial
{
    public partial class addPedido : Form
    {

        string User0 = "";
        Conexao conex = new Conexao();


        public addPedido()
        {
            InitializeComponent();
            
            string query0 = "SELECT Nome FROM clientes ORDER BY Nome ASC;";
            conex.SqldataReader(conex.execCommand(query0, conex.conecta()), cmbNome, "Nome");
            string query1 = "SELECT descricao FROM tipo_status ORDER BY descricao ASC";
            conex.SqldataReader(conex.execCommand(query1, conex.conecta()), cmbStatus, "descricao");

            /*
            this.componentis = new System.ComponentModel.Container();
            userControl1 = new MyControlLibrary.TabCtlEx();
            tabPage1 = new MyControlLibrary.TabPageEx(this.componentis);
            tabPage2 = new MyControlLibrary.TabPageEx(this.componentis);
            userControl1.SuspendLayout();
            this.SuspendLayout();
            panel2.Controls.Add(userControl1);
            this.userControl1.ConfirmOnClose = true;
            this.userControl1.Controls.Add(this.tabPage2);            
            this.userControl1.Controls.Add(this.tabPage1);
            this.userControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.userControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl1.ItemSize = new System.Drawing.Size(330, 24);
            this.userControl1.Location = new System.Drawing.Point(8, 40);
            this.userControl1.Dock = DockStyle.Fill;
            this.userControl1.Name = "userControl11";
            this.userControl1.SelectedIndex = 0;
            this.userControl1.Size = new System.Drawing.Size(824, 320);
            this.userControl1.TabIndex = 0;
            this.userControl1.TabStop = false;
            this.userControl1.OnClose += new MyControlLibrary.TabCtlEx.OnHeaderCloseDelegate(this.userControl1_OnClose);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Menu = null;
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(816, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Menu = null;
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(816, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.Controls.Add(this.userControl1);
             * */
        }

        public addPedido(string user)
        {
            InitializeComponent();
            fill(user);

        }
        private void fill(string user)
        {
            string query0 = "SELECT Nome FROM clientes ORDER BY Nome ASC;";
            conex.SqldataReader(conex.execCommand(query0, conex.conecta()), cmbNome, "Nome");
            string query1 = "SELECT descricao FROM tipo_status ORDER BY descricao ASC";
            conex.SqldataReader(conex.execCommand(query1, conex.conecta()), cmbStatus, "descricao");
            User0 = user;
            string query2 = "SELECT MAX(IDPedido) AS 'MAX' FROM pedidos";
            txt_idpedido.Text = conex.SqldataReaderString(conex.execCommand(query2, conex.conecta()), "MAX");
        }
        private void fill()
        {
            string query0 = "SELECT Nome FROM clientes ORDER BY Nome ASC;";
            conex.SqldataReader(conex.execCommand(query0, conex.conecta()), cmbNome, "Nome");
            string query1 = "SELECT descricao FROM tipo_status ORDER BY descricao ASC";
            conex.SqldataReader(conex.execCommand(query1, conex.conecta()), cmbStatus, "descricao");            
            string query2 = "SELECT MAX(IDPedido) AS 'MAX' FROM pedidos";
            txt_idpedido.Text = conex.SqldataReaderString(conex.execCommand(query2, conex.conecta()), "MAX");
        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            if (cmbNome.Text == "" || txtListaItens.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Tem certeza que deseja cadastrar o pedido ?", "Salvar ?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                    );

                if (result1 == DialogResult.Yes)
                {
                    ModelPedidos moPedidos = new ModelPedidos();
                    Conexao conex = new Conexao();

                    string format = "yyyy-MM-dd HH:mm:ss";


                    moPedidos.CRastreamento = txtCodRastreamento.Text;
                    moPedidos.ListaItens = txtListaItens.Text;
                    moPedidos.DataPedido = dateTimePicker1.Value.ToString(format);
                    moPedidos.DataPrevisao = dateTimePicker2.Value.ToString(format);
                    moPedidos.QntEst = txtQntEst.Text;


                    string query = "INSERT INTO pedidos (CRastreamento, ListaItens, id_cliente, id_status, DataPedido, DataPrevisao, QntEst, id_nome) "
                    + "values('" + moPedidos.CRastreamento + "', '" + moPedidos.ListaItens + "', (SELECT id_clientes FROM clientes WHERE clientes.Nome = '" + cmbNome.Text + "'),"
                    + " (SELECT id_status FROM tipo_status WHERE tipo_status.descricao = '" + cmbStatus.Text + "'), '" + moPedidos.DataPedido + "', '" + moPedidos.DataPrevisao + "','" + moPedidos.QntEst + "',"
                    + " (SELECT Codigo FROM usuarios WHERE usuarios.Nome = '" + User0 + "'))";

                    conex.cadPedidos(moPedidos, query);

                    MessageBox.Show("Pedido Cadastrado com sucesso!", "Pedido Salvo", MessageBoxButtons.OK);

                    conex.desconecta();
                    limpar();                    
                    fill();
                    cmbNome.Focus();
                }
                if (result1 == DialogResult.Cancel)
                {

                }

            }
        }
        public void limpar()
        {
            //txt_idpedido.Text = "";
            cmbNome.Items.Clear();
            cmbNome.Items.Clear();
            txtCodRastreamento.Text = "";
            txtListaItens.Text = "";
            txtQntEst.Text = "";
            txtValorEst.Text = "";
            cmbNome.Text = "";
            dateTimePicker2.Value = DateTime.Now;

        }

        private void TSB_NovoPedido_Click(object sender, EventArgs e)
        {
            limpar();
            fill();
        }




    }
}
