namespace App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien
{
    partial class GUI_BanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHangMua = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.gpbHangHoa = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangMua)).BeginInit();
            this.gpbHangHoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHang
            // 
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Location = new System.Drawing.Point(16, 39);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowTemplate.Height = 24;
            this.dgvHang.Size = new System.Drawing.Size(462, 450);
            this.dgvHang.TabIndex = 41;
            this.dgvHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHang_CellClick);
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(196, 115);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(150, 22);
            this.txtTenHH.TabIndex = 52;
            this.txtTenHH.TextChanged += new System.EventHandler(this.txtTenHH_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(74, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Tên Hàng";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(572, 370);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 44);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.Location = new System.Drawing.Point(572, 442);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(85, 44);
            this.btnMoi.TabIndex = 49;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(572, 297);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 44);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(196, 87);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(150, 22);
            this.txtMaHH.TabIndex = 47;
            this.txtMaHH.TextChanged += new System.EventHandler(this.txtMaHH_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Mã Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Số Lượng";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(196, 143);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(150, 22);
            this.numSoLuong.TabIndex = 44;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(572, 230);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 44);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTong);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(678, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 642);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHangMua);
            this.groupBox2.Location = new System.Drawing.Point(9, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 371);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // dgvHangMua
            // 
            this.dgvHangMua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHangMua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangMua.Location = new System.Drawing.Point(17, 39);
            this.dgvHangMua.Name = "dgvHangMua";
            this.dgvHangMua.RowTemplate.Height = 24;
            this.dgvHangMua.Size = new System.Drawing.Size(379, 323);
            this.dgvHangMua.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(301, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "VND";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.Location = new System.Drawing.Point(158, 536);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(128, 59);
            this.btnThanhToan.TabIndex = 20;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKH.Location = new System.Drawing.Point(255, 55);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(150, 22);
            this.txtMaKH.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(255, 27);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(150, 22);
            this.txtMaHD.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng";
            // 
            // txtTong
            // 
            this.txtTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTong.Enabled = false;
            this.txtTong.Location = new System.Drawing.Point(145, 508);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(150, 22);
            this.txtTong.TabIndex = 10;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgay.Enabled = false;
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(255, 86);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(150, 22);
            this.dtpNgay.TabIndex = 5;
            // 
            // gpbHangHoa
            // 
            this.gpbHangHoa.Controls.Add(this.dgvHang);
            this.gpbHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbHangHoa.Location = new System.Drawing.Point(70, 191);
            this.gpbHangHoa.Name = "gpbHangHoa";
            this.gpbHangHoa.Size = new System.Drawing.Size(478, 525);
            this.gpbHangHoa.TabIndex = 55;
            this.gpbHangHoa.TabStop = false;
            this.gpbHangHoa.Text = "Hàng Hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(818, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 56;
            this.label4.Text = "HÓA ĐƠN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 29);
            this.label8.TabIndex = 56;
            this.label8.Text = "HÀNG HÓA";
            // 
            // GUI_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbHangHoa);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.btnThem);
            this.Name = "GUI_BanHang";
            this.Size = new System.Drawing.Size(1471, 800);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangMua)).EndInit();
            this.gpbHangHoa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgvHangMua;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gpbHangHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}
