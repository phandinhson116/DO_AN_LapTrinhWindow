namespace App_QLBanHangSieuThiMini
{
    partial class FormManager
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
            this.tabconNguoiQuanLy = new System.Windows.Forms.TabControl();
            this.qlbieudo = new System.Windows.Forms.TabPage();
            this.plManager = new System.Windows.Forms.Panel();
            this.lblSort = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChart = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbSold = new System.Windows.Forms.RadioButton();
            this.rbWarehouse = new System.Windows.Forms.RadioButton();
            this.rbEmployees = new System.Windows.Forms.RadioButton();
            this.tp_qlHangHoa = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnTrove = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayCungCap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDVCungCap = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_qlNhanVien = new System.Windows.Forms.TabPage();
            this.tp_qlHoaDon = new System.Windows.Forms.TabPage();
            this.tabconNguoiQuanLy.SuspendLayout();
            this.qlbieudo.SuspendLayout();
            this.plManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tp_qlHangHoa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.pnlChucNang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabconNguoiQuanLy
            // 
            this.tabconNguoiQuanLy.Controls.Add(this.qlbieudo);
            this.tabconNguoiQuanLy.Controls.Add(this.tp_qlHangHoa);
            this.tabconNguoiQuanLy.Controls.Add(this.tp_qlNhanVien);
            this.tabconNguoiQuanLy.Controls.Add(this.tp_qlHoaDon);
            this.tabconNguoiQuanLy.Location = new System.Drawing.Point(12, 12);
            this.tabconNguoiQuanLy.Name = "tabconNguoiQuanLy";
            this.tabconNguoiQuanLy.SelectedIndex = 0;
            this.tabconNguoiQuanLy.Size = new System.Drawing.Size(1148, 683);
            this.tabconNguoiQuanLy.TabIndex = 0;
            // 
            // qlbieudo
            // 
            this.qlbieudo.Controls.Add(this.plManager);
            this.qlbieudo.Location = new System.Drawing.Point(4, 25);
            this.qlbieudo.Name = "qlbieudo";
            this.qlbieudo.Padding = new System.Windows.Forms.Padding(3);
            this.qlbieudo.Size = new System.Drawing.Size(1140, 654);
            this.qlbieudo.TabIndex = 0;
            this.qlbieudo.Text = "Quản Lý Biểu Đồ";
            this.qlbieudo.UseVisualStyleBackColor = true;
            // 
            // plManager
            // 
            this.plManager.Controls.Add(this.lblSort);
            this.plManager.Controls.Add(this.comboBox1);
            this.plManager.Controls.Add(this.lblChart);
            this.plManager.Controls.Add(this.dataGridView1);
            this.plManager.Controls.Add(this.rbSold);
            this.plManager.Controls.Add(this.rbWarehouse);
            this.plManager.Controls.Add(this.rbEmployees);
            this.plManager.Location = new System.Drawing.Point(7, 7);
            this.plManager.Margin = new System.Windows.Forms.Padding(4);
            this.plManager.Name = "plManager";
            this.plManager.Size = new System.Drawing.Size(1126, 640);
            this.plManager.TabIndex = 1;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(23, 239);
            this.lblSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(117, 20);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Sắp Xếp Theo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 193);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChart.Location = new System.Drawing.Point(23, 156);
            this.lblChart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(82, 20);
            this.lblChart.TabIndex = 4;
            this.lblChart.Text = "BIỂU ĐỒ:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(914, 605);
            this.dataGridView1.TabIndex = 3;
            // 
            // rbSold
            // 
            this.rbSold.AutoSize = true;
            this.rbSold.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSold.Location = new System.Drawing.Point(16, 111);
            this.rbSold.Margin = new System.Windows.Forms.Padding(4);
            this.rbSold.Name = "rbSold";
            this.rbSold.Size = new System.Drawing.Size(85, 24);
            this.rbSold.TabIndex = 2;
            this.rbSold.TabStop = true;
            this.rbSold.Text = "Đã Bán";
            this.rbSold.UseVisualStyleBackColor = false;
            // 
            // rbWarehouse
            // 
            this.rbWarehouse.AutoSize = true;
            this.rbWarehouse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWarehouse.Location = new System.Drawing.Point(16, 69);
            this.rbWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.rbWarehouse.Name = "rbWarehouse";
            this.rbWarehouse.Size = new System.Drawing.Size(150, 24);
            this.rbWarehouse.TabIndex = 1;
            this.rbWarehouse.TabStop = true;
            this.rbWarehouse.Text = "Hàng Trong Kho";
            this.rbWarehouse.UseVisualStyleBackColor = false;
            // 
            // rbEmployees
            // 
            this.rbEmployees.AutoSize = true;
            this.rbEmployees.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmployees.Location = new System.Drawing.Point(16, 28);
            this.rbEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmployees.Name = "rbEmployees";
            this.rbEmployees.Size = new System.Drawing.Size(106, 24);
            this.rbEmployees.TabIndex = 0;
            this.rbEmployees.TabStop = true;
            this.rbEmployees.Text = "Nhân Viên";
            this.rbEmployees.UseVisualStyleBackColor = false;
            // 
            // tp_qlHangHoa
            // 
            this.tp_qlHangHoa.Controls.Add(this.groupBox1);
            this.tp_qlHangHoa.Controls.Add(this.pnlChucNang);
            this.tp_qlHangHoa.Controls.Add(this.panel1);
            this.tp_qlHangHoa.Location = new System.Drawing.Point(4, 25);
            this.tp_qlHangHoa.Name = "tp_qlHangHoa";
            this.tp_qlHangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tp_qlHangHoa.Size = new System.Drawing.Size(1140, 654);
            this.tp_qlHangHoa.TabIndex = 1;
            this.tp_qlHangHoa.Text = "Quản Lý Hàng Hóa";
            this.tp_qlHangHoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.dgvHangHoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(28, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 432);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.DonGia,
            this.SoLuong,
            this.DVCungCap,
            this.NgayNhapHang});
            this.dgvHangHoa.Location = new System.Drawing.Point(6, 27);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.Size = new System.Drawing.Size(1130, 399);
            this.dgvHangHoa.TabIndex = 3;
            this.dgvHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.FillWeight = 200F;
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 200;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 200;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 200;
            // 
            // DVCungCap
            // 
            this.DVCungCap.DataPropertyName = "DVCungCap";
            this.DVCungCap.HeaderText = "Dịch Vụ Cung Cấp";
            this.DVCungCap.Name = "DVCungCap";
            this.DVCungCap.Width = 200;
            // 
            // NgayNhapHang
            // 
            this.NgayNhapHang.DataPropertyName = "NgayNhapHang";
            this.NgayNhapHang.HeaderText = "Ngày Nhập Hàng";
            this.NgayNhapHang.Name = "NgayNhapHang";
            this.NgayNhapHang.Width = 200;
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnHuyBo);
            this.pnlChucNang.Controls.Add(this.btnTrove);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnLuu);
            this.pnlChucNang.Controls.Add(this.btnAdd);
            this.pnlChucNang.Controls.Add(this.btnReload);
            this.pnlChucNang.Controls.Add(this.button3);
            this.pnlChucNang.Location = new System.Drawing.Point(28, 146);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(1054, 85);
            this.pnlChucNang.TabIndex = 8;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(610, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 52);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuyBo.BackColor = System.Drawing.Color.Purple;
            this.btnHuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Location = new System.Drawing.Point(739, 18);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(103, 52);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // btnTrove
            // 
            this.btnTrove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrove.BackColor = System.Drawing.Color.Fuchsia;
            this.btnTrove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrove.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTrove.Location = new System.Drawing.Point(870, 18);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(103, 52);
            this.btnTrove.TabIndex = 5;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(349, 18);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 52);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(476, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 52);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(219, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReload.BackColor = System.Drawing.Color.Aqua;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(94, 18);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(103, 52);
            this.btnReload.TabIndex = 9;
            this.btnReload.Text = "ReLoad";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dtpNgayCungCap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtTenHang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDVCungCap);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.txtMaHang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 142);
            this.panel1.TabIndex = 7;
            // 
            // dtpNgayCungCap
            // 
            this.dtpNgayCungCap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayCungCap.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpNgayCungCap.CustomFormat = "";
            this.dtpNgayCungCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayCungCap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNgayCungCap.Location = new System.Drawing.Point(677, 58);
            this.dtpNgayCungCap.Name = "dtpNgayCungCap";
            this.dtpNgayCungCap.Size = new System.Drawing.Size(242, 22);
            this.dtpNgayCungCap.TabIndex = 2;
            this.dtpNgayCungCap.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Cung Cấp :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Lượng :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "DV Cung Cấp :";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(373, 55);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(145, 36);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Location = new System.Drawing.Point(132, 55);
            this.txtTenHang.Multiline = true;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(144, 36);
            this.txtTenHang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá :";
            // 
            // txtDVCungCap
            // 
            this.txtDVCungCap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDVCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDVCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVCungCap.Location = new System.Drawing.Point(677, 3);
            this.txtDVCungCap.Multiline = true;
            this.txtDVCungCap.Name = "txtDVCungCap";
            this.txtDVCungCap.Size = new System.Drawing.Size(242, 36);
            this.txtDVCungCap.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(373, 3);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(144, 36);
            this.txtDonGia.TabIndex = 1;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(132, 3);
            this.txtMaHang.Multiline = true;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(144, 36);
            this.txtMaHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Hàng :";
            // 
            // tp_qlNhanVien
            // 
            this.tp_qlNhanVien.Location = new System.Drawing.Point(4, 25);
            this.tp_qlNhanVien.Name = "tp_qlNhanVien";
            this.tp_qlNhanVien.Size = new System.Drawing.Size(1140, 654);
            this.tp_qlNhanVien.TabIndex = 2;
            this.tp_qlNhanVien.Text = "Quản lý Nhân Viên";
            this.tp_qlNhanVien.UseVisualStyleBackColor = true;
            // 
            // tp_qlHoaDon
            // 
            this.tp_qlHoaDon.Location = new System.Drawing.Point(4, 25);
            this.tp_qlHoaDon.Name = "tp_qlHoaDon";
            this.tp_qlHoaDon.Size = new System.Drawing.Size(1140, 654);
            this.tp_qlHoaDon.TabIndex = 3;
            this.tp_qlHoaDon.Text = "Quản lý Hóa Đơn";
            this.tp_qlHoaDon.UseVisualStyleBackColor = true;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 730);
            this.Controls.Add(this.tabconNguoiQuanLy);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManager";
            this.Text = "Quản lý";
            this.tabconNguoiQuanLy.ResumeLayout(false);
            this.qlbieudo.ResumeLayout(false);
            this.plManager.ResumeLayout(false);
            this.plManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tp_qlHangHoa.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.pnlChucNang.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabconNguoiQuanLy;
        private System.Windows.Forms.TabPage qlbieudo;
        private System.Windows.Forms.Panel plManager;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblChart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbSold;
        private System.Windows.Forms.RadioButton rbWarehouse;
        private System.Windows.Forms.RadioButton rbEmployees;
        private System.Windows.Forms.TabPage tp_qlHangHoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapHang;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDVCungCap;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tp_qlNhanVien;
        private System.Windows.Forms.TabPage tp_qlHoaDon;
    }
}