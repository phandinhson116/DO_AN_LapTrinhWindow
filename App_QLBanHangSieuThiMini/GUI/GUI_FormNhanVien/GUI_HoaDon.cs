using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_QLBanHangSieuThiMini.BLL;
namespace App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien
{
    public partial class GUI_HoaDon : UserControl
    {
        BLL_HoaDon bll = new BLL_HoaDon();

        public GUI_HoaDon()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvHoaDon.DataSource = bll.GetHoaDon(txtMaHD.Text.Trim(), txtMaKH.Text.Trim(), txtMaNV.Text.Trim());
            dgvHoaDon.AutoResizeColumns();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvChiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvChiTietHD.DataSource = bll.GetChiTietHoaDon(Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells[0].Value));
                dgvChiTietHD.AutoResizeColumns();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}