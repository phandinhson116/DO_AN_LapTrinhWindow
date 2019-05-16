using System.Data;

namespace App_QLBanHangSieuThiMini.DAL
{
    internal class DAL_DangNhap
    {
        private DBConnect db = null;

        public DAL_DangNhap()
        {
            db = new DBConnect();
        }

        public string LogIn(string account, string password)
        {
            return db.MyExecuteQueryDataReader("select MaNV, MatKhau, ChucDanh from NhanVien where MaNV='" + account + "' and MatKhau='" + password + "'", CommandType.Text);
        }
    }
}