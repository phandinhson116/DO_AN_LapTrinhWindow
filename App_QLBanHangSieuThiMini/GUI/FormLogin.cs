using App_QLBanHangSieuThiMini.DAL;
using App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien;
using System;
using System.Drawing;
using System.Windows.Forms;
using App_QLBanHangSieuThiMini.BLL;
namespace App_QLBanHangSieuThiMini
{
    public partial class FormLogin : Form
    {
        BLL_DangNhap bll = new BLL_DangNhap();

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
            Form newForm = null;
            try
            {
                switch (bll.GetChucDanh(Convert.ToInt32(this.txtAccount.Text), this.txtPassword.Text))
                {
                    case "Quản Lý":
                        {
                            newForm = new FormManager(Convert.ToInt32(this.txtAccount.Text));
                        };
                        break;

                    case "NV Nhập Hàng":
                        {
                            newForm = new fNhapHang(Convert.ToInt32(this.txtAccount.Text));
                        }
                        break;

                    case "NV Bán Hàng":
                        {
                            newForm = new FormNhanVien(Convert.ToInt32(this.txtAccount.Text));
                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, MessageBoxOptions.ServiceNotification); ;
                            txtAccount.Focus();
                            break;
                        }
                }
            }
            catch
            {
                MessageBox.Show("Xin hãy nhập tài khoản hoặc mật khẩu !! ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, MessageBoxOptions.ServiceNotification);
                txtAccount.Focus();
            }
            if (newForm != null)
            {
                newForm.FormClosed += (s, eva) => this.Show();
                this.Hide();
                newForm.ShowDialog();
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