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
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();
        }

        DataProvider dt = new DataProvider();
       
        void TaoTree(TreeView tre, DataTable tbl)
        {
            int i;
            foreach (DataRow drw in tbl.Rows)
            {
                TreeNode N = new TreeNode();
                N = tre.Nodes.Add(drw[0].ToString());
                N.Tag = drw[0].ToString();
                for (i = 1; i <= tbl.Columns.Count - 1; i++)
                {
                    N.Nodes.Add(drw[i].ToString());
                }
            }
        }
        private void TaoListView(ListView lvw, DataTable tbl)
        {
            ListViewItem lvwItem = new ListViewItem();
            int i;
            lvw.Items.Clear();
            foreach (DataRow drw in tbl.Rows)
            {
                lvwItem = lvw.Items.Add(drw[0].ToString());
                for (i = 1; i <= tbl.Columns.Count - 1; i++)
                {
                    lvwItem.SubItems.Add(drw[i].ToString());
                }
            }
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DonHang_Load_1(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = dt.dulieutb("hoadon");
            TaoTree(tree, tbl);
           
        }

        private void Tree_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (tree.SelectedNode != null && tree.SelectedNode.Parent == null)
            {
                ListViewItem lvwitem = new ListViewItem();
                DataTable tbl = new DataTable();
                string strma = "";
                strma = tree.SelectedNode.Tag.ToString();
                tbl = dt.ThtinHD(strma);
                TaoListView(list, tbl);
            }
            txtHD.Text = tree.SelectedNode.Text;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from HOADON where MAHD ='" + txtHD.Text + "'";
            DialogResult hoithoai = MessageBox.Show("bạn có chắc xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(hoithoai == DialogResult.Yes)
            {
                if (dt.CapNhatDuLieu(sql) != 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    tree.SelectedNode.Remove();


                }
                else MessageBox.Show("Xóa thất bại", "Thông báo");

            }

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        






        // hàm kiểm tra lỗi 


    }
}
