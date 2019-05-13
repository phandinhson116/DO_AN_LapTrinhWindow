using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using App_QLBanHangSieuThiMini.DAL;
using App_QLBanHangSieuThiMini.ValueObject;

namespace App_QLBanHangSieuThiMini.BLL
{
    class BLL_KhachHang
    {
        DAL_KhachHang _dal = new DAL_KhachHang();

        public DataTable GetKhachHang()
        {
            return _dal.GetTable();
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
