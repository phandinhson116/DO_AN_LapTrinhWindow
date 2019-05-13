using App_QLBanHangSieuThiMini.BS_Player;
using System;
using System.Data;
using System.Windows.Forms;

namespace App_QLBanHangSieuThiMini
{
    public partial class FormManager : Form
    {
        private DataTable dtHangHoa = null;
        private DataTable dtNhanVien = null;
        // DataTable dtThongKeDoanhThu = null;

        private QL_HangHoa dbHH = new QL_HangHoa();
        private QL_NhanVien dbNV = new QL_NhanVien();
        private bool ThemNV;
        string err;

        private QL_ThongKeDoanhThu dbTKDT = new QL_ThongKeDoanhThu();

        public FormManager()
        {
           InitializeComponent();
        }

        #region QLNhanVien

        private void LoadDataNV()
        {
            try
            {
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                DataSet ds = dbNV.LayNhanVien();
                dtNhanVien = ds.Tables[0];
                // Dua du lieu len DataGridView
                dgvNhanVien.DataSource = dtNhanVien;
                // Thay doi do rong cot
                dgvNhanVien.AutoResizeColumns();
                // Xoa cac doi tuong trong Panel
                this.txtMaNV.ResetText();
                this.txtTenNV.ResetText();

                this.txtDiaChi.ResetText();
                this.txtSDT.ResetText();
                this.txtMatkhau.ResetText();
                this.cmbChucDanh.ResetText();
                // Khong cho thao tac tren cac nut Luu/ Huy
                this.btnLuuNV.Enabled = false;
                this.btnHuyNV.Enabled = false;

                // cho thao tac tren cac nut Them/Sua/Xoa/Thoat
                this.btnThemNV.Enabled = true;
                this.btnSuaNV.Enabled = true;

                dgvNhanVien_CellClick(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thu tu dong hien hanh
            int r = dgvNhanVien.CurrentCell.RowIndex;
            // Chuyen thong tin len Panel
            this.txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenNV.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();

            if (dgvNhanVien.Rows[r].Cells[2].Value.ToString().Trim() == "Nam")
            {
                this.rdbNam.Checked = true;
                this.rdbNu.Checked = false;
            }
            if (dgvNhanVien.Rows[r].Cells[2].Value.ToString().Trim() == "Nữ")
            {
                this.rdbNu.Checked = true;
                this.rdbNam.Checked = false;
            }

            this.txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            this.dtpNamsinh.Text= dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtSDT.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            this.txtMatkhau.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            this.cmbChucDanh.Text = dgvNhanVien.Rows[r].Cells[7].Value.ToString();
            this.txtLuong.Text = dgvNhanVien.Rows[r].Cells[8].Value.ToString();
        }

        private void btnLoadNV_Click(object sender, EventArgs e)
        {
            LoadDataNV();
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            // Kich hoat Them
            ThemNV = true;

            this.txtMaNV.ResetText();
            this.txtTenNV.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            this.rdbNam.Checked = false;
            this.rdbNu.Checked = false;
            this.txtMatkhau.ResetText();
            this.dtpNamsinh.ResetText();
            this.cmbChucDanh.ResetText();

            // Cho thao tac tren cac nut Luu/ Huy/ Thoat
            this.btnLuuNV.Enabled = true;
            this.btnHuyNV.Enabled = true;
            this.panel1.Enabled = true;
            // Khong cho thao tac tren cac nut Them/ Xoa/ Thoat
            this.btnThemNV.Enabled = false;
            this.btnSuaNV.Enabled = false;
            this.btnTrove.Enabled = false;
            // Dua con tro den TextFied txtThanhPho
            this.txtMaNV.Focus();
        }
        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            string rdbGT;
            if (rdbNam.Checked == true)
            {
                rdbGT = rdbNam.Text.Trim();
            }
            else
            {
                rdbGT = rdbNu.Text.Trim();
            }
            if (ThemNV)
            {
                try
                {
                    //Thuc hien lenh
                    QL_NhanVien qlNhanVien = new QL_NhanVien();
                    qlNhanVien.ThemNhanVien(this.txtMaNV.Text, this.txtTenNV.Text, rdbGT, this.txtDiaChi.Text, this.dtpNamsinh.Text, this.txtSDT.Text, this.txtMatkhau.Text, this.cmbChucDanh.Text, Convert.ToInt32(txtLuong.Text), ref err);
                    LoadDataNV();
                    MessageBox.Show("Da them vao !!");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                QL_NhanVien qlNhanVien = new QL_NhanVien();
                qlNhanVien.CapNhatNhanVien(this.txtMaNV.Text, this.txtTenNV.Text, rdbGT, this.txtDiaChi.Text,this.dtpNamsinh.Text, this.txtSDT.Text, this.txtMatkhau.Text, this.cmbChucDanh.Text,Convert.ToInt32(txtLuong.Text), ref err);
                LoadDataNV();
                MessageBox.Show("Đã sửa xong!!");
            }
        }
        #endregion QLNhanVien
        #region  QLHangHoa
        private void LoadDataHH()
        {
            try
            {
                dtHangHoa = new DataTable();
                dtHangHoa.Clear();
                DataSet ds = dbHH.LayHangHoa();
                dtHangHoa = ds.Tables[0];
                // Dua du lieu len DataGridView ở tabControl quản lí háng hóa
                dgvHangHoa.DataSource = dtHangHoa;
                // Thay doi do rong cot
                dgvHangHoa.AutoResizeColumns();
                // Xoa cac doi tuong trong Panel
                this.txtMaHang.ResetText();
                this.txtTenHang.ResetText();

                this.txtDVCungCap.ResetText();
                // Khong cho thao tac tren cac nut Luu/ Huy

                this.btnHuyBo.Enabled = false;
                this.panel1.Enabled = false;
                // cho thao tac tren cac nut Them/Sua/Xoa/Thoat

                this.btnTrove.Enabled = true;
                dgvHangHoa_CellClick(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataHH();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thu tu dong hien hanh
            int r = dgvHangHoa.CurrentCell.RowIndex;
            // Chuyen thong tin len Panel
            this.txtMaHang.Text = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
            this.txtTenHang.Text = dgvHangHoa.Rows[r].Cells[1].Value.ToString();

            this.txtDVCungCap.Text = dgvHangHoa.Rows[r].Cells[4].Value.ToString();
            this.dtpNgayCungCap.Text = dgvHangHoa.Rows[r].Cells[5].Value.ToString();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xoa trong cac doi tuong trong Panel
            this.txtMaHang.ResetText();
            this.txtTenHang.ResetText();

            this.txtDVCungCap.ResetText();
            this.dtpNgayCungCap.ResetText();
            // Cho Thao tac tren cac nut Them/ Xoa / Sua/ Thoat

            this.btnTrove.Enabled = true;
            //Khong cho thao tac tren cac nut Luu/ Huy/ Panel

            this.btnHuyBo.Enabled = false;
            this.panel1.Enabled = false;
            dgvHangHoa_CellClick(null, null);
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            // Khai bao bien tra loi
            DialogResult traloi;
            traloi = MessageBox.Show("Chac khong?", "Tra loi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
        }
        #endregion





    }
}