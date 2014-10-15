namespace MeuDestinatario.Financeiro
{
    partial class pc_addClassificacao
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
            this.TSB_SalvarPedido = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.TSB_Listar,
            this.TSB_SalvarPedido});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1135, 25);
            this.toolStrip1.TabIndex = 4;
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
            this.TSB_Listar.Size = new System.Drawing.Size(78, 22);
            this.TSB_Listar.Text = "Consultar";
            this.TSB_Listar.ToolTipText = "Listar todos os clientes.";
            // 
            // TSB_SalvarPedido
            // 
            this.TSB_SalvarPedido.Image = global::MeuDestinatario.Properties.Resources.icon_save_1;
            this.TSB_SalvarPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_SalvarPedido.Name = "TSB_SalvarPedido";
            this.TSB_SalvarPedido.Size = new System.Drawing.Size(57, 22);
            this.TSB_SalvarPedido.Text = "Pagar";
            this.TSB_SalvarPedido.ToolTipText = "Salvar novo Cliente";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(116, 80);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(983, 191);
            this.treeView1.TabIndex = 5;
            // 
            // pc_addClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 559);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "pc_addClassificacao";
            this.Text = "Classificação Orçamentária";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton TSB_Listar;
        private System.Windows.Forms.ToolStripButton TSB_SalvarPedido;
        private System.Windows.Forms.TreeView treeView1;
    }
}