using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using App_QLBanHangSieuThiMini.DB_Player;

namespace App_QLBanHangSieuThiMini.DAL
{
    class DAL_DangNhap
    {
        DBConnect db = null;

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
