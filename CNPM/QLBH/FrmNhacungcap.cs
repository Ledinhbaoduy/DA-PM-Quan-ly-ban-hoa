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
    public partial class FrmNhacungcap : Form
    {
        public FrmNhacungcap()
        {
            InitializeComponent();
        }
        DataProvider dt = new DataProvider();
        Boolean them, sua, xoa = false;
        DataSet ds = new DataSet();
        void hienthidulieu()
        {
            //lấy dữ liệu từ bảng nhà cung cấp 
            ds = dt.laydulieu("select * from NHACUNGCAP ");
            dgvdanhsach.DataSource = ds.Tables[0];
        }
        void lockControll()
        {
            btnthem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;

            txtMa_NCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiachi.Enabled = false;
            txtSDT.Enabled = false;

            txtMa_NCC.Focus();
        }

      

        void UnlockControll()
        {
            btnthem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;

            txtMa_NCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiachi.Enabled = true;
            txtSDT.Enabled = true;
            

            btnthem.Focus();
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
        private void Btnthem_Click(object sender, EventArgs e)
        {
            UnlockControll();
            txtMa_NCC.Text = dt.AutoCapMa("NHACUNGCAP", "NCC");
            txtMa_NCC.Enabled = false;

            txtTenNCC.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";
            them = true;
        }



        private void BtnXoa_Click(object sender, EventArgs e)
        {
            UnlockControll();
            txtMa_NCC.Enabled = false;
            xoa = true;
            DialogResult hoithoai = MessageBox.Show("Bạn có chắc xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoithoai == DialogResult.Yes)
            {
                if (xoa)
                {
                    string sql = "delete from NHACUNGCAP where MA_NCC='" + txtMa_NCC.Text + "'";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Ðã xóa thành công!", "Thông báo");
                        hienthidulieu();
                    }
                    else
                    {
                        MessageBox.Show("xóa thất bại");
                    }

                }
            }
              
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            lockControll();
        }

        private void BtnXEm_Click(object sender, EventArgs e)
        {
            hienthidulieu();
        }

        private void Dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int soDong = e.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvdanhsach.Rows[soDong];
            txtMa_NCC.Text = row.Cells["MA_NCC"].Value.ToString();
            txtTenNCC.Text = row.Cells["TEN_NCC"].Value.ToString();
            txtDiachi.Text = row.Cells["DIACHI"].Value.ToString();
            txtSDT.Text = row.Cells["SDT"].Value.ToString();
        }

        private void Dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgvdanhsach_CellContentClick(sender, e);
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

        private void BtnSua_Click(object sender, EventArgs e)
        {
            UnlockControll();
            txtMa_NCC.Enabled = false;
            sua = true;
            DialogResult hoithoai = MessageBox.Show("Bạn có chắc sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoithoai == DialogResult.Yes)
            {
                if (sua)
                {
                    string sql = "UPDATE NHACUNGCAP SET  MA_NCC='" + txtMa_NCC.Text + "', TEN_NCC='" + chuan_xau(txtTenNCC.Text) + "', DIACHI='" + txtDiachi.Text + "', SDT='" + txtSDT.Text + "' where MA_NCC='" + txtMa_NCC.Text + "'";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Ðã sửa thành công!", "Thông báo");
                        hienthidulieu();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }

        }
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if(txtDiachi.Text == ""|| txtSDT.Text == "" || txtTenNCC.Text == "")
            {
                MessageBox.Show("Vui lòng đầy đủ thông tin", "Thông báo");
            }

             else if (them)
            {
                try
                {
                    string sql = "insert into NHACUNGCAP(MA_NCC,TEN_NCC,DIACHI,SDT)";
                    sql += "values('" + txtMa_NCC.Text + "','" + chuan_xau(txtTenNCC.Text) + "','" + txtDiachi.Text + "','" + txtSDT.Text + "')";

                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        hienthidulieu();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                }
            }


     
        }
    }
}
