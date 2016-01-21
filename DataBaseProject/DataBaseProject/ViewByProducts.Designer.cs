namespace DataBaseProject
{
    partial class ViewByProducts
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.findBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lAverage = new System.Windows.Forms.Label();
            this.lSumPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.findBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(742, 173);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_CellMouseClick);
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(12, 204);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(544, 168);
            this.dgvView.TabIndex = 1;
            // 
            // findBox
            // 
            this.findBox.Controls.Add(this.button2);
            this.findBox.Controls.Add(this.button1);
            this.findBox.Controls.Add(this.label2);
            this.findBox.Controls.Add(this.label1);
            this.findBox.Controls.Add(this.textBox2);
            this.findBox.Controls.Add(this.textBox1);
            this.findBox.Location = new System.Drawing.Point(581, 204);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(179, 237);
            this.findBox.TabIndex = 3;
            this.findBox.TabStop = false;
            this.findBox.Text = "Find product";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lAverage
            // 
            this.lAverage.AutoSize = true;
            this.lAverage.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAverage.Location = new System.Drawing.Point(12, 375);
            this.lAverage.Name = "lAverage";
            this.lAverage.Size = new System.Drawing.Size(327, 29);
            this.lAverage.TabIndex = 4;
            this.lAverage.Text = "Average products quantity - 22";
            this.lAverage.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lAverage.UseCompatibleTextRendering = true;
            // 
            // lSumPrice
            // 
            this.lSumPrice.AutoSize = true;
            this.lSumPrice.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSumPrice.Location = new System.Drawing.Point(12, 409);
            this.lSumPrice.Name = "lSumPrice";
            this.lSumPrice.Size = new System.Drawing.Size(164, 27);
            this.lSumPrice.TabIndex = 5;
            this.lSumPrice.Text = "Earned money - 23";
            this.lSumPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lSumPrice.UseCompatibleTextRendering = true;
            // 
            // ViewByProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.lSumPrice);
            this.Controls.Add(this.lAverage);
            this.Controls.Add(this.findBox);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.dgvProducts);
            this.Name = "ViewByProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ViewByProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.findBox.ResumeLayout(false);
            this.findBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.GroupBox findBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lAverage;
        private System.Windows.Forms.Label lSumPrice;
    }
}