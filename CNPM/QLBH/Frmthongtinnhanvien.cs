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
    public partial class Frmthongtinnhanvien : Form
    {
        public Frmthongtinnhanvien()
        {
            InitializeComponent();
        }
        DataProvider dt = new DataProvider();
        DataSet ds = new DataSet();
        Boolean them, sua, xoa = false;
        void hienthinhanvien()
        {
            // hiển thi thông tin nhân viên
            DataSet ds = new DataSet();
            ds = dt.laydulieu("select * from NHANVIEN");
            dgvdanhsachNV.DataSource = ds.Tables[0];
        }
        //hàm chuẩn hóa tên nhân viên các chữ cái đầu viết hoa
        private string chuan_xau(string xau)
        {
            string kq = "";
            xau = xau.Trim().ToLower();//Phải đổi sang Unicode thì sử dụng .ToLower() không bị lỗi font
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
        public void UnlockControl()
        {
            btnThem_nv.Enabled = true;
            btnSua_nv.Enabled = true;
            btnLuu_nv.Enabled = true;
            btnXoa_nv.Enabled = true;

            txtMa_nv.Enabled = true;
            txtHoten.Enabled = true;
            cboGioitinh.Enabled = true;
            txtLuong.Enabled = true;
            cboLoai_nv.Enabled = true;
            txtDiachi.Enabled = true;
            txtMatkhau.Enabled = true;
            txtSDT.Enabled = true;
            txtTK.Enabled = true;

            btnThem_nv.Focus();
        }
        //khóa  nút và các textbox combobox
        public void lockControl()
        {
            btnThem_nv.Enabled = true;
            btnSua_nv.Enabled = true;
            btnLuu_nv.Enabled = false;
            btnXoa_nv.Enabled = true;

            txtMa_nv.Enabled = false;
            txtHoten.Enabled = false;
            cboGioitinh.Enabled = false;
            txtLuong.Enabled = false;
            cboLoai_nv.Enabled = false;
            txtDiachi.Enabled = false;
            txtMatkhau.Enabled = false;
            txtSDT.Enabled = false;
            txtTK.Enabled = false;


            txtMa_nv.Focus();
        }

        private void BtnThem_nv_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txtMa_nv.Text = dt.AutoCapMa("NHANVIEN", "00");
            them = true;
            txtMa_nv.Enabled = false;
            txtHoten.Text = "";
            cboGioitinh.Text = "";
            txtLuong.Text = "";
            cboLoai_nv.Text = "";
            txtDiachi.Text = "";
            txtMatkhau.Text = "";
            txtSDT.Text = "";
            txtTK.Text = "";
        }

        private void BtnXoa_nv_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txtMa_nv.Enabled = false;
            xoa = true;
            DialogResult hoithoai = MessageBox.Show("bạn có chắc xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(hoithoai == DialogResult.Yes)
            {
                if (xoa)
                {
                    string sql = "delete from NHANVIEN Where MANV= '";
                    sql += txtMa_nv.Text + "'";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Xoa thanh cong");
                        hienthinhanvien();
                    }
                }
            }
              
        }

        private void BtnSua_nv_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txtMa_nv.Enabled = false;
            sua = true;
            DialogResult hoithoai = MessageBox.Show("bạn có chắc sửa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoithoai == DialogResult.Yes)
            {
                if (sua)
                {
                    string sql = "UPDATE NHANVIEN SET  MANV= '" + txtMa_nv.Text + "', TENNV='" + chuan_xau(txtHoten.Text) + "', PHAI='" + cboGioitinh.Text + "', " +
                        "DTHOAI='" + txtSDT.Text + "', LOAI_NV='" + cboLoai_nv.Text + "', LUONG='" + txtLuong.Text + "',TAIKHOAN='" + txtTK.Text + "',MATKHAU = '" + txtMatkhau.Text + "' where  MANV= '" + txtMa_nv.Text + "'";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Đã sửa thành công!", "Thông báo");
                        hienthinhanvien();
                    }
                    else
                    {
                        MessageBox.Show("thất bại ");
                    }
                }
            }
            
        }

        private void BtnLuu_nv_Click(object sender, EventArgs e)
        {
            if(txtHoten.Text == "" || txtDiachi.Text =="" || txtLuong.Text == ""||txtMatkhau.Text == ""||txtSDT.Text == ""||txtTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đây đủ thông tin", "thông báo");
            }
            else if (them)
            {
                try
                {
                    string sql = "insert into NHANVIEN(MANV,TENNV,PHAI,DTHOAI,DIACHI,LOAI_NV,LUONG,TAIKHOAN,MATKHAU)";
                    sql += "values('" + txtMa_nv.Text + "','" + chuan_xau(txtHoten.Text) + "','" + cboGioitinh.Text + "','" + txtSDT.Text + "'," +
                        "'" + txtDiachi.Text + "','" + cboLoai_nv.Text + "','"+txtLuong.Text+"','" + txtTK.Text + "','"+txtMatkhau.Text+"')";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Cap nhat thanh cong");
                        hienthinhanvien();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
        }

        private void DgvdanhsachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int soDong = e.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvdanhsachNV.Rows[soDong];
            txtMa_nv.Text = row.Cells["MANV"].Value.ToString();
            txtHoten.Text = row.Cells["TENNV"].Value.ToString();
            cboGioitinh.Text = row.Cells["PHAI"].Value.ToString();
            txtDiachi.Text = row.Cells["DIACHI"].Value.ToString();
            cboLoai_nv.Text = row.Cells["LOAI_NV"].Value.ToString();
            txtLuong.Text = row.Cells["LUONG"].Value.ToString();
            txtSDT.Text = row.Cells["DTHOAI"].Value.ToString();
            txtMatkhau.Text = row.Cells["MATKHAU"].Value.ToString();
            txtTK.Text = row.Cells["TAIKHOAN"].Value.ToString();
           

        }

        private void BtnTimkiem_nv_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = dt.laydanhsach("select * from NHANVIEN where TENNV like '%" + txtTimkiem_nv.Text + "%' OR MANV LIKE '%" + txtTimkiem_nv.Text + "%'");
                dgvdanhsachNV.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("không tìm thấy dữ liệu");
            }
        }

        private void TxtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmthongtinnhanvien_Load(object sender, EventArgs e)
        {
            lockControl();
        }

        private void BtnXem_ds_Click(object sender, EventArgs e)
        {
            hienthinhanvien();
        }
    }

}
