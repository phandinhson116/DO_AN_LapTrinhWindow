using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_QLBanHangSieuThiMini.ValueObject;
using App_QLBanHangSieuThiMini.DAL;

namespace App_QLBanHangSieuThiMini.BLL
{
    class BLL_ThongTinCaNhan
    {
        DAL_NhanVien dal = new DAL_NhanVien();
        public NhanVien GetThongTin(int maNV)
        {
            return dal.GetRow(maNV);
        }

        public bool SuaThongTin(NhanVien nhanvien)
        {
            return dal.Sua(nhanvien);
        }

        public bool DoiMatKhau(int maNV, string matKhau)
        {
            NhanVien nhanvien = dal.GetRow(maNV);
            return dal.Sua(new NhanVien(nhanvien.MaNV, nhanvien.TenNV, nhanvien.GioiTinh, nhanvien.DiaChi, matKhau, nhanvien.ChucDanh, nhanvien.SDT, nhanvien.Luong));
        }
    }
}
