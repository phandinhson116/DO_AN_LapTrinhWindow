using System;

namespace App_QLBanHangSieuThiMini.ValueObject
{
    internal class HoaDon
    {
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public int MaNV { get; set; }
        public DateTime Ngay { get; set; }

        public HoaDon(int maHD, int maKH, int maNV, DateTime ngay)
        {
            MaHD = maHD;
            MaKH = maKH;
            MaNV = maNV;
            Ngay = ngay;
        }
    }
}