using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHang.FormQuanLi
{
    public partial class FormLogin : Form
    {
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form fManager = new FormManager();
            fManager.ShowDialog();
        }
    }
}
