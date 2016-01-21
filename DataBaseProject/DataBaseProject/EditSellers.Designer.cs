namespace DataBaseProject
{
    partial class EditSellers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.passportBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.refButton = new System.Windows.Forms.Button();
            this.conButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ascSort = new System.Windows.Forms.RadioButton();
            this.desSort = new System.Windows.Forms.RadioButton();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.sortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(85, 186);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(135, 20);
            this.nameBox.TabIndex = 2;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(85, 224);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(135, 20);
            this.surnameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // patronymicBox
            // 
            this.patronymicBox.Location = new System.Drawing.Point(85, 262);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(135, 20);
            this.patronymicBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patronymic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(246, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(300, 183);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(135, 20);
            this.salaryBox.TabIndex = 9;
            // 
            // passportBox
            // 
            this.passportBox.Location = new System.Drawing.Point(300, 224);
            this.passportBox.Name = "passportBox";
            this.passportBox.Size = new System.Drawing.Size(135, 20);
            this.passportBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(230, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Passport";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(17, 300);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add seller";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(128, 300);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(99, 23);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // refButton
            // 
            this.refButton.Location = new System.Drawing.Point(128, 300);
            this.refButton.Name = "refButton";
            this.refButton.Size = new System.Drawing.Size(99, 23);
            this.refButton.TabIndex = 15;
            this.refButton.Text = "Update";
            this.refButton.UseVisualStyleBackColor = true;
            this.refButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // conButton
            // 
            this.conButton.Location = new System.Drawing.Point(370, 301);
            this.conButton.Name = "conButton";
            this.conButton.Size = new System.Drawing.Size(103, 23);
            this.conButton.TabIndex = 16;
            this.conButton.Text = "Accept";
            this.conButton.UseVisualStyleBackColor = true;
            this.conButton.Click += new System.EventHandler(this.conButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(479, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ascSort
            // 
            this.ascSort.AutoSize = true;
            this.ascSort.Location = new System.Drawing.Point(451, 183);
            this.ascSort.Name = "ascSort";
            this.ascSort.Size = new System.Drawing.Size(75, 17);
            this.ascSort.TabIndex = 18;
            this.ascSort.TabStop = true;
            this.ascSort.Text = "Ascending";
            this.ascSort.UseVisualStyleBackColor = true;
            // 
            // desSort
            // 
            this.desSort.AutoSize = true;
            this.desSort.Location = new System.Drawing.Point(451, 200);
            this.desSort.Name = "desSort";
            this.desSort.Size = new System.Drawing.Size(82, 17);
            this.desSort.TabIndex = 19;
            this.desSort.TabStop = true;
            this.desSort.Text = "Descending";
            this.desSort.UseVisualStyleBackColor = true;
            // 
            // sortBox
            // 
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "Seller_name",
            "Seller_surname",
            "Seller_patronymic",
            "Salary",
            "Passport"});
            this.sortBox.Location = new System.Drawing.Point(451, 223);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(121, 21);
            this.sortBox.TabIndex = 20;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(451, 250);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(121, 23);
            this.sortButton.TabIndex = 21;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // EditSellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 336);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.desSort);
            this.Controls.Add(this.ascSort);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.conButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passportBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patronymicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refButton);
            this.Name = "EditSellers";
            this.Text = "EditSellers";
            this.Load += new System.EventHandler(this.EditSellers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patronymicBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.TextBox passportBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button refButton;
        private System.Windows.Forms.Button conButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton ascSort;
        private System.Windows.Forms.RadioButton desSort;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Button sortButton;

    }
}