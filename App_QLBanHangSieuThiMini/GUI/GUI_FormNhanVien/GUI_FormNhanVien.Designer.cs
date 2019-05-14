namespace App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien
{
    partial class FormBanHang
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHoaDon = new System.Windows.Forms.TabPage();
            this.guI_BanHang1 = new App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien.GUI_BanHang();
            this.tabPageKhachHang = new System.Windows.Forms.TabPage();
            this.guI_KhachHang1 = new App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien.GUI_KhachHang();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageHoaDon.SuspendLayout();
            this.tabPageKhachHang.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHoaDon);
            this.tabControl1.Controls.Add(this.tabPageKhachHang);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 695);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHoaDon
            // 
            this.tabPageHoaDon.Controls.Add(this.guI_BanHang1);
            this.tabPageHoaDon.Location = new System.Drawing.Point(4, 25);
            this.tabPageHoaDon.Name = "tabPageHoaDon";
            this.tabPageHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHoaDon.Size = new System.Drawing.Size(941, 666);
            this.tabPageHoaDon.TabIndex = 0;
            this.tabPageHoaDon.Text = "Hóa Đơn";
            this.tabPageHoaDon.UseVisualStyleBackColor = true;
            // 
            // guI_BanHang1
            // 
            this.guI_BanHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guI_BanHang1.Location = new System.Drawing.Point(3, 3);
            this.guI_BanHang1.Name = "guI_BanHang1";
            this.guI_BanHang1.Size = new System.Drawing.Size(935, 660);
            this.guI_BanHang1.TabIndex = 1;
            // 
            // tabPageKhachHang
            // 
            this.tabPageKhachHang.Controls.Add(this.guI_KhachHang1);
            this.tabPageKhachHang.Location = new System.Drawing.Point(4, 25);
            this.tabPageKhachHang.Name = "tabPageKhachHang";
            this.tabPageKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKhachHang.Size = new System.Drawing.Size(941, 666);
            this.tabPageKhachHang.TabIndex = 1;
            this.tabPageKhachHang.Text = "Khách Hàng";
            this.tabPageKhachHang.UseVisualStyleBackColor = true;
            // 
            // guI_KhachHang1
            // 
            this.guI_KhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guI_KhachHang1.Location = new System.Drawing.Point(3, 3);
            this.guI_KhachHang1.Name = "guI_KhachHang1";
            this.guI_KhachHang1.Size = new System.Drawing.Size(935, 660);
            this.guI_KhachHang1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(824, 12);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(89, 31);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvHoaDon);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 666);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Lịch sử";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(808, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(41, 79);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(856, 550);
            this.dgvHoaDon.TabIndex = 1;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 743);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.tabControl1.ResumeLayout(false);
            this.tabPageHoaDon.ResumeLayout(false);
            this.tabPageKhachHang.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHoaDon;
        private System.Windows.Forms.TabPage tabPageKhachHang;
        private GUI_BanHang guI_BanHang1;
        private GUI_KhachHang guI_KhachHang1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnRefresh;
    }
}