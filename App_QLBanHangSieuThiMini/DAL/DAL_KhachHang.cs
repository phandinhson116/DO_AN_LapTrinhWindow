using App_QLBanHangSieuThiMini.ValueObject;
using System;
using System.Data;

namespace App_QLBanHangSieuThiMini.DAL
{
    internal class DAL_KhachHang
    {
        private DBConnect _dbConnect = new DBConnect();

        public DataTable GetTable()
        {
            return _dbConnect.ExecuteQuery("select * from KhachHang");
        }

        public KhachHang GetRow(int maKH)
        {
            DataTable dt = _dbConnect.ExecuteQuery(string.Format("select * from KhachHang where MaKH = {0}", maKH));
            KhachHang khachhang = new KhachHang(
                Convert.ToInt32(dt.Rows[0]["MaKH"]),
                dt.Rows[0]["TenKH"].ToString(),
                dt.Rows[0]["SDT"].ToString(),
                dt.Rows[0]["GioiTinh"].ToString(),
                dt.Rows[0]["DiaChi"].ToString(),
                Convert.ToInt32(dt.Rows[0]["SoDiem"]));
            return khachhang;
        }

        public bool Them(KhachHang khachhang)
        {
            string strSql = string.Format("insert into KhachHang (TenKH, SDT, GioiTinh, DiaChi, SoDiem) values(N'{0}', '{1}', N'{2}', N'{3}', {4})",
                khachhang.TenKH, khachhang.SDT, khachhang.GioiTinh, khachhang.DiaChi, khachhang.SoDiem);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Xoa(int maKH)
        {
            string strSql = string.Format("delete from KhachHang where MaKH = {0}", maKH);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Sua(KhachHang khachHang)
        {
            string strSql = string.Format("update KhachHang set TenKH = N'{0}', SDT = '{1}', GioiTinh = N'{2}', DiaChi = N'{3}', SoDiem = {4} where MaKH = {5}", khachHang.TenKH, khachHang.SDT, khachHang.GioiTinh, khachHang.DiaChi, khachHang.SoDiem, khachHang.MaKH);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public int GetNextID()
        {
            return Convert.ToInt32(_dbConnect.ExucuteScalar("select ident_current('KhachHang')"));
        }
    }
}