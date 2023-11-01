using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi_QuanLyNganHang.Sql
{
    internal class LoginToFormMain
    {
        private static LoginToFormMain instance;

        public static LoginToFormMain Instance
        {
            get { if (instance == null) instance = new LoginToFormMain(); return instance; }
            private set { instance = value; }
        }
        private LoginToFormMain() { }
        public bool LoginFormMain(string username, string password)
        {
            string query = "CHECK_LOGIN @userName , @passWord ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
        public bool checkStaff(string username)
        {
            string query = "SELECT loaitk FROM Login WHERE Username = @username";
            int loaitk;

            // Gọi phương thức ExecuteQuery với tham số username
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            if (result.Rows.Count > 0)
            {
                loaitk = Convert.ToInt32(result.Rows[0]["loaitk"]);

                if (loaitk == 0)
                {
                    // Gán true cho Admin (loaitk = 0)
                    return true;
                }
                else if (loaitk == 1)
                {
                    // Gán false cho User (loaitk = 1)
                    return false;
                }
            }

            // Nếu không tìm thấy hoặc có lỗi, mặc định trả về false cho User
            return false;
        }

        public bool UpdateAccount(string username, string displayname, string password)
        {
            string query = "Account_Update @AccountName  , @DisplayName , @Pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, displayname, password });
            return result.Rows.Count > 0;
        }
    }
}
