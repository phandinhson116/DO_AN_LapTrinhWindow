using System.Data;
using System;

namespace App_QLBanHangSieuThiMini.DAL
{
    internal class DAL_ThongKeDoanhThu
    {
        private DBConnect db = null;

        public DAL_ThongKeDoanhThu()
        {
            db = new DBConnect();
        }

        public DataTable SalaryOfEmployee()
        {
            return db.ExecuteQuery("select MaNV[Mã Nhân Viên], TenNV[Tên Nhân Viên], ChucDanh[Chức Danh], Luong[Lương]  from NhanVien");
        }

        public DataTable Income()
        {
            return db.ExecuteQuery("SELECT HangHoa.MaHH[Mã Hàng Hóa], TenHH[Tên Hàng], count(ChiTietHoaDon.SoLuong)[Số Lượng], ChiTietHoaDon.DonGia[Đơn Giá], count(ChiTietHoaDon.SoLuong)*ChiTietHoaDon.DonGia[Thành Tiền] FROM ChiTietHoaDon inner join HangHoa on ChiTietHoaDon.MaHH=HangHoa.MaHH group by HangHoa.MaHH, ChiTietHoaDon.DonGia, TenHH");
        }

        public DataTable GoodsEntered()
        {
            return db.ExecuteQuery("SELECT MaHH[Mã Hàng], TenHH[Tên Hàng], DonGia[Đơn Giá], SoLuong[Số Lượng], DVCungCap[Đơn Vị Cung Cấp], NgayNhapHang[Ngày Nhập Hàng], NgayHetHan[Ngày hết hạn], DonGia*SoLuong[Thành Tiền] FROM HangHoa");
        }

        public int TotalRevenue(int Month, int Year)
        {
            if (db.ExecuteQuery("SELECT SUM(DonGia*SoLuong)[Revenue] FROM HoaDon JOIN ChiTietHoaDon ON HoaDon.MaHD = ChiTietHoaDon.MaHD WHERE MONTH(NgayLap) = " + Month + " and YEAR(NgayLap)=" + Year).Rows[0]["Revenue"] == null)
                return 0;
            return Convert.ToInt32(db.ExecuteQuery("SELECT SUM(DonGia*SoLuong)[Revenue] FROM HoaDon JOIN ChiTietHoaDon ON HoaDon.MaHD = ChiTietHoaDon.MaHD WHERE MONTH(NgayLap) = " + Month + " and YEAR(NgayLap)=" + Year).Rows[0]["Revenue"]);
        }

        public int TotalExpenditure(int Month, int Year)
        {
            if (db.ExecuteQuery("SELECT SUM(SoLuongNhap*DonGiaNhap)[Expenditure] FROM HangHoa WHERE MONTH(NgayNhapHang)= " + Month + " and YEAR(NgayNhapHang) = " + Year).Rows[0]["Expenditure"] == null)
                return 0;
            return Convert.ToInt32(db.ExecuteQuery("SELECT SUM(SoLuongNhap*DonGiaNhap)[Expenditure] FROM HangHoa WHERE MONTH(NgayNhapHang) = "+Month+" and YEAR(NgayNhapHang) = "+Year).Rows[0]["Expenditure"]);
        }
    }
}