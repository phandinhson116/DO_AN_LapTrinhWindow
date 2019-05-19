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
using App_QLBanHangSieuThiMini.DAL;
using App_QLBanHangSieuThiMini.ValueObject;

namespace App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien
{
    public partial class GUI_ThongTinCaNhan : UserControl
    {
        int _maNV;
        BLL_ThongTinCaNhan bll = new BLL_ThongTinCaNhan();

        public GUI_ThongTinCaNhan(int maNV)
        {
            _maNV = maNV;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            NhanVien nv = bll.GetThongTin(_maNV);
            txtMaNV.Text = nv.MaNV.ToString();
            txtTenNV.Text = nv.TenNV;
            txtDiaChi.Text = nv.DiaChi;
            txtSDT.Text = nv.SDT;
            txtGioiTinh.Text = nv.GioiTinh;
            txtChucDanh.Text = nv.ChucDanh;
            txtMaTK.Text = _maNV.ToString();
            txtLuong.Text = nv.Luong.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nvCu = bll.GetThongTin(_maNV);
            NhanVien nvMoi = new NhanVien(
                Convert.ToInt32(txtMaNV.Text),
                txtTenNV.Text,
                txtGioiTinh.Text,
                txtDiaChi.Text,
                nvCu.MatKhau,
                nvCu.ChucDanh,
                txtSDT.Text,
                nvCu.Luong);
            if (bll.SuaThongTin(nvMoi))
                MessageBox.Show("Đã lưu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2,MessageBoxOptions.ServiceNotification);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Equals(bll.GetThongTin(_maNV).MatKhau))
            {
                if (txtMatKhauMoi.Text.Equals(txtXacNhanMatKhau.Text))
                {
                    bll.DoiMatKhau(_maNV, txtMatKhauMoi.Text);
                    MessageBox.Show("Đã đổi mật khẩu!Cảm ơn bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không khớp!Xin hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng! Xin hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            }
            txtXacNhanMatKhau.ResetText();
            txtMatKhau.ResetText();
            txtMatKhauMoi.ResetText();
        }
    }
}
