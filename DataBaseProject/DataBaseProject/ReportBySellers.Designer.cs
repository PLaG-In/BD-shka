namespace DataBaseProject
{
    partial class ReportBySellers
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SellingsDataSet = new DataBaseProject.SellingsDataSet();
            this.SellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SellersTableAdapter = new DataBaseProject.SellingsDataSetTableAdapters.SellersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SellingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SellersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DataBaseProject.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(589, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // SellingsDataSet
            // 
            this.SellingsDataSet.DataSetName = "SellingsDataSet";
            this.SellingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SellersBindingSource
            // 
            this.SellersBindingSource.DataMember = "Sellers";
            this.SellersBindingSource.DataSource = this.SellingsDataSet;
            // 
            // SellersTableAdapter
            // 
            this.SellersTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBySellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 426);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBySellers";
            this.Text = "ReportBySellers";
            this.Load += new System.EventHandler(this.ReportBySellers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SellersBindingSource;
        private SellingsDataSet SellingsDataSet;
        private SellingsDataSetTableAdapters.SellersTableAdapter SellersTableAdapter;
    }
}