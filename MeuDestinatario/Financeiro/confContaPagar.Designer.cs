namespace MeuDestinatario.Financeiro
{
    partial class confContaPagar
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
            this.butCancelar = new System.Windows.Forms.ToolStripButton();
            this.TSB_SalvarPedido = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblVM = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblVSem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSubGrupo = new System.Windows.Forms.ComboBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtFormPgto = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.labCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbCondPgto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butCancelar,
            this.TSB_SalvarPedido});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // butCancelar
            // 
            this.butCancelar.Image = global::MeuDestinatario.Properties.Resources.icon_delete__1;
            this.butCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(73, 22);
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TSB_SalvarPedido
            // 
            this.TSB_SalvarPedido.Image = global::MeuDestinatario.Properties.Resources.icon_save_1;
            this.TSB_SalvarPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_SalvarPedido.Name = "TSB_SalvarPedido";
            this.TSB_SalvarPedido.Size = new System.Drawing.Size(58, 22);
            this.TSB_SalvarPedido.Text = "Salvar";
            this.TSB_SalvarPedido.ToolTipText = "Salvar novo Cliente";
            this.TSB_SalvarPedido.Click += new System.EventHandler(this.TSB_SalvarPedido_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 482);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtConta);
            this.panel2.Controls.Add(this.txtFormPgto);
            this.panel2.Controls.Add(this.txtFornecedor);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtValorTotal);
            this.panel2.Controls.Add(this.labCodigo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.cmbCondPgto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 482);
            this.panel2.TabIndex = 101;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.lblVM);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblVSem);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(34, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 57);
            this.panel4.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(199, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Total a Pagar:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(300, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(202, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Comprado no Mês:";
            // 
            // lblVM
            // 
            this.lblVM.AutoSize = true;
            this.lblVM.Location = new System.Drawing.Point(104, 31);
            this.lblVM.Name = "lblVM";
            this.lblVM.Size = new System.Drawing.Size(41, 13);
            this.lblVM.TabIndex = 3;
            this.lblVM.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "A vencer no Mês:";
            // 
            // lblVSem
            // 
            this.lblVSem.Location = new System.Drawing.Point(124, 8);
            this.lblVSem.Name = "lblVSem";
            this.lblVSem.Size = new System.Drawing.Size(70, 17);
            this.lblVSem.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "A vencer na Semana:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbSubGrupo);
            this.groupBox1.Controls.Add(this.cmbGrupo);
            this.groupBox1.Location = new System.Drawing.Point(32, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 132);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classificação Orçamentária";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.ItemHeight = 13;
            this.cmbCategoria.Location = new System.Drawing.Point(90, 29);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(246, 21);
            this.cmbCategoria.TabIndex = 6;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sub-Grupo:";
            // 
            // cmbSubGrupo
            // 
            this.cmbSubGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubGrupo.Enabled = false;
            this.cmbSubGrupo.FormattingEnabled = true;
            this.cmbSubGrupo.ItemHeight = 13;
            this.cmbSubGrupo.Location = new System.Drawing.Point(90, 82);
            this.cmbSubGrupo.Name = "cmbSubGrupo";
            this.cmbSubGrupo.Size = new System.Drawing.Size(246, 21);
            this.cmbSubGrupo.TabIndex = 8;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.Enabled = false;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.ItemHeight = 13;
            this.cmbGrupo.Location = new System.Drawing.Point(90, 55);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(246, 21);
            this.cmbGrupo.TabIndex = 7;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            this.cmbGrupo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbGrupo_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(461, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 402);
            this.panel3.TabIndex = 108;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 378);
            this.dataGridView1.TabIndex = 107;
            // 
            // txtConta
            // 
            this.txtConta.Enabled = false;
            this.txtConta.Location = new System.Drawing.Point(114, 216);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(121, 20);
            this.txtConta.TabIndex = 106;
            // 
            // txtFormPgto
            // 
            this.txtFormPgto.Enabled = false;
            this.txtFormPgto.Location = new System.Drawing.Point(114, 189);
            this.txtFormPgto.Name = "txtFormPgto";
            this.txtFormPgto.Size = new System.Drawing.Size(87, 20);
            this.txtFormPgto.TabIndex = 105;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(112, 58);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(294, 20);
            this.txtFornecedor.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 103;
            this.label8.Text = "Valor Total:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(114, 160);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(87, 20);
            this.txtValorTotal.TabIndex = 102;
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Location = new System.Drawing.Point(62, 35);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(43, 13);
            this.labCodigo.TabIndex = 0;
            this.labCodigo.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fornecedor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Forma de Pgto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cond. Pgto:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(112, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 20);
            this.txtCodigo.TabIndex = 100;
            // 
            // cmbCondPgto
            // 
            this.cmbCondPgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondPgto.Enabled = false;
            this.cmbCondPgto.FormattingEnabled = true;
            this.cmbCondPgto.ItemHeight = 13;
            this.cmbCondPgto.Location = new System.Drawing.Point(115, 243);
            this.cmbCondPgto.Name = "cmbCondPgto";
            this.cmbCondPgto.Size = new System.Drawing.Size(120, 21);
            this.cmbCondPgto.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Conta:";
            // 
            // confContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "confContaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar Parcelas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton butCancelar;
        private System.Windows.Forms.ToolStripButton TSB_SalvarPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSubGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbCondPgto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtFormPgto;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblVM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblVSem;
        private System.Windows.Forms.Label label5;
    }
}