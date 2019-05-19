using App_QLBanHangSieuThiMini.ValueObject;
using System;
using System.Data;

namespace App_QLBanHangSieuThiMini.DAL
{
    internal class DAL_HangHoa
    {
        private DBConnect _dbConnect = new DBConnect();

        public DataTable GetTable(string whereMaHH = "", string whereTenHH = "")
        {
            string strSql = string.Format("select * from HangHoa where MaHH like '{0}%' and TenHH like N'%{1}%'", whereMaHH, whereTenHH);
            return _dbConnect.ExecuteQuery(strSql);
        }

        public bool Them(HangHoa hang)
        {
            string strSql = string.Format("insert into HangHoa (TenHH, DonGia, SoLuong, DVCungCap, NgayNhapHang, NgayHetHan) values(N'{0}', {1}, {2}, N'{3}', '{4}', '{5}')", hang.TenHH, hang.DonGia, hang.SoLuong, hang.DVCungCap, hang.NgayNhapHang.ToString("yyyy-MM-dd"), hang.NgayHetHan.ToString("yyyy-MM-dd"));

            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Xoa(int maHH)
        {
            string strSql = string.Format("delete from HangHoa where MaHH = {0}", maHH);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Sua(HangHoa hang)
        {
            string strSql = string.Format("update HangHoa set TenHH = N'{0}', DonGia = {1}, SoLuong = {2}, DVCungCap = N'{3}', NgayNhapHang= '{4}',NgayHetHan  = '{5}' where MaHH = {6}", hang.TenHH, hang.DonGia, hang.SoLuong, hang.DVCungCap, hang.NgayNhapHang.ToString("yyyy-MM-dd"), hang.NgayHetHan.ToString("yyyy-MM-dd"), hang.MaHH);

            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public DataTable TimKiemMaHH(int maHH)
        {
            string strSql = string.Format("select *from HangHoa where MaHH ={0}", maHH);

            return _dbConnect.ExecuteQuery(strSql);
        }

        public DataTable TimKiemTenHH(string tenHH)
        {
            string strSql = string.Format("select *from HangHoa where TenHH LIKE '%{0}%'", tenHH.Trim());

            return _dbConnect.ExecuteQuery(strSql);
        }

        public DataTable TimKiemDVCungCap(string tenDV)
        {
            string strSql = string.Format("select *from HangHoa where DVCungCap LIKE '%{0}%'", tenDV.Trim());

            return _dbConnect.ExecuteQuery(strSql);
        }

        public DataTable TimKiemSPHetHan()
        {
            string strSql = string.Format("Select * from HangHoa where NgayHetHan<Convert(date,GETDATE(),102)");
            return _dbConnect.ExecuteQuery(strSql);
        }

        public DataTable TimKiemSPConHan()
        {
            string strSql = string.Format("Select * from HangHoa where NgayHetHan>=Convert(date,GETDATE(),102)");
            return _dbConnect.ExecuteQuery(strSql);
        }

        public HangHoa GetRow(int maHH)
        {
            DataTable dt = _dbConnect.ExecuteQuery(string.Format("select * from HangHoa where MaHH = '{0}'", maHH));
            HangHoa hanghoa = new HangHoa()
            {
                MaHH = Convert.ToInt32(dt.Rows[0]["MaHH"]),
                TenHH = dt.Rows[0]["TenHH"].ToString(),
                DonGia = (float)Convert.ToDouble(dt.Rows[0]["DonGia"]),
                SoLuong = Convert.ToInt32(dt.Rows[0]["SoLuong"]),
                DVCungCap = dt.Rows[0]["DVCungCap"].ToString(),
                NgayNhapHang = Convert.ToDateTime(dt.Rows[0]["NgayNhapHang"]),
                NgayHetHan = Convert.ToDateTime(dt.Rows[0]["NgayHetHan"])
            };
            return hanghoa;
        }

        public int GetNextID()
        {
            return Convert.ToInt32(_dbConnect.ExucuteScalar("select ident_current('HangHoa')"));
        }
    }
}