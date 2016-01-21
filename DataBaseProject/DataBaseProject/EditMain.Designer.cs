namespace DataBaseProject
{
    partial class EditMain
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
            this.BLoad = new System.Windows.Forms.Button();
            this.BConfirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BCancel = new System.Windows.Forms.Button();
            this.bcBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.updButton = new System.Windows.Forms.Button();
            this.ascSort = new System.Windows.Forms.RadioButton();
            this.desSort = new System.Windows.Forms.RadioButton();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.srchButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BLoad
            // 
            this.BLoad.Location = new System.Drawing.Point(603, 215);
            this.BLoad.Name = "BLoad";
            this.BLoad.Size = new System.Drawing.Size(75, 23);
            this.BLoad.TabIndex = 2;
            this.BLoad.Text = "Load Image";
            this.BLoad.UseVisualStyleBackColor = true;
            this.BLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // BConfirm
            // 
            this.BConfirm.Location = new System.Drawing.Point(565, 364);
            this.BConfirm.Name = "BConfirm";
            this.BConfirm.Size = new System.Drawing.Size(75, 23);
            this.BConfirm.TabIndex = 3;
            this.BConfirm.Text = "Confirm";
            this.BConfirm.UseVisualStyleBackColor = true;
            this.BConfirm.Click += new System.EventHandler(this.BConfirm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 197);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(648, 364);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 5;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // bcBox
            // 
            this.bcBox.Location = new System.Drawing.Point(15, 241);
            this.bcBox.Name = "bcBox";
            this.bcBox.Size = new System.Drawing.Size(135, 20);
            this.bcBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Barcode";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(15, 292);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(135, 20);
            this.typeBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity";
            // 
            // quBox
            // 
            this.quBox.Location = new System.Drawing.Point(168, 271);
            this.quBox.Name = "quBox";
            this.quBox.Size = new System.Drawing.Size(135, 20);
            this.quBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(322, 292);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(135, 20);
            this.priceBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Country";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(322, 241);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(135, 20);
            this.countryBox.TabIndex = 16;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 364);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(135, 23);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add new record";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(560, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(322, 364);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(135, 23);
            this.delButton.TabIndex = 19;
            this.delButton.Text = "Delete record";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(168, 364);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(135, 23);
            this.editButton.TabIndex = 20;
            this.editButton.Text = "Edit record";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // updButton
            // 
            this.updButton.Location = new System.Drawing.Point(168, 364);
            this.updButton.Name = "updButton";
            this.updButton.Size = new System.Drawing.Size(135, 23);
            this.updButton.TabIndex = 21;
            this.updButton.Text = "Update record";
            this.updButton.UseVisualStyleBackColor = true;
            this.updButton.Click += new System.EventHandler(this.updButton_Click);
            // 
            // ascSort
            // 
            this.ascSort.AutoSize = true;
            this.ascSort.Location = new System.Drawing.Point(474, 241);
            this.ascSort.Name = "ascSort";
            this.ascSort.Size = new System.Drawing.Size(75, 17);
            this.ascSort.TabIndex = 22;
            this.ascSort.TabStop = true;
            this.ascSort.Text = "Ascending";
            this.ascSort.UseVisualStyleBackColor = true;
            // 
            // desSort
            // 
            this.desSort.AutoSize = true;
            this.desSort.Location = new System.Drawing.Point(474, 265);
            this.desSort.Name = "desSort";
            this.desSort.Size = new System.Drawing.Size(82, 17);
            this.desSort.TabIndex = 23;
            this.desSort.TabStop = true;
            this.desSort.Text = "Descending";
            this.desSort.UseVisualStyleBackColor = true;
            // 
            // sortBox
            // 
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "Barcode",
            "Product_type",
            "Number_of_products",
            "Manufacturer_country",
            "Price"});
            this.sortBox.Location = new System.Drawing.Point(565, 244);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(121, 21);
            this.sortBox.TabIndex = 24;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(565, 271);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 25;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Search by country";
            // 
            // srchButton
            // 
            this.srchButton.Location = new System.Drawing.Point(156, 338);
            this.srchButton.Name = "srchButton";
            this.srchButton.Size = new System.Drawing.Size(65, 23);
            this.srchButton.TabIndex = 28;
            this.srchButton.Text = "Search";
            this.srchButton.UseVisualStyleBackColor = true;
            this.srchButton.Click += new System.EventHandler(this.srchButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Search by type";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 338);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.srchButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.desSort);
            this.Controls.Add(this.ascSort);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bcBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BConfirm);
            this.Controls.Add(this.BLoad);
            this.Controls.Add(this.updButton);
            this.Name = "EditMain";
            this.Text = "EditMain";
            this.Load += new System.EventHandler(this.EditMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLoad;
        private System.Windows.Forms.Button BConfirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox bcBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button updButton;
        private System.Windows.Forms.RadioButton ascSort;
        private System.Windows.Forms.RadioButton desSort;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button srchButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}