using CuoiKi_QuanLyNganHang.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi_QuanLyNganHang
{
    internal class HandleSql
    {
        private static HandleSql instance;

        public static  HandleSql Instance
        {
            get { if (instance == null) instance = new HandleSql(); return instance; }
            private set { instance = value; }
        }
        private HandleSql() { }

        public static bool UpdateAccount(string username, string displayname, string password)
        {
            string query = "Account_Update @AccountName  , @DisplayName , @Pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, displayname, password });
            return result.Rows.Count > 0;
        }
        public string GetBalanceFromDatabase(string username)
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
