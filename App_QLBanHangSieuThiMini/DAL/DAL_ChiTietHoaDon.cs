using App_QLBanHangSieuThiMini.ValueObject;
using System;
using System.Collections.Generic;
using System.Data;

namespace App_QLBanHangSieuThiMini.DAL
{
    internal class DAL_ChiTietHoaDon
    {
        private DBConnect _dbConnect = new DBConnect();

        public DataTable GetTable()
        {
            return _dbConnect.ExecuteQuery("select * from ChiTietHoaDon");
        }

        public bool Them(ChiTietHoaDon chitietHD)
        {
            string strSql = string.Format("insert into ChiTietHoaDon values({0}, {1}, {2}, {3})", chitietHD.MaHD, chitietHD.MaHH, chitietHD.DonGia, chitietHD.SoLuong);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Xoa(int maHD, int maHH)
        {
            string strSql = string.Format("delete from ChiTietHoaDon where MaHD = {0} and MaHH = {1}", maHD, maHH);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Xoa(int maHD)
        {
            string strSql = string.Format("delete from ChiTietHoaDon where MaHD = {0}", maHD);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Sua(ChiTietHoaDon chitietHD)
        {
            string strSql = string.Format("update ChiTietHoaDon set DonGia = {0}, SoLuong = {1} where MaHD = {2} and MaHH = {3}",
                chitietHD.DonGia, chitietHD.SoLuong, chitietHD.MaHD, chitietHD.MaHH);
            _dbConnect.ExecuteNonQuery(strSql);
            return true;
        }

        //Lay tat ca cac hang hoa cua mot hoa don
        public List<ChiTietHoaDon> GetChiTietHoaDon(int MaHD)
        {
            DataTable dt = _dbConnect.ExecuteQuery(string.Format("select * from ChiTietHoaDon where MaHD = {0}", MaHD));
            List<ChiTietHoaDon> chitietHDs = new List<ChiTietHoaDon>();
            foreach (DataRow row in dt.Rows)
            {
                ChiTietHoaDon chitietHD = new ChiTietHoaDon(
                    Convert.ToInt32(row["MaHD"]),
                    Convert.ToInt32(row["MaHH"]),
                    (float)Convert.ToDouble(row["DonGia"]),
                    Convert.ToInt32(row["SoLuong"]));
                chitietHDs.Add(chitietHD);
            }
            return chitietHDs;
        }
    }
}