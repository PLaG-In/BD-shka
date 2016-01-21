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
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMain edit = new EditMain(true);
            edit.Show();
        }

        private void sellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSellers edit = new EditSellers();
            edit.Show();
        }

        private void sellingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSellings edit = new EditSellings();
            edit.Show();
        }

        private void byProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewByProducts viewByProducts = new ViewByProducts();
            viewByProducts.Show();
        }

        private void bySellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBySellers viewBySellers = new ViewBySellers();
            viewBySellers.Show();
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reportForm = new Reports();
            reportForm.Show();
        }

        private void allSellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportBySellers reportForm = new ReportBySellers();
            reportForm.Show();
        }

        private void allSellingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportBySellings reportForm = new ReportBySellings();
            reportForm.Show();
        }

        private void showingByProductNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewReport reportForm = new NewReport();
            reportForm.Show();
        }
    }
}
