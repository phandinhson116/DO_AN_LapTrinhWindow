using App_QLBanHangSieuThiMini.DB_Player;
using System.Data;

namespace App_QLBanHangSieuThiMini.BS_Player
{
    internal class QL_NhanVien
    {
        private DataBase_Main db = null;

        public QL_NhanVien()
        {
            db = new DataBase_Main();
        }

        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text);
        }

        public bool ThemNhanVien(string MaNV, string TenNV, string GioiTinh, string DiaChi, string SDT, string MatKhau,string ChucDanh,int Luong, ref string err)
        {
            string sqlString = "Insert Into NhanVien Values(" + "'" + MaNV + "',N'" + TenNV + "',N'" + GioiTinh + "',N'" + DiaChi +  "',N'" + SDT + "',N'" + MatKhau + "',N'"+ ChucDanh + "',N'" + Luong + "' )";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaNhanVien(ref string err, string MaNV)
        {
            string sqlString = "Delete From NhanVien Where MaNV='"
                        + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString.Trim(), CommandType.Text, ref err);
        }

        public bool CapNhatNhanVien(string MaNV, string TenNV, string GioiTinh, string DiaChi, string SDT, string MatKhau, string ChucDanh, int Luong, ref string err)
        {
            string sqlString = "Update NhanVien Set TenNV=N'" + TenNV + "',GioiTinh=N'" + GioiTinh + "',DiaChi=N'" + DiaChi +  "',SDT=N'" + SDT + "',MatKhau=N'" + MatKhau + "',ChucDanh=N'" + ChucDanh+"',Luong=N'"+Luong
                            + "'Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString.Trim(), CommandType.Text, ref err);
        }
    }
}