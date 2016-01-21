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
    public partial class ReportBySellers : Form
    {
        public ReportBySellers()
        {
            InitializeComponent();
        }

        private void ReportBySellers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "SellingsDataSet.Sellers". При необходимости она может быть перемещена или удалена.
            this.SellersTableAdapter.Fill(this.SellingsDataSet.Sellers);

            this.reportViewer1.RefreshReport();
        }
    }
}
