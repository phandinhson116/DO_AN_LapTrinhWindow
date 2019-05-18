namespace App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guI_KhachHang1 = new App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien.GUI_KhachHang();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guI_HoaDon1 = new App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien.GUI_HoaDon();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(798, 6);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(111, 23);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(692, 6);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 702);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa Đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.guI_KhachHang1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 673);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Khách Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // guI_KhachHang1
            // 
            this.guI_KhachHang1.Location = new System.Drawing.Point(0, -19);
            this.guI_KhachHang1.Name = "guI_KhachHang1";
            this.guI_KhachHang1.Size = new System.Drawing.Size(1000, 800);
            this.guI_KhachHang1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.guI_HoaDon1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(950, 673);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lịch Sử";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // guI_HoaDon1
            // 
            this.guI_HoaDon1.Location = new System.Drawing.Point(21, -19);
            this.guI_HoaDon1.Name = "guI_HoaDon1";
            this.guI_HoaDon1.Size = new System.Drawing.Size(900, 580);
            this.guI_HoaDon1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(950, 673);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thông TIn Cá Nhân";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 743);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangXuat);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private GUI_KhachHang guI_KhachHang1;
        private GUI_HoaDon guI_HoaDon1;
        private System.Windows.Forms.TabPage tabPage4;
    }
}