using System;
using System.Drawing;
using System.Windows.Forms;
namespace CuoiKi_QuanLyNganHang.Class
{
    internal class PaddedTextBox : TextBox
    {

        private int paddingLeft = 5; // Giá trị padding bên trái
        private int paddingRight = 5; // Giá trị padding bên phải
        private int paddingTop = 5; // Giá trị padding phía trên
        private int paddingBottom = 5; // Giá trị padding phía dưới

        public PaddedTextBox()
        {
            // Đăng ký sự kiện Paint để vẽ TextBox với padding
            this.Paint += PaddedTextBox_Paint;
        }

        protected override void OnResize(EventArgs e)
        {
            // Khi kích thước của TextBox thay đổi, vẽ lại để cập nhật padding
            this.Invalidate();
            base.OnResize(e);
        }

        private void PaddedTextBox_Paint(object sender, PaintEventArgs e)
        {
            // Vẽ TextBox với padding
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);

            Rectangle textRect = this.ClientRectangle;
            textRect.Inflate(-paddingLeft, -paddingTop);
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, textRect, this.ForeColor, this.BackColor,
                TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl);
        }

        // Các thuộc tính cho phép thiết lập giá trị padding
        public int PaddingLeft
        {
            get { return paddingLeft; }
            set
            {
                paddingLeft = value;
                this.Invalidate();
            }
        }

        public int PaddingRight
        {
            get { return paddingRight; }
            set
            {
                paddingRight = value;
                this.Invalidate();
            }
        }

        public int PaddingTop
        {
            get { return paddingTop; }
            set
            {
                paddingTop = value;
                this.Invalidate();
            }
        }

        public int PaddingBottom
        {
            get { return paddingBottom; }
            set
            {
                paddingBottom = value;
                this.Invalidate();
            }
        }

    }
}
