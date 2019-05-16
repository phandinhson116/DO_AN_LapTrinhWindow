using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using App_QLBanHangSieuThiMini.DAL;
using App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien;
namespace App_QLBanHangSieuThiMini
{
    public partial class FormLogin : Form
    {
        private DAL_DangNhap lg = new DAL_DangNhap();
        
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

        #endregion Watermark

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.gbDangNhap.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (lg.LogIn(this.txtAccount.Text, this.txtPassword.Text))
                {
                    case "Quản Lý":
                        {
                            FormManager fManager = new FormManager();
                            fManager.ShowDialog();
                        };
                        break;
                    case "NV Nhập Hàng":
                        {
                            Form fNhapHang = new fNhapHang();
                            fNhapHang.ShowDialog();

                        }
                        break;
                    case "NV Bán Hàng":
                        {
                            Form fNhanVien = new FormNhanVien(Convert.ToInt32(this.txtAccount.Text));
                            fNhanVien.ShowDialog();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Xin hãy nhập tài khoản hoặc mật khẩu !! ", "Thông báo");
                            txtAccount.Focus();
                            break;
                        }

                }
                
            }
            catch
            {
                MessageBox.Show("Xin hãy nhập tài khoản hoặc mật khẩu !! ", "Thông báo");
                txtAccount.Focus();
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