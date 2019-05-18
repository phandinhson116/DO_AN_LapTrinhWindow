using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_QLBanHangSieuThiMini.DAL;

namespace App_QLBanHangSieuThiMini.BLL
{
    internal class BLL_ThongKeDoanhThu
    {
        DAL_ThongKeDoanhThu _dal = new DAL_ThongKeDoanhThu();

        public int TotalRevenue(int Month, int Year)
        {
            return _dal.TotalRevenue(Month, Year);
        }

        public int TotalExpenditure(int Month, int Year)
        {
            return _dal.TotalExpenditure(Month, Year);
        }
    }
}
