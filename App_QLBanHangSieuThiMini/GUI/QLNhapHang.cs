﻿using App_QLBanHangSieuThiMini.DAL;
using App_QLBanHangSieuThiMini.ValueObject;
using System;
using System.Data;
using System.Windows.Forms;

namespace App_QLBanHangSieuThiMini
{
    public partial class fNhapHang : Form
    {
        private bool Them;
        private DAL_HangHoa dbHH = new DAL_HangHoa();


        private GUI.GUI_FormNhanVien.GUI_ThongTinCaNhan guI_ThongTinCaNhan1;
        int _maNV;
        public fNhapHang(int maNV)
        {
            _maNV = maNV;
            InitializeComponent();

            // 
            // guI_ThongTinCaNhan1
            // 
            this.guI_ThongTinCaNhan1 = new GUI.GUI_FormNhanVien.GUI_ThongTinCaNhan(_maNV);
            this.guI_ThongTinCaNhan1.Location = new System.Drawing.Point(29, -65);
            this.guI_ThongTinCaNhan1.Name = "guI_ThongTinCaNhan1";
            this.guI_ThongTinCaNhan1.Size = new System.Drawing.Size(900, 700);
            this.guI_ThongTinCaNhan1.TabIndex = 0;
            this.tabPage2.Controls.Add(this.guI_ThongTinCaNhan1);
        }

        private void LoadData()
        {
            try
            {
                DataTable dtHangHoa = new DataTable();
                dtHangHoa.Clear();
                dtHangHoa = dbHH.GetTable();
                // Dua du lieu Hang Hóa len DataGridView
                dgvHangHoa.DataSource = dtHangHoa;
                // Thay doi do rong cot
                dgvHangHoa.AutoResizeColumns();
                // Xoa cac doi tuong trong Panel
                this.txtMaHang.ResetText();
                this.txtTenHang.ResetText();
                this.txtSoLuong.ResetText();
                this.txtDonGia.ResetText();
                this.txtDVCungCap.ResetText();
                this.dtpNgayNhapHang.ResetText();
                this.dtpNgayHetHan.ResetText();
                // Khong cho thao tac tren cac nut Luu/ Huy
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel1.Enabled = false;
                // cho thao tac tren cac nut Them/Sua/Xoa/Thoat
                this.btnAdd.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnTrove.Enabled = true;
                dgvHangHoa_CellClick(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thu tu dong hien hanh
            int r = dgvHangHoa.CurrentCell.RowIndex;
            // Chuyen thong tin len Panel
            this.txtMaHang.Text = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
            this.txtTenHang.Text = dgvHangHoa.Rows[r].Cells[1].Value.ToString();
            this.txtDonGia.Text = dgvHangHoa.Rows[r].Cells[2].Value.ToString();
            this.txtSoLuong.Text = dgvHangHoa.Rows[r].Cells[3].Value.ToString();
            this.txtDVCungCap.Text = dgvHangHoa.Rows[r].Cells[4].Value.ToString();
            this.txtSoLuongNhap.Text = dgvHangHoa.Rows[r].Cells[5].Value.ToString();
            this.txtDonGiaNhap.Text = dgvHangHoa.Rows[r].Cells[6].Value.ToString();
            this.dtpNgayNhapHang.Text = dgvHangHoa.Rows[r].Cells[7].Value.ToString().Trim();
            this.dtpNgayHetHan.Text = dgvHangHoa.Rows[r].Cells[8].Value.ToString().Trim();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kich hoat Them
            Them = true;
            // Xoa trong cac doi tuong trong Panel
            this.txtMaHang.ResetText();
            this.txtTenHang.ResetText();
            this.txtSoLuong.ResetText();
            this.txtDonGia.ResetText();
            this.txtDVCungCap.ResetText();
            this.dtpNgayNhapHang.ResetText();

            // Cho thao tac tren cac nut Luu/ Huy/ Thoat
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            // Khong cho thao tac tren cac nut Them/ Xoa/ Thoat
            this.btnAdd.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnTrove.Enabled = false;
            // Dua con tro den TextFied txtThanhPho
            this.txtMaHang.Focus();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xoa trong cac doi tuong trong Panel
            this.txtMaHang.ResetText();
            this.txtTenHang.ResetText();
            this.txtSoLuong.ResetText();
            this.txtDonGia.ResetText();
            this.txtDVCungCap.ResetText();
            this.dtpNgayNhapHang.ResetText();
            // Cho Thao tac tren cac nut Them/ Xoa / Sua/ Thoat
            this.btnAdd.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnTrove.Enabled = true;
            //Khong cho thao tac tren cac nut Luu/ Huy/ Panel
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel1.Enabled = false;
            dgvHangHoa_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    //Thuc hien lenh
                    dbHH.Them(new HangHoa(0, txtTenHang.Text, (float)Convert.ToDouble(txtDonGia.Text), Convert.ToInt32(txtSoLuong.Text), txtDVCungCap.Text, dtpNgayNhapHang.Value, dtpNgayHetHan.Value));
                    LoadData();
                    MessageBox.Show("Đã thêm vào !!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2,MessageBoxOptions.ServiceNotification);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                dbHH.Sua(new HangHoa(Convert.ToInt32(txtMaHang.Text), txtTenHang.Text, (float)Convert.ToDouble(txtDonGia.Text), Convert.ToInt32(txtSoLuong.Text), txtDVCungCap.Text, dtpNgayNhapHang.Value, dtpNgayHetHan.Value));
                LoadData();
                MessageBox.Show("Đã sửa xong!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvHangHoa.CurrentCell.RowIndex;
                string strHangHoa = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
                if (traloi == DialogResult.Yes)
                {
                    dbHH.Xoa(Convert.ToInt32(strHangHoa));
                    LoadData();
                    MessageBox.Show("Đã xóa xong!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                }
                else
                {
                    MessageBox.Show("Không thực hiện lệnh xóa! Lệnh xóa đã bị hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kich hoat bien Sua
            Them = false;
            // Cho chep thao tac tren Panel
            this.panel1.Enabled = true;
            dgvHangHoa_CellClick(null, null);
            // Cho thao tac tren cac nut Luu/ Huy/ Panel

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            // Khong cho thao tac tren cac nut Them/Xoa/ Thoat
            this.btnAdd.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTrove.Enabled = false;
            // Dua con tro den TenThanhPho
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Focus();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            // Khai bao bien tra loi
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
        }

        private void btnTrove_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
        }
    }
}