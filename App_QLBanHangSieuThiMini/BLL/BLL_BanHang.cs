using App_QLBanHangSieuThiMini.DAL;
using App_QLBanHangSieuThiMini.ValueObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace App_QLBanHangSieuThiMini.BLL
{
    internal class BLL_BanHang
    {
        private DAL_HangHoa _dalHangHoa = new DAL_HangHoa();
        private DAL_HoaDon _dalHoaDon = new DAL_HoaDon();
        private DAL_ChiTietHoaDon _dalChiTietHoaDon = new DAL_ChiTietHoaDon();
        private DAL_KhachHang _dalKhachHang = new DAL_KhachHang();

        public int GetMaHHMoi()
        {
            return _dalHangHoa.GetNextID();
        }

        public int GetMaHDMoi()
        {
            return _dalHoaDon.GetNextID();
        }

        public DataTable GetTableHangMua(Dictionary<int, int> hangMua)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mã", typeof(int)));
            dt.Columns.Add(new DataColumn("Đơn Giá", typeof(float)));
            dt.Columns.Add(new DataColumn("Số Lượng", typeof(int)));
            foreach (int maHH in hangMua.Keys)
            {
                DataRow row = dt.NewRow();
                row["Mã"] = maHH;
                row["Đơn Giá"] = _dalHangHoa.GetRow(maHH).DonGia;
                row["Số Lượng"] = hangMua[maHH];
                dt.Rows.Add(row);
            }
            return dt;
        }

        public DataTable GetHangHoa(string whereMaHH, string whereTenHH)
        {
            return _dalHangHoa.GetTable(whereMaHH, whereTenHH);
        }

        public float TinhTongTien(int maKH, Dictionary<int, int> hangmua)
        {
            float tong = 0;
            foreach (int maHH in hangmua.Keys)
            {
                tong += _dalHangHoa.GetRow(maHH).DonGia * hangmua[maHH];
            }
            return tong - _dalKhachHang.GetRow(maKH).SoDiem;
        }

        public float TinhTongTien(Dictionary<int, int> hangmua)
        {
            float tong = 0;
            foreach (int maHH in hangmua.Keys)
            {
                tong += _dalHangHoa.GetRow(maHH).DonGia * hangmua[maHH];
            }
            return tong;
        }

        public bool KiemTraDuHang(Dictionary<int, int> hangmua)
        {
            bool result = true;
            foreach (int maHH in hangmua.Keys)
            {
                HangHoa hang = _dalHangHoa.GetRow(maHH);
                //Khong con du hang de mua
                if (hang.SoLuong < hangmua[maHH])
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Mặt hàng {0} không còn đủ hàng", hang.MaHH));
                    result = false;
                }
            }
            return result;
        }

        public bool MuaHang(int maKH, int maNV, DateTime thoigian, Dictionary<int, int> hangmua)
        {
            bool result = true;
            if (KiemTraDuHang(hangmua))
            {
                //sua lai so luong hang
                foreach (int maHH in hangmua.Keys)
                {
                    HangHoa hang = _dalHangHoa.GetRow(maHH);
                    hang.SoLuong = hang.SoLuong - hangmua[maHH];
                    _dalHangHoa.Sua(hang);
                }
                KhachHang khachang = _dalKhachHang.GetRow(maKH);
                float tong = TinhTongTien(maKH, hangmua);
                int maHD = _dalHoaDon.GetNextID();
                //them HoaDon
                _dalHoaDon.Them(new HoaDon(maHD, maKH, maNV, thoigian, tong));
                //them ChiTietHoaDon
                foreach (int maHH in hangmua.Keys)
                {
                    _dalChiTietHoaDon.Them(new ChiTietHoaDon(maHD, maHH, _dalHangHoa.GetRow(maHH).DonGia, hangmua[maHH]));
                }
                khachang.SoDiem = khachang.SoDiem + (int)tong / 100000 * 10;
                _dalKhachHang.Sua(khachang);

                MessageBox.Show("Giao dịch thành công!");
                
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}