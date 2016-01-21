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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "SellingsDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.ProductsTableAdapter.Fill(this.SellingsDataSet.Products);

            this.reportViewer1.RefreshReport();
        }
    }
}
