using App_QLBanHangSieuThiMini.ValueObject;
using System;
using System.Data;

namespace App_QLBanHangSieuThiMini.DAL
{
    internal class DAL_HoaDon
    {
        private DBConnect _dbConnect = new DBConnect();

        public DataTable GetTable()
        {
            /*
            DataTable dt = GetData("HoaDon");
            List<HoaDon> list = new List<HoaDon>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new HoaDon(row["MaHD"].ToString(),row["MaKH"].ToString(),row["MaNV"].ToString(),Convert.ToDateTime(row["NgayLap"])));
            }
            return list;*/
            return _dbConnect.ExecuteQuery("select * from HoaDon");
        }

        public DataTable GetTable(string whereMaHD, string whereMaKH, string whereMaNV)
        {
            string strSql = string.Format("select * from HoaDon where MaHD like '{0}%' and MaKH like '{1}%' and MaNV like '{2}%'", whereMaHD, whereMaKH, whereMaNV);
            return _dbConnect.ExecuteQuery(strSql);
        }

        public HoaDon GetRow(int maHD)
        {
            DataTable dt = _dbConnect.ExecuteQuery(string.Format("select * from HoaDon where MaHD = {0}", maHD));
            HoaDon hoadon = new HoaDon(
                Convert.ToInt32(dt.Rows[0]["MaHD"]),
                Convert.ToInt32(dt.Rows[0]["MaKH"]),
                Convert.ToInt32(dt.Rows[0]["MaNV"]),
               Convert.ToDateTime(dt.Rows[0]["NgayLap"]));
            return hoadon;
        }

        public bool Them(HoaDon hoadon)
        {
            string strSql = string.Format("insert into HoaDon (MaKH, MaNV, NgayLap) values({0}, {1}, '{2}')", hoadon.MaKH, hoadon.MaNV, hoadon.Ngay);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Xoa(int maHD)
        {
            string strSql = string.Format("delete from HoaDon where MaHD = {0}", maHD);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Sua(HoaDon hoadon)
        {
            string strSql = string.Format("update HoaDon set MaKH = {0}, MaNV = {1}, NgayLap = '{2}' where MaHD = {3}",
                hoadon.MaKH, hoadon.MaNV, hoadon.Ngay, hoadon.MaHD);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public int GetNextID()
        {
            return Convert.ToInt32(_dbConnect.ExucuteScalar("select ident_current('HoaDon')")) + 1;
        }
    }
}