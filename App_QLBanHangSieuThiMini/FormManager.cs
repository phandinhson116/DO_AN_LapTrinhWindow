
using App_QLBanHangSieuThiMini.DAL;
using App_QLBanHangSieuThiMini.ValueObject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App_QLBanHangSieuThiMini
{
    public partial class FormManager : Form
    {
        private DAL_HangHoa dbHH = new DAL_HangHoa();
        private DAL_NhanVien dbNV = new DAL_NhanVien();
        private DAL_ThongKeDoanhThu dbTKDT = new DAL_ThongKeDoanhThu();
        private bool ThemNV;



        public FormManager()
        {
            InitializeComponent();
        }

        #region ThongKeDoanhThu

        private void radioButtonSalaryOfEmployee_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dtTKDT = new DataTable();
            dtTKDT.Clear();
            dtTKDT = dbTKDT.SalaryOfEmployee();
            dgvThongKeDoanhThu.DataSource = dtTKDT;
        }

        private void radioButtonGoodsEntered_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dtTKDT = new DataTable();
            dtTKDT.Clear();
            dtTKDT = dbTKDT.GoodsEntered();

            dgvThongKeDoanhThu.DataSource = dtTKDT;
        }

        private void radioButtonIncome_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dtTKDT = new DataTable();
            dtTKDT.Clear();
            dtTKDT = dbTKDT.Income();
            dgvThongKeDoanhThu.DataSource = dtTKDT;
        }

        #endregion
        #region QLNhanVien

        private void LoadDataNV()
        {
            try
            {
                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = dbNV.GetTable();
                // Dua du lieu len DataGridView
                dgvNhanVien.DataSource = dtNhanVien;
                // Thay doi do rong cot
                dgvNhanVien.AutoResizeColumns();
               
                this.txtMaNV.ResetText();
                this.txtTenNV.ResetText();

                this.txtDiaChi.ResetText();

                this.txtSDT.ResetText();
                this.txtMatkhau.ResetText();
                this.cmbChucDanh.ResetText();
                this.txtLuong.ResetText();
                // Khong cho thao tac tren cac nut Luu/ Huy
                this.btnLuuNV.Enabled = false;
                this.btnHuyNV.Enabled = false;
                pnlTTNhanVien.Enabled = false;
                // cho thao tac tren cac nut Them/Sua/Xoa/Thoat
                this.btnThemNV.Enabled = true;
                this.btnSuaNV.Enabled = true;
                this.txtMaNV.Enabled = false;
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
            this.txtSDT.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtMatkhau.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            this.cmbChucDanh.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            this.txtLuong.Text = dgvNhanVien.Rows[r].Cells[7].Value.ToString();
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
            //this.dtpNamsinh.ResetText();
            this.cmbChucDanh.ResetText();

            // Cho thao tac tren cac nut Luu/ Huy/ Thoat
            this.btnLuuNV.Enabled = true;
            this.btnHuyNV.Enabled = true;
            pnlTTNhanVien.Enabled = true;
            // Khong cho thao tac tren cac nut Them/ Xoa/ Thoat
            this.btnThemNV.Enabled = false;
            this.btnSuaNV.Enabled = false;
          

            // Dua con tro den txtTenNV
            this.txtMaNV.Enabled = false;
            this.txtTenNV.Focus();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            ThemNV = false;

            // Cho chep thao tac tren Panel

            dgvNhanVien_CellClick(null, null);
            // Cho thao tac tren cac nut Luu/ Huy/ Panel

            this.btnLuuNV.Enabled = true;
            this.btnHuyNV.Enabled = true;
            pnlTTNhanVien.Enabled = true;
            // Khong cho thao tac tren cac nut Them/Xoa/ Thoat
            this.btnThemNV.Enabled = false;
            this.btnSuaNV.Enabled = false;
            this.btnXoaNV.Enabled = false;

            // Dua con tro den TenNV
            this.txtMaNV.Enabled = false;
            this.txtTenNV.Focus();
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
                    dbNV.Them(new NhanVien(0, txtTenNV.Text.Trim(), rdbGT, txtDiaChi.Text.Trim(), txtMatkhau.Text.Trim(), cmbChucDanh.Text.Trim(), txtSDT.Text.Trim(), Convert.ToInt32(txtLuong.Text)));
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
                dbNV.Sua(new NhanVien(Convert.ToInt32(txtMaNV.Text), txtTenNV.Text.Trim(), rdbGT, txtDiaChi.Text.Trim(), txtMatkhau.Text.Trim(), cmbChucDanh.Text.Trim(), txtSDT.Text.Trim(), Convert.ToInt32(txtLuong.Text)));
                LoadDataNV();
                MessageBox.Show("Đã sửa xong!!");
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNhanVien.CurrentCell.RowIndex;
                string strNhanVien = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbNV.Xoa(Convert.ToInt32(strNhanVien));
                    LoadDataNV();
                    MessageBox.Show("Đã xóa xong!!!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện lệnh xóa! Lệnh xóa đã bị hủy!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnHuyNV_Click(object sender, EventArgs e)
        {

        }
        #endregion QLNhanVien

        #region QLHangHoa



        private void btnReload_Click(object sender, EventArgs e)
        {
            DataTable dtHangHoa = new DataTable();
            dtHangHoa.Clear();
            dtHangHoa = dbHH.GetTable();
            // Dua du lieu Hang Hóa len DataGridView
            dgvHangHoa.DataSource = dtHangHoa;
            // Thay doi do rong cot
            dgvHangHoa.AutoResizeColumns();
        }

        

      
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTimKiem = new DataTable();
                dtTimKiem.Clear();
                if(cmbMucTimKiem.SelectedIndex==0)
                {
                    dtTimKiem = dbHH.TimKiemMaHH(Convert.ToInt32(txtTimKiem.Text));
                    // Dua du lieu Hang Hóa len DataGridView
                    dgvHangHoa.DataSource = dtTimKiem;
                    // Thay doi do rong cot
                    dgvHangHoa.AutoResizeColumns();
                }
                else if (cmbMucTimKiem.SelectedIndex == 1)
                {
                    dtTimKiem = dbHH.TimKiemTenHH(txtTimKiem.Text);
                    // Dua du lieu Hang Hóa len DataGridView
                    dgvHangHoa.DataSource = dtTimKiem;
                    // Thay doi do rong cot
                    dgvHangHoa.AutoResizeColumns();
                }
                else if(cmbMucTimKiem.SelectedIndex==2)
                {
                    dtTimKiem = dbHH.TimKiemDVCungCap(txtTimKiem.Text);
                    // Dua du lieu Hang Hóa len DataGridView
                    dgvHangHoa.DataSource = dtTimKiem;
                    // Thay doi do rong cot
                    dgvHangHoa.AutoResizeColumns();
                }
                else if(cmbMucTimKiem.SelectedIndex ==3)
                {
                 
                    dtTimKiem = dbHH.TimKiemSPHetHan();
                    // Dua du lieu Hang Hóa len DataGridView
                    dgvHangHoa.DataSource = dtTimKiem;
                    // Thay doi do rong cot
                    dgvHangHoa.AutoResizeColumns();
                }
                else if (cmbMucTimKiem.SelectedIndex == 4)
                {

                    dtTimKiem = dbHH.TimKiemSPConHan();
                    // Dua du lieu Hang Hóa len DataGridView
                    dgvHangHoa.DataSource = dtTimKiem;
                    // Thay doi do rong cot
                    dgvHangHoa.AutoResizeColumns();
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
     
       
           
           

        }
        private void cmbMucTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMucTimKiem.SelectedIndex == 3|| cmbMucTimKiem.SelectedIndex == 4)
            {
                txtTimKiem.Enabled = false;

            }
            else
            {
                txtTimKiem.Enabled = true;
            }





            #endregion QLHangHoa

        }

        
    }
}