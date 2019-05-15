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
    public partial class FormNhanVien : Form
    {
        int _maNV;
        private GUI_BanHang guI_BanHang1;
        public FormNhanVien(int maNV)
        {
            _maNV = maNV;
            InitializeComponent();

            this.guI_BanHang1 = new App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien.GUI_BanHang(_maNV);
            //
            // guI_BanHang1
            // 
            this.tabPage1.Controls.Add(this.guI_BanHang1);
            this.guI_BanHang1.Location = new System.Drawing.Point(-28, 6);
            this.guI_BanHang1.Name = "guI_BanHang1";
            this.guI_BanHang1.Size = new System.Drawing.Size(1000, 800);
            this.guI_BanHang1.TabIndex = 0;
            txtMaNV.Text = _maNV.ToString();
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
