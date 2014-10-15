using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MeuDestinatario.Comercial;
using System.Drawing.Drawing2D;

namespace MeuDestinatario
{
    public class Tab01
    {
        DataGridViewRow dtrow = new DataGridViewRow();
        DataView dtview = new DataView();
        Conexao conex = new Conexao();

        // ENCAPSULAMENTO USUARIOS
        private Configuracao.addUsuarios insAddUsuario;
       // private editUsuarios insEditUsuario;

        public Configuracao.addUsuarios InsAddUsuarios
        {
            get { return insAddUsuario; }
            set { insAddUsuario = value; }
        }

        // ENCAPSULAMENTO PEDIDO
        private addPedido insAddPedido;
        private editPedidos insEditPedido;

        public addPedido InsAddPedido
        {
            get { return insAddPedido; }
            set { insAddPedido = value; }
        }
        public editPedidos InsEditPedido
        {
            get { return insEditPedido; }
            set { insEditPedido = value; }
        }

        // ENCAPSULAMENTO GERAL

        
        private DataGridView datagrid;
        private ComboBox comb1;
        private ComboBox comb2;
        private TextBox text1;

        public DataGridView Datagrid
        {
            get { return datagrid; }
            set { datagrid = value; }
        }
        public ComboBox Comb2
        {
            get { return comb2; }
            set { comb2 = value; }
        }
        public ComboBox Comb1
        {
            get { return comb1; }
            set { comb1 = value; }
        }
        public TextBox Text1
        {
            get { return text1; }
            set { text1 = value; }
        }




        // DATAGRID

        public void eventDataGridView()
        {
            datagrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.fazerdatagrid);
        }
        private void fazerdatagrid(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtrow = datagrid.Rows[e.RowIndex];
        }
        //                      BOTOES DE PESQUISA
        public void eventButtonPesq(Button buttPesquisa)
        {
            buttPesquisa.Click += new System.EventHandler(addPesquisa);
        }
        public void addPesquisa(object sender, EventArgs e)
        {
            dtview.Table = conex.GetPedidos();
            try
            {
                dtview.RowFilter = string.Format("Nome LIKE '%{0}%' AND Status LIKE '%{1}%'"
                + "AND Rastreamento LIKE '%{2}'", comb1.Text, comb2.Text, text1.Text);
                datagrid.DataSource = dtview;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            dtview.RowFilter = string.Format("Nome LIKE '%{0}%' AND Status LIKE '%{1}%'"
                + "AND Rastreamento LIKE '%{2}'", comb1.Text, comb2.Text, text1.Text);
            datagrid.DataSource = dtview;*/
        }

        //                                 PEDIDOS

        public void eventButtonPedidos(Button button)
        {
            //button.Click += new System.EventHandler();
        }
        public void eventMenuItemPedidos(ToolStripMenuItem menuitem0, ToolStripMenuItem menuitem1, ToolStripMenuItem menuitem2)
        {
            menuitem0.Click += new System.EventHandler(addEditPedidos);
            menuitem1.Click += new System.EventHandler(addNewPedidos);
            menuitem2.Click += new System.EventHandler(addReceberPedidos);
        }
        public void eventComboChangedPedido()
        {
            comb1.TextChanged += new System.EventHandler(addCmbChangePedido);
        }
        public void eventPreencherComboPedido()
        {
            Conexao conex1 = new Conexao();
            conex1.SqldataReader(conex.execCommand("Select Nome from usuarios ORDER BY Nome ASC;", conex.conecta()), comb1, "Nome");

        }
        public void eventPreencherCombo2Pedido()
        {
            Conexao conex2 = new Conexao();
            conex2.SqldataReader(conex.execCommand("Select descricao from tipo_status ORDER BY id_status ASC;", conex2.conecta()), comb2, "descricao");
        }

        // VOID'S PEDIDOS
        public void addEditPedidos(object sender, EventArgs e)
        {
            if (dtrow.Cells.Count <= 0)
            {
                MessageBox.Show("É necessário escolhar uma linha para editar o Pedidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                insEditPedido.Show();
            }
        }

        public void delEditPedidos()
        {
            insEditPedido.Dispose();
        }
        public void addNewPedidos(object sender, EventArgs e)
        {
            insAddPedido.Show();
        }
        public void delNewUsuario()
        {
            InsAddPedido.Dispose();
        }
        public void addReceberPedidos(object sender, EventArgs e)
        {
            receberPedido news = new receberPedido();
            news.Show();
        }
        public void addCancelarPedidos(object sender, EventArgs e)
        {
        }
        public void addCmbChangePedido(object sender, EventArgs e)
        {
            Conexao conex3 = new Conexao();
            DataView Dview = new DataView(conex3.GetUsuarios("Select Nome From usuarios"));
            Dview.RowFilter = string.Format("Nome LIKE '%{0}'", comb1);
            //comb1.Text = Dview.ToString();
        }

        //                              USUARIOS
        public void eventButtonUsuarios(Button button)
        {
        }
        public void eventMenuItemUsuarios(ToolStripMenuItem menuitem0, ToolStripMenuItem menuitem1, ToolStripMenuItem menuitem2)
        {
            menuitem0.Click += new System.EventHandler(addEditUsuarios);
            menuitem1.Click += new System.EventHandler(addNewUsuarios);
            menuitem2.Click += new System.EventHandler(addRemoveUsuarios);

        }

        //VOID'S USUARIOS
        public void addEditUsuarios(object sender, EventArgs e)
        {
            if (dtrow.Cells.Count <= 0)
            {
                MessageBox.Show("É necessário escolher clicar na linha escolhida para editar o Usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                editUsuarios inst = new editUsuarios();
                inst.Show();
            }
        }
        public void addNewUsuarios(object sender, EventArgs e)
        {            
            insAddUsuario.Show();
        }
        public void delNewUsuarios()
        {
            insAddUsuario.Dispose();
        }
        public void addRemoveUsuarios(object sender, EventArgs e)
        {

        }


        //                              FORNECEDORES
        public void addNewFornecedor(object sender, EventArgs e)
        {
            Comercial.addFornecedor inst = new addFornecedor();
            inst.Show();
        }
        public void addEditFornecedor(object sender, EventArgs e)
        {
        }
    }



}
