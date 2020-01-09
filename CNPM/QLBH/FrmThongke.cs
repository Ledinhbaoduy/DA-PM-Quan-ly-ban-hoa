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
    public partial class FrmThongke : Form
    {
        public FrmThongke()
        {
            InitializeComponent();
        }
        DataProvider dt = new DataProvider();
        private void FrmThongke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCHBHDataSet.HOADON' table. You can move, or remove it, as needed.
            
        }

        private void BtnXemchitiet_Click(object sender, EventArgs e)
        {
            this.HOADONTableAdapter.Fill(this.QLCHBHDataSet.HOADON);
            this.rpview.RefreshReport();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
        }


        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
