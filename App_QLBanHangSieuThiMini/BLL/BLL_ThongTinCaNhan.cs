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
            NhanVien nhanvienCu = dal.GetRow(maNV);
            NhanVien nhanvienMoi = new NhanVien()
            {
                MaNV = nhanvienCu.MaNV,
                TenNV = nhanvienCu.TenNV,
                GioiTinh = nhanvienCu.GioiTinh,
                DiaChi = nhanvienCu.DiaChi,
                MatKhau = matKhau,
                ChucDanh = nhanvienCu.ChucDanh,
                SDT = nhanvienCu.SDT,
                Luong = nhanvienCu.Luong
            };
            return dal.Sua(nhanvienMoi);
        }
    }
}
