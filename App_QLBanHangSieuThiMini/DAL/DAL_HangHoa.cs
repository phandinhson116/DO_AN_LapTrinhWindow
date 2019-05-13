using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using App_QLBanHangSieuThiMini.ValueObject;

namespace App_QLBanHangSieuThiMini.DAL
{
    class DAL_HangHoa
    {
        DBConnect _dbConnect = new DBConnect();

        public DataTable GetTable()
        {
            return _dbConnect.ExecuteQuery("select * from HangHoa");
        }

        public bool Them(HangHoa hang)
        {
            string strSql = string.Format("insert into HangHoa (TenHH, DonGia, SoLuong, DVCungCap, NgayNhapHang, NgayHetHan) values(N'{0}', {1}, {2}, N'{3}', '{4}', '{5}')", hang.TenHH, hang.DonGia, hang.SoLuong, hang.DVCungCap, hang.NgayNhapHang, hang.NgayHetHan);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Xoa(int maHH)
        {
            string strSql = string.Format("delete from HangHoa where MaHH = {0}", maHH);
            return _dbConnect.ExecuteNonQuery(strSql);
            
        }

        public bool Sua(HangHoa hang)
        {
            string strSql = string.Format("update HangHoa set TenHH = N'{0}', DonGia = {1}, SoLuong = {2}, DVCungCap = N'{3}', NgayNhapHang = '{4}', NgayHetHan = '{5}' where MaHH = {6}", hang.TenHH, hang.DonGia, hang.SoLuong, hang.DVCungCap, hang.NgayNhapHang, hang.NgayHetHan, hang.MaHH);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public HangHoa GetRow(int maHH)
        {
            DataTable dt = _dbConnect.ExecuteQuery(string.Format("select * from HangHoa where MaHH = '{0}'", maHH));
            HangHoa hanghoa = new HangHoa(
                Convert.ToInt32(dt.Rows[0]["MaHH"]),
                dt.Rows[0]["TenHH"].ToString(),
                (float)Convert.ToDouble(dt.Rows[0]["DonGia"]),
                Convert.ToInt32(dt.Rows[0]["SoLuong"]),
                dt.Rows[0]["DVCungCap"].ToString(),
                Convert.ToDateTime(dt.Rows[0]["NgayNhapHang"]),
                Convert.ToDateTime(dt.Rows[0]["NgayHetHan"]));
            return hanghoa;
        }
    }
}
