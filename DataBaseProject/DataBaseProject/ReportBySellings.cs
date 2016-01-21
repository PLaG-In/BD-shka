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
    public partial class ReportBySellings : Form
    {
        public ReportBySellings()
        {
            InitializeComponent();
        }

        private void ReportBySellings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "SellingsDataSet.Sellings". При необходимости она может быть перемещена или удалена.
            this.SellingsTableAdapter.Fill(this.SellingsDataSet.Sellings);

            this.reportViewer1.RefreshReport();
        }
    }
}
