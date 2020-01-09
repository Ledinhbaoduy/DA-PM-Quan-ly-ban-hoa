
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class Frmdangnhap : Form
    {
        public Frmdangnhap()
        {
            InitializeComponent();
        }
        DataProvider dt = new DataProvider();
       
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoithoai;
            hoithoai = MessageBox.Show("Bạn có chắc muốn thoát!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(hoithoai == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btndangnhap_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM NHANVIEN WHERE TAIKHOAN ='" + txtTendangnhap.Text + "' and matkhau ='" + txtMatkhau.Text + "'";
            try
            {
                if (dt.KiemTraDangNhap(sql) == true)
                {
                    Form f = new Frmchinh(txtTendangnhap.Text);
                    f.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, tài khoản hoặc mật khẩu không hợp lệ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập thất bại, Vui lòng kiểm tra lại");
            }
        }

    }
}
