using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        DataProvider dt = new DataProvider();
        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCHBHDataSet.HOADON' table. You can move, or remove it, as needed.
            this.HOADONTableAdapter.Fill(this.QLCHBHDataSet.HOADON);

            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void BtnNgay_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sql = "select * from HOADON WHERE DAY(NGAYLAP) ='" + dtpNgay.Value.Day + "' group by TONGTIEN desc ";
        }
    }
}
