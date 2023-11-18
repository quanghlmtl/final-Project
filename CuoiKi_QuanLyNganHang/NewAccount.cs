using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.MoreForm;
using CuoiKi_QuanLyNganHang.Class;
using CuoiKi_QuanLyNganHang.Sql;
namespace CuoiKi_QuanLyNganHang
{
    public partial class FormNewAccount : Method
    {
        static int i = 2004;
        static int tk = 653170845;
        DateTime datetime = DateTime.Now;
        public FormNewAccount()
        {
            InitializeComponent();
            lblNewAcc.Parent = pictureBox1;
            lblMessage.Parent = pictureBox1;
            btnHome.Parent = pictureBox1;
            CenterToScreen();
        }

        public void HideHomeButton()
        {
            btnHome.Visible = false;
        }
        //Event toolboxs
        //Button click
        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            if ( CheckNullOrWhiteSpace(txtName, lblMessage, "Họ và tên", "full name"))
                return;
            else if ( CheckNullOrWhiteSpace(txtCCCD, lblMessage, "Số CCCD", "citizen identification"))
                return;
            else if (CheckNullOrWhiteSpace(txtPhoneNumb, lblMessage, "Số điện thoại", "phone number"))
                return;
            else if (CheckNullOrWhiteSpace(txtUsername, lblMessage, "Tên tài khoản", "username"))
                return;
            else if (CheckNullOrWhiteSpace(txtPassword1, lblMessage, "Mật khẩu", "password"))
                return;
            else if (CheckNullOrWhiteSpace(txtPassword2, lblMessage, "Nhập lại mật khẩu", "password again"))
                return;
            if (txtPassword2.Texts != txtPassword1.Texts)
            {
                this.lblMessage.Visible = true;
                this.lblMessage.Text = "*Those passwords didn’t match. Try again.";
                txtPassword2.Focus();
                return;
            }
            else
            {
                lblMessage.Visible = false;
                //if (checkadd() == true)
                //{
                checkadd();
                MessageBox.Show("Thêm tài khoản thành công");
                FormLogin flg = new FormLogin();
                this.Hide();
                flg.ShowDialog();
                //}
                //else MessageBox.Show("Không thể thêm tài khoản");
                
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

        //Hover username, password 
        private void NewAccount_Enter(object sender, EventArgs e)
        {
            if (sender == txtName)
            {
                HandleEnter(sender, e, txtName, "Họ và tên", false);
                return;
            }
            else if (sender == txtCCCD)
            {
                HandleEnter(sender, e, txtCCCD, "Số CCCD", false);
                return;
            }
            else if (sender == txtPhoneNumb)
            {
                HandleEnter(sender, e, txtPhoneNumb, "Số điện thoại", false);
                return;
            }
            else if (sender == txtUsername)
            {
                HandleEnter(sender, e, txtUsername, "Tên tài khoản", false);
                return;
            }
        }
        private void txtPassword1_Enter(object sender, EventArgs e)
        {
            HandleEnter(sender, e, txtPassword1, "Mật khẩu", true);
        }
        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            HandleEnter(sender, e, txtPassword2, "Nhập lại mật khẩu", true);
        }
        private void NewAccount_Leave(object sender, EventArgs e)
        {
            HandleLeave(sender, e, txtName, "Họ và tên", false);
            HandleLeave(sender, e, txtPassword1, "Mật khẩu", true);
            HandleLeave(sender, e, txtPassword2, "Nhập lại mật khẩu", true);
        }

        //Btn home
        private void btnHome_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
        }

        //Event form
        //Close form
        private void FormNewAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void checkadd()
        {
            string query = "[dbo].[add_account] @name, @cccd, @phone, @user, @pass, @id, @date, @loaitk,@bank,@stk,@sodutk";
            string name = txtName.Texts;
            string cccd = txtCCCD.Texts;
            string phone = txtPhoneNumb.Texts;
            string user = txtUsername.Texts;
            string pass = txtPassword1.Texts;
            string date = datetime.ToString();
            int bank = 1210001;
            int stk = tk + 12342;
            int sodutk= 0;
            int loaitk = 1;
            int id = ++i;
            DataProvider.Instance.add_newacc(query, name, cccd, phone, user, pass, id, date, loaitk,bank,stk,sodutk);
            //DataTable reasul = DataProvider.Instance.add_newacc(query, name, cccd, phone, user, pass, id, date, loaitk);
            //if (reasul.Rows.Count > 0) { return true; }
            //else return false;
        }

       

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Texts;
            if (string.IsNullOrEmpty(txtCCCD.Texts))
            {

                HandleLeave(sender, e, txtCCCD, "Số CCCD", false);
            }
            else
            {

                string query = "select CCCD from ThongTin where CCCD = @cccd ";
                if (check(query, cccd) == true)
                {
                    MessageBox.Show("Căn cước công dân đã tốn tại");
                    txtCCCD.Focus();
                    txtCCCD.Texts = "";
                }

            }
        }
        bool check(string query, string data)
        {
            return DataProvider.Instance.Checked(query, new object[] { data });
        }

        private void txtPhoneNumb_Leave(object sender, EventArgs e)
        {
            string phone = txtPhoneNumb.Texts;
            if (string.IsNullOrEmpty(txtPhoneNumb.Texts))
            {

                HandleLeave(sender, e, txtPhoneNumb, "Số điện thoại", false);
            }
            else
            {

                string query = "select Phone from ThongTin where Phone = @phone";
                if (check(query, phone) == true)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng ");
                    txtPhoneNumb.Focus();
                    txtPhoneNumb.Texts = "";
                }

            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            string user = txtUsername.Texts;
            if (string.IsNullOrEmpty(txtUsername.Texts))
            {
                HandleLeave(sender, e, txtUsername, "Tên tài khoản", false);
            }
            else
            {

                string query = "select Username from Login where Username = @user ";
                if (check(query, user) == true)
                {
                    MessageBox.Show("Username đã tốn tại");
                    txtUsername.Focus();
                    txtUsername.Texts = "";
                }

            }
        }
    }
}
