namespace CuoiKi_QuanLyNganHang.Forms
{
    partial class FormCardManegement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.btnCreatCard = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackgroundImage = global::CuoiKi_QuanLyNganHang.Properties.Resources._12;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(154, 52);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel.Size = new System.Drawing.Size(490, 360);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Transparent;
            this.right.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.right.FlatAppearance.BorderSize = 0;
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.ForeColor = System.Drawing.Color.Transparent;
            this.right.Image = global::CuoiKi_QuanLyNganHang.Properties.Resources.icons8_right_40;
            this.right.Location = new System.Drawing.Point(680, 162);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(77, 72);
            this.right.TabIndex = 1;
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.button3_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Transparent;
            this.left.FlatAppearance.BorderSize = 0;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left.ForeColor = System.Drawing.Color.Transparent;
            this.left.Image = global::CuoiKi_QuanLyNganHang.Properties.Resources.icons8_left_40;
            this.left.Location = new System.Drawing.Point(26, 162);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 72);
            this.left.TabIndex = 3;
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCreatCard
            // 
            this.btnCreatCard.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreatCard.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnCreatCard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreatCard.BorderRadius = 20;
            this.btnCreatCard.BorderSize = 0;
            this.btnCreatCard.FlatAppearance.BorderSize = 0;
            this.btnCreatCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatCard.Font = new System.Drawing.Font("Averta Std CY", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatCard.ForeColor = System.Drawing.Color.White;
            this.btnCreatCard.Location = new System.Drawing.Point(273, 162);
            this.btnCreatCard.Name = "btnCreatCard";
            this.btnCreatCard.Size = new System.Drawing.Size(220, 64);
            this.btnCreatCard.TabIndex = 4;
            this.btnCreatCard.Text = "Card/Credit issuance";
            this.btnCreatCard.TextColor = System.Drawing.Color.White;
            this.btnCreatCard.UseVisualStyleBackColor = false;
            this.btnCreatCard.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // FormCardManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuoiKi_QuanLyNganHang.Properties.Resources.cool_background1;
            this.ClientSize = new System.Drawing.Size(794, 459);
            this.Controls.Add(this.btnCreatCard);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCardManegement";
            this.Text = "FormCardManegement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCardManegement_FormClosing);
            this.Load += new System.EventHandler(this.FormCardManegement_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private RJControls.RJButton btnCreatCard;
    }
}