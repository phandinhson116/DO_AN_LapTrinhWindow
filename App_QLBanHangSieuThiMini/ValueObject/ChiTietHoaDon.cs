namespace App_QLBanHangSieuThiMini.ValueObject
{
    internal class ChiTietHoaDon
    {
        public int MaHD { get; set; }
        public int MaHH { get; set; }
        public float DonGia { get; set; }
        public int SoLuong { get; set; }

        public ChiTietHoaDon(int maHD, int maHH, float donGia, int soLuong)
        {
            MaHD = maHD;
            MaHH = maHH;
            DonGia = donGia;
            SoLuong = soLuong;
        }
    }
}