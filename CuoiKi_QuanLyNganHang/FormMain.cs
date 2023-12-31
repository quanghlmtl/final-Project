﻿using CuoiKi_QuanLyNganHang.Forms;
using CuoiKi_QuanLyNganHang.Sql;
using CuoiKi_QuanLyNganHang.MoreForm;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace CuoiKi_QuanLyNganHang
{
    public partial class FormMain : Method
    {
        //Fields
        private Form activeForm;
       //string accountquery = "GET_NAME";

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
        private string name;
        private int id;
        public FormMain(string tk, string name, string id)
        {
            this.tk = tk;
            this.name = name;
            this.id = int.Parse(id);
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Even form load
        private void FormMain_Load(object sender, EventArgs e)
        {
            btnClose.Parent = lblTitle;
            btnMaximum.Parent = lblTitle;
            btn.Parent = lblTitle;
            if (checkStaff(tk) == 1)
            {
                Home form = new Home(name, id);
                OpenChildForm(form, btnHome.Text);
                ButtonViable(1, true);
                ButtonViable(0, false);
            }
            else if (checkStaff(tk) == 0)
            {
                HomeAdmin form = new HomeAdmin(name);
                OpenChildForm(form, btnHome.Text);
                ButtonViable(0, true);
                ButtonViable(1, false);
            }
        }

        //Methods
        int checkStaff(string tk)
        {
           return LoginToFormMain.Instance.checkStaff(tk);
        }
        private void EnableButton(Button choiceButtton)
        {
            btnHome.Enabled = true;
            btnTransfer.Enabled = true;
            btnSaving.Enabled = true;
            btnHistory.Enabled = true;
            btnInformation.Enabled = true;
            btnCard.Enabled = true;
            choiceButtton.Enabled = false;
        } 
        void ButtonViable(int tk, bool check)
        {
            if (tk == 1) 
            {
                btnHome.Visible = check;
                btnTransfer.Visible = check;
                btnSaving.Visible = check;
                btnHistory.Visible = check;
                btnInformation.Visible = check;
            }
            if (tk == 0) 
            {
                btnHomeAdmin.Visible = check;
                btnSearch.Visible = check;
                btnStatistics.Visible = check;
            }
        }
        protected void OpenChildForm(Form childForm, string text)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
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
            OpenChildForm(new Home(name, id), btnTransfer.Text);
            EnableButton(btnHome);
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTransferMoney(id, name), btnTransfer.Text);
            EnableButton(btnTransfer);
        }
        private void btnSaving_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSaving(id), btnSaving.Text);
            EnableButton(btnSaving);
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHistory(id), btnHistory.Text);
            EnableButton(btnHistory);
        }
        private void btnCard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCardManegement(id), btnCard.Text);
            EnableButton(btnCard);
        }
        private void btnInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInformation(id), btnInformation.Text);
            EnableButton(btnInformation);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
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
