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
    }
}
