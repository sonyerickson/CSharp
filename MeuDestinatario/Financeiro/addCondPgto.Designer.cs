namespace MeuDestinatario.Financeiro
{
    partial class addCondPgto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Listar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_NovoPedido = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_SalvarPedido = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDias);
            this.panel1.Controls.Add(this.txtParcelas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 137);
            this.panel1.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(116, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 20);
            this.txtID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Código:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(116, 91);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(112, 20);
            this.txtDias.TabIndex = 4;
            // 
            // txtParcelas
            // 
            this.txtParcelas.Location = new System.Drawing.Point(116, 65);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(228, 20);
            this.txtParcelas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(116, 39);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(228, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qnt Parcelas:";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intervalo em Dias:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Listar,
            this.toolStripButton5,
            this.TSB_NovoPedido,
            this.toolStripButton6,
            this.TSB_SalvarPedido});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(793, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Listar
            // 
            this.TSB_Listar.Image = global::MeuDestinatario.Properties.Resources.Inventory_icon1;
            this.TSB_Listar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Listar.Name = "TSB_Listar";
            this.TSB_Listar.Size = new System.Drawing.Size(55, 22);
            this.TSB_Listar.Text = "Listar";
            this.TSB_Listar.ToolTipText = "Listar todos os clientes.";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_NovoPedido
            // 
            this.TSB_NovoPedido.Image = global::MeuDestinatario.Properties.Resources.icon_Add;
            this.TSB_NovoPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_NovoPedido.Name = "TSB_NovoPedido";
            this.TSB_NovoPedido.Size = new System.Drawing.Size(56, 22);
            this.TSB_NovoPedido.Text = "Novo";
            this.TSB_NovoPedido.ToolTipText = "Limpa os campa para inserir um novo pedido.";
            this.TSB_NovoPedido.Click += new System.EventHandler(this.TSB_NovoPedido_Click);
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
            this.TSB_SalvarPedido.Size = new System.Drawing.Size(58, 22);
            this.TSB_SalvarPedido.Text = "Salvar";
            this.TSB_SalvarPedido.ToolTipText = "Salvar novo Cliente";
            this.TSB_SalvarPedido.Click += new System.EventHandler(this.TSB_SalvarPedido_Click);
            // 
            // addCondPgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 162);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "addCondPgto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Condição de Pagamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Listar;
        private System.Windows.Forms.ToolStripSeparator toolStripButton5;
        private System.Windows.Forms.ToolStripButton TSB_NovoPedido;
        private System.Windows.Forms.ToolStripSeparator toolStripButton6;
        private System.Windows.Forms.ToolStripButton TSB_SalvarPedido;
    }
}