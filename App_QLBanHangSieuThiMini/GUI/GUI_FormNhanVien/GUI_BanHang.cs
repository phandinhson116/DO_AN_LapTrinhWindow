﻿using System;
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
    public partial class GUI_BanHang : UserControl
    {
        int _maNV;
        BLL_BanHang bll = new BLL_BanHang();
        Dictionary<int, int> hangmua = new Dictionary<int, int>();


        public GUI_BanHang(int maNV)
        {
            _maNV = maNV;
            InitializeComponent();
            LoadData();
            btnMoi_Click(btnMoi, null);
          
        }

        private void LoadData()
        {
            dgvHang.DataSource = bll.GetHangHoa(txtMaHH.Text, txtTenHH.Text);
            dgvHang.AutoResizeColumns();

            dgvHangMua.DataSource = bll.GetTableHangMua(hangmua);
            dgvHangMua.AutoResizeColumns();
            if (string.IsNullOrEmpty(txtMaKH.Text.Trim()))
                txtTong.Text = bll.TinhTongTien(hangmua).ToString();
            else
                txtTong.Text = bll.TinhTongTien(Convert.ToInt32(txtMaKH.Text), hangmua).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                hangmua[Convert.ToInt32(txtMaHH.Text)] = Convert.ToInt32(numSoLuong.Value);
                LoadData();
                txtMaHH.ResetText();
                txtTenHH.ResetText();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hangmua.Remove(Convert.ToInt32(txtMaHH.Text));
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hangmua[Convert.ToInt32(txtMaHH.Text)] = Convert.ToInt32(numSoLuong.Value);
            LoadData();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.ResetText();
            txtMaHD.Text = bll.GetMaHDMoi().ToString();
            hangmua = new Dictionary<int, int>();
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHH.TextChanged -= txtMaHH_TextChanged;
            txtMaHH.TextChanged -= txtTenHH_TextChanged;
            txtMaHH.Text = dgvHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenHH.Text = dgvHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaHH.TextChanged += txtMaHH_TextChanged;
            txtMaHH.TextChanged += txtTenHH_TextChanged;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(string.Format("Tổng số tiền của quý khách là {0} VND. Xin cảm ơn quý khách đã mua hàng!", bll.TinhTongTien(Convert.ToInt32(txtMaKH.Text), hangmua)), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification); ;
                bll.MuaHang(_maNV, Convert.ToInt32(txtMaKH.Text.Trim()), DateTime.Now, hangmua);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTenHH_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}