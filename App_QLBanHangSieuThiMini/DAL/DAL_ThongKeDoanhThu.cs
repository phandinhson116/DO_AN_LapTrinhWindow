using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QLBanHangSieuThiMini.DAL
{
    class DAL_ThongKeDoanhThu
    {
        DBConnect db = null;

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
    }
}
