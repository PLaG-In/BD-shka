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
    public partial class EditSellers : Form
    {
        private String _tableName = "Sellers";
        private SqlConnection _connection;
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _sqlCmdBuilder;
        private DataSet _dataSet;
        private SqlCommand _cmd;
        private SQL _sqlWorker = new SQL();
        public EditSellers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            nameBox.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            surnameBox.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            patronymicBox.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            salaryBox.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            passportBox.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            editButton.Visible = false;
            addButton.Visible = false;
            refButton.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _sqlCmdBuilder = new SqlCommandBuilder(_adapter);
            int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            _cmd = new SqlCommand();
            _cmd.Connection = _connection;
            String name = nameBox.Text, surname = surnameBox.Text, patronymic = patronymicBox.Text, salary = salaryBox.Text, passport = passportBox.Text;
            _cmd.CommandText = "UPDATE [dbo].[Sellers] SET Seller_surname=N'" + surname + "',Seller_name=N'" + name + "',Passport=N'" + passport + "',Salary=N'"+ salary +"',Seller_patronymic=N'" + patronymic + "'  WHERE Seller_ID='" + id + "'";
            _cmd.ExecuteNonQuery();
            refButton.Visible = false;
            addButton.Visible = true;
            editButton.Visible = true;
            nameBox.Clear();
            surnameBox.Clear();
            patronymicBox.Clear();
            salaryBox.Clear();
            passportBox.Clear();
            _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT Seller_ID, Seller_surname, Seller_name, Seller_patronymic, Salary, Passport FROM Sellers");
        }

        private void EditSellers_Load(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((this.nameBox.Text.Length == 0) || (this.surnameBox.Text.Length == 0)
              || (this.patronymicBox.Text.Length == 0) || (this.salaryBox.Text.Length == 0)
              || (this.passportBox.Text.Length == 0))
            {
                MessageBox.Show("Wrong inputs!",
                    "Error");
            }
            else
            {
                String name = nameBox.Text, surname = surnameBox.Text, patronymic = patronymicBox.Text, salary = salaryBox.Text, passport = passportBox.Text;
                _cmd = new SqlCommand();
                int id = dataGridView1.RowCount;
                String id_n = _dataSet.Tables[0].Rows[id - 2]["Seller_ID"].ToString();
                id = Convert.ToInt32(id_n) + 1;
                _cmd.Connection = _connection;
                _cmd.CommandText = "INSERT INTO [dbo].[Sellers] (Seller_ID, Seller_name, Seller_surname, Seller_patronymic, Salary, Passport) VALUES(N'" + id.ToString() + "',N'"
                    + name + "',N'" + surname + "',N'" + patronymic + "',N'" + salary + "',N'" + passport + "')";
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                nameBox.Clear();
                surnameBox.Clear();
                patronymicBox.Clear();
                salaryBox.Clear();
                passportBox.Clear();
                _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT Seller_ID, Seller_name, Seller_surname, Seller_patronymic, Salary, Passport FROM Sellers");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conButton_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
                _cmd.CommandText = "DELETE FROM [dbo].[Sellings] WHERE Seller_ID='" + id + "'";
                _cmd.ExecuteNonQuery();
                _cmd.CommandText = "DELETE FROM [dbo].[Sellers] WHERE Seller_ID='" + id + "'";
                _cmd.ExecuteNonQuery();
                _sqlWorker.FillDataGridViewByQuery(dataGridView1, "SELECT Seller_ID, Seller_name, Seller_surname, Seller_patronymic, Salary, Passport FROM Sellers");
            }
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
