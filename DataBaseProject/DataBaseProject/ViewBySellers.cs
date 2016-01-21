using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class ViewBySellers : Form
    {
    private static SQL _sqlWorker = new SQL();

        public ViewBySellers()
        {
            InitializeComponent();
        }

        private int GetCurrentSQLRow()
        {
            DataGridViewRow currentRow = dataSellers.CurrentRow;
            if (currentRow == null)
            {
                return -1;
            }
            DataGridViewCellCollection cellsCollection = currentRow.Cells;
            DataGridViewCell idCell = cellsCollection[0];
            return int.Parse(idCell.Value.ToString());
        }

        private void dgvSellers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id;
            if ((id = GetCurrentSQLRow()) == -1)
            {
                return;
            }
            try
            {
                _sqlWorker.FillDataGridViewByQuery(dataShow, "SELECT Sellers.Seller_Name, Sellers.Seller_Surname, Sellers.Seller_Patronymic, Sellings.Number_of_sell, Sellings.Data FROM Sellings INNER JOIN Sellers ON Sellings.Seller_ID = Sellers.Seller_ID WHERE (Sellings.Seller_ID = " + id.ToString() + ")");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ViewBySellers_Load(object sender, EventArgs e)
        {
            _sqlWorker.FillDataGridViewByQuery(dataSellers, "SELECT * FROM Sellers");
        }
    }
}
