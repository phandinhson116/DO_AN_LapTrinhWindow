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
using App_QLBanHangSieuThiMini.ValueObject;

namespace App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien
{
    public partial class GUI_KhachHang : UserControl
    {
        BLL_KhachHang bll = new BLL_KhachHang();

        public GUI_KhachHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvKhachHang.DataSource = bll.GetKhachHang();
            dgvKhachHang.AutoResizeColumns();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtDiem.Text = "0";
            cbGioiTinh.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bll.ThemKhachHang(new KhachHang(0,
                txtTenKH.Text.Trim(),
                txtSDT.Text.Trim(),
                cbGioiTinh.Items[cbGioiTinh.SelectedIndex].ToString().Trim(),
                txtDiaChi.Text.Trim(),
                0));
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bll.XoaKhachHang(Convert.ToInt32(txtMaKH.Text));
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bll.SuaKhachHang(new KhachHang(Convert.ToInt32(txtMaKH.Text),
                txtTenKH.Text.Trim(),
                txtSDT.Text.Trim(),
                cbGioiTinh.Items[cbGioiTinh.SelectedIndex].ToString().Trim(),
                txtDiaChi.Text.Trim(),
                0));
            LoadData();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            switch (dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString().Trim())
            {
                case "Nam":
                    cbGioiTinh.SelectedIndex = 0;
                    break;
                case "Nữ":
                    cbGioiTinh.SelectedIndex = 1;
                    break;
                default:
                    cbGioiTinh.SelectedIndex = 2;
                    break;
            }
            txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDiem.Text = dgvKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}