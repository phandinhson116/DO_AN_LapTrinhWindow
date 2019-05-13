using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QLBanHangSieuThiMini.ValueObject
{
    class HangHoa
    {
        public int MaHH { get; set; }
        public string TenHH { get; set; }
        public float DonGia { get; set; }
        public int SoLuong { get; set; }
        public string DVCungCap { get; set; }
        public DateTime NgayNhapHang { get; set; }
        public DateTime NgayHetHan { get; set; }

        public HangHoa(int maHH,string tenHH,float donGia,int soLuong,string dvCungCap,DateTime ngayNhap,DateTime ngayHetHan)
        {
            MaHH = maHH;
            TenHH = tenHH;
            DonGia = donGia;
            SoLuong = soLuong;
            DVCungCap = dvCungCap;
            NgayNhapHang = ngayNhap;
            NgayHetHan = ngayHetHan;
        }
    }
}
