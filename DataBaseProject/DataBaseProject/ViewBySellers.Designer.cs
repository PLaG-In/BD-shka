namespace DataBaseProject
{
    partial class ViewBySellers
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
            this.dataSellers = new System.Windows.Forms.DataGridView();
            this.dataShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSellers
            // 
            this.dataSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSellers.Location = new System.Drawing.Point(12, 12);
            this.dataSellers.Name = "dataSellers";
            this.dataSellers.Size = new System.Drawing.Size(789, 167);
            this.dataSellers.TabIndex = 0;
            this.dataSellers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSellers_CellMouseClick);
            // 
            // dataShow
            // 
            this.dataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShow.Location = new System.Drawing.Point(12, 198);
            this.dataShow.Name = "dataShow";
            this.dataShow.Size = new System.Drawing.Size(789, 174);
            this.dataShow.TabIndex = 1;
            // 
            // ViewBySellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 384);
            this.Controls.Add(this.dataShow);
            this.Controls.Add(this.dataSellers);
            this.Name = "ViewBySellers";
            this.Text = "Sellers";
            this.Load += new System.EventHandler(this.ViewBySellers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSellers;
        private System.Windows.Forms.DataGridView dataShow;
    }
}