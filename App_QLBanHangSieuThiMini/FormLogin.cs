using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBanHangSieuThiMini
{
    public partial class FormLogin : Form
    {
        string ConnStr= "Data Source=DESKTOP-LRIE6A1;Initial Catalog=QL_BanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader data = null;
        public FormLogin()
        {
            InitializeComponent();
            //Watermark
            txtAccount.Text = "Enter Your ID";
            txtAccount.ForeColor = Color.Silver;
            txtPassword.Text = "Enter Password";
            txtPassword.ForeColor = Color.Silver;
        }

        #region Watermark
        private void txtAccount_Leave(object sender, EventArgs e)
        {
            if (txtAccount.Text == "")
            {
                txtAccount.Text = "Enter Your ID";
                txtAccount.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtAccount_Enter(object sender, EventArgs e)
        {
            if (txtAccount.Text == "Enter Your ID")
            {
                txtAccount.Text = "";
                txtAccount.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }
        #endregion

       

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.gbDangNhap.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnStr);
            try
            {
                conn.Open();
                string account = txtAccount.Text;
                string pass = txtPassword.Text;

                string sql= "Select MaNV,MatKhau From NhanVien where MaNV='" + account + "'and MatKhau='" + pass + "'";
                cmd = new SqlCommand(sql, conn);
                data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    Form fManager = new FormManager();
                    fManager.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!",
                    "Thông báo");
                    txtAccount.Focus();
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
          
        }
    }
}
