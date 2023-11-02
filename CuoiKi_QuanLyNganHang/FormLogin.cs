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
using CuoiKi_QuanLyNganHang.MoreForm;
using CuoiKi_QuanLyNganHang.Sql;
namespace CuoiKi_QuanLyNganHang
{
    public partial class FormLogin : Method
    {
        public FormLogin()
        {
            InitializeComponent();
        }
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

        //Methods
        bool checkLogin(string tk, string mk)
        {
            return LoginToFormMain.Instance.LoginFormMain(tk, mk);
        }

        private string[] listSTR = new string[] { };
        private string name = "";
        private void Login()
        {
            
            string tk = txtUser.Texts;
            string mk = txtPassword.Texts;
            string id = "";
            if (checkLogin(tk, mk))
            {
                listSTR = LoginToFormMain.Instance.GetNameAndIdFromDatabase(tk);
                name = listSTR[0];
                id = listSTR[1];
                FormMain formMain = new FormMain(tk, name, id);
                this.Hide();
                formMain.ShowDialog();
            }
            else if (CheckNullOrWhiteSpace(txtUser, lblMessage, "Tên đăng nhập", "username")) return;
            else if (CheckNullOrWhiteSpace(txtPassword, lblMessage, "Mật khẩu", "password")) return;
            else
            {
                this.lblMessage.Text = "*Incorrect username or password";
                this.lblMessage.Visible = true;
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

        //Event toolboxes

        //Check login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        //Hidden password
        private void Hidden_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouesUpActions(sender, e, txtPassword, "Mật khẩu");
        }
        private void Hidden_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDownActions(sender, e, txtPassword, "Mật khẩu");
        }

        //Hover username, password 
        private void txtUser_Enter(object sender, EventArgs e)
        {
            HandleEnter(sender, e, txtUser, "Tên đăng nhập", false);
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            HandleEnter(sender, e, txtPassword, "Mật khẩu", true);
        }
        private void FormLogin_Leave(object sender, EventArgs e)
        {
            HandleLeave(sender, e, txtUser, "Tên đăng nhập", false);
            HandleLeave(sender, e, txtPassword, "Mật khẩu", true);
        }

        //Show form ForgetPassword, NewAccount
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

        //Event form
        //Close form
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
