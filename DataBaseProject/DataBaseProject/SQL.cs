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
    class SQL
    {
        public static String _conStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BD\Project 2-3\DataBaseProject\DataBaseProject\Sellings.mdf;Integrated Security=True";


        public void FillDataGridViewByQuery(DataGridView dgv, String query)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = _conStr;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            dgv.DataSource = dataTable;
        }
    }
}
