using App_QLBanHangSieuThiMini.DAL;
using App_QLBanHangSieuThiMini.ValueObject;
using System.Data;

namespace App_QLBanHangSieuThiMini.BLL
{
    internal class BLL_KhachHang
    {
        private DAL_KhachHang _dal = new DAL_KhachHang();

        public DataTable GetKhachHang()
        {
            return _dal.GetTable();
        }

        public DataTable GetKhachHang(string maKH, string tenKH, string sdt)
        {
            return _dal.GetTable(maKH, tenKH, sdt);
        }

        public bool ThemKhachHang(KhachHang khachhang)
        {
            return _dal.Them(khachhang);
        }

        public bool XoaKhachHang(int maKH)
        {
            return _dal.Xoa(maKH);
        }

        public bool SuaKhachHang(KhachHang khachhang)
        {
            return _dal.Sua(khachhang);
        }
    }
}