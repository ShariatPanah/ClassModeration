using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Moderation.BLL;
using Class_Moderation.DAL;

namespace ClassModeration
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ClassModerationDAL.Login(txtUser.Text.ToString(), txtPass.Text.ToString()) != 0)
            {
                frmMain Main = new frmMain();
                Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("!نام كاربري يا رمز عبور اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = txtPass.Text = string.Empty;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
