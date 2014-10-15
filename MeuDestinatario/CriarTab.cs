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

namespace MeuDestinatario
{
    class CriarTab
    {
        TabControl tabControlInterno;

        private string tabName;
        public string TabName
        {
            get { return tabName; }
            set { tabName = value; }
        }

        //private Tab01 eventsUsuarios;

        Tab01 events = new Tab01();
        Tab01 eventosPedidos = new Tab01();

        public TabPage tabpage = new TabPage();
        DataGridView data = new DataGridView();
        MenuStrip menu = new MenuStrip();
        ToolStripMenuItem menuitem0 = new ToolStripMenuItem();
        ToolStripMenuItem menuitem1 = new ToolStripMenuItem();
        ToolStripMenuItem menuitem2 = new ToolStripMenuItem();
        ToolStripMenuItem menuitem3 = new ToolStripMenuItem();
        ToolStripMenuItem menuitem4 = new ToolStripMenuItem();

        DataGridViewRow DTRow = new DataGridViewRow();
        Panel panel = new Panel();
        Label lab0 = new Label();
        Label lab1 = new Label();
        Label lab2 = new Label();
        Label lab3 = new Label();
        Label lab4 = new Label();
        Label lab5 = new Label();
        Label lab6 = new Label();
        Label lab7 = new Label();
        ComboBox combo1 = new ComboBox();
        ComboBox combo2 = new ComboBox();
        Button butt = new Button();
        Button buttLimpar = new Button();
        TextBox txtCRastreamento = new TextBox();
        TextBox txtValorEst = new TextBox();
        TextBox txtValorPago = new TextBox();
        DateTimePicker pickerDataPedido = new DateTimePicker();
        DateTimePicker pickerDataChegada = new DateTimePicker();
        DateTimePicker pickerDataRetirada = new DateTimePicker();

        Form form0 = new Form();
        Form form1 = new Form();
        Form form2 = new Form();
        Form form3 = new Form();
        Form form4 = new Form();



        //ADD TABPAGE

        public TabPage addTabePage(DataTable datatable,string Text)
        {
            try
            {
                string title = "Nome da Página      " + (tabControlInterno.TabCount + 1).ToString();

                tabControlInterno.TabPages.Add(tabpage);

                tabpage.Controls.Add(data);
                tabpage.Controls.Add(panel);
                tabpage.Name = tabName;
                tabpage.Text = Text;
                
                data.Location = new System.Drawing.Point(451, 30);
                data.Size = new System.Drawing.Size(1104, 920);

                data.DataSource = datatable;

                return tabpage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void selectPage()
        {
            tabControlInterno.SelectedTab = tabpage;
        }

        // SET TABCONTROL

        public void setTabControl(TabControl tabcontrol)
        {
            tabControlInterno = tabcontrol;
        }

        // ADD MENUSTRIP

        public MenuStrip addMenuStrip()
        {
            try
            {
                menu.Size = new System.Drawing.Size(1543, 24);
                menu.Location = new System.Drawing.Point(3, 3);
                menu.RightToLeft = RightToLeft.Yes;
                menu.BackColor = System.Drawing.Color.White;
                tabpage.Controls.Add(menu);
                menu.Dock = DockStyle.Top;
                panel.BackColor = Color.White;

                panel.Size = new System.Drawing.Size(437, 899);
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.Dock = DockStyle.Left;
                data.Dock = DockStyle.Fill;
                panel.Controls.Add(lab0);
                panel.Controls.Add(lab1);
                panel.Controls.Add(lab2);
                panel.Controls.Add(lab3);
                panel.Controls.Add(lab4);
                panel.Controls.Add(lab5);
                panel.Controls.Add(lab6);
                panel.Controls.Add(lab7);
                panel.Controls.Add(combo1);
                panel.Controls.Add(combo2);
                panel.Controls.Add(txtCRastreamento);
                panel.Controls.Add(butt);
                panel.Controls.Add(buttLimpar);
                panel.Controls.Add(pickerDataPedido);
                panel.Controls.Add(pickerDataChegada);
                panel.Controls.Add(pickerDataRetirada);
                panel.Controls.Add(txtValorEst);
                panel.Controls.Add(txtValorPago);


                return menu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        // ADD MENUITEMS

        public ToolStripMenuItem[] addMenuItem(string nome0)
        {
            try
            {
                menu.Items.AddRange(new ToolStripItem[] { menuitem0 });
                /*  ToolStripMenuItem[] retorno = new ToolStripMenuItem[2];
                    retorno[0] = menuitem1;
                    retorno[1] = menuitem2;    */

                menuitem0.Text = nome0;
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public ToolStripMenuItem[] addMenuItem(string nome0, string nome1)
        {
            try
            {
                menu.Items.AddRange(new ToolStripItem[] { menuitem0, menuitem1 });
                menuitem0.Text = nome0;
                menuitem1.Text = nome1;
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public ToolStripMenuItem[] addMenuItem(string nome0, string nome1, string nome2)
        {
            try
            {
                menu.Items.AddRange(new ToolStripItem[] { menuitem0, menuitem1, menuitem2 });
                menuitem0.Text = nome0;
                menuitem1.Text = nome1;
                menuitem2.Text = nome2;
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public ToolStripMenuItem[] addMenuItem(string nome0, string nome1, string nome2, string nome3)
        {
            try
            {
                menu.Items.AddRange(new ToolStripItem[] { menuitem0, menuitem1, menuitem2, menuitem3, menuitem4 });
                menuitem0.Text = nome0;
                menuitem1.Text = nome1;
                menuitem2.Text = nome2;
                menuitem3.Text = nome3;
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public ToolStripMenuItem[] addMenuItem(string nome0, string nome1, string nome2, string nome3, string nome4)
        {
            try
            {
                menu.Items.AddRange(new ToolStripItem[] { menuitem0, menuitem1, menuitem2, menuitem3, menuitem4 });
                menuitem0.Text = nome0;
                menuitem1.Text = nome1;
                menuitem2.Text = nome2;
                menuitem3.Text = nome3;
                menuitem4.Text = nome4;
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        // MENUITEMS_CLIKS



        private void data_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DTRow = data.Rows[e.RowIndex];
        }


        // EVENTOS PEDIDOS

        public void addEventosPedidos()
        {
            
            //SETS
            
            eventosPedidos.Datagrid = data;
            eventosPedidos.Comb1 = combo1;
            eventosPedidos.Comb2 = combo2;
            eventosPedidos.InsAddPedido = new Comercial.addPedido();
            eventosPedidos.InsEditPedido = new editPedidos();
            eventosPedidos.eventDataGridView();
            eventosPedidos.eventMenuItemPedidos(menuitem0, menuitem1, menuitem2);            
            eventosPedidos.Text1 = txtCRastreamento;
            //BUTTONS
            eventosPedidos.eventButtonPesq(butt);
            //DATA
            eventosPedidos.eventPreencherComboPedido();
            eventosPedidos.eventPreencherCombo2Pedido();
            eventosPedidos.eventComboChangedPedido();
        }

        // EVENTOS USUARIOS
        public void addEventosUsuarios()
        {
            events.InsAddUsuarios = new Configuracao.addUsuarios();
            
            events.Datagrid = data;            
            events.eventDataGridView();
            events.eventMenuItemUsuarios(menuitem0, menuitem1, menuitem2);
        }

        public void Fechar()
        {
            events.delNewUsuarios();
        }



        //EVENTOS FORNECEDORES
        public void addEventosFornecedores()
        {
        }

        public void setPropertiesLabs(string Text0, string Text1, string Text2, string Text3, string Text4, string Text5, string Text6, string Text7)
        {
            lab0.Location = new System.Drawing.Point(6, 11);
            lab0.Text = Text0;
            lab0.AutoSize = true;
            lab1.Location = new System.Drawing.Point(6, 38);
            lab1.Text = Text1;
            lab1.AutoSize = true;
            lab2.Location = new System.Drawing.Point(6, 65);
            lab2.Text = Text2;
            lab2.AutoSize = true;
            lab3.Location = new System.Drawing.Point(6, 92);
            lab3.Text = Text3;
            lab3.AutoSize = true;
            lab4.Location = new System.Drawing.Point(6, 119);
            lab4.Text = Text4;
            lab4.AutoSize = true;
            lab5.Location = new System.Drawing.Point(6, 146);
            lab5.Text = Text5;
            lab5.AutoSize = true;
            lab6.Location = new System.Drawing.Point(6, 173);
            lab6.Text = Text6;
            lab6.AutoSize = true;
            lab7.Location = new System.Drawing.Point(6, 200);
            lab7.Text = Text7;
            lab7.AutoSize = true;

            combo1.Location = new System.Drawing.Point(50, 8);
            combo1.Size = new System.Drawing.Size(300, 21);
            combo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            combo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            combo2.Location = new System.Drawing.Point(103, 34);
            combo2.Size = new System.Drawing.Size(247, 21);
            combo2.FormattingEnabled = true;
            combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            combo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtCRastreamento.Location = new System.Drawing.Point(144, 61);
            txtCRastreamento.Size = new System.Drawing.Size(206, 20);
            pickerDataPedido.Location = new System.Drawing.Point(103, 87);
            pickerDataPedido.Size = new System.Drawing.Size(247, 20);
            pickerDataChegada.Location = new System.Drawing.Point(103, 113);
            pickerDataChegada.Size = new System.Drawing.Size(247, 20);
            pickerDataRetirada.Location = new System.Drawing.Point(103, 142);
            pickerDataRetirada.Size = new System.Drawing.Size(247, 20);

            txtValorEst.Location = new System.Drawing.Point(92, 170);
            txtValorEst.Size = new System.Drawing.Size(258, 20);

            txtValorPago.Location = new System.Drawing.Point(74, 197);
            txtValorPago.Size = new System.Drawing.Size(276, 20);

            buttLimpar.Location = new System.Drawing.Point(356, 34);
            buttLimpar.UseVisualStyleBackColor = true;
            buttLimpar.Size = new System.Drawing.Size(75, 22);
            buttLimpar.Text = "Limpar";
            butt.Location = new System.Drawing.Point(356, 8);
            butt.Size = new System.Drawing.Size(75, 22);
            butt.Text = "Pesquisar";
            butt.UseVisualStyleBackColor = true;
        }


        // OBSOLETOS












/*





        public DataGridViewCellMouseEventHandler addEventRowIndexClick()
        {

            return null;
        }

        public void menuitem0_Click(object sender, EventArgs e)
        {
            setEvent0.Show();
        }
        private void menuitem1_Click(object sender, EventArgs e)
        {
            setEvent1.Show();
        }
        private void menuitem2_Click(object sender, EventArgs e)
        {
            setEvent2.Show();
        }
        private void menuitem3_Click(object sender, EventArgs e)
        {
            setEvent3.Show();
        }
        private void menuitem4_Click(object sender, EventArgs e)
        {
            setEvent4.Show();
        }

        public EventHandler addEventHandler0()
        {
            menuitem0.Click += new EventHandler(menuitem0_Click);
            return null;
        }
        public EventHandler addEventHandler1()
        {
            menuitem1.Click += new EventHandler(menuitem1_Click);
            return null;
        }
        public EventHandler addEventHandler2()
        {
            menuitem2.Click += new EventHandler(menuitem2_Click);
            return null;
        }
        public EventHandler addEventHandler3()
        {
            menuitem3.Click += new EventHandler(menuitem3_Click);
            return null;
        }
        public EventHandler addEventHandler4()
        {
            menuitem4.Click += new EventHandler(menuitem4_Click);
            return null;
        }

        public Form setEvent0
        {
            get { return form0; }
            set { form0 = value; }
        }
        public Form setEvent1
        {
            get { return form1; }
            set { form1 = value; }
        }
        public Form setEvent2
        {
            get { return form2; }
            set { form2 = value; }
        }
        public Form setEvent3
        {
            get { return form3; }
            set { form3 = value; }
        }
        public Form setEvent4
        {
            get { return form4; }
            set { form4 = value; }
        }
        */
    }
}
