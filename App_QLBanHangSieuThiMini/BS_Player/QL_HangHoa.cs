using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_QLBanHangSieuThiMini.DB_Player;

namespace App_QLBanHangSieuThiMini.BS_Player
{
    class QL_HangHoa
    {
        DataBase_Main db = null;

        public QL_HangHoa()
        {
            db = new DataBase_Main();
        }

        public DataSet LayHangHoa()
        {
            return db.ExecuteQueryDataSet("select * from HangHoa", CommandType.Text);
        }

        public bool ThemHangHoa(string MaHang, string TenHang,int DonGia, int SoLuong,string DVCungCap,string NgayNhapHang, ref string err)
        {
            string sqlString = "Insert Into HangHoa Values(" + "'" + MaHang + "',N'" + TenHang + "',N'"+DonGia+"',N'"+SoLuong+"',N'"+DVCungCap+"',N'"+NgayNhapHang+ "' )";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaHangHoa(ref string err, string MaHang)
        {
            string sqlString = "Delete From HangHoa Where MaHang='"
                        + MaHang+ "'";
            return db.MyExecuteNonQuery(sqlString.Trim(), CommandType.Text, ref err);
        }
        public bool CapNhatHangHoa(string MaHang, string TenHang, int DonGia, int SoLuong, string DVCungCap, string NgCungCap, ref string err)
        {
            string sqlString = "Update HangHoa Set TenHang=N'" + TenHang + "',DonGia=N'" + DonGia + "',SoLuong=N'" + SoLuong + "',DVCungCap=N'" + DVCungCap+"',NgayNhapHang=N'" +NgCungCap
                            + "'Where MaHang='" + MaHang + "'";
            return db.MyExecuteNonQuery(sqlString.Trim(), CommandType.Text, ref err);
        }
    }
}
