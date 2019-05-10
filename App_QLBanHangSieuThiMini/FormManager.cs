using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_QLBanHangSieuThiMini.BS_Player;
namespace App_QLBanHangSieuThiMini
{
    public partial class FormManager : Form
    {
        DataTable dtHangHoa = null;
        bool Them;
        string err;
        QL_HangHoa dbHH = new QL_HangHoa();
        public FormManager()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtHangHoa = new DataTable();
                dtHangHoa.Clear();
                DataSet ds = dbHH.LayHangHoa();
                dtHangHoa = ds.Tables[0];
                // Dua du lieu len DataGridView
                dgvHangHoa.DataSource = dtHangHoa;
                // Thay doi do rong cot
                dgvHangHoa.AutoResizeColumns();
                // Xoa cac doi tuong trong Panel
                this.txtMaHang.ResetText();
                this.txtTenHang.ResetText();
                this.txtSoLuong.ResetText();
                this.txtDonGia.ResetText();
                this.txtDVCungCap.ResetText();
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
            this.dtpNgayCungCap.Text = dgvHangHoa.Rows[r].Cells[5].Value.ToString();



        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvHangHoa.CurrentCell.RowIndex;
                string strHangHoa = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbHH.XoaHangHoa(ref err, strHangHoa);
                    LoadData();
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

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xoa trong cac doi tuong trong Panel
            this.txtMaHang.ResetText();
            this.txtTenHang.ResetText();
            this.txtSoLuong.ResetText();
            this.txtDonGia.ResetText();
            this.txtDVCungCap.ResetText();
            this.dtpNgayCungCap.ResetText();
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

        private void btnTrove_Click(object sender, EventArgs e)
        {
            // Khai bao bien tra loi
            DialogResult traloi;
            traloi = MessageBox.Show("Chac khong?", "Tra loi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    //Thuc hien lenh
                    QL_HangHoa qlHangHoa = new QL_HangHoa();
                    qlHangHoa.ThemHangHoa(this.txtMaHang.Text, this.txtTenHang.Text, Convert.ToInt32(this.txtSoLuong.Text), Convert.ToInt32(this.txtDonGia.Text), this.txtDVCungCap.Text, this.dtpNgayCungCap.Text, ref err);
                    LoadData();
                    MessageBox.Show("Da them vao !!");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                QL_HangHoa qlHH = new QL_HangHoa();
                qlHH.CapNhatHangHoa(this.txtMaHang.Text.Trim(), this.txtTenHang.Text.Trim(), Convert.ToInt32(this.txtDonGia.Text.Trim()), Convert.ToInt32(this.txtSoLuong.Text.Trim()), this.txtDVCungCap.Text.Trim(), this.dtpNgayCungCap.Text.Trim(), ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!!");
            }
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
            this.dtpNgayCungCap.ResetText();

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

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
