namespace HefdynApp
{
    partial class CompositeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView compositeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalResultColumn;
        private System.Windows.Forms.Label totalResultLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.compositeDataGridView = new System.Windows.Forms.DataGridView();
            this.indexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compositeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // compositeDataGridView
            // 
            this.compositeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compositeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexColumn,
            this.totalResultColumn});
            this.compositeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.compositeDataGridView.Name = "compositeDataGridView";
            this.compositeDataGridView.Size = new System.Drawing.Size(360, 150);
            this.compositeDataGridView.TabIndex = 0;
            // 
            // indexColumn
            // 
            this.indexColumn.HeaderText = "Index";
            this.indexColumn.Name = "indexColumn";
            // 
            // totalResultColumn
            // 
            this.totalResultColumn.HeaderText = "Total Result";
            this.totalResultColumn.Name = "totalResultColumn";
            // 
            // totalResultLabel
            // 
            this.totalResultLabel.AutoSize = true;
            this.totalResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalResultLabel.Location = new System.Drawing.Point(12, 180);
            this.totalResultLabel.Name = "totalResultLabel";
            this.totalResultLabel.Size = new System.Drawing.Size(51, 17);
            this.totalResultLabel.TabIndex = 1;
            this.totalResultLabel.Text = "Result";
            // 
            // CompositeForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.totalResultLabel);
            this.Controls.Add(this.compositeDataGridView);
            this.Name = "CompositeForm";
            this.Text = "Composite Index";
            ((System.ComponentModel.ISupportInitialize)(this.compositeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}