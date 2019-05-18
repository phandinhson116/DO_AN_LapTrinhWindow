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
        private GUI.GUI_FormNhanVien.GUI_ThongTinCaNhan guI_ThongTinCaNhan1;

        public FormNhanVien(int maNV)
        {
            _maNV = maNV;
            InitializeComponent();
            //
            // guI_BanHang1
            //     
            this.guI_BanHang1 = new App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien.GUI_BanHang(_maNV);
            this.tabPage1.Controls.Add(this.guI_BanHang1);
            this.guI_BanHang1.Location = new System.Drawing.Point(-28, 6);
            this.guI_BanHang1.Name = "guI_BanHang1";
            this.guI_BanHang1.Size = new System.Drawing.Size(1000, 800);
            this.guI_BanHang1.TabIndex = 0;
            txtMaNV.Text = _maNV.ToString();

            // 
            // guI_ThongTinCaNhan1
            // 
            this.guI_ThongTinCaNhan1 = new App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien.GUI_ThongTinCaNhan(_maNV);
            this.tabPage4.Controls.Add(this.guI_ThongTinCaNhan1);
            this.guI_ThongTinCaNhan1.Location = new System.Drawing.Point(100, 6);
            this.guI_ThongTinCaNhan1.Name = "guI_ThongTinCaNhan1";
            this.guI_ThongTinCaNhan1.Size = new System.Drawing.Size(900, 700);
            this.guI_ThongTinCaNhan1.TabIndex = 0;


        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
