using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using MeuDestinatario;
using MySql.Data.MySqlClient;
using Access;
using Microsoft.Reporting.WinForms;
using System.Diagnostics;





namespace MeuDestinatario
{
    public partial class Home0 : Form
    {
        List<TreeNode> chkNodesMenu = new List<TreeNode>();
        private string path = "C:\\Users\\Comp2\\Documents\\Visual Studio 2012\\Projects\\MeuDestinatario";
        private string path1 = "C:\\Program Files (x86)\\Meu Destinatário\\Meu Destinatário\\ContasAPagar.exe";
        private string User0 = "";
        Conexao conex = new Conexao();

        public DataGridView DGViewUsuarios = new DataGridView();

        DataGridViewRow DTRowPedidos = new DataGridViewRow();
        DataGridViewRow DTRowUsuarios = new DataGridViewRow();
        DataGridViewRow DTRowForncedores = new DataGridViewRow();

        ComboBox comb1 = new ComboBox();
        ComboBox comb2 = new ComboBox();
        ComboBox comb3 = new ComboBox();
        TextBox text1 = new TextBox();

        DataView dtview = new DataView();

        //Rectangle r;
        Pen pen = new Pen(Brushes.GreenYellow);
        Brush et = Brushes.Yellow;


        CriarTab criarUsuarios = new CriarTab();
        CriarTab criarPedidos = new CriarTab();
        CriarTab criarFornecedores = new CriarTab();
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();


        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        /*
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }*/
/*
        public Home0()
        {            
            InitializeComponent();
            //label25.AutoSize = true;
            //Conexao conex = new Conexao();
            dataGridView1.DataSource = conex.GetPedidos("SELECT pedidos.IDPedido AS 'Codigo', clientes.Nome, pedidos.CRastreamento AS 'Rastreamento', tipo_status.descricao AS 'Status', pedidos.DataPedido AS 'Data Pedido', pedidos.QntEst AS 'Qnt. Estimada', pedidos.ListaItens AS 'Itens', pedidos.QntFinal AS 'Qnt. Final', pedidos.DataChegada AS 'Data Chegada', pedidos.DataRetirada AS 'Data Retirada', pedidos.ValorEst, pedidos.ValorPago FROM pedidos INNER JOIN (clientes, tipo_status) ON pedidos.id_cliente = clientes.id_clientes AND pedidos.id_status = tipo_status.id_status WHERE tipo_status.descricao = 'Abertos' ORDER BY pedidos.IDPedido ASC;");
            string query0 = "SELECT Nome from clientes ORDER BY Nome ASC;";
            conex.SqldataReader(conex.execCommand(query0, conex.conecta()), comboBox2, "Nome");
            string query1 = "SELECT descricao from tipo_status ORDER BY descricao ASC";
            conex.SqldataReader(conex.execCommand(query1, conex.conecta()), comboBox1, "descricao");
            string query2 = "SELECT COUNT(*) FROM pedidos";
            conex.SqldataReader(conex.execCommand(query2, conex.conecta()), label25, "COUNT(*)");
            string query3 = "SELECT COUNT(*) AS soma FROM pedidos INNER JOIN tipo_status ON pedidos.id_status = tipo_status.id_status WHERE tipo_status.descricao = 'Abertos' ;";
            conex.SqldataReader(conex.execCommand(query3, conex.conecta()), label11, "soma");

            // Adicionar dados a grade de Usuários
            //dataGridView2.DataSource = conex.GetUsuarios();
        }
        */
        public Home0(string User)
        {            
            InitializeComponent();
            //label25.AutoSize = true;
            //Conexao conex = new Conexao();
            dataGridView1.DataSource = conex.GetPedidos("SELECT pedidos.IDPedido AS 'Codigo', clientes.Nome, pedidos.CRastreamento AS 'Rastreamento', tipo_status.descricao AS 'Status', pedidos.DataPedido AS 'Data Pedido', pedidos.QntEst AS 'Qnt. Estimada', pedidos.ListaItens AS 'Itens', pedidos.QntFinal AS 'Qnt. Final', pedidos.DataChegada AS 'Data Chegada', pedidos.DataRetirada AS 'Data Retirada', pedidos.ValorEst, pedidos.ValorPago FROM pedidos INNER JOIN (clientes, tipo_status) ON pedidos.id_cliente = clientes.id_clientes AND pedidos.id_status = tipo_status.id_status WHERE tipo_status.descricao = 'Abertos' ORDER BY pedidos.IDPedido ASC;");
            string query0 = "SELECT Nome from clientes ORDER BY Nome ASC;";
            conex.SqldataReader(conex.execCommand(query0, conex.conecta()), comboBox2, "Nome");
            string query1 = "SELECT descricao from tipo_status ORDER BY descricao ASC";
            conex.SqldataReader(conex.execCommand(query1, conex.conecta()), comboBox1, "descricao");
            string query2 = "SELECT COUNT(*) FROM pedidos";
            conex.SqldataReader(conex.execCommand(query2, conex.conecta()), label25, "COUNT(*)");
            string query3 = "SELECT COUNT(*) AS soma FROM pedidos INNER JOIN tipo_status ON pedidos.id_status = tipo_status.id_status WHERE tipo_status.descricao = 'Abertos' ;";
            conex.SqldataReader(conex.execCommand(query3, conex.conecta()), label11, "soma");
            User0 = User;
            // Adicionar dados a grade de Usuários
            //dataGridView2.DataSource = conex.GetUsuarios();


        }

        public string UsuarioAtivo
        {
            get { return User0; }
            set { User0 = value; }
        }

        //                                                                         MENU PRINCIPAL

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Configuracao.addUsuarios one = new Configuracao.addUsuarios();
            one.Show();


        }
        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void correiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rastreamento instancia = new Rastreamento();
            instancia.ShowDialog();

        }
        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emailForm instancia = new emailForm();
            instancia.Show();
        }

        //                                                                  TREEVIEW AND TREENODES CODES

        private void fillNodes()
        {
            treeView1.Nodes.Add("Clientes");
            treeView1.Nodes.Add("Fornecedores");
            treeView1.Nodes.Add("Pedidos");
            treeView1.Nodes.Add("Despesas");

            treeView1.Nodes[0].Nodes.Add("Cadastrar Novo Usuário");
            treeView1.Nodes[0].Nodes.Add("Excluir Novo Usuário");

            treeView1.Nodes[1].Nodes.Add("Incluir Fornecedor");
            treeView1.Nodes[1].Nodes.Add("Excluir Novo Fornecedor");

            treeView1.Nodes[2].Nodes.Add("Faturas em Aberto");
        }
        private void removeNodes()
        {
            treeView1.SelectedNode.Remove();
            // treeView1.Nodes.Clear(); limpar treeview

        }
        void RemoveCheckedNodes(TreeNodeCollection nodes1)
        {

            foreach (TreeNode nodes2 in nodes1)
            {
                if (nodes2.Checked)
                {
                    chkNodesMenu.Add(nodes2);
                }
                else
                {
                    RemoveCheckedNodes(nodes2.Nodes);
                }
            }

            foreach (TreeNode checkedNode in chkNodesMenu)
            {
                nodes1.Remove(checkedNode);
            }
        }
        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);

            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));

        }
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));

            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));

            return directoryNode;
        }
        private void openFilefromNode()
        {
            String TreeNodeName = treeView1.SelectedNode.ToString().Replace("TreeNode: ", String.Empty);
            MessageBox.Show(path + "\\" + TreeNodeName);
            System.Diagnostics.Process.Start(path + "\\" + TreeNodeName);

        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Text == "Usuários")
            {/*
                MessageBox.Show(Path.GetTempPath());
                ReportViewer report = new ReportViewer();
                report.ProcessingMode = ProcessingMode.Local;

                //CAminho para ecnontrar o relatório
                report.LocalReport.ReportEmbeddedResource =
                    "MeuDestinatario.Usuarios.rdlc";
                
                //ParÂmetros do relatório
                List<ReportParameter> listReportParameter = new List<ReportParameter>();
                listReportParameter.Add(new ReportParameter("one", "PRIMEIRO TESTE"));
                    report.LocalReport.SetParameters(listReportParameter);
                
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytePDF = report.LocalReport.Render(
                    "Pdf", null, out mimeType, out encoding,
                    out extension, out streamids, out warnings
                    );

                FileStream fileStreamPDF = null;
                string nomeArquivo = Path.GetTempPath() +
                    "PrimeiroTesteTMP" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") +
                    ".pdf";
                fileStreamPDF = new FileStream(nomeArquivo, FileMode.Create);
                fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
                fileStreamPDF.Close();
                Process.Start(nomeArquivo);*/
                
                ReportOne one = new ReportOne();
                one.Show();
                

               /* criarUsuarios.setTabControl(tabControl1);
                if (tabControl1.TabPages.Contains(criarUsuarios.tabpage) == false)
                {
                }
                else
                {
                    tabControl1.SelectedTab = criarUsuarios.tabpage;
                }*/
            }
            if (e.Node.Text == "Pedidos")
            {

                criarPedidos.setTabControl(tabControl1);
                if (tabControl1.TabPages.Contains(criarPedidos.tabpage) == false)
                {

                }
                else
                {
                    tabControl1.SelectedTab = criarPedidos.tabpage;
                }

            }
            if (e.Node.Text == "Fornecedores")
            {
                System.Diagnostics.Process.Start(path1);

            }

        }



        //                                                                          EVENTOS VÁLIDOS

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left - 0, e.Bounds.Top + 5);
            Rectangle closeButton = new Rectangle(e.Bounds.Right - 16, e.Bounds.Top + 6, 10, 10);
            e.Graphics.FillRectangle(et, closeButton);
            e.Graphics.DrawRectangle(pen, closeButton);
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 3);
            e.DrawFocusRectangle();
            
            */


            TabColors[tabControl1.TabPages[e.Index]] = Color.White;
            using (Brush br = new SolidBrush(TabColors[tabControl1.TabPages[e.Index]]))
            {

                e.Graphics.FillRectangle(br, e.Bounds);
                SizeF sz = e.Graphics.MeasureString(tabControl1.TabPages[e.Index].Text, e.Font);
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

                Rectangle closeButton = new Rectangle(e.Bounds.Right - 16, e.Bounds.Top + 6, 10, 10);
                e.Graphics.FillRectangle(et, closeButton);
                e.Graphics.DrawRectangle(pen, closeButton);
                e.Graphics.DrawString("x", e.Font, Brushes.White, e.Bounds.Right - 15, e.Bounds.Top + 3);
                // e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.LightGreen, e.Bounds.Left + 2, e.Bounds.Top + 5);

                /*
                    Rectangle rect = e.Bounds;
                    rect.Offset(0, 1);
                    rect.Inflate(0, -1);
                    e.Graphics.DrawRectangle(Pens.Pink, rect);
                    e.DrawFocusRectangle();
                    */
            }
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                // GETTING THE POSITION OF THE 'X' MARK
                Rectangle closeButton2 = new Rectangle(r.Right - 15, r.Top + 3, 9, 7);
                if (closeButton2.Contains(e.Location))
                {

                    if (MessageBox.Show("Fechar esta tab?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        //criarUsuarios.Fechar();
                        this.tabControl1.TabPages.RemoveAt(i);


                    }
                }
            }
        }
        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {/*
            Rectangle Change2 = new Rectangle();

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                r = tabControl1.GetTabRect(i);
                Rectangle Change = new Rectangle(r.Right - 15, r.Top + 3, 9, 7);
                Change = Change2;
            }
            if (e.Location.Equals(Change2.Location))
            {
                et = Brushes.Red;
                pen.Brush = Brushes.Red;

            }
            else
            {
                et = Brushes.Transparent;
                pen.Brush = Brushes.Transparent;

            }*/
        }
        private void cmbNome_TextChanged(object sender, EventArgs e)
        {


        }
        private void cmbStatus_TextChanged(object sender, EventArgs e)
        {
            //DataView DV = new DataView(conex.GetPedidos());

        }

        // EVENTOS TABPAGE 2

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DTRowPedidos = dataGridView1.Rows[e.RowIndex];
        }

        //                                         MÉTODOS PRONTOS (BOTÕES E LABELS)

        private void button6_Click(object sender, EventArgs e)
        {
            removeNodes();
            RemoveCheckedNodes(treeView1.Nodes);
        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {



        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListDirectory(treeView1, path);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openFilefromNode();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            Conexao conex = new Conexao();

            criarTab("Pedidos", "nomeDGV", conex.GetPedidos());
            criarMenuStrip();
            criarMenuItem();*/
        }



        private void butPesquisar_Click(object sender, EventArgs e)
        {
            dtview.Table = conex.GetPedidos("SELECT pedidos.IDPedido AS 'Código', clientes.Nome, pedidos.CRastreamento AS 'Rastreamento', tipo_status.descricao AS 'Status', pedidos.DataPedido AS 'Data Pedido', pedidos.QntEst AS 'Qnt. Estimada', pedidos.ListaItens AS 'Itens', pedidos.QntFinal AS 'Qnt. Final', pedidos.DataChegada AS 'Data Chegada', pedidos.DataRetirada AS 'Data Retirada', pedidos.ValorEst, pedidos.ValorPago FROM pedidos INNER JOIN (clientes, tipo_status) ON pedidos.id_cliente = clientes.id_clientes AND pedidos.id_status = tipo_status.id_status ORDER BY pedidos.IDPedido ASC;");
            try
            {
                dtview.RowFilter = string.Format("Nome LIKE '%{0}%' AND Status LIKE '%{1}%'"
                + "AND Rastreamento LIKE '%{2}'", comboBox2.Text, comboBox1.Text, textBox2.Text);
                dataGridView1.DataSource = dtview;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTRowPedidos.Cells.Count <= 0)
            {
                MessageBox.Show("Clique na coluna a esquerda dentro do grid", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                editPedidos instancia = new editPedidos(DTRowPedidos);
                instancia.ShowDialog();
            }

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comercial.addPedido inst = new Comercial.addPedido(User0);
            inst.ShowDialog();
            
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = conex.GetPedidos("SELECT pedidos.IDPedido AS 'Codigo', usuarios.Nome, pedidos.CRastreamento AS 'Rastreamento', tipo_status.descricao AS 'Status', pedidos.DataPedido AS 'Data Pedido', pedidos.QntEst AS 'Qnt. Estimada', pedidos.ListaItens AS 'Items', pedidos.QntFinal AS 'Qnt. Final', pedidos.DataChegada AS 'Data Chegada', pedidos.DataRetirada AS 'Data Retirada', pedidos.ValorEst, pedidos.ValorPago FROM pedidos INNER JOIN (usuarios, tipo_status) ON pedidos.id_nome = usuarios.Codigo AND pedidos.id_status = tipo_status.id_status WHERE tipo_status.descricao = 'Abertos' ORDER BY pedidos.IDPedido ASC;");

            dataGridView1.DataSource = conex.GetPedidos("SELECT pedidos.IDPedido AS 'Codigo', clientes.Nome, pedidos.CRastreamento AS 'Rastreamento', tipo_status.descricao AS 'Status', pedidos.DataPedido AS 'Data Pedido', pedidos.QntEst AS 'Qnt. Estimada', pedidos.ListaItens AS 'Itens', pedidos.QntFinal AS 'Qnt. Final', pedidos.DataChegada AS 'Data Chegada', pedidos.DataRetirada AS 'Data Retirada', pedidos.ValorEst, pedidos.ValorPago FROM pedidos INNER JOIN (clientes, tipo_status) ON pedidos.id_cliente = clientes.id_clientes AND pedidos.id_status = tipo_status.id_status WHERE tipo_status.descricao = 'Abertos' ORDER BY pedidos.IDPedido ASC;");
            comboBox2.Items.Clear();
            string query0 = "SELECT Nome from clientes ORDER BY Nome ASC;";
            conex.SqldataReader(conex.execCommand(query0, conex.conecta()), comboBox2, "Nome");
            comboBox1.Items.Clear();
            string query1 = "SELECT descricao from tipo_status ORDER BY descricao ASC";
            conex.SqldataReader(conex.execCommand(query1, conex.conecta()), comboBox1, "descricao");
            string query2 = "SELECT COUNT(*) FROM pedidos";
            conex.SqldataReader(conex.execCommand(query2, conex.conecta()), label25, "COUNT(*)");
            string query3 = "SELECT COUNT(*) AS soma FROM pedidos INNER JOIN tipo_status ON pedidos.id_status = tipo_status.id_status WHERE tipo_status.descricao = 'Abertos' ;";
            conex.SqldataReader(conex.execCommand(query3, conex.conecta()), label11, "soma");
        }

        private void novoFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadFornecedor ins = new cadFornecedor();
            ins.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            // this.label25.Size = new System.Drawing.Size(80, 65);


            string query0 = "SELECT COUNT(*) FROM pedidos";
            conex.SqldataReader(conex.execCommand(query0, conex.conecta()), label25, "COUNT(*)");


            /*
            DataTable data0 = conex.GetPedidos(query0);
            ModelPedidos model = new ModelPedidos();
            conex.cadPedidos(model, query0);
            label25.Text = model.IDPedido;
            */
            // conex.desconecta();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DTRowPedidos.Cells.Count <= 0)
            {
                MessageBox.Show("Clique na coluna a esquerda dentro do grid", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                editPedidos instancia = new editPedidos(DTRowPedidos);
                instancia.Show();
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
        //Application.Run(new )
          /*  Class1 teste = new Class1();
            string var = teste.teste();
            MessageBox.Show(teste.teste());
            */
            MessageBox.Show(Access.Ex.strpublic());
            string var1 = Ex.var2;
            

        }

        private void Home0_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void novoUsuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void editarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUsuario cad = new CadUsuario();
            cad.ShowDialog();
        }

        private void adicionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comercial.addCliente cli = new Comercial.addCliente();
            cli.ShowDialog();
        }

        private void adionarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comercial.addFornecedor fo = new Comercial.addFornecedor();
            fo.ShowDialog();
        }

        private void adicionarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financeiro.addConta co = new Financeiro.addConta();
            co.ShowDialog();
        }

        private void adicionarBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financeiro.addBanco bo = new Financeiro.addBanco();
            bo.ShowDialog();
        }

        private void novaContaAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Financeiro.contasPagar ne = new Financeiro.contasPagar();
            ne.ShowDialog();
        }

        private void consultarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos instancia = new Pedidos();
            instancia.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracao.addUsuarios ne = new Configuracao.addUsuarios();
            ne.ShowDialog();
        }

        private void novoPedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Comercial.addPedido inst = new Comercial.addPedido(User0);
            inst.ShowDialog();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contasAPAgarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelContaPagar ce = new RelContaPagar();
            ce.ShowDialog() ;
        }

        private void gerenciarContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financeiro.gerContasPagar ge = new Financeiro.gerContasPagar();
            ge.ShowDialog();
        }

        private void condiçõesDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financeiro.addCondPgto ne = new Financeiro.addCondPgto();
            ne.ShowDialog();
        }



        //TESTES











    }
}
