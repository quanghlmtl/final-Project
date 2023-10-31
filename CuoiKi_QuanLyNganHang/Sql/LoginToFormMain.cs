using System;
using System.Collections.Generic;
using System.Data;
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
            string query = "USP_LOGIN @userName , @passWord ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
        public bool checkStaff(string username)
        {
            string query = "SELECT *\r\nFROM RoleAccount\r\nINNER JOIN Account ON Account.AccountName = RoleAccount.AccountName\r\nINNER JOIN Role ON Role.ID = RoleAccount.RoleID\r\nWHERE Account.AccountName = '" + username + "' and RoleID = 2;";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool UpdateAccount(string username, string displayname, string password)
        {
            string query = "Account_Update @AccountName  , @DisplayName , @Pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, displayname, password });
            return result.Rows.Count > 0;
        }
    }
}
