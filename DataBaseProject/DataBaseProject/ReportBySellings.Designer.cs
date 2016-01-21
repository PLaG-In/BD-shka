namespace DataBaseProject
{
    partial class ReportBySellings
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
            this.SellingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SellingsTableAdapter = new DataBaseProject.SellingsDataSetTableAdapters.SellingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SellingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SellingsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DataBaseProject.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(595, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // SellingsDataSet
            // 
            this.SellingsDataSet.DataSetName = "SellingsDataSet";
            this.SellingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SellingsBindingSource
            // 
            this.SellingsBindingSource.DataMember = "Sellings";
            this.SellingsBindingSource.DataSource = this.SellingsDataSet;
            // 
            // SellingsTableAdapter
            // 
            this.SellingsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBySellings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 426);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBySellings";
            this.Text = "ReportBySellings";
            this.Load += new System.EventHandler(this.ReportBySellings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SellingsBindingSource;
        private SellingsDataSet SellingsDataSet;
        private SellingsDataSetTableAdapters.SellingsTableAdapter SellingsTableAdapter;
    }
}