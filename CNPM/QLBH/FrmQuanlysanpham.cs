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
    public partial class FrmQuanlysanpham : Form
    {
        public FrmQuanlysanpham()
        {
            InitializeComponent();
        }
       
        DataSet ds;
        DataProvider dt = new DataProvider();
        Boolean them, sua, xoa = false;
        void hienthidulieu()
        {
            //lấy dữ liệu từ bảng nhân viên 
            ds = new DataSet();
            ds = dt.laydulieu("select * from SANPHAM ");
            dgvdanhsach.DataSource = ds.Tables[0];

        }
        //mở khóa  nút và các textbox combobox
        public void UnlockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;

            txtMasp.Enabled = true;
            txtTensp.Enabled = true;
            cboKhuyenmai.Enabled = true;
            txtGiaban.Enabled = true;
            txtSL_kho.Enabled = true;
            cboLoai.Enabled = true;
            cboNCC.Enabled = true;

            btnThem.Focus();
        }
        //khóa  nút và các textbox combobox
        public void lockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;

            txtMasp.Enabled = false;
            txtTensp.Enabled = false;
            txtGiaban.Enabled = false;
            cboKhuyenmai.Enabled = false;
            txtSL_kho.Enabled = false;
            cboLoai.Enabled = false;
            cboNCC.Enabled = false;


            txtMasp.Focus();
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
        private void GpbDanhsachsanpham_Enter(object sender, EventArgs e)
        {

        }

        private void FrmQuanlysanpham_Load(object sender, EventArgs e)
        {
            

            lockControl();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            them = true;
            txtMasp.Text = dt.AutoCapMa("SANPHAM","SP");
            txtMasp.Enabled = false;
            txtTensp.Text = "";
            txtGiaban.Text = "";
            cboKhuyenmai.Text = "KM1";
            txtSL_kho.Text = "";
            cboLoai.Text = "L1";
            cboNCC.Text = "NCC1";
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {

            UnlockControl();
            DialogResult hoithoai;
            txtMasp.Enabled = false;
            sua = true;
            hoithoai = MessageBox.Show("bạn có chắc sửa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(hoithoai== DialogResult.Yes)
            {
                if (sua)
                {
                    string sql = "UPDATE SANPHAM SET  MASP= '" + txtMasp.Text + "', TENSP='" + chuan_xau(txtTensp.Text) + "', SL_TONKHO='" + txtSL_kho.Text + "', " +
                        "GIABAN='" + txtGiaban.Text + "', MALOAI='" + cboLoai.Text + "', KHUYENMAI='" + cboKhuyenmai.Text + "',NHACUNGCAP='" + cboNCC.Text + "' where  MASP= '" + txtMasp.Text + "'";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Đã sửa thành công!", "Thông báo");
                        hienthidulieu();
                    }
                }
            }
            

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            UnlockControl();
            xoa = true;
            txtMasp.Enabled = false;
            DialogResult hoithoai = MessageBox.Show("bạn có chắc xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoithoai == DialogResult.Yes)
            {
                if (xoa)
                {
                    string sql = "delete from SANPHAM Where MASP= '";
                    sql += txtMasp.Text + "'";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Xoa thanh cong");
                        hienthidulieu();
                    }
                }
            }
               
        }

        private void Dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int soDong = e.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvdanhsach.Rows[soDong];
            txtMasp.Text = row.Cells["MASP"].Value.ToString();
            txtTensp.Text = row.Cells["TENSP"].Value.ToString();
            cboLoai.Text = row.Cells["MALOAI"].Value.ToString();
            txtSL_kho.Text = row.Cells["SL_TONKHO"].Value.ToString();
            cboKhuyenmai.Text = row.Cells["KHUYENMAI"].Value.ToString();
            txtGiaban.Text = row.Cells["GIABAN"].Value.ToString();
            cboNCC.Text = row.Cells["NHACUNGCAP"].Value.ToString();
        }

        private void BtnXemDS_Click_1(object sender, EventArgs e)
        {
            hienthidulieu();
            

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            
                this.Close();
        }

        //private void BtnLuu_Click(object sender, EventArgs e)
        //{
            
        //}

        private void CboLoai_SelectedIndexChanged(object sender, EventArgs e)
          {

           }

        private void BtnLuu_Click_1(object sender, EventArgs e)
        {
           
            if (them)
            {
                try
                {
                    string sql = "insert into SANPHAM (MASP,TENSP,SL_TONKHO,GIABAN,MALOAI,KHUYENMAI,NHACUNGCAP)";
                    sql += "values('" + txtMasp.Text + "','" + txtTensp.Text + "','" + txtSL_kho.Text + "','" + txtGiaban.Text + "'," +
                        "'" + cboLoai.Text + "','" + cboKhuyenmai.Text + "','" + cboNCC.Text + "')";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Thêm thanh cong");
                        hienthidulieu();
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                }
                   
              
            }
          
           
        }

        private void TxtSL_kho_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtGiaban_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTensp_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtSL_kho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void TxtGiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
          {

            try
            {
                DataSet ds = new DataSet();
                ds = dt.laydanhsach("select * from SANPHAM where TENSP like '%" + txtTimKiem.Text + "%' OR MASP LIKE '%"+ txtTimKiem.Text + "%'");
                dgvdanhsach.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("không tìm thấy dữ liệu");
            }

        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BtnTimKiem_Click(sender, e);
        }
    }
}
