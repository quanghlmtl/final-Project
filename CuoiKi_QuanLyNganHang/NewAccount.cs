using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang
{
    public partial class FormNewAccount : Form
    {
        public FormNewAccount()
        {
            InitializeComponent();
            lblNewAcc.Parent = pictureBox1;
            lblMessage.Parent = pictureBox1;
            btnHome.Parent = pictureBox1;
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Texts) || txtName.Texts == "Họ và tên")
            {
                this.lblMessage.Visible = true;
                this.lblMessage.Text = "*Please enter your name";
                txtName.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtID.Texts) || txtID.Texts == "Số CMND")
            {
                this.lblMessage.Visible = true;
                this.lblMessage.Text = "*Please enter your ID";
                txtID.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPhoneNumb.Texts) || txtPhoneNumb.Texts == "Số điện thoại")
            {
                this.lblMessage.Visible = true;
                this.lblMessage.Text = "*Please enter your phone number";
                txtPhoneNumb.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Texts) || txtUsername.Texts == "Tên tài khoản")
            {
                this.lblMessage.Visible = true;
                this.lblMessage.Text = "*Please enter your username";
                txtUsername.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword1.Texts) || txtPassword1.Texts == "Mật khẩu")
            {
                this.lblMessage.Visible = true;
                this.lblMessage.Text = "*Please enter your password";
                txtPassword1.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword2.Texts) || txtPassword2.Texts == "Nhập lại mật khẩu" )
            {
                this.lblMessage.Visible = true;
                this.lblMessage.Text = "*Please enter your password again";
                txtPassword2.Focus();
                return;
            }
            else if (txtPassword2.Texts != txtPassword1.Texts)
            {
                this.lblMessage.Visible = true;
                this.lblMessage.Text = "*Those passwords didn’t match. Try again.";
                txtPassword2.Focus();
                return;
            }
            else
            {
                lblMessage.Visible = false;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            } 
        }

        private void txtPhoneNumb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            } 
        }
        private bool isMousePressed = false;
        //Hidden password
        private void hidden1_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPassword1.Texts == "Mật khẩu")
                return;
            if (e.Button == MouseButtons.Left)
            {
                isMousePressed = false;
                txtPassword1.PasswordChar = true;
                hidden1.BringToFront();
            }
        }
        private void hidden1_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPassword1.Texts == "Mật khẩu")
                return;
            if (e.Button == MouseButtons.Left)
            {
                hidden1.SendToBack();
                txtPassword1.PasswordChar = false;
                isMousePressed = true;
            }
        }

        private void hidden2_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPassword2.Texts == "Nhập lại mật khẩu")
                return;
            if (e.Button == MouseButtons.Left)
            {
                isMousePressed = false;
                txtPassword2.PasswordChar = true;
                hidden2.BringToFront();
            }
        }

        private void hidden2_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPassword2.Texts == "Nhập lại mật khẩu")
                return;
            if (e.Button == MouseButtons.Left)
            {
                hidden2.SendToBack();
                txtPassword2.PasswordChar = false;
                isMousePressed = true;
            }
        }
        //hover password
        private void txtPassword1_Enter(object sender, EventArgs e)
        {
            if (txtPassword1.Texts == "Mật khẩu")
            {
                this.txtPassword1.Texts = "";
                txtPassword1.PasswordChar = true;
            }
        }
        private void txtPassword1_Leave(object sender, EventArgs e)
        {
            if (txtPassword1.Texts == "")
            {
                this.txtPassword1.Texts = "Mật khẩu";
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
        }

        private void FormNewAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
