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
    public partial class FrmKhuyenmai : Form
    {
        public FrmKhuyenmai()
        {
            InitializeComponent();
        }
        DataProvider dt = new DataProvider();
        Boolean them, xoa, sua = false;
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        void hienthi()
        {
            DataSet ds = new DataSet();
            ds = dt.laydulieu("select * from KhuyenMai");
            dgvdanhsach.DataSource = ds.Tables[0];
        }
        void lockControll()
        {
            btnthem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;

            txtMa_KM.Enabled = false;
            txtHinhthuc.Enabled = false;
            dtpNgaybatdau.Enabled = false;
            dtpNgayketthuc.Enabled = false;

            txtMa_KM.Focus();
        }

     

        void UnlockControll()
        {
            btnthem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;

            txtMa_KM.Enabled = true;
            txtHinhthuc.Enabled = true;
            dtpNgaybatdau.Enabled = true;
            dtpNgayketthuc.Enabled = true;

            btnthem.Focus();
        }

     

        private void Btnthem_Click(object sender, EventArgs e)
        {
            UnlockControll();
            txtMa_KM.Enabled = false;
            txtMa_KM.Text = dt.AutoCapMa("KhuyenMai", "KM");
            txtHinhthuc.Text = "";
            dtpNgaybatdau.MaxDate = DateTime.Today;
            dtpNgayketthuc.MinDate = DateTime.Today;
            them = true;
        }

    

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            UnlockControll();
            txtMa_KM.Enabled = false;
            xoa = true;
            DialogResult hoithoai = MessageBox.Show("Bạn có chắc xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(hoithoai == DialogResult.Yes)
            {
                if (xoa)
                {
                    string sql = "Delete from KhuyenMai where MAKM ='" + txtMa_KM.Text + "'";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        hienthi();
                    }
                    else
                    {
                        MessageBox.Show("xóa thất bại");
                    }
                }
            }
           
        }

        private void Dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int soDong = e.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvdanhsach.Rows[soDong];
            txtMa_KM.Text = row.Cells["MAKM"].Value.ToString();
            txtHinhthuc.Text = row.Cells["HINHTHUC"].Value.ToString();
            dtpNgaybatdau.Value = DateTime.Parse(row.Cells["NGAYBATDAU"].Value.ToString());
            dtpNgayketthuc.Value = DateTime.Parse(row.Cells["NGAYKETTHUC"].Value.ToString());
        }

        private void FrmKhuyenmai_Load(object sender, EventArgs e)
        {
            lockControll();
        }

        private void BtnXEm_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void DtpNgaybatdau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            UnlockControll();
            txtMa_KM.Enabled = false;
            sua = true;
            DialogResult hoithoai = MessageBox.Show("Bạn có chắc sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoithoai == DialogResult.Yes)
            {
                if (sua)
                {
                    string sql = "UPDATE KHUYENMAI SET  MAKM='" + txtMa_KM.Text + "', HINHTHUC='" + txtHinhthuc.Text + "', NGAYBATDAU='" + dtpNgaybatdau.Value + "', NGAYKETTHUC='" + dtpNgayketthuc.Value + "' where MAKM='" + txtMa_KM.Text + "'";
                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Ðã sửa thành công!", "Thông báo");
                        hienthi();
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
            if (txtMa_KM.Text == "" || txtHinhthuc.Text == "") 
            {
                MessageBox.Show("Vui lòng nhập lại đầy đủ thông tin !");
            }
            else if (them)
            {
                try
                {
                    if(txtHinhthuc.Text == "") { }
                    string sql = "insert into KHUYENMAI(MAKM,HINHTHUC,NGAYBATDAU,NGAYKETTHUC)";
                    sql += "values('" + txtMa_KM.Text + "','" + txtHinhthuc.Text + "','" + dtpNgaybatdau.Value + "','" + dtpNgayketthuc.Value + "')";

                    if (dt.CapNhatDuLieu(sql) != 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        hienthi();
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
