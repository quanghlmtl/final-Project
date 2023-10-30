using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang;

namespace CuoiKi_QuanLyNganHang
{
    public partial class FormMain : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private Form preForm;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Constructor
        public FormMain()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
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
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
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
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Home";
            panelTitle.BackColor = Color.FromArgb(0, 135, 137);
            panelLogo.BackColor = Color.FromArgb(27, 38, 56);
            currentButton = null;
        }

        private void hideMoreButton(bool value)
        {
            item1.Visible = value;
            item2.Visible = value;
            item3.Visible = value;
            btnHide.Visible = value;
            value = !value;
            btnShow.Visible = value;
            
        }

        //Button click 
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                lblTitle.Text = "Home";
            }
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

        //button show more
        private void btnShow_Click(object sender, EventArgs e)
        {
            hideMoreButton(true);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            hideMoreButton(false);
        }
    }
}
