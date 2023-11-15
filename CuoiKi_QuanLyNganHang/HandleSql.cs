using CuoiKi_QuanLyNganHang.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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


        //public string[] GetBalanceFromDatabase(string username)
        //{
        //    string query =
        //        "SELECT ThongTin.Name, Login.ID FROM ThongTin INNER JOIN Login ON ThongTin.ID = Login.ID WHERE Login.Username = @username";
        //    string[] result = new string[2];

        //    DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

        //    if (data.Rows.Count > 0)
        //    {
        //        result[0] = data.Rows[0]["Name"].ToString();
        //        result[1] = data.Rows[0]["ID"].ToString();
        //        return result;
        //    }
        //    else
        //    {
        //        result[0] = "Không tìm thấy tên người dùng.";
        //        result[1] = "-1";
        //        return result;
        //    }
        //}

        //get
        public static int GetDataFromDTB2(string query, int id)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return (int)result.Rows[0][0];
        }
        public static string GetDataFromDTB(string query, int id)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result.Rows[0][0].ToString();
        }
        public static string GetDataFromDTB(string query, int id, string nameBank)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id, nameBank });
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["NameTK"].ToString();
            }
            return "null";
        }
        public static string GetDataFromDTB(string query, Class.CustomComboBox combobox)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AddData(combobox, row.ItemArray);
            }
            return data.Rows[0]["NameBank"].ToString();
        }
        public static void AddData(Class.CustomComboBox combobox, params object[] row)
        {
            combobox.Items.Add(string.Join(", ", row));
        }
        public string[] select_acc(string query, int id)
        {
            string[] result = new string[6];
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            if (data.Rows.Count > 0)
            {
                result[0] = data.Rows[0]["Name"].ToString();
                result[1] = data.Rows[0]["Phone"].ToString();
                result[2] = data.Rows[0]["CCCD"].ToString();
                result[3] = data.Rows[0]["SoDuTK"].ToString();
                result[4] = data.Rows[0]["Pass"].ToString();
                result[5] = data.Rows[0]["Username"].ToString();
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
