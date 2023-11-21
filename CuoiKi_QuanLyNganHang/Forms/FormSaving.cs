using CuoiKi_QuanLyNganHang.MoreForm;
using CuoiKi_QuanLyNganHang.Sql;
using System;

namespace CuoiKi_QuanLyNganHang.Forms
{
    public partial class FormSaving : Method
    {
        private int id = 0;
        private int money = 0;
        private int money2 = 0;
        private string dateStart = "";
        private string dateEnd = "";
        string query = "SELECT [SoDuTK] FROM [TaiKhoan] Where ID = @id";
        string query2 = "[InsertDichVu] @ID , @MucLS , @LoaiDichVu , @MoneyStart , @MoneyEnd , @DateStart ,  @DateEnd";
        double laiSuat = 0.0;
        public FormSaving()
        {
            InitializeComponent();
        }
        public FormSaving(int id)
        {
            this.id = id;
            InitializeComponent();
            txtAccountBalance.Enabled = false;
            txtInterest.Enabled = false;
            txtDateEnd.Enabled = false;
            txtAccountBalance.Texts = HandleSql.GetDataFromDTB(query, id);
        }
        DateTime currentTime = DateTime.Now;
        //method
        private void Reset()
        {
            txtMoney.Texts = "";
            txtSendingTerm.Texts = "";
            txtInterest.Text = "";
            txtDateEnd.Texts = "";
        }
        void UpdateValue()
        {
            if (!string.IsNullOrEmpty(txtMoney.Texts))
            {
                string txtmoney = txtMoney.Texts.Replace(".", "");
                money = int.Parse(txtmoney);
            }
            if (!string.IsNullOrEmpty(txtSendingTerm.Texts))
            {
                money2 = tinhLaiSuat(money, laiSuat);
                txtInterest.Texts = money2.ToString();
                txtDateEnd.Texts = dateEnd;
            }
        }
        int tinhLaiSuat(int money, double laisuat)
        {
            double result = money + money * laisuat;
            return (int)Math.Round(result);
        }

        //event
        private void txtSendingTerm_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedThoiHan = txtSendingTerm.SelectedIndex;

            if (selectedThoiHan == 0)
            {
                laiSuat = 0.04;
                dateEnd = currentTime.AddMonths(1).ToString("dd/MM/yyyy");
            }
            else if (selectedThoiHan == 1)
            {
                laiSuat = 0.04;
                dateEnd = currentTime.AddMonths(3).ToString("dd/MM/yyyy");
            }
            else if (selectedThoiHan == 2)
            {
                laiSuat = 0.07;
                dateEnd = currentTime.AddMonths(6).ToString("dd/MM/yyyy");
            }
            else if (selectedThoiHan == 3)
            {
                laiSuat = 0.07;
                dateEnd = currentTime.AddYears(1).ToString("dd/MM/yyyy");
            }
            else if (selectedThoiHan == 4)
            {
                laiSuat = 0.07;
                dateEnd = currentTime.AddYears(3).ToString("dd/MM/yyyy");
            }
            else if (selectedThoiHan == 5)
            {
                laiSuat = 0.085;
                dateEnd = currentTime.AddYears(10).ToString("dd/MM/yyyy");
            }
            UpdateValue();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dateStart = currentTime.ToString("dd/MM/yyyy");
            int money3 = -money;
            DataProvider.Instance.SetDataToDichVu(query2, id, laiSuat, "Sổ tiết kiệm", money, money2, dateStart, dateEnd);
            DataProvider.Instance.UpdateBalance(money3, id);
            txtAccountBalance.Texts = HandleSql.GetDataFromDTB(query, id);
            CustomMessageBox message = new CustomMessageBox("Đăng kí dịch vụ sổ tiết kiệm online thành công.");
            message.Show();
            Reset();
        }

        private void txtMoney__TextChanged(object sender, EventArgs e)
        {
            UpdateValue();
        }
    }
}
