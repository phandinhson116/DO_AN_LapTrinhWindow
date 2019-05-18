using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_QLBanHangSieuThiMini.DAL;
using App_QLBanHangSieuThiMini.ValueObject;

namespace App_QLBanHangSieuThiMini.BLL
{
    class BLL_DangNhap
    {
        DAL_NhanVien dal = new DAL_NhanVien();
        
        public string GetChucDanh(int manv,string matkhau)
        {
            NhanVien nv=dal.GetRow(manv);
            if (nv != null && nv.MatKhau.Equals(matkhau))
            {
                return nv.ChucDanh;
            }
            else
                return string.Empty;
        } 
    }
}
