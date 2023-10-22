using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.MoreForm;
namespace CuoiKi_QuanLyNganHang
{
    public partial class FormNewAccount : Method
    {
        public FormNewAccount()
        {
            InitializeComponent();
            lblNewAcc.Parent = pictureBox1;
            lblMessage.Parent = pictureBox1;
            btnHome.Parent = pictureBox1;
        }

        //Event toolboxs

        private void btnCreate_Click(object sender, EventArgs e)
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

        //Hidden password
        private void hidden1_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouesUpActions(sender, e, txtPassword1, "Mật khẩu");
        }
        private void hidden1_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDownActions(sender, e, txtPassword1, "Mật khẩu");
        }
        private void hidden2_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouesUpActions(sender, e, txtPassword2, "Nhập lại mật khẩu");
        }
        private void hidden2_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDownActions(sender, e, txtPassword2, "Nhập lại mật khẩu");
        }

        //Hover password
        private void txtPassword1_Enter(object sender, EventArgs e)
        {
           
        }
        private void txtPassword1_Leave(object sender, EventArgs e)
        {

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

        private void txtName_Leave(object sender, EventArgs e)
        {

            if (this.txtName.Texts == "")
            {
               
                this.txtName.Texts = "Họ và tên";
            }
            if (txtID.Texts == "")
            {
               
                this.txtID.Texts = "Số CCCD";
       
            }
            if (this.txtPhoneNumb.Texts == "")
            {
               
                this.txtPhoneNumb.Texts = "Số điện thoại";
             
            }
            if (this.txtUsername.Texts == "")
            {
            
                txtUsername.Texts = "Tên tài khoản";
               
            }
            if (this.txtPassword1.Texts == "")
            {
                
                txtPassword1.Texts = "Tên tài khoản";

            }
            if (this.txtPassword2.Texts == "")
            {
               
                txtPassword2.Texts = "Tên tài khoản";

            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Texts == "Họ và tên")
            txtName.Texts = "";
        }

        private void txtName_MouseDown(object sender, MouseEventArgs e)
        {
            
            txtName.Texts = "";
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Texts == "Số CMND")
                txtID.Texts = "";
            else txtID.Texts = "";
           
        }

        private void txtPhoneNumb_Enter(object sender, EventArgs e)
        {
            if(txtPhoneNumb.Texts=="Số điện thoại")
            this.txtPhoneNumb.Texts = "";
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Texts=="Tên tài khoản")
            this.txtUsername.Texts = "";
        }

        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            this.txtPassword2.Texts = "";
        }

        private void txtPassword1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
