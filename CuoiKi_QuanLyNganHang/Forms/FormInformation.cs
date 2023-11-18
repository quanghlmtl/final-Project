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
using CuoiKi_QuanLyNganHang.Class;
using CuoiKi_QuanLyNganHang.Sql;
using static System.Net.Mime.MediaTypeNames;

namespace CuoiKi_QuanLyNganHang.Forms
{
    public partial class FormInformation : Method
    {
        string query = "select Pass from Login where ID = @id and Pass = @pass";
        int id;
        string[] listSTR = new string[] { };
        string name = "";
        string phone = "";
        string cccd = "";
        string pass = "";
        string sodutk = "";
        string username;
        public FormInformation(int id)
        {
            InitializeComponent();
            this.id = id;
            VisualChange(false);
        }
        private void FormInformation_Load(object sender, EventArgs e)
        {
            select();
            rjTextBox1.Texts = name;
            rjTextBox2.Texts = phone;
            rjTextBox3.Texts = cccd;
            rjTextBox4.Texts = sodutk;
            rjTextBox1.Enabled = false;
            rjTextBox2.Enabled = false;
            rjTextBox3.Enabled = false;
            rjTextBox4.Enabled = false;
        }
        //method 
        private void VisualChange(bool value)
        {
            //lable
            lblPassOld.Visible = value;
            lblPass.Visible = value;
            lblConfirmPass.Visible = value;
            //textbox
            txtPassword1.Visible = value;
            txtPassword2.Visible = value;
            txtPassword3.Visible = value;
            //hidden,presently
            hidden.Visible = value;
            hidden1.Visible = value;
            hidden2.Visible = value;
            presently.Visible = value;
            presently1.Visible = value;
            presently2.Visible = value;
            btnConfirm.Visible = value;
            btnChange.Visible = !value;
        }

        //hidden
        private void hidden_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword1.PasswordChar = true;
            hidden.BringToFront();
        }

        private void hidden_MouseDown(object sender, MouseEventArgs e)
        {
            hidden.SendToBack();
            txtPassword1.PasswordChar = false;
        }
        //hidden1
        private void hidden1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword2.PasswordChar = true;
            hidden1.BringToFront();
        }

        private void hidden1_MouseDown(object sender, MouseEventArgs e)
        {
            hidden1.SendToBack();
            txtPassword2.PasswordChar = false;
        }
        //hidden3
        private void hidden2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword3.PasswordChar = true;
            hidden2.BringToFront();
        }
        private void hidden2_MouseDown(object sender, MouseEventArgs e)
        {
            hidden2.SendToBack();
            txtPassword3.PasswordChar = false;
        }
        //btn Change
        private void btnChange_Click(object sender, EventArgs e)
        {
            VisualChange(true);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!check(query, id, txtPassword1.Texts))
            {
                MessageBox.Show("Sai Mật Khẩu");
                txtPassword1.Focus();
                return;
            }
            if (txtPassword2.Texts != txtPassword3.Texts)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo!", MessageBoxButtons.RetryCancel);
            }
            else if (txtPassword1.Texts == txtPassword2.Texts)
            {
                MessageBox.Show("Nhập mật khẩu khác Mật khẩu cũ! ");
            }
            else
            {
                 string newpass = txtPassword2.Texts;
                DataProvider.Instance.UpdateAccount(username,newpass);
                MessageBox.Show("Thay đổi thành công!", "Thông báo!", MessageBoxButtons.OK);
                VisualChange(false);
            }
        }
        
        private void select()
        {
            string query = "SELECT tt.Name,tt.Phone,tt.CCCD,tk.SoDuTK,lg.Pass,lg.Username FROM ThongTin tt join TaiKhoan tk on tt.ID=tk.ID join Login lg on tk.ID=lg.ID WHERE tt.ID = @id";

            listSTR = HandleSql.Instance.select_acc(query, id);
            name = listSTR[0];
            phone = listSTR[1];
            cccd = listSTR[2];
            sodutk = listSTR[3];
            pass = listSTR[4];
            username = listSTR[5];
        }
        bool check(string query, int id, string pass)
        {
            return DataProvider.Instance.Checked(query, new object[] { id,pass });
        }

        private void txtPassword1_Leave(object sender, EventArgs e)
        {
            if (!check(query, id, txtPassword1.Texts))
            {
                MessageBox.Show("Sai Mật Khẩu");
            }
        }
    }
}

        