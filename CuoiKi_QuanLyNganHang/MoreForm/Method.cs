using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang.MoreForm
{
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }
        //Mouse up
        protected void HandleMouesUpActions(object sender, MouseEventArgs e, RJControls.RJTextBox txt, string placeholderText)
        {
            if (txt.Texts == placeholderText)
                return;
            if (e.Button == MouseButtons.Left)
            {
                Control hidden = (Control)sender;
                txt.PasswordChar = true;
                hidden.BringToFront();
            }
        }
        //Mouse down
        protected void HandleMouseDownActions(object sender, MouseEventArgs e, RJControls.RJTextBox txt, string placeholderText)
        {
            if (txt.Texts == placeholderText)
                return;
            if (e.Button == MouseButtons.Left)
            {
                Control hidden = (Control)sender;
                hidden.SendToBack();
                txt.PasswordChar = false;
            }
        }      
        //Textbox enter
        protected void HandleEnter(object sender, EventArgs e, RJControls.RJTextBox txt, string value, bool txtpassword)
        {
            if (txt.Texts == value)
                txt.Texts = "";
            if (txtpassword)
                txt.PasswordChar = true;
        }
        //Textbox leave
        protected void HandleLeave(object sender, EventArgs e, RJControls.RJTextBox txt, string value, bool txtpassword)
        {
            if (txt.Texts == "")
            {
                txt.Texts = value;
                if (txtpassword)
                    txt.PasswordChar = false;
            }
            else if (txt.Texts != value)
            {
                if (txtpassword)
                    txt.PasswordChar = true;
            }
        }
        //Textbox handle empty
        protected void HandleEmpty(RJControls.RJTextBox txt, Label lb, string value, bool txtpassword)
        {
            if (txt.Texts == "")
            {
                txt.Padding = new Padding(8, 15, 5, 5);
                txt.Font = new Font("Averta Std CY", 16);
                txt.Texts = value;
                lb.Hide();
            }

        }
        //Textbox enter more prooerties
        protected void HandleEnterMoreProperties(object sender, EventArgs e, Label label, RJControls.RJTextBox textBox, string placeholder)
        {
            label.Show();
            textBox.Font = new Font("Averta Std CY", 14);
            textBox.Padding = new Padding(8, 20, 5, 5);
            if (textBox.Texts == placeholder)
                textBox.Texts = "";
        }
        //Check Textbox is Null Or White Space
        protected bool CheckNullOrWhiteSpace(RJControls.RJTextBox txt, Label lb, string value1, string value2)
        {
            if (string.IsNullOrWhiteSpace(txt.Texts) || txt.Texts == value1)
            {
                lb.Visible = true;
                lb.Text = "*Please enter " + value2;
                txt.Focus();
                return true;
            }
            else return false;
        }
    }
}
