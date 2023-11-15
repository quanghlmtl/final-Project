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

namespace CuoiKi_QuanLyNganHang.Forms
{
    public partial class FormInformation : Method
    {
        int id;
        string[] listSTR = new string[] { };
        string name = "";
        string phone = "";
        string cccd = "";
        string pass = "";
        string sodutk = "";
        string username;
        string newpass;
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
            txtPassword1.Texts = pass;
            newpass = txtPassword2.Texts;
        }
        //method 
        private void VisualChange(bool value)
        {
            //lable
            lblPass.Visible = value;
            lblConfirmPass.Visible = value;
            //textbox
            txtPassword1.Visible = value;
            txtPassword2.Visible = value;
            //hidden,presently
            hidden.Visible = value;
            hidden1.Visible = value;
            presently.Visible = value;
            presently1.Visible = value;
            btnConfirm.Visible = value;
            value = !value;
            btnChange.Visible = value;
        }

        //hidden
        private void hidden_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouesUpActions(sender, e, txtPassword1, "");
        }

        private void hidden_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDownActions(sender, e, txtPassword1, "Mật khẩu");
        }

        private void hidden1_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouesUpActions(sender, e, txtPassword2, "Nhập lại mật khẩu");
        }

        private void hidden1_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDownActions(sender, e, txtPassword2, "Nhập lại mật khẩu");
        }
        //btn Change
        private void btnChange_Click(object sender, EventArgs e)
        {
            VisualChange(true);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPassword1.Texts != txtPassword2.Texts)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo!", MessageBoxButtons.RetryCancel);
            }
            else
            {
                DataProvider.Instance.UpdateAccount(username, newpass);
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
    }
}

        