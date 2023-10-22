using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.Class;

namespace CuoiKi_QuanLyNganHang
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        string strMK = "Mật khẩu";
        string strTK = "Tên đăng nhập";

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txtUser.Texts = "Tên đăng nhập";
            txtPassword.Texts = "Mật khẩu";
            lblTitle.Parent = pictureBox1;
            lblMessage.Parent = pictureBox1;
            lblLogin.Parent = pictureBox1;
            lsForgetPassword.Parent = pictureBox1;
            lsNewAccout.Parent = pictureBox1;
        }

        //methods
        private void Login()
        {
            if (string.IsNullOrWhiteSpace(txtUser.Texts) || txtUser.Texts == "Tên đăng nhập")
            {
                this.lblMessage.Visible = true;
                this.lblMessage.Text = "*Please enter your username";
                txtUser.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Texts) || txtPassword.Texts == "Mật khẩu")
            {
                this.lblMessage.Text = "*Please enter your password";
                this.lblMessage.Visible = true;
                txtPassword.Focus();
                return;
            }
            else
            {
                ur ur = new ur().Login(this.txtUser.Texts, this.txtPassword.Texts);
                if (ur != null)
                {
                    MainForm mainForm = new MainForm(ur);
                    mainForm.Show();
                    base.Hide();
                    //mainForm.FormClosed += this.MainForm_Logout;
                }
                else
                {
                    this.lblMessage.Text = "*Incorrect username or password";
                    this.lblMessage.Visible = true;
                }
            }
        }
        private void Logout()
        {
            this.txtPassword.ClearTextBox();
            this.txtUser.ClearTextBox();
            this.lblMessage.Visible = false;
            this.lblLogin.Select();
            base.Show();
        }
        private bool isMousePressed = false;

        //Hidden Password
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPassword.Texts == "Mật khẩu")
                return;
            if (e.Button == MouseButtons.Left)
            {
                isMousePressed = false;
                txtPassword.PasswordChar = true;
                hidden.BringToFront();
            }
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPassword.Texts == "Mật khẩu")
                return;
            if (e.Button == MouseButtons.Left)
            {
                hidden.SendToBack();
                txtPassword.PasswordChar = false;
                isMousePressed = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Login();
        }
        //handle place holder username, password 

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Texts == "Tên đăng nhập")
            {
                this.txtUser.Texts = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Texts == "")
            {
                this.txtUser.Texts = "Tên đăng nhập";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Texts == "Mật khẩu")
            {
                this.txtPassword.Texts = "";
                txtPassword.PasswordChar = true;
               
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Texts == "")
            {
                this.txtPassword.Texts = "Mật khẩu";
                txtPassword.PasswordChar = false;
            }
            else if (txtPassword.Texts != "Mật khẩu")
            {
                txtPassword.PasswordChar = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.Login();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void lsForgetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            this.Hide();
            resetPassword.ShowDialog();
        }

        private void lsNewAccout_Click(object sender, EventArgs e)
        {
            FormNewAccount newAccount = new FormNewAccount();
            this.Hide();
            newAccount.ShowDialog();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
