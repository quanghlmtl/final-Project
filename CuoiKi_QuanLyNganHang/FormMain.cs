using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.Forms;
using CuoiKi_QuanLyNganHang.Sql;
using CuoiKi_QuanLyNganHang.HandleSql;
namespace CuoiKi_QuanLyNganHang
{
    public partial class FormMain : Form
    {
        //Fields
        private Form activeForm;
        string accountquery = "select * from [Account]";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Constructor
        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private string tk;
        private string mk;
        public FormMain(string tk, string mk)
        {
            this.tk = tk;
            this.mk = mk;
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        //Even form load
        private void FormMain_Load(object sender, EventArgs e)
        {
            string displayName = "";
            foreach (DataRow account in GetAllDataNew(accountquery).Rows)
            {
                if (account["AccountName"].ToString().Equals(tk))
                {
                    displayName = account["DisplayName"].ToString();
                    break;
                }
            }
            Home form = new Home(displayName);
            OpenChildForm(form, btnHome.Text);
            //activeButton(btnHome.Text);
            if (checkStaff(tk))
            {
                btnHome.Enabled = false;
                btnTransfer.Enabled = false;
                btnSaving.Enabled = false;
                btnHistory.Enabled = false;
                btnInformation.Enabled = false;
            }
        }

        //Methods
        bool checkStaff(string tk)
        {
            return LoginToFormMain.Instance.checkStaff(tk);
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                }
            }
        }
        private void ActivateButton(string value)
        {
            foreach (Control control in panelDesktopPane.Controls)
            {
                if (control is System.Windows.Forms.Button)
                {
                    System.Windows.Forms.Button button = (System.Windows.Forms.Button)control;
                    //if (button.Text == title)
                    //{
                    //    button.BackColor = Color.AliceBlue;
                    //}
                    //else
                    //{
                    //    button.BackColor = Color.Transparent;
                    //}
                }
            }
        }
        private void OpenChildForm(Form childForm, string text)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //ActivateButton(text);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = text;
        }

        //Button click 
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home(), btnTransfer.Text);

        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTransferMoney(), btnTransfer.Text);
        }
        private void btnSaving_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSaving(), btnSaving.Text);
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHistory(), btnHistory.Text);
        }
        private void btnInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInformation(), btnInformation.Text);
        }
        //Move form
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Custom Window Control Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximum_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState=FormWindowState.Normal;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
