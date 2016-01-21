using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataBaseProject
{
    public partial class EditSellings : Form
    {
        private String _tableName = "Sellings";
        private SqlConnection _connection;
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _sqlCmdBuilder;
        private DataSet _dataSet;
        private SqlCommand _cmd;
        private SQL _sqlWorker = new SQL();

        public EditSellings()
        {
            InitializeComponent();
        }

        private void EditSellings_Load(object sender, EventArgs e)
        {
            try
            {
                this.sellersTableAdapter1.Fill(this.sellingsDataSet.Sellers);
                this.productsTableAdapter1.Fill(this.sellingsDataSet.Products);
                _connection = new SqlConnection();
                _connection.ConnectionString = SQL._conStr;
                _connection.Open();
                _adapter = new SqlDataAdapter("SELECT Sellings.Sellings_ID, Products.Product_type, Sellers.Seller_surname, Products.Price, Sellings.Number_of_sell, Sellings.Data FROM " + _tableName + ", Products, Sellers WHERE (Products.Product_ID = Sellings.Product_ID) and (Sellers.Seller_ID = Sellings.Seller_ID)", _connection);
                _dataSet = new DataSet();
                _adapter.Fill(_dataSet, _tableName);
                productBox.DataSource = _dataSet.Tables[0];
                productBox.DisplayMember = _dataSet.Tables[0].Columns[1].ToString();
                sellerBox.DataSource = _dataSet.Tables[0];
                sellerBox.DisplayMember = _dataSet.Tables[0].Columns[2].ToString();
                dataGridView1.DataSource = _dataSet.Tables[0];
                this.dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((this.productBox.Text.Length == 0) || (this.sellerBox.Text.Length == 0)
              || (this.dtpSell.Text.Length == 0) || (this.quBox.Text.Length == 0))
            {
                MessageBox.Show("Wrong inputs!",
                    "Error");
            }
            else
            {
                String quantity = quBox.Text;
                String date = dtpSell.Value.ToString("dd.MM.yyyy");
                object seller = sellerBox.SelectedValue, product = productBox.SelectedValue;
                _cmd = new SqlCommand();
                int id = dataGridView1.RowCount;
                String id_n = _dataSet.Tables[0].Rows[id - 2]["Sellings_ID"].ToString();
                id = Convert.ToInt32(id_n) + 1;
                _cmd.Connection = _connection;
                _cmd.CommandText = "INSERT INTO [dbo].[Sellings] (Sellings_ID, Seller_ID, Product_ID, Number_of_sell, Data) VALUES(N'" + id.ToString() + "',N'"
                    + seller.ToString() + "',N'" + product.ToString() + "',N'" + quantity + "',N'" + date + "')";
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                quBox.Clear();
                _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT Products.Product_type, Sellers.Seller_surname, Products.Price, Sellings.Number_of_sell, Sellings.Data FROM " + _tableName + ", Products, Sellers WHERE (Products.Product_ID = Sellings.Product_ID) and (Sellers.Seller_ID = Sellings.Seller_ID)");
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
                int id = dataGridView1.CurrentRow.Index;
                SqlCommand _cmd = new SqlCommand();
                _cmd.Connection = _connection;
                _cmd.CommandText = "DELETE FROM [dbo].[Sellings] WHERE Sellings_ID='" + id.ToString() + "'";
                _cmd.ExecuteNonQuery();
                _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT Products.Product_type, Sellers.Seller_surname, Products.Price, Sellings.Number_of_sell, Sellings.Data FROM " + _tableName + ", Products, Sellers WHERE (Products.Product_ID = Sellings.Product_ID) and (Sellers.Seller_ID = Sellings.Seller_ID)");
            }
        }

        private void accButton_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            productBox.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            sellerBox.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            dtpSell.Value = DateTime.ParseExact(dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString(), "dd.MM.yyyy", null);
            quBox.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            editButton.Visible = false;
            addButton.Visible = false;
            updButton.Visible = true;
        }

        private void updButton_Click_1(object sender, EventArgs e)
        {
            _sqlCmdBuilder = new SqlCommandBuilder(_adapter);
            _cmd = new SqlCommand();
            _cmd.Connection = _connection;
            int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            String quantity = quBox.Text;
            String date = dtpSell.Value.ToString("dd.MM.yyyy");
            object seller = sellerBox.SelectedValue, product = productBox.SelectedValue;
            _cmd.CommandText = "UPDATE [dbo].[Sellings] SET Seller_ID=N'" + seller.ToString() + "',Product_ID=N'" + product.ToString() + "',Number_of_sell=N'" + quantity + "',Data=N'" + date + "'  WHERE Sellings_ID='" + id + "'";
            _cmd.ExecuteNonQuery();
            updButton.Visible = false;
            addButton.Visible = true;
            editButton.Visible = true;
            quBox.Clear();
            _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT Products.Product_type, Sellers.Seller_surname, Products.Price, Sellings.Number_of_sell, Sellings.Data FROM " + _tableName + ", Products, Sellers WHERE (Products.Product_ID = Sellings.Product_ID) and (Sellers.Seller_ID = Sellings.Seller_ID)");
        }

        private void sortButton_Click(object sender, EventArgs e)
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
    }
}
