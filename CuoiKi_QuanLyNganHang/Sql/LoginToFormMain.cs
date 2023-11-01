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
        public int checkStaff(string username)
        {
            string query = "SELECT loaitk FROM Login WHERE Username = @username";
            int loaitk;

            // Gọi phương thức ExecuteQuery với tham số username
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            if (result.Rows.Count > 0)
            {
                loaitk = Convert.ToInt32(result.Rows[0]["loaitk"]);
                return loaitk;
            }
            return -1;
        }

        public string GetNameFromDatabase(string username)
        {
            string query =
                "SELECT Name FROM ThongTin INNER JOIN Login ON ThongTin.ID = Login.ID Where Username = @username";
            string name;
            // Gọi phương thức ExecuteQuery với tham số username
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            if (result.Rows.Count > 0)
            {
                name = result.Rows[0]["Name"].ToString();
                return name;
            }
            else
            {
                name = "Không tìm thấy tên người dùng.";
                return name;
            }
        }
    }
}
