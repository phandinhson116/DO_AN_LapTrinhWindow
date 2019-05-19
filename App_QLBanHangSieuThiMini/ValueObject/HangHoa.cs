using System;

namespace App_QLBanHangSieuThiMini.ValueObject
{
    internal class HangHoa
    {
        public int MaHH { get; set; }
        public string TenHH { get; set; }
        public float DonGia { get; set; }
        public int SoLuong { get; set; }
        public string DVCungCap { get; set; }
        public DateTime NgayNhapHang { get; set; }
        public DateTime NgayHetHan { get; set; }
        
    }
}