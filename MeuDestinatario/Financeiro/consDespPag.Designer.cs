namespace MeuDestinatario.Financeiro
{
    partial class consDespPag
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSomaMes = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSomaSemana = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateComp2 = new System.Windows.Forms.DateTimePicker();
            this.dateComp1 = new System.Windows.Forms.DateTimePicker();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(862, 25);
            this.toolStrip1.TabIndex = 14;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 108);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSomaMes);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.lblSomaSemana);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(10, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(601, 82);
            this.panel3.TabIndex = 31;
            // 
            // lblSomaMes
            // 
            this.lblSomaMes.AutoSize = true;
            this.lblSomaMes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomaMes.Location = new System.Drawing.Point(133, 54);
            this.lblSomaMes.Name = "lblSomaMes";
            this.lblSomaMes.Size = new System.Drawing.Size(52, 20);
            this.lblSomaMes.TabIndex = 30;
            this.lblSomaMes.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Soma Total no M/:";
            // 
            // lblSomaSemana
            // 
            this.lblSomaSemana.AutoSize = true;
            this.lblSomaSemana.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomaSemana.Location = new System.Drawing.Point(133, 34);
            this.lblSomaSemana.Name = "lblSomaSemana";
            this.lblSomaSemana.Size = new System.Drawing.Size(52, 20);
            this.lblSomaSemana.TabIndex = 28;
            this.lblSomaSemana.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Soma Total na S/:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(133, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "label7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Soma Total:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 24);
            this.button1.TabIndex = 25;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbFornecedor);
            this.panel2.Controls.Add(this.txtCodigo2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dateComp2);
            this.panel2.Controls.Add(this.dateComp1);
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
            this.panel2.Size = new System.Drawing.Size(862, 124);
            this.panel2.TabIndex = 16;
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
            this.label9.Location = new System.Drawing.Point(525, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Data de Compra:";
            // 
            // dateComp2
            // 
            this.dateComp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateComp2.Location = new System.Drawing.Point(757, 40);
            this.dateComp2.Name = "dateComp2";
            this.dateComp2.Size = new System.Drawing.Size(97, 20);
            this.dateComp2.TabIndex = 10;
            this.dateComp2.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dateComp1
            // 
            this.dateComp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateComp1.Location = new System.Drawing.Point(622, 40);
            this.dateComp1.Name = "dateComp1";
            this.dateComp1.Size = new System.Drawing.Size(97, 20);
            this.dateComp1.TabIndex = 9;
            this.dateComp1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 296);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // consDespPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "consDespPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Despesas a Pagar";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateComp2;
        private System.Windows.Forms.DateTimePicker dateComp1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateVen2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateVen1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSomaMes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSomaSemana;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
    }
}