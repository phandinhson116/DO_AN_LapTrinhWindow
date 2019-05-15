using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using App_QLBanHangSieuThiMini.DAL;

namespace App_QLBanHangSieuThiMini.BLL
{
    class BLL_HoaDon
    {
        DAL_HoaDon _dalHoaDon = new DAL_HoaDon();
        DAL_ChiTietHoaDon _dalChiTietHoaDon = new DAL_ChiTietHoaDon();

        public DataTable GetHoaDon()
        {
            return _dalHoaDon.GetTable();
        }

        public DataTable GetHoaDon(string maHD, string maKH, string maNV)
        {
            return _dalHoaDon.GetTable(maHD, maKH, maNV);
        }

        public DataTable GetChiTietHoaDon(int maHD)
        {
            return _dalChiTietHoaDon.GetChiTietHoaDons(maHD);
        }
    }
}
