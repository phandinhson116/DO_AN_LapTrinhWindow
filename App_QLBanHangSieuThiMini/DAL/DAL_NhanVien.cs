using App_QLBanHangSieuThiMini.ValueObject;
using System;
using System.Data;
using System.Windows.Forms;

namespace App_QLBanHangSieuThiMini.DAL
{
    internal class DAL_NhanVien
    {
        private DBConnect _dbConnect = new DBConnect();

        public DataTable GetTable()
        {
            return _dbConnect.ExecuteQuery("select * from NhanVien");
        }

        public bool Them(NhanVien nhanvien)
        {
            string strSql = string.Format("insert into NhanVien (TenNV, GioiTinh, DiaChi, SDT, MatKhau, ChucDanh, Luong)  values (N'{0}', N'{1}', N'{2}', '{3}', '{4}', N'{5}', {6})",
               nhanvien.TenNV, nhanvien.GioiTinh, nhanvien.DiaChi, nhanvien.SDT, nhanvien.MatKhau, nhanvien.ChucDanh, nhanvien.Luong);
            MessageBox.Show(strSql, "Thong bao", MessageBoxButtons.OK);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Xoa(int maNV)
        {
            string strSql = string.Format("delete from NhanVien where MaNV = {0}", maNV);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public bool Sua(NhanVien nhanvien)
        {
            string strSql = string.Format("update NhanVien set TenNV = N'{0}', GioiTinh = N'{1}', DiaChi = N'{2}', SDT = {3}, MatKhau = '{4}', ChucDanh = N'{5}', Luong = {6} where MaNV = {7}",
                nhanvien.TenNV, nhanvien.GioiTinh, nhanvien.DiaChi, nhanvien.SDT, nhanvien.MatKhau, nhanvien.ChucDanh, nhanvien.Luong, nhanvien.MaNV);
            return _dbConnect.ExecuteNonQuery(strSql);
        }

        public int GetNextID()
        {
            return Convert.ToInt32(_dbConnect.ExucuteScalar("select ident_current('NhanVien')"));
        }
    }
}