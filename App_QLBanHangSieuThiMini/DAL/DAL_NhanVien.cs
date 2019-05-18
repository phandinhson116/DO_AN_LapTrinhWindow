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

        public NhanVien GetRow(int manv)
        {
            NhanVien nhanvien = null;
            DataTable dt = _dbConnect.ExecuteQuery(string.Format("select * from NhanVien where MaNV = {0}", manv));
            if (dt.Rows.Count > 0)
            {
                nhanvien = new NhanVien(
                   Convert.ToInt32(dt.Rows[0]["MaNV"]),
                    dt.Rows[0]["TenNV"].ToString(),
                    dt.Rows[0]["GioiTinh"].ToString(),
                    dt.Rows[0]["DiaChi"].ToString(),
                    dt.Rows[0]["MatKhau"].ToString(),
                    dt.Rows[0]["ChucDanh"].ToString(),
                    dt.Rows[0]["SDT"].ToString(),
                   Convert.ToInt32(dt.Rows[0]["Luong"]));
            }
            else MessageBox.Show("Không tìm thấy nhân viên này");
            return nhanvien;
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
        public DataTable TimKiemMaNV(int maNV)
        {
            string strSql = string.Format("select *from NhanVien where MaNV ={0}", maNV);

            return _dbConnect.ExecuteQuery(strSql);
        }
        public DataTable TimKiemTenNV(string tenNV)
        {
            string strSql = string.Format("select *from NhanVien where TenNV LIKE N'%{0}%'", tenNV);

            return _dbConnect.ExecuteQuery(strSql);
        }
        public DataTable TimKiemGT(string gioiTinh)
        {
            string strSql = string.Format("select *from NhanVien where GioiTinh LIKE N'%{0}%'", gioiTinh);

            return _dbConnect.ExecuteQuery(strSql);
        }
        public DataTable TimKiemChucDanh(string chucDanh)
        {
            string strSql = string.Format("select *from NhanVien where ChucDanh LIKE N'%{0}%'", chucDanh);

            return _dbConnect.ExecuteQuery(strSql);
        }
        public DataTable TimKiemDiaChi(string diaChi)
        {
            string strSql = string.Format("select *from NhanVien where DiaChi LIKE N'%{0}%'", diaChi);

            return _dbConnect.ExecuteQuery(strSql);
        }
        public int GetNextID()
        {
            return Convert.ToInt32(_dbConnect.ExucuteScalar("select ident_current('NhanVien')"));
        }
    }
}