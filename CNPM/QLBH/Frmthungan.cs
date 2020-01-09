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
    public partial class Frmthungan : Form
    {
        public Frmthungan()
        {
            InitializeComponent();
        }
        string MaNV = "";
        public Frmthungan(string MANV)
        {
            InitializeComponent();
            MaNV = MANV;
        }
        DataProvider dt = new DataProvider();
        String Ma = "";
        String[] MaSP = new String[2];
        int gia;
        String[] MaXoa = new String[2];

        private void CboLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = dt.laydulieu("SELECT MASP,TENSP,SL_TONKHO,GIABAN,LOAISP.TENLOAI_SP,KHUYENMAI.HINHTHUC,NHACUNGCAP.TEN_NCC FROM SANPHAM, LOAISP,KHUYENMAI,NHACUNGCAP WHERE SANPHAM.MALOAI ='" + cboLoaiSp.SelectedValue.ToString() + "' and SANPHAM.MALOAI = LOAISP.MALOAI and SANPHAM.KHUYENMAI = KHUYENMAI.MAKM and SANPHAM.NHACUNGCAP = NHACUNGCAP.MA_NCC ");
            dgvDanhsachSP.DataSource = ds.Tables[0];
        }

        private void Frmthungan_Load(object sender, EventArgs e)
        {
            radTT.Checked = false;
            radVL.Checked = true;
            txtTongTien.Enabled = false;
            Ma = dt.AutoCapMa("HOADON", "HD");
            dt.CapNhatDuLieu("insert into HOADON(MAHD) values('" + Ma + "')");
            dgvHoadon.DataSource = dt.laydanhsach("SELECT * FROM CHITIETHOADON WHERE MAHD='" + Ma + "'").Tables[0];

            DataSet ds;
            ds = dt.laydanhsach("select * from LOAISP ");
            cboLoaiSp.DataSource = ds.Tables[0];
            cboLoaiSp.DisplayMember = "TENLOAI_SP";
            cboLoaiSp.ValueMember = "MALOAI";
            cboLoaiSp.SelectedIndex = 0;

            ds = dt.laydanhsach("select * from KHACHHANG ");
            cboKH.DataSource = ds.Tables[0];
            cboKH.DisplayMember = "MAKH";
            cboKH.ValueMember = "MAKH";
            cboKH.SelectedIndex = 0;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string giamgia;
                if (MaSP[1] != null)
                    giamgia = MaSP[1].Replace("%", "");
                else
                    giamgia = "0";
                double tongtien = Convert.ToInt32(txtSL.Text) * gia * ((100 - Convert.ToDouble(giamgia)) / 100);
                string sql = "insert into CHITIETHOADON(MAHD,MASP,SOLUONG,KHUYENMAI,GIABAN,THANHTIEN)";
                sql += " values('" + Ma + "','" + MaSP[0] + "'," + Convert.ToInt32(txtSL.Text) + ",'" + MaSP[1] + "'," + gia + "," + Convert.ToInt32(tongtien) + ")";
                if (dt.CapNhatDuLieu(sql) != 0)
                {
                    MessageBox.Show("Thành công");
                    dgvHoadon.DataSource = dt.laydanhsach("SELECT * FROM CHITIETHOADON WHERE MAHD='" + Ma + "'").Tables[0];
                }
                else
                {
                    MessageBox.Show("Thất bại, vui lòng kiểm tra lại thông tin");
                    btnXacnhan.Enabled = true;
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Chưa chọn sản phẩm");
            }
        }

        private void DgvHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaXoa[0] = dgvHoadon.Rows[e.RowIndex].Cells[0].Value.ToString();
            MaXoa[1] = dgvHoadon.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void DgvDanhsachSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            MaSP[0] = dgvDanhsachSP.Rows[i].Cells[0].Value.ToString();
            gia = Int32.Parse(dgvDanhsachSP.Rows[i].Cells[3].Value.ToString());
            MaSP[1] = dgvDanhsachSP.Rows[i].Cells[5].Value.ToString();
        }

        private void Btnlammoi_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = "0";
            txtSL.Text = "1";
            radVL.Checked = true;
            Ma = dt.AutoCapMa("HOADON", "HD");
            dt.CapNhatDuLieu("insert into HOADON(MAHD) values('" + Ma + "')");
            dgvHoadon.DataSource = dt.laydanhsach("SELECT * FROM CHITIETHOADON WHERE MAHD='" + Ma + "'").Tables[0];

            DataSet ds;
            ds = dt.laydanhsach("select * from LOAISP ");
            cboLoaiSp.DataSource = ds.Tables[0];
            cboLoaiSp.DisplayMember = "TENLOAI_SP";
            cboLoaiSp.ValueMember = "MALOAI";
            cboLoaiSp.SelectedIndex = 0;
        }

        private void BtnXacnhan_Click(object sender, EventArgs e)
        {
            string KH = "";
            string sql;
            if (radVL.Checked == true)
                KH = "KH00";
            else
            {
                KH = cboKH.SelectedValue.ToString();
            }
            object tongtien = dt.Money(" SELECT SUM(THANHTIEN) FROM CHITIETHOADON WHERE MAHD = '" + Ma + "'");
            sql = "UPDATE HOADON SET TONGTIEN='" + Convert.ToInt32(tongtien) + "', NGAYLAP='" + DateTime.Now.Date + "',MAKH='" + KH + "',MANV='" + MaNV + "' WHERE MAHD='" + Ma + "'";
            if (dt.CapNhatDuLieu(sql) != 0)
            {
                MessageBox.Show("Thanh toán thành công");
                txtTongTien.Text = tongtien.ToString();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại, vui lòng kiểm tra lại thông tin");
            }
        }

        private void RadVL_CheckedChanged(object sender, EventArgs e)
        {
            cboKH.Visible = false;
        }

        private void RadTT_CheckedChanged(object sender, EventArgs e)
        {
            cboKH.Visible = true;
        }

        private void CboKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = " DELETE FROM CHITIETHOADON WHERE MAHD='" + MaXoa[0] + "'and MASP='" + MaXoa[1] + "'";
                if (dt.CapNhatDuLieu(sql) != 0)
                {
                    MessageBox.Show("Thành công");
                    dgvHoadon.DataSource = dt.laydanhsach("SELECT * FROM CHITIETHOADON WHERE MAHD='" + MaXoa[0] + "'").Tables[0];
                }
                else
                {
                    MessageBox.Show("Thất bại, vui lòng kiểm tra lại thông tin");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
