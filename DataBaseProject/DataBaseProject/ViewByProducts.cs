using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class ViewByProducts : Form
    {
        private SQL _sqlWorker = new SQL();
        public ViewByProducts()
        {
            InitializeComponent();
            lSumPrice.Text = "";
        }

        private String GetQueryResultAsString(String query)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = SQL._conStr;
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.CommandType = CommandType.Text;
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable.Rows[0].ItemArray[0].ToString();
        }

        private void ViewByProducts_Load(object sender, EventArgs e)
        {
            try
            {
                _sqlWorker.FillDataGridViewByQuery(dgvProducts, "SELECT * FROM Products");
                lAverage.Text = "Average products quantity - " + GetQueryResultAsString("SELECT AVG(Number_of_products) FROM Products");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = GetCurrentRowForID();
            if (id == -1)
            {
                return;
            }
            try
            {
                _sqlWorker.FillDataGridViewByQuery(dgvView, "SELECT Products.Product_type, Products.Price, Sellings.Number_of_sell, Sellings.Data FROM Sellings INNER JOIN Products ON Sellings.Product_ID = Products.Product_ID WHERE (Sellings.Product_ID = " + id.ToString() + ")");
                lSumPrice.Text = "Earned money - " + GetQueryResultAsString("SELECT (AVG(Price) * SUM(Sellings.Number_of_sell)) FROM Sellings, Products WHERE ((Products.Product_ID = Sellings.Product_ID) and (Sellings.Product_ID = " + id.ToString() + "))");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private int GetCurrentRowForID()
        {
            DataGridViewRow curRow = dgvProducts.CurrentRow;
            if (curRow == null)
            {
                return -1;
            }
            DataGridViewCellCollection cellsColl = curRow.Cells;
            DataGridViewCell idCell = cellsColl[0];
            return int.Parse(idCell.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
        if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Fill textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _sqlWorker.FillDataGridViewByQuery(dgvProducts, "SELECT * FROM Products WHERE ((Manufacturer_country LIKE '" + textBox1.Text + "%') and (Product_type LIKE '" + textBox2.Text + "%'))");
            lAverage.Text = "Average products quantity - " + GetQueryResultAsString("SELECT AVG(Number_of_products) FROM Products WHERE Product_ID IN (SELECT Product_ID FROM Products WHERE ((Manufacturer_country LIKE '" + textBox1.Text + "%') and (Product_type LIKE '" + textBox2.Text + "%')))");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            _sqlWorker.FillDataGridViewByQuery(dgvProducts, "SELECT * FROM Products");
            lAverage.Text = "Average products quantity - " + GetQueryResultAsString("SELECT AVG(Number_of_products) FROM Products");
        }
    }
}
