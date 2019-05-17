using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_QLBanHangSieuThiMini.BLL;
namespace App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien
{
    public partial class GUI_BanHang : UserControl
    {
        int _maNV;
        BLL_BanHang bll = new BLL_BanHang();
        Dictionary<int, int> hangmua = new Dictionary<int, int>();


        public GUI_BanHang(int maNV)
        {
            _maNV = maNV;
            InitializeComponent();
            LoadData();
            btnMoi_Click(btnMoi, null);
        }

        private void LoadData()
        {
            dgvHang.DataSource = bll.GetHangHoa((string.IsNullOrEmpty(txtMaHH.Text.Trim())) ? 0 : Convert.ToInt32(txtMaHH.Text), txtTenHH.Text);
            dgvHang.AutoResizeColumns();

            dgvHangMua.DataSource = bll.GetTableHangMua(hangmua);
            dgvHangMua.AutoResizeColumns();

            txtTong.Text = bll.TinhTongTien(hangmua).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hangmua[Convert.ToInt32(txtMaHH.Text)] = Convert.ToInt32(numSoLuong.Value);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hangmua.Remove(Convert.ToInt32(txtMaHH.Text));
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hangmua[Convert.ToInt32(txtMaHH.Text)] = Convert.ToInt32(numSoLuong.Value);
            LoadData();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.ResetText();
            txtMaHD.Text = bll.GetMaHDMoi().ToString();
            hangmua = new Dictionary<int, int>();
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHH.TextChanged -= txtMaHH_TextChanged;
            txtMaHH.TextChanged -= txtTenHH_TextChanged;
            txtMaHH.Text = dgvHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenHH.Text = dgvHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaHH.TextChanged += txtMaHH_TextChanged;
            txtMaHH.TextChanged += txtTenHH_TextChanged;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Tổng số tiền của bạn la {0}.Cảm ơn đã mua hàng của chúng tôi!", bll.TinhTongTien(hangmua)));
            bll.MuaHang(_maNV, Convert.ToInt32(txtMaKH.Text.Trim()), DateTime.Now, hangmua);
        }

        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTenHH_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}