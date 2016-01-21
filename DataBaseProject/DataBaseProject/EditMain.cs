using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class EditMain : Form
    {
        private String _tableName = "Products";
        private SqlConnection _connection;
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _sqlCmdBuilder; 
        private DataSet _dataSet;
        private SqlCommand _cmd;
        private SQL _sqlWorker = new SQL();

        public EditMain(Boolean isProduct)
        {
            InitializeComponent();
            pictureBox1.Visible = true;
        }
        private int GetCurrentRowForID()
        {
            DataGridViewRow curRow = dataGridView1.CurrentRow;
            if (curRow == null)
            {
                return -1;
            }
            DataGridViewCellCollection cellsColl = curRow.Cells;
            DataGridViewCell idCell = cellsColl[0];
            return int.Parse(idCell.Value.ToString());
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            int id = GetCurrentRowForID();
            if (id == -1) return;
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    String fN = System.IO.Path.GetFileName(op.FileName);
                    System.IO.File.Copy(op.FileName, fN, true);
                    Bitmap bt = new Bitmap(op.FileName);
                    pictureBox1.Image = bt;
                    FileStream stream = new FileStream(fN, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(stream);
                    byte[] photo = reader.ReadBytes((int)stream.Length);
                    reader.Close();
                    stream.Close();
                    _dataSet.Tables[0].Rows[id - 1]["Photo"] = photo;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Can't load image");
            }
        }

        private void BConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                _sqlCmdBuilder = new SqlCommandBuilder(_adapter);
                _adapter.Update(_dataSet, _tableName);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        private void EditMain_Load(object sender, EventArgs e)
        {
            try
            {
                _connection = new SqlConnection();
                _connection.ConnectionString = SQL._conStr;
                _connection.Open();
                _adapter = new SqlDataAdapter("SELECT * FROM " + _tableName, _connection);
                _dataSet = new DataSet();
                _adapter.Fill(_dataSet, _tableName);
                dataGridView1.DataSource = _dataSet.Tables[0];
                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BLoad.Visible = true;
            pictureBox1.Image = null;
            int id = GetCurrentRowForID();
            if (id == -1) return;
            object path = _dataSet.Tables[0].Rows[id - 1]["Photo"];
            String pl = path.ToString();
            if (path == null || pl.Length == 0)
            {
                return;
            }
            byte[] myBytes = (byte[])path;
            Bitmap bit = new Bitmap(new MemoryStream(myBytes));
            pictureBox1.Image = bit;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((this.bcBox.Text.Length == 0) || (this.typeBox.Text.Length == 0) 
                || (this.quBox.Text.Length == 0) || (this.priceBox.Text.Length == 0)
                || (this.countryBox.Text.Length == 0))
            {
                MessageBox.Show("Wrong inputs!",
                    "Error");
            }
            else
            {
                String barcode = bcBox.Text, type = typeBox.Text, quantity = quBox.Text, price = priceBox.Text, country = countryBox.Text;
                int id = dataGridView1.RowCount;
                String id_n = _dataSet.Tables[0].Rows[id - 2]["Product_ID"].ToString();
                id = Convert.ToInt32(id_n) + 1;
                _cmd = new SqlCommand();
                _cmd.Connection = _connection;
                _cmd.CommandText = "INSERT INTO [dbo].[Products] (Product_ID, Barcode, Product_type, Number_of_products, Price, Manufacturer_country) VALUES(N'" + id.ToString() + "',N'"
                    + barcode + "',N'" + type + "',N'" + quantity + "',N'" + price + "',N'" + country + "')";
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                bcBox.Clear();
                typeBox.Clear();
                quBox.Clear();
                priceBox.Clear();
                countryBox.Clear();
                _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT Product_ID, Barcode, Product_type, Number_of_products, Price, Manufacturer_country FROM Products");
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Are you sure want to delete this record?", "Confirm message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) 
            {
                return;
            }

            if (result == DialogResult.Yes)
            {
                string id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                _cmd = new SqlCommand();
                _cmd.Connection = _connection;
                _cmd.CommandText = "DELETE FROM [dbo].[Sellings] WHERE Product_ID='" + id + "'";
                _cmd.ExecuteNonQuery();
                _cmd.CommandText = "DELETE FROM [dbo].[Products] WHERE Product_ID='" + id + "'";
                _cmd.ExecuteNonQuery();
                _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT Product_ID, Barcode, Product_type, Number_of_products, Price, Manufacturer_country FROM Products");
            }
        }

        private void updButton_Click(object sender, EventArgs e)
        {
            _sqlCmdBuilder = new SqlCommandBuilder(_adapter);
            int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            _cmd = new SqlCommand();
            _cmd.Connection = _connection;
            String barcode = bcBox.Text, type= typeBox.Text, quantity = quBox.Text, country = countryBox.Text, price = priceBox.Text;
            _cmd.CommandText = "UPDATE [dbo].[Products] SET Barcode=N'" + barcode + "',Product_type=N'" + type + "',Price=N'" + price + "',Manufacturer_country=N'"+ country +"',Number_of_products=N'" + quantity + "'  WHERE Product_ID='" + id + "'";
            _cmd.ExecuteNonQuery();
            updButton.Visible = false;
            addButton.Visible = true;
            editButton.Visible = true;
            bcBox.Clear();
            typeBox.Clear();
            quBox.Clear();
            countryBox.Clear();
            priceBox.Clear();
            _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT Product_ID, Barcode, Product_type, Number_of_products, Price, Manufacturer_country FROM Products");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            bcBox.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            typeBox.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            quBox.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            countryBox.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            priceBox.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            editButton.Visible = false;
            addButton.Visible = false;
            updButton.Visible = true;
        }
        private void sortButton_Click_1(object sender, EventArgs e)
        {
            {
                if (sortBox.Text.Length != 0)
                {
                    if (ascSort.Checked)
                    {
                        dataGridView1.Sort(dataGridView1.Columns[sortBox.Text], ListSortDirection.Ascending);
                    }
                    else
                    {
                        dataGridView1.Sort(dataGridView1.Columns[sortBox.Text], ListSortDirection.Descending);
                    }
                }
            }
        }

        private void srchButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Fill textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT * FROM Products WHERE ((Manufacturer_country LIKE '" + textBox1.Text + "%') and (Product_type LIKE '" + textBox2.Text + "%'))");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT * FROM Products");
        }
    }
}
