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
    public partial class Frmkhachhang : Form
    {
        public Frmkhachhang()
        {
            InitializeComponent();
        }
        DataProvider dt = new DataProvider();
        DataSet ds = new DataSet();
        Boolean them, xoa, sua = false;
        private void BtnXemchitiet_Click(object sender, EventArgs e)
        {
            ds = dt.laydulieu("select * from KHACHHANG");
            dgvKhachhang.DataSource = ds.Tables[0];
        }
        public void UnlockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            txtMakhach.Enabled = true;
            txtHoten.Enabled = true;
            txtDiachi.Enabled = true;
            txtEmail.Enabled = true;
            txtSodienthoai.Enabled = true;
            cboGioitinh.Enabled = true;
            btnThem.Focus();
        }
        public void lockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;

            txtMakhach.Enabled = false;
            txtHoten.Enabled = false;
            txtDiachi.Enabled = false;
            txtEmail.Enabled = false;
            txtSodienthoai.Enabled = false;
            cboGioitinh.Enabled = false;

            txtMakhach.Focus();
        }
        private string chuan_xau(string xau)
        {
            string kq = "";
            xau = xau.Trim().ToLower();//Ph?i d?i sang Unicode thi su dung .ToLower() không b? l?i font
            for (int i = 0; i < xau.Length; i++)
            {
                if (i == 0)
                    kq += xau[i].ToString().ToUpper();
                else
                    kq += xau[i];
                if (xau[i] == ' ')
                {
                    while (xau[i] == ' ')
                    {
                        i++;
                    }
                    kq += xau[i].ToString().ToUpper();
                }
            }
            return kq.ToString();

        }
        private void Frmkhachhang_Load(object sender, EventArgs e)
        {

            lockControl();

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txtMakhach.Enabled = false;//tránh trường hợp mã khách hàng nhập sai
            cboGioitinh.Text = "Nam";
            sua = true;
            

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            lockControl();
            btnLuu.Enabled = true;
            txtMakhach.Enabled = false;
            cboGioitinh.Text = "Nam";
            btnXemchitiet.PerformClick();
            xoa = true;
       
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            cboGioitinh.Text = "Nam";
            them = true;
            txtMakhach.Text = dt.AutoCapMa("KHACHHANG", "KH");
            txtMakhach.Enabled = false;
            txtHoten.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtSodienthoai.Text = "";
            cboGioitinh.Text = "";
        }


        private void DgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int soDong = e.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKhachhang.Rows[soDong];
            txtMakhach.Text = row.Cells["MAKH"].Value.ToString();
            txtHoten.Text = row.Cells["TENKH"].Value.ToString();
            cboGioitinh.Text = row.Cells["PHAI"].Value.ToString();
            txtDiachi.Text = row.Cells["DIACHI"].Value.ToString();
            txtSodienthoai.Text = row.Cells["DIENTHOAI"].Value.ToString();
            txtEmail.Text = row.Cells["EMAIL"].Value.ToString();

        }

        private void TxtSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLuu_Click_1(object sender, EventArgs e)
        {
            if (txtMakhach.Text == "" || txtHoten.Text == "" || txtDiachi.Text == "" || txtEmail.Text == "" || txtSodienthoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại đầy đủ thông tin !");
            }
            else if (them)
            {
                if (cboGioitinh.SelectedIndex == 0)
                {
                    cboGioitinh.Text = "Nam";
                }
                else cboGioitinh.Text = "Nữ";
                string sql = "INSERT INTO KHACHHANG(MAKH,TENKH,PHAI,DIENTHOAI,EMAIL,DIACHI)VALUES (";
                sql += "'" + txtMakhach.Text + "','" + chuan_xau(txtHoten.Text) + "','" + cboGioitinh.Text + "','" + txtSodienthoai.Text + "','" + txtEmail.Text + "','" + txtDiachi.Text + "')";
                if (dt.CapNhatDuLieu(sql) != 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công !!");
                    btnXemchitiet.PerformClick();
                    lockControl();
                    them = false;
                }
            }
            else if (sua)
            {
                DialogResult hoithoai = MessageBox.Show("Bạn có chắc sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoithoai == DialogResult.Yes)
                {
                    if (cboGioitinh.SelectedIndex == 0)
                        cboGioitinh.Text = "Nam";
                    else cboGioitinh.Text = "Nữ";
                    string sql = "UPDATE KHACHHANG " +
                        "SET MAKH='" + txtMakhach.Text + "',TENKH='" + chuan_xau(txtHoten.Text) + "',PHAI='" + cboGioitinh.Text + "',DIENTHOAI='" + txtSodienthoai.Text + "',EMAIL='" + txtEmail.Text + "',DIACHI='" + txtDiachi.Text + "'" +
                        "WHERE MAKH='" + txtMakhach.Text + "'";

                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("cập nhật thành công!!");
                        btnXemchitiet.PerformClick();
                        lockControl();
                        sua = false;
                    }
                }

            }
            else if (xoa)
            {
                DialogResult hoithoai = MessageBox.Show("Bạn có chắc xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoithoai == DialogResult.Yes)
                {
                    string sql = "DELETE FROM KHACHHANG WHERE MAKH='" + txtMakhach.Text + "'";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("xóa thành công !!");
                        btnXemchitiet.PerformClick();
                        lockControl();
                        xoa = false;
                    }
                }
            }
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void BtnLuu_Click(object sender, EventArgs e)
        //{
           
        //}
    }
}
