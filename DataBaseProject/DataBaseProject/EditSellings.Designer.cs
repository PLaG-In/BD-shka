namespace DataBaseProject
{
    partial class EditSellings
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
            this.dtpSell = new System.Windows.Forms.DateTimePicker();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.accButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.productBox = new System.Windows.Forms.ComboBox();
            this.sellingsDataSet = new DataBaseProject.SellingsDataSet();
            this.sellerBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.quBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sellersTableAdapter1 = new DataBaseProject.SellingsDataSetTableAdapters.SellersTableAdapter();
            this.productsTableAdapter1 = new DataBaseProject.SellingsDataSetTableAdapters.ProductsTableAdapter();
            this.sellersbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sellingsDataSet1 = new DataBaseProject.SellingsDataSet();
            this.editButton = new System.Windows.Forms.Button();
            this.updButton = new System.Windows.Forms.Button();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.ascSort = new System.Windows.Forms.RadioButton();
            this.desSort = new System.Windows.Forms.RadioButton();
            this.sortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSell
            // 
            this.dtpSell.Location = new System.Drawing.Point(274, 173);
            this.dtpSell.Name = "dtpSell";
            this.dtpSell.Size = new System.Drawing.Size(200, 20);
            this.dtpSell.TabIndex = 3;
            this.dtpSell.Value = new System.DateTime(2016, 1, 15, 0, 0, 0, 0);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(126, 268);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 6;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 268);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // accButton
            // 
            this.accButton.Location = new System.Drawing.Point(471, 268);
            this.accButton.Name = "accButton";
            this.accButton.Size = new System.Drawing.Size(75, 23);
            this.accButton.TabIndex = 9;
            this.accButton.Text = "Accept";
            this.accButton.UseVisualStyleBackColor = true;
            this.accButton.Click += new System.EventHandler(this.accButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product";
            // 
            // productBox
            // 
            this.productBox.DataSource = this.sellingsDataSet;
            this.productBox.DisplayMember = "Products.Product_type";
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(74, 174);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(121, 21);
            this.productBox.TabIndex = 14;
            this.productBox.ValueMember = "Sellings.FK_Sellings_Products.Product_Id";
            // 
            // sellingsDataSet
            // 
            this.sellingsDataSet.DataSetName = "SellingsDataSet";
            this.sellingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellerBox
            // 
            this.sellerBox.DataSource = this.sellingsDataSet;
            this.sellerBox.DisplayMember = "Sellers.Seller_surname";
            this.sellerBox.FormattingEnabled = true;
            this.sellerBox.Location = new System.Drawing.Point(74, 215);
            this.sellerBox.Name = "sellerBox";
            this.sellerBox.Size = new System.Drawing.Size(121, 21);
            this.sellerBox.TabIndex = 15;
            this.sellerBox.ValueMember = "Sellings.FK_Sellings_Products.Seller_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Seller";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(230, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quBox
            // 
            this.quBox.Location = new System.Drawing.Point(274, 215);
            this.quBox.Name = "quBox";
            this.quBox.Size = new System.Drawing.Size(100, 20);
            this.quBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(201, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quantity";
            // 
            // sellersTableAdapter1
            // 
            this.sellersTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // sellersbindingSource1
            // 
            this.sellersbindingSource1.DataMember = "Sellers";
            this.sellersbindingSource1.DataSource = this.sellingsDataSet;
            // 
            // productsbindingSource1
            // 
            this.productsbindingSource1.DataMember = "Products";
            this.productsbindingSource1.DataSource = this.sellingsDataSet;
            // 
            // sellingsDataSet1
            // 
            this.sellingsDataSet1.DataSetName = "SellingsDataSet";
            this.sellingsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(306, 268);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 23;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // updButton
            // 
            this.updButton.Location = new System.Drawing.Point(306, 268);
            this.updButton.Name = "updButton";
            this.updButton.Size = new System.Drawing.Size(75, 23);
            this.updButton.TabIndex = 24;
            this.updButton.Text = "Update";
            this.updButton.UseVisualStyleBackColor = true;
            this.updButton.Click += new System.EventHandler(this.updButton_Click_1);
            // 
            // sortBox
            // 
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "Seller_surname",
            "Product_type",
            "Price",
            "Number_of_sell",
            "Data"});
            this.sortBox.Location = new System.Drawing.Point(511, 201);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(121, 21);
            this.sortBox.TabIndex = 25;
            // 
            // ascSort
            // 
            this.ascSort.AutoSize = true;
            this.ascSort.Location = new System.Drawing.Point(480, 178);
            this.ascSort.Name = "ascSort";
            this.ascSort.Size = new System.Drawing.Size(75, 17);
            this.ascSort.TabIndex = 26;
            this.ascSort.TabStop = true;
            this.ascSort.Text = "Ascending";
            this.ascSort.UseVisualStyleBackColor = true;
            // 
            // desSort
            // 
            this.desSort.AutoSize = true;
            this.desSort.Location = new System.Drawing.Point(571, 178);
            this.desSort.Name = "desSort";
            this.desSort.Size = new System.Drawing.Size(82, 17);
            this.desSort.TabIndex = 27;
            this.desSort.TabStop = true;
            this.desSort.Text = "Descending";
            this.desSort.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(534, 228);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 28;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // EditSellings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 306);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.desSort);
            this.Controls.Add(this.ascSort);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellerBox);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.accButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.dtpSell);
            this.Controls.Add(this.updButton);
            this.Name = "EditSellings";
            this.Text = "EditSellings";
            this.Load += new System.EventHandler(this.EditSellings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSell;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button accButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productBox;
        private System.Windows.Forms.ComboBox sellerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox quBox;
        private System.Windows.Forms.Label label5;
        private SellingsDataSet sellingsDataSet;
        private SellingsDataSetTableAdapters.SellersTableAdapter sellersTableAdapter1;
        private SellingsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.BindingSource sellersbindingSource1;
        private System.Windows.Forms.BindingSource productsbindingSource1;
        private SellingsDataSet sellingsDataSet1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button updButton;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.RadioButton ascSort;
        private System.Windows.Forms.RadioButton desSort;
        private System.Windows.Forms.Button sortButton;
    }
}