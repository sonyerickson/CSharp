namespace MeuDestinatario.Financeiro
{
    partial class gerContasPagar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sSCHPASDataSet = new MeuDestinatario.SSCHPASDataSet();
            this.sSCHPASDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testeTableAdapter = new MeuDestinatario.SSCHPASDataSetTableAdapters.TesteTableAdapter();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSCHPASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSCHPASDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1150, 686);
            this.dataGridView1.TabIndex = 0;
            // 
            // sSCHPASDataSet
            // 
            this.sSCHPASDataSet.DataSetName = "SSCHPASDataSet";
            this.sSCHPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sSCHPASDataSetBindingSource
            // 
            this.sSCHPASDataSetBindingSource.DataSource = this.sSCHPASDataSet;
            this.sSCHPASDataSetBindingSource.Position = 0;
            // 
            // testeBindingSource
            // 
            this.testeBindingSource.DataMember = "Teste";
            this.testeBindingSource.DataSource = this.sSCHPASDataSetBindingSource;
            // 
            // testeTableAdapter
            // 
            this.testeTableAdapter.ClearBeforeFill = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.Width = 78;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 64;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // gerContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 686);
            this.Controls.Add(this.dataGridView1);
            this.Name = "gerContasPagar";
            this.Text = "gerContasPagar";
            this.Load += new System.EventHandler(this.gerContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSCHPASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSCHPASDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sSCHPASDataSetBindingSource;
        private SSCHPASDataSet sSCHPASDataSet;
        private System.Windows.Forms.BindingSource testeBindingSource;
        private SSCHPASDataSetTableAdapters.TesteTableAdapter testeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;

        
    }
}