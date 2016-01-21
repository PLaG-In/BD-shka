namespace DataBaseProject
{
    partial class DataBase
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bySellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSellingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showingByProductNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.sellersToolStripMenuItem,
            this.sellingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // sellersToolStripMenuItem
            // 
            this.sellersToolStripMenuItem.Name = "sellersToolStripMenuItem";
            this.sellersToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sellersToolStripMenuItem.Text = "Sellers";
            this.sellersToolStripMenuItem.Click += new System.EventHandler(this.sellersToolStripMenuItem_Click);
            // 
            // sellingsToolStripMenuItem
            // 
            this.sellingsToolStripMenuItem.Name = "sellingsToolStripMenuItem";
            this.sellingsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sellingsToolStripMenuItem.Text = "Sellings";
            this.sellingsToolStripMenuItem.Click += new System.EventHandler(this.sellingsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byProductsToolStripMenuItem,
            this.bySellersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // byProductsToolStripMenuItem
            // 
            this.byProductsToolStripMenuItem.Name = "byProductsToolStripMenuItem";
            this.byProductsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.byProductsToolStripMenuItem.Text = "by products";
            this.byProductsToolStripMenuItem.Click += new System.EventHandler(this.byProductsToolStripMenuItem_Click);
            // 
            // bySellersToolStripMenuItem
            // 
            this.bySellersToolStripMenuItem.Name = "bySellersToolStripMenuItem";
            this.bySellersToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.bySellersToolStripMenuItem.Text = "by sellers";
            this.bySellersToolStripMenuItem.Click += new System.EventHandler(this.bySellersToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductsToolStripMenuItem,
            this.allSellersToolStripMenuItem,
            this.allSellingsToolStripMenuItem,
            this.showingByProductNameToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // allProductsToolStripMenuItem
            // 
            this.allProductsToolStripMenuItem.Name = "allProductsToolStripMenuItem";
            this.allProductsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.allProductsToolStripMenuItem.Text = "All products";
            this.allProductsToolStripMenuItem.Click += new System.EventHandler(this.allProductsToolStripMenuItem_Click);
            // 
            // allSellersToolStripMenuItem
            // 
            this.allSellersToolStripMenuItem.Name = "allSellersToolStripMenuItem";
            this.allSellersToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.allSellersToolStripMenuItem.Text = "All sellers";
            this.allSellersToolStripMenuItem.Click += new System.EventHandler(this.allSellersToolStripMenuItem_Click);
            // 
            // allSellingsToolStripMenuItem
            // 
            this.allSellingsToolStripMenuItem.Name = "allSellingsToolStripMenuItem";
            this.allSellingsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.allSellingsToolStripMenuItem.Text = "All sellings";
            this.allSellingsToolStripMenuItem.Click += new System.EventHandler(this.allSellingsToolStripMenuItem_Click);
            // 
            // showingByProductNameToolStripMenuItem
            // 
            this.showingByProductNameToolStripMenuItem.Name = "showingByProductNameToolStripMenuItem";
            this.showingByProductNameToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.showingByProductNameToolStripMenuItem.Text = "Showing by product barcode";
            this.showingByProductNameToolStripMenuItem.Click += new System.EventHandler(this.showingByProductNameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 118);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataBase";
            this.Text = "DataBase";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bySellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSellingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showingByProductNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}