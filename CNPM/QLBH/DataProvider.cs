using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DataProvider
    {

        public OleDbConnection con = new OleDbConnection();

        public DataProvider()
        {
            ketnoi();
        }
        void ketnoi()
        {
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=QLCHBH.mdb";
            if (con.State == ConnectionState.Closed)
                con.Open();

        }
        public DataSet laydulieu(string sql)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter da;
            da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            return ds;
        }
        // hàm tìm kiếm 
        public DataSet laydanhsach(string sql)
        {

            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;

        }
        //hàm cập nhật dữ liệu
        public int CapNhatDuLieu(String sql)
        {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                return cmd.ExecuteNonQuery();
        }
      
        public String AutoCapMa(string loai, string ma)
        {
            String MA = "";
            for (int i = 1; ; i++)
            {
                MA = ma + i.ToString();
                if (!KiemTraMa(loai, MA))
                    break;
            }
            return MA;
        }
        public Boolean KiemTraMa(string loai, string ma)
        {
            String MA = "";
            if (loai == "KHACHHANG")
                MA = "MAKH";
            if (loai == "NHANVIEN")
                MA = "MANV";
            if (loai == "HOADON")
                MA = "MAHD";
            if (loai == "SANPHAM")
                MA = "MASP";
            if (loai == "PHIEUNHAPHANG")
                MA = "MAPHIEU";
            if (loai == "PHIEUXUATHANG")
                MA = "MAPHIEU";
            if (loai == "KhuyenMai")
                MA = "MAKM";
            if (loai == "NHACUNGCAP")
                MA = "MA_NCC";
            return KiemTraDangNhap("Select " + MA + " FROM " + loai + " WHERE " + MA + "='" + ma + "'");
        }
        public Boolean KiemTraDangNhap(String sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            da.SelectCommand = cmd;
            DataTable ds = new DataTable();
            da.Fill(ds);
            if (ds.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public object Money(String sql)
        {
            object tbl;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            tbl = cmd.ExecuteScalar();
            return tbl;
        }
        public DataTable ThtinHD(string strMaHD)
        {
            string sql;
            DataSet ds = new DataSet();
            DataTable tbl = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand();
            sql = " select chitiethoadon.mahd,sanpham.masp,hoadon.makh,hoadon.manv,ngaylap,soluong,sanpham.giaban,khuyenmai.makm ,tongtien from hoadon,chitiethoadon,sanpham,khuyenmai where hoadon.mahd=chitiethoadon.mahd and  chitiethoadon.masp=sanpham.masp and sanpham.khuyenmai=khuyenmai.makm and chitiethoadon.mahd='" + strMaHD + "'";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(tbl);
            return tbl;
        }
      
        public DataTable dulieutb(string tblName)
        {
            string sql;
            DataTable tbl = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand();
            sql = "select * from " + tblName;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(tbl);
            return tbl;
        }

    }
}
