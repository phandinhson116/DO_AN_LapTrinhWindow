using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QLBanHangSieuThiMini.ValueObject
{
    class KhachHang
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int SoDiem { get; set; }

        public KhachHang(int maKH,string tenKH,string sdt,string gioiTinh,string diaChi,int soDiem)
        {
            MaKH = maKH;
            TenKH = tenKH;
            SDT = sdt;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDiem = soDiem;
        }
    }
}
