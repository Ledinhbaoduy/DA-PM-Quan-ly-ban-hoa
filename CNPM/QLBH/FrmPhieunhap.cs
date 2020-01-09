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
    public partial class FrmPhieunhap : Form
    {
        public FrmPhieunhap()
        {
            InitializeComponent();
        }
        DataProvider dt = new DataProvider();
        DataSet ds;
        Boolean them, xoa, sua = false;
        //KHÓA MỞ CÁC NÚT FORM PHIẾU NHẬP
        public void lockControl()
        {
            btnthem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa_Nhap.Enabled= true;

            txtMaPN.Enabled = false;
            txtNV_Lap_N.Enabled = false;
            txtSluong.Enabled = false;
            dtpngaylap.Enabled = false;
            txtMasp.Enabled = false;
            txtTongtien.Enabled = false;

            txtMaPN.Focus();
        }
        public void UnlockControl()
        {
            btnthem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa_Nhap.Enabled = true;

            txtMaPN.Enabled = true;
            txtNV_Lap_N.Enabled = true;
            txtSluong.Enabled = true;
            dtpngaylap.Enabled = true;
            txtMasp.Enabled = true;
            txtTongtien.Enabled = true;

            btnthem.Focus();
        }

        private void FrmPhieunhap_Load_1(object sender, EventArgs e)
        {
            lockControl();
        }

        private void Btnthem_Click_1(object sender, EventArgs e)
        {
            UnlockControl();
            them = true;
            txtMaPN.Enabled = false;
            txtMaPN.Text = dt.AutoCapMa("PHIEUNHAPHANG", "PN");
            txtNV_Lap_N.Text = "";
            txtSluong.Text = "";
            dtpngaylap.Text = "";
            txtMasp.Text = "";
            txtTongtien.Text = "";
        }

        private void BtnXoa_Nhap_Click_2(object sender, EventArgs e)
        {
            UnlockControl();
            txtMaPN.Enabled = false;
            btnLuu.Enabled = true;
            xoa = true;
        }

        private void BtnSua_Click_1(object sender, EventArgs e)
        {
            UnlockControl();
            btnLuu.Enabled = true;
            txtMaPN.Enabled = false;
            sua = true;
        }

        private void BtnLuu_Click_1(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    //CHỨC NĂNG THÊM 
                    string sql = "INSERT INTO PHIEUNHAPHANG(MAPHIEU,NV_LAP,NGAYLAP,SOLUONG,TONGTIEN,MASP)VALUES (";
                    sql += "'" + txtMaPN.Text + "','" + txtNV_Lap_N.Text + "','" + dtpngaylap.Value + "','" + txtSluong.Text + "','" + txtTongtien.Text + "','" + txtMasp.Text + "')";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công !!");
                        btnXEm.PerformClick();
                        lockControl();
                        them = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("dữ liệu đã tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else if (sua)
            {
                //CHỨC NĂNG SỬA
                string sql = "UPDATE PHIEUNHAPHANG " +
               "SET MAPHIEU='" + txtMaPN.Text + "',NV_LAP='" + txtNV_Lap_N.Text + "',NGAYLAP='" + dtpngaylap.Value + "',SOLUONG='" + txtSluong.Text + "',TONGTIEN='" + txtTongtien.Text + "',MASP='" + txtMasp.Text + "'" +
               "WHERE MAPHIEU='" + txtMaPN.Text + "'";

                if (dt.CapNhatDuLieu(sql) != 0)
                {
                    MessageBox.Show("cập nhật thành công!!");
                    btnXEm.PerformClick();
                    lockControl();
                    sua = false;
                }
            }
            else if (xoa)
            {
                //CHỨC NĂNG XÓA 
                string sql = "DELETE FROM PHIEUNHAPHANG WHERE MAPHIEU='" + txtMaPN.Text + "'";
                if (dt.CapNhatDuLieu(sql) != 0)
                {
                    MessageBox.Show("xóa thành công !!");
                    btnXEm.PerformClick();
                    lockControl();
                    xoa = false;
                }
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnXEm_Click_1(object sender, EventArgs e)
        {
            ds = dt.laydulieu("SELECT*FROM PHIEUNHAPHANG");
            dgvdanhsach.DataSource = ds.Tables[0];
        }

        private void Dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int soDong = e.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvdanhsach.Rows[soDong];
            txtMaPN.Text = row.Cells["MAPHIEU"].Value.ToString();
            txtNV_Lap_N.Text = row.Cells["NV_LAP"].Value.ToString();
            txtSluong.Text = row.Cells["SOLUONG"].Value.ToString();
            dtpngaylap.Value = DateTime.Parse(row.Cells["NGAYLAP"].Value.ToString());
            txtMasp.Text = row.Cells["MASP"].Value.ToString();
            txtTongtien.Text = row.Cells["TONGTIEN"].Value.ToString();
        }

      }
}
