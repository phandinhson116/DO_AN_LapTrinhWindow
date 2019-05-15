using App_QLBanHangSieuThiMini.DAL;
using System.Data;

namespace App_QLBanHangSieuThiMini.BLL
{
    internal class BLL_HoaDon
    {
        private DAL_HoaDon _dalHoaDon = new DAL_HoaDon();
        private DAL_ChiTietHoaDon _dalChiTietHoaDon = new DAL_ChiTietHoaDon();

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