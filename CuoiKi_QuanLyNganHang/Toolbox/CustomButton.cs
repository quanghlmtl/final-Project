using System.Windows.Forms;

namespace Learn1.Toolbox
{
    class CustomButton : Button
    {
        public CustomButton()
        {
            // Đặt các thuộc tính mặc định của CustomButton
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = System.Drawing.Color.FromArgb(192, 192, 192);
            this.FlatAppearance.BorderColor = System.Drawing.Color.White;

            // Đặt font mặc định
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
        }
    }
}
