namespace MeuDestinatario.Financeiro
{
    partial class conFatPagar
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Limpar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_SalvarPedido = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.butPagar = new System.Windows.Forms.ToolStripButton();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datePgto2 = new System.Windows.Forms.DateTimePicker();
            this.datePgto1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateVen2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateVen1 = new System.Windows.Forms.DateTimePicker();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSomaTotal = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Cancelar,
            this.toolStripButton5,
            this.TSB_Limpar,
            this.toolStripButton6,
            this.TSB_SalvarPedido});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(950, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Cancelar
            // 
            this.TSB_Cancelar.Image = global::MeuDestinatario.Properties.Resources.icon_delete__1;
            this.TSB_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Cancelar.Name = "TSB_Cancelar";
            this.TSB_Cancelar.Size = new System.Drawing.Size(73, 22);
            this.TSB_Cancelar.Text = "Cancelar";
            this.TSB_Cancelar.ToolTipText = "Cancelar Fatura";
            this.TSB_Cancelar.Click += new System.EventHandler(this.TSB_Cancelar_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_Limpar
            // 
            this.TSB_Limpar.Image = global::MeuDestinatario.Properties.Resources.icon_Add;
            this.TSB_Limpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Limpar.Name = "TSB_Limpar";
            this.TSB_Limpar.Size = new System.Drawing.Size(64, 22);
            this.TSB_Limpar.Text = "Limpar";
            this.TSB_Limpar.ToolTipText = "Retorno os valores dos campos aos valores padrão.";
            this.TSB_Limpar.Click += new System.EventHandler(this.TSB_Limpar_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_SalvarPedido
            // 
            this.TSB_SalvarPedido.Image = global::MeuDestinatario.Properties.Resources.icon_save_1;
            this.TSB_SalvarPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_SalvarPedido.Name = "TSB_SalvarPedido";
            this.TSB_SalvarPedido.Size = new System.Drawing.Size(77, 22);
            this.TSB_SalvarPedido.Text = "Pesquisar";
            this.TSB_SalvarPedido.ToolTipText = "Pesquisa faturas conforme filtros.";
            this.TSB_SalvarPedido.Click += new System.EventHandler(this.TSB_SalvarPedido_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSomaTotal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 109);
            this.panel1.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Soma Total:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Controls.Add(this.cmbFornecedor);
            this.panel2.Controls.Add(this.txtCodigo2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.datePgto2);
            this.panel2.Controls.Add(this.datePgto1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.txtValor2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateVen2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtValor1);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateVen1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 170);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.butPagar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 145);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(950, 25);
            this.toolStrip2.TabIndex = 32;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::MeuDestinatario.Properties.Resources.icon_delete__1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(109, 22);
            this.toolStripButton1.Text = "Cancelar Fatura";
            this.toolStripButton1.ToolTipText = "Cancela conta a pagar.";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::MeuDestinatario.Properties.Resources.icon_Add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton2.Text = "Adicionar";
            this.toolStripButton2.ToolTipText = "Adicionar nova despesa a pagar.";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // butPagar
            // 
            this.butPagar.Image = global::MeuDestinatario.Properties.Resources.icon_save_1;
            this.butPagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butPagar.Name = "butPagar";
            this.butPagar.Size = new System.Drawing.Size(57, 22);
            this.butPagar.Text = "Pagar";
            this.butPagar.ToolTipText = "Fazer a baixa de títulos a pagar.";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(87, 40);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(235, 21);
            this.cmbFornecedor.TabIndex = 3;
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(222, 17);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo2.TabIndex = 2;
            this.txtCodigo2.Text = "9999";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Até:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(725, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Até:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Data de Pagamento:";
            // 
            // datePgto2
            // 
            this.datePgto2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePgto2.Location = new System.Drawing.Point(757, 40);
            this.datePgto2.Name = "datePgto2";
            this.datePgto2.Size = new System.Drawing.Size(97, 20);
            this.datePgto2.TabIndex = 10;
            this.datePgto2.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // datePgto1
            // 
            this.datePgto1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePgto1.Location = new System.Drawing.Point(622, 40);
            this.datePgto1.Name = "datePgto1";
            this.datePgto1.Size = new System.Drawing.Size(97, 20);
            this.datePgto1.TabIndex = 9;
            this.datePgto1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "Aberto";
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(87, 93);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(100, 21);
            this.cmbStatus.TabIndex = 6;
            this.cmbStatus.ValueMember = "Aberto";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(222, 66);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Até:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(725, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data de Vencimento:";
            // 
            // dateVen2
            // 
            this.dateVen2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVen2.Location = new System.Drawing.Point(757, 17);
            this.dateVen2.Name = "dateVen2";
            this.dateVen2.Size = new System.Drawing.Size(97, 20);
            this.dateVen2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Valor:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(87, 67);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fornecedor:";
            // 
            // dateVen1
            // 
            this.dateVen1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVen1.Location = new System.Drawing.Point(622, 17);
            this.dateVen1.Name = "dateVen1";
            this.dateVen1.Size = new System.Drawing.Size(97, 20);
            this.dateVen1.TabIndex = 7;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 307);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lblSomaTotal
            // 
            this.lblSomaTotal.AutoSize = true;
            this.lblSomaTotal.Location = new System.Drawing.Point(87, 29);
            this.lblSomaTotal.Name = "lblSomaTotal";
            this.lblSomaTotal.Size = new System.Drawing.Size(41, 13);
            this.lblSomaTotal.TabIndex = 25;
            this.lblSomaTotal.Text = "label12";
            // 
            // conFatPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "conFatPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Faturas a Pagar";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripButton5;
        private System.Windows.Forms.ToolStripButton TSB_Limpar;
        private System.Windows.Forms.ToolStripSeparator toolStripButton6;
        private System.Windows.Forms.ToolStripButton TSB_SalvarPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateVen1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateVen2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datePgto2;
        private System.Windows.Forms.DateTimePicker datePgto1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton butPagar;
        private System.Windows.Forms.Label lblSomaTotal;
    }
}