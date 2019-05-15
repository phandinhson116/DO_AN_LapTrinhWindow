using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = new DAL.DAL_HoaDon().GetTable();
        }
    }
}
