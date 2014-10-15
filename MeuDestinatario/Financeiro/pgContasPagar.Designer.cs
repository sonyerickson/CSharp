namespace MeuDestinatario.Financeiro
{
    partial class pgContasPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Listar = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.dtPagamento = new System.Windows.Forms.DateTimePicker();
            this.lblDataPgto = new System.Windows.Forms.Label();
            this.txtVlrPago = new System.Windows.Forms.TextBox();
            this.cmbCC = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFormPgto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCentroCusto = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCustoSubGrupo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbSubGrupo = new System.Windows.Forms.ComboBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblVlrPago = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCondPgto = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblDtCompra = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataSet1 = new MeuDestinatario.DataSet1();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableTableAdapter = new MeuDestinatario.DataSet1TableAdapters.DataTableTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Listar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(857, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Listar
            // 
            this.TSB_Listar.Image = global::MeuDestinatario.Properties.Resources.Inventory_icon1;
            this.TSB_Listar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Listar.Name = "TSB_Listar";
            this.TSB_Listar.Size = new System.Drawing.Size(118, 22);
            this.TSB_Listar.Text = "Consultar Contas";
            this.TSB_Listar.ToolTipText = "Listar todos os clientes.";
            this.TSB_Listar.Click += new System.EventHandler(this.TSB_Listar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 243);
            this.panel3.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblValorPago);
            this.panel1.Controls.Add(this.lblConta);
            this.panel1.Controls.Add(this.dtPagamento);
            this.panel1.Controls.Add(this.lblDataPgto);
            this.panel1.Controls.Add(this.txtVlrPago);
            this.panel1.Controls.Add(this.cmbCC);
            this.panel1.Location = new System.Drawing.Point(479, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 208);
            this.panel1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 52);
            this.button1.TabIndex = 22;
            this.button1.Text = "Pagar Conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Location = new System.Drawing.Point(81, 63);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(62, 13);
            this.lblValorPago.TabIndex = 13;
            this.lblValorPago.Text = "Valor Pago:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(104, 36);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(38, 13);
            this.lblConta.TabIndex = 20;
            this.lblConta.Text = "Conta:";
            // 
            // dtPagamento
            // 
            this.dtPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPagamento.Location = new System.Drawing.Point(148, 87);
            this.dtPagamento.Name = "dtPagamento";
            this.dtPagamento.Size = new System.Drawing.Size(121, 20);
            this.dtPagamento.TabIndex = 14;
            // 
            // lblDataPgto
            // 
            this.lblDataPgto.AutoSize = true;
            this.lblDataPgto.Location = new System.Drawing.Point(43, 90);
            this.lblDataPgto.Name = "lblDataPgto";
            this.lblDataPgto.Size = new System.Drawing.Size(105, 13);
            this.lblDataPgto.TabIndex = 15;
            this.lblDataPgto.Text = "Data de Pagamento:";
            // 
            // txtVlrPago
            // 
            this.txtVlrPago.Location = new System.Drawing.Point(148, 60);
            this.txtVlrPago.Name = "txtVlrPago";
            this.txtVlrPago.Size = new System.Drawing.Size(121, 20);
            this.txtVlrPago.TabIndex = 12;
            // 
            // cmbCC
            // 
            this.cmbCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCC.FormattingEnabled = true;
            this.cmbCC.ItemHeight = 13;
            this.cmbCC.Location = new System.Drawing.Point(148, 33);
            this.cmbCC.Name = "cmbCC";
            this.cmbCC.Size = new System.Drawing.Size(121, 21);
            this.cmbCC.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(12, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(461, 208);
            this.panel4.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbFormPgto);
            this.groupBox3.Location = new System.Drawing.Point(27, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 86);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forma de Pagamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Forma Pgto:";
            // 
            // cmbFormPgto
            // 
            this.cmbFormPgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormPgto.FormattingEnabled = true;
            this.cmbFormPgto.ItemHeight = 13;
            this.cmbFormPgto.Location = new System.Drawing.Point(125, 19);
            this.cmbFormPgto.Name = "cmbFormPgto";
            this.cmbFormPgto.Size = new System.Drawing.Size(121, 21);
            this.cmbFormPgto.TabIndex = 21;
            this.cmbFormPgto.SelectedIndexChanged += new System.EventHandler(this.cmbFormPgto_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbCentroCusto);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbCustoSubGrupo);
            this.groupBox1.Location = new System.Drawing.Point(27, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 93);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Centro de Custo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Centro de Custo:";
            // 
            // cmbCentroCusto
            // 
            this.cmbCentroCusto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentroCusto.FormattingEnabled = true;
            this.cmbCentroCusto.ItemHeight = 13;
            this.cmbCentroCusto.Location = new System.Drawing.Point(125, 25);
            this.cmbCentroCusto.Name = "cmbCentroCusto";
            this.cmbCentroCusto.Size = new System.Drawing.Size(246, 21);
            this.cmbCentroCusto.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Sub-Grupo:";
            // 
            // cmbCustoSubGrupo
            // 
            this.cmbCustoSubGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustoSubGrupo.FormattingEnabled = true;
            this.cmbCustoSubGrupo.ItemHeight = 13;
            this.cmbCustoSubGrupo.Location = new System.Drawing.Point(125, 52);
            this.cmbCustoSubGrupo.Name = "cmbCustoSubGrupo";
            this.cmbCustoSubGrupo.Size = new System.Drawing.Size(246, 21);
            this.cmbCustoSubGrupo.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 221);
            this.dataGridView1.TabIndex = 101;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCategoria);
            this.groupBox2.Controls.Add(this.cmbSubGrupo);
            this.groupBox2.Controls.Add(this.cmbGrupo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(410, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 107);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classificação Orçamentária";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.ItemHeight = 13;
            this.cmbCategoria.Location = new System.Drawing.Point(125, 19);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(246, 21);
            this.cmbCategoria.TabIndex = 6;
            // 
            // cmbSubGrupo
            // 
            this.cmbSubGrupo.Enabled = false;
            this.cmbSubGrupo.FormattingEnabled = true;
            this.cmbSubGrupo.ItemHeight = 13;
            this.cmbSubGrupo.Location = new System.Drawing.Point(125, 72);
            this.cmbSubGrupo.Name = "cmbSubGrupo";
            this.cmbSubGrupo.Size = new System.Drawing.Size(246, 21);
            this.cmbSubGrupo.TabIndex = 8;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.Enabled = false;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.ItemHeight = 13;
            this.cmbGrupo.Location = new System.Drawing.Point(125, 45);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(246, 21);
            this.cmbGrupo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sub-Grupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grupo:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 417);
            this.panel2.TabIndex = 104;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 171);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(857, 25);
            this.toolStrip2.TabIndex = 109;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::MeuDestinatario.Properties.Resources.icon_delete__1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton2.Text = "Cancelar Faturas";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::MeuDestinatario.Properties.Resources.Inventory_icon1;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton3.Text = "Reparcelar";
            this.toolStripButton3.ToolTipText = "Listar todos os clientes.";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::MeuDestinatario.Properties.Resources.icon_save_1;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton4.Text = "Pagar";
            this.toolStripButton4.ToolTipText = "Salvar novo Cliente";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblVlrPago);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.lblCondPgto);
            this.panel5.Controls.Add(this.lblValorTotal);
            this.panel5.Controls.Add(this.lblDtCompra);
            this.panel5.Controls.Add(this.lblFornecedor);
            this.panel5.Controls.Add(this.lblCodigo);
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(857, 171);
            this.panel5.TabIndex = 108;
            // 
            // lblVlrPago
            // 
            this.lblVlrPago.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrPago.Location = new System.Drawing.Point(148, 91);
            this.lblVlrPago.Name = "lblVlrPago";
            this.lblVlrPago.Size = new System.Drawing.Size(214, 28);
            this.lblVlrPago.TabIndex = 109;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 108;
            this.label10.Text = "Valor Pago:";
            // 
            // lblCondPgto
            // 
            this.lblCondPgto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondPgto.Location = new System.Drawing.Point(148, 124);
            this.lblCondPgto.Name = "lblCondPgto";
            this.lblCondPgto.Size = new System.Drawing.Size(214, 23);
            this.lblCondPgto.TabIndex = 107;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(148, 63);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(214, 23);
            this.lblValorTotal.TabIndex = 106;
            // 
            // lblDtCompra
            // 
            this.lblDtCompra.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCompra.Location = new System.Drawing.Point(148, 35);
            this.lblDtCompra.Name = "lblDtCompra";
            this.lblDtCompra.Size = new System.Drawing.Size(214, 23);
            this.lblDtCompra.TabIndex = 105;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(148, 7);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(214, 23);
            this.lblFornecedor.TabIndex = 104;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(1, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 31);
            this.lblCodigo.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fornecedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cond. Pgto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Data de Compra:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.dataSet1;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // pgContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Name = "pgContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar Conta";
            this.Load += new System.EventHandler(this.pgContasPagar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Listar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtPagamento;
        private System.Windows.Forms.Label lblDataPgto;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.TextBox txtVlrPago;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSubGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCC;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCentroCusto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCustoSubGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFormPgto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private DataSet1TableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblDtCompra;
        private System.Windows.Forms.Label lblCondPgto;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblVlrPago;
        private System.Windows.Forms.Label label10;
    }
}