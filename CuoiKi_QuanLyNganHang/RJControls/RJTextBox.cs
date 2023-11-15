using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang.RJControls
{
    [DefaultEvent("_TextChanged")]
    public partial class RJTextBox : UserControl
    {
        //enum
        public enum Choose {All, Text, Number, NoOne}
        public enum Choose2 { Left, Right, Center }

        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isForcued = false;
        private bool numberMoney = false;
        private Choose stateValue;
        private Choose2 cTextAlign;
        private Padding controlPadding = new Padding(0);
        //private HorizontalAlignment cTextAlign;

        //Constructor
        public RJTextBox()
        {
            InitializeComponent();
        }
        //Events
        public event EventHandler _TextChanged;
        //Properties
        [Category("Custom Advance")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom Advance")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Custom Advance")]
        public bool UnderLinedStyle
        {
            get
            {
                return underLinedStyle;
            }
            set
            {
                underLinedStyle = value;
                this.Invalidate();
            }
        }
        [Category("Custom Advance")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        [Category("Custom Advance")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("Custom Advance")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("Custom Advance")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("Custom Advance")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }
        [Category("Custom Advance")]
        public string Texts
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        [Category("Custom Advance")]
        //public HorizontalAlignment CTextAlign
        //{
        //    get { return cTextAlign; }
        //    set { cTextAlign = value; }
        //}
        public Choose2 CTextAlign
        {
            get { return cTextAlign; }
            set { cTextAlign = value; }
        }
        [Category("Custom Advance")]
        public Choose StateValue
        {
            get
            {
                return stateValue;
            }
            set
            {
                stateValue = value;
            }
        }
        [Category("Custom Advance")]
        public Padding ControlPadding
        {
            get
            {
                return controlPadding;
            }
            set
            {
                controlPadding = value;
                this.Invalidate();
            }
        }
        [Category("Custom Advance")]
        public bool NumberMoney
        {
            get
            {
                return numberMoney;
            }
            set
            {
                numberMoney = value;
            }
        }
        //overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (isForcued)
                {
                    
                    if (underLinedStyle)//line style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else//normal style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underLinedStyle)//line style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else//normal style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateControlHeight();
                UpdateTextAlign();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
            UpdateTextAlign();
        }
        //private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        private void UpdateTextAlign()
        {
            switch (CTextAlign)
            {
                case Choose2.Center:
                    textBox1.TextAlign = HorizontalAlignment.Center;
                    break;
                case Choose2.Left:
                     textBox1.TextAlign = HorizontalAlignment.Left;
                    break;
                case Choose2.Right:
                     textBox1.TextAlign = HorizontalAlignment.Right;
                    break;
            }
        }
        private void textBox1_KeyPress4(object sender, KeyPressEventArgs e)
        {
            switch (StateValue)
            {
                case Choose.All:
                    // Cho phép tất cả các ký tự
                    break;
                case Choose.Text:
                    if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back))
                    {
                        e.Handled = true; // Hủy bỏ sự kiện KeyPress nếu không phải là ký tự chữ, Delete hoặc Backspace
                    }
                    break;
                case Choose.Number:
                    //if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back))
                    if (char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true; // Hủy bỏ sự kiện KeyPress nếu không phải là ký tự số
                    }
                    break;
                case Choose.NoOne:
                    e.Handled = true; // Hủy bỏ sự kiện KeyPress hoàn toàn
                    break;
            }
        }
        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            this.Invalidate();
        }
        private bool formattingText = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (numberMoney && !formattingText)
            {
                formattingText = true;

                string text = textBox1.Text;
                string formattedText = FormatNumberWithCommas(text);
                textBox1.Text = formattedText;
                textBox1.SelectionStart = formattedText.Length;

                formattingText = false;

                // Invoke the custom TextChanged event
                OnCustomTextChanged(EventArgs.Empty);
            }
        }
        protected virtual void OnCustomTextChanged(EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(this, e);
            }
        }
        private string FormatNumberWithCommas(string text)
        {
            // Xóa các dấu chấm hoặc dấu phẩy hiện có để chuẩn bị định dạng lại số
            text = text.Replace(".", "").Replace(",", "");

            // Định dạng lại số
            string formattedText = "";
            int count = 0;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                formattedText = text[i] + formattedText;
                count++;
                if (count % 3 == 0 && i > 0)
                {
                    formattedText = "." + formattedText; // Thay dấu chấm thành dấu phẩy nếu bạn muốn
                }
            }

            return formattedText;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isForcued = true;
            UpdateControlHeight();
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isForcued = false;
            UpdateControlHeight();
            this.Invalidate();
        }
        public void ClearTextBox()
        {
            textBox1.Text = string.Empty; // Xóa nội dung của TextBox
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

    }
}
