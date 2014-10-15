namespace MeuDestinatario.Financeiro
{
    partial class addFormPgto
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TSB_Listar = new System.Windows.Forms.ToolStripButton();
            this.TSB_NovoPedido = new System.Windows.Forms.ToolStripButton();
            this.TSB_SalvarPedido = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.TSB_Listar,
            this.TSB_NovoPedido,
            this.TSB_SalvarPedido});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1038, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::MeuDestinatario.Properties.Resources.icon_delete__1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Cancelar";
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
            // TSB_NovoPedido
            // 
            this.TSB_NovoPedido.Image = global::MeuDestinatario.Properties.Resources.icon_Add;
            this.TSB_NovoPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_NovoPedido.Name = "TSB_NovoPedido";
            this.TSB_NovoPedido.Size = new System.Drawing.Size(56, 22);
            this.TSB_NovoPedido.Text = "Novo";
            this.TSB_NovoPedido.ToolTipText = "Limpa os campa para inserir um novo pedido.";
            // 
            // TSB_SalvarPedido
            // 
            this.TSB_SalvarPedido.Image = global::MeuDestinatario.Properties.Resources.icon_save_1;
            this.TSB_SalvarPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_SalvarPedido.Name = "TSB_SalvarPedido";
            this.TSB_SalvarPedido.Size = new System.Drawing.Size(58, 22);
            this.TSB_SalvarPedido.Text = "Salvar";
            this.TSB_SalvarPedido.ToolTipText = "Salvar novo Cliente";
            // 
            // addFormPgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 334);
            this.Controls.Add(this.toolStrip1);
            this.Name = "addFormPgto";
            this.Text = "addFormPgto";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton TSB_Listar;
        private System.Windows.Forms.ToolStripButton TSB_NovoPedido;
        private System.Windows.Forms.ToolStripButton TSB_SalvarPedido;
    }
}