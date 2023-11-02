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
            get
            {
                if (instance == null) instance = new LoginToFormMain();
                return instance;
            }
            private set { instance = value; }
        }

        private LoginToFormMain()
        {
        }

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

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            if (result.Rows.Count > 0)
            {
                loaitk = Convert.ToInt32(result.Rows[0]["loaitk"]);
                return loaitk;
            }

            return -1;
        }

        public string[] GetNameAndIdFromDatabase(string username)
        {
            string query =
                "SELECT ThongTin.Name, Login.ID FROM ThongTin INNER JOIN Login ON ThongTin.ID = Login.ID WHERE Login.Username = @username";
            string[] result = new string[2];

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            if (data.Rows.Count > 0)
            {
                result[0] = data.Rows[0]["Name"].ToString();
                result[1] = data.Rows[0]["ID"].ToString();
                return result;
            }
            else
            {
                result[0] = "Không tìm thấy tên người dùng.";
                result[1] = "-1";
                return result;
            }
        }
    }
}
