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
    public partial class Frmchinh : Form
    {
        private int childFormNumber = 0;

        public Frmchinh()
        {
            InitializeComponent();
        }
        string MANV;
        string[] LoaiNV = new string[2];
        DataProvider dt = new DataProvider();
        DataSet ds = new DataSet();

        public Frmchinh(String taikhoan)
        {
            InitializeComponent();
            ds = dt.laydanhsach ("SELECT TENNV,MANV,LOAI_NV FROM NHANVIEN WHERE TAIKHOAN='" + taikhoan + "'");
            lblTen.Text = ds.Tables[0].Rows[0]["TENNV"].ToString();
            MANV = ds.Tables[0].Rows[0]["MANV"].ToString();
            LoaiNV[0] = ds.Tables[0].Rows[0]["LOAI_NV"].ToString();

            ds = dt.laydanhsach("SELECT TENLOAI_NV FROM LOAI_NV WHERE MALOAI_NV='" + LoaiNV[0] + "'");
            LoaiNV[1] = ds.Tables[0].Rows[0]["TENLOAI_NV"].ToString();
            
        }
      
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private bool CheckExitsForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void BtnQLNV_Click(object sender, EventArgs e)
        {
            if(! CheckExitsForm("Frmnhanvien"))
            {
                Form frm = new Frmnhanvien();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("Frmnhanvien");
        }

        private void BtnThuNgan_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("Frmthungan"))
            {
                Form thungan = new Frmthungan(MANV);
                thungan.MdiParent = this;
                thungan.Show();
            }
            else
                ActiveChildForm("Frmthungan");

        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("FrmThongke"))
            {
               Form tk = new FrmThongke();
                tk.MdiParent = this;
                tk.Show();
            }
            else
                ActiveChildForm("FrmThongke");

        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {

            if (!CheckExitsForm("Frmkhachhang"))
            {
                Form kh = new Frmkhachhang();
                kh.MdiParent = this;
                kh.Show();
            }
            else
                ActiveChildForm("Frmkhachhang");
        }

        private void Btndonhang_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("DonHang"))
            {
                Form dh = new DonHang();
                dh.MdiParent = this;
                dh.Show();
            }
            else
                ActiveChildForm("DonHang");
        }

        private void BtnQLSP_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("FrmQuanlysanpham"))
            {
                Form sp = new FrmQuanlysanpham();
                sp.MdiParent = this;
                sp.Show();
            }
            else
                ActiveChildForm("FrmQuanlysanpham");
        }

        private void BtnQLNV_Click_1(object sender, EventArgs e)
        {

            if (!CheckExitsForm("Frmnhanvien"))
            {
                Form nv = new Frmnhanvien();
                nv.MdiParent = this;
                nv.Show();
            }
            else
                ActiveChildForm("Frmnhanvien");
        }

        private void BtnKho_Click(object sender, EventArgs e)
        {

            if (!CheckExitsForm("FrmPhieunhap"))
            {
                Form k = new FrmPhieunhap();
                k.MdiParent = this;
                k.Show();
            }
            else
                ActiveChildForm("FrmPhieunhap");

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoithoai = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (hoithoai == DialogResult.Yes)
                Application.Exit();
        }

        private void LblTen_Click(object sender, EventArgs e)
        {

        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmthongtinnhanvien ad = new Frmthongtinnhanvien();
            ad.MdiParent = this;
            ad.Show();
        }

        private void NhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnQLNV_Click(sender, e);
        }

        private void KháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnKhachHang_Click(sender, e);
        }

        private void SảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnQLSP_Click(sender, e);
        }

        private void HoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btndonhang_Click(sender, e);
        }

        private void KhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnKho_Click(sender, e);
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnThoat_Click(sender, e);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void Frmchinh_Load(object sender, EventArgs e)
        {

            if(LoaiNV[0] != "QL")
            {
                adminToolStripMenuItem.Enabled = false;

            }
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmdangnhap frm = new Frmdangnhap();
            frm.Show();

        }

        private void ThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmthongtinchitiet ct = new Frmthongtinchitiet();
            ct.Show();
        }

        private void BtnKhuyenmai_Click(object sender, EventArgs e)
        {
            FrmKhuyenmai kh = new FrmKhuyenmai();
            kh.MdiParent = this;
            kh.Show();
        }

        private void BtnNhacungcap_Click(object sender, EventArgs e)
        {
            FrmNhacungcap n = new FrmNhacungcap();
            n.MdiParent = this;
            n.Show();
        }
    }
}
