namespace MeuDestinatario
{
    partial class ReportOne
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
            this.AcessoTfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SSCHPASDataSet = new MeuDestinatario.SSCHPASDataSet();
            this.TesteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TesteTableAdapter = new MeuDestinatario.SSCHPASDataSetTableAdapters.TesteTableAdapter();
            this.sSCHPASDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rel_fat_apagar1 = new MeuDestinatario.Financeiro.rel_fat_apagar();
            this.First1 = new MeuDestinatario.First();
            this.rel_fat_apagar2 = new MeuDestinatario.Financeiro.rel_fat_apagar();
            this.rel_Usuarios1 = new MeuDestinatario.Relatórios.rel_Usuarios();
            ((System.ComponentModel.ISupportInitialize)(this.AcessoTfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSCHPASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TesteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSCHPASDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AcessoTfBindingSource
            // 
            this.AcessoTfBindingSource.DataMember = "AcessoTf";
            // 
            // SSCHPASDataSet
            // 
            this.SSCHPASDataSet.DataSetName = "SSCHPASDataSet";
            this.SSCHPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TesteBindingSource
            // 
            this.TesteBindingSource.DataMember = "Teste";
            this.TesteBindingSource.DataSource = this.SSCHPASDataSet;
            // 
            // TesteTableAdapter
            // 
            this.TesteTableAdapter.ClearBeforeFill = true;
            // 
            // sSCHPASDataSetBindingSource
            // 
            this.sSCHPASDataSetBindingSource.DataSource = this.SSCHPASDataSet;
            this.sSCHPASDataSetBindingSource.Position = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rel_Usuarios1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1270, 456);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 456);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReportOne";
            this.Text = "ReportOne";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AcessoTfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSCHPASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TesteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSCHPASDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource AcessoTfBindingSource;
        private System.Windows.Forms.BindingSource TesteBindingSource;
        private SSCHPASDataSet SSCHPASDataSet;
        private SSCHPASDataSetTableAdapters.TesteTableAdapter TesteTableAdapter;
        private System.Windows.Forms.BindingSource sSCHPASDataSetBindingSource;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private First First1;
        private Financeiro.rel_fat_apagar rel_fat_apagar1;
        private Financeiro.rel_fat_apagar rel_fat_apagar2;
        private Relatórios.rel_Usuarios rel_Usuarios1;

    }
}