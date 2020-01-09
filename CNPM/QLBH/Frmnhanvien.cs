using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class Frmnhanvien : Form
    {
        public Frmnhanvien()
        {
            InitializeComponent();
        }
        DataProvider dt = new DataProvider();
        void hienthidulieu()
        {
            //lấy dữ liệu từ bảng nhân viên 
            DataSet ds = new DataSet();
            ds = dt.laydulieu("select MANV, TENNV, PHAI, DTHOAI,LOAI_NV from NHANVIEN ");
            dgvdanhsach.DataSource = ds.Tables[0];

        }

        private void Frmthongtinnhanvien_Load(object sender, EventArgs e)
        {
            hienthidulieu();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = dt.laydanhsach("select * from NHANVIEN where TENNV like '%" + txtTimkiem.Text + "%'");
                dgvdanhsach.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("không tìm thấy dữ liệu");
            }
        }
    }
}
