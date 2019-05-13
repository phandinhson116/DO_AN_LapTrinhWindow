using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QLBanHangSieuThiMini.ValueObject
{
    class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string MatKhau { get; set; }
        public string ChucDanh { get; set; }
        public string SDT { get; set; }
        public int Luong { get; set; }
        public NhanVien(int maNV, string tenNV, string gioiTinh, string diaChi, string matKhau, string chucDanh, string sdt, int luong)
        {
            MaNV = maNV;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            MatKhau = matKhau;
            ChucDanh = chucDanh;
            SDT = sdt;
            Luong = luong;
        }
    }
}
