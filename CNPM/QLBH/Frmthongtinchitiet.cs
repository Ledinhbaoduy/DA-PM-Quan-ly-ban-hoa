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
    public partial class Frmthongtinchitiet : Form
    {
        public Frmthongtinchitiet()
        {
            InitializeComponent();
        }
        DataProvider dt = new DataProvider();
        Boolean capnhat = true;
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frmthongtinchitiet_Load(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            //ds = dt.laydulieu("select MANV from NHANVIEN");
            //cboMaNV.DataSource = ds.Tables[0];
            //cboMaNV.DisplayMember = "MANV";
            //cboMaNV.ValueMember = "";
        }

        private void BtnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMatkhaucu.Text == "" || txtTaikhoan.Text == "" || txtMatkhaumoi1.Text == "" || txtMatkhaumoi2.Text == "")
            {
                MessageBox.Show("Nhập đẩy đủ thông tin tài khoản!!!","Thông báo" ,MessageBoxButtons.OK);
            }
            if(capnhat)
            {
                string sql = "UPDATE NHANVIEN SET MATKHAU = '" + txtMatkhaumoi1.Text + "'";
                if (dt.CapNhatDuLieu(sql) != 0)
                {
                    MessageBox.Show("Đã sửa thành công!", "Thông báo");

                }
               
            }

           
                
           
        }
            
       
    }
}
