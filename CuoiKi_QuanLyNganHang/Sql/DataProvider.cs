using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang.Sql
{
    public class DataProvider
    {
        public string connectionSTR = //"Data Source=HUYENMYDANG\\SQL;Initial Catalog=QLNH;Integrated Security=True";
           "Data Source=.;Initial Catalog=QLNH;Integrated Security=True";

        private static DataProvider instance;

        public string getconnectionSTR()
        {
            return connectionSTR;
        }

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Close();
                adapter.Fill(data);
            }
            return data;
        }

        public bool checkforgot2(string name, string cccd, string phone, string username)
        {
            string query = "[CHECK_FORGOT] @name, @cccd, @Phone, @userName";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    command.Parameters.Add("@cccd", SqlDbType.Char).Value = cccd;
                    command.Parameters.Add("@phone", SqlDbType.Char).Value = phone;
                    command.Parameters.Add("@userName", SqlDbType.Char).Value = username;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    return data.Rows.Count > 0;
                }
            }
        }
        public bool UpdateAccount(string username, string newpass)
        {
            string query = "update Login set Pass = @newpass where Username = @username";
            DataTable datatable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@newpass", newpass);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(datatable);
                    return datatable.Rows.Count > 0;
                }
            }
        }
        public bool Checked(string query, object[] parameter = null)
        {
            bool check = false;
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    if (data.Rows.Count > 0) { check = true; }
                }
            }
            return check;
        }
        public void add_newacc(string query, string name, string cccd, string phone, string user, string pass, int id, string date, int loaitk,int bank,int stk,int sodutk, string Nametk)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@cccd", SqlDbType.Char).Value = cccd;
                command.Parameters.Add("@phone", SqlDbType.Char).Value = phone;
                command.Parameters.Add("@user", SqlDbType.Char).Value = user;
                command.Parameters.Add("@pass", SqlDbType.Char).Value = pass;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@date", SqlDbType.SmallDateTime).Value = date;
                command.Parameters.Add("@loaitk", SqlDbType.Int).Value = loaitk;
                command.Parameters.Add("@bank", SqlDbType.Int).Value = bank;
                command.Parameters.Add("@stk", SqlDbType.Int).Value = stk;
                command.Parameters.Add("@sodutk", SqlDbType.Int).Value = sodutk;
                command.Parameters.Add("@Nametk", SqlDbType.NVarChar).Value = Nametk;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void SetDataToGiaoDich(string query, int IDGD, int IDTo, int IDFrom, int SoTien, string DateGD, string Notes)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@IDGD", SqlDbType.Int).Value = IDGD;
                command.Parameters.Add("@IDTo", SqlDbType.Int).Value = IDTo;
                command.Parameters.Add("@IDFrom", SqlDbType.Int).Value = IDFrom;
                command.Parameters.Add("@SoTien", SqlDbType.Int).Value = SoTien;
                command.Parameters.Add("@DateGD", SqlDbType.SmallDateTime).Value = DateGD;
                command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Notes;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void SetDataToCards(string query, object[] parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@ID", SqlDbType.Int).Value = parameter[0];
                command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = parameter[1];
                command.Parameters.Add("@SoDuCard", SqlDbType.Int).Value = parameter[2];
                command.Parameters.Add("@IssueDate", SqlDbType.SmallDateTime).Value = parameter[3];
                command.Parameters.Add("@ExpirationDate", SqlDbType.SmallDateTime).Value = parameter[4];
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void SetDataToDichVu(string query, int ID, double MucLS, string LoaiDichvu, int MoneyStart, int MoneyEnd,
            string DateStart, string DateEnd)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@MucLS", SqlDbType.Float).Value = MucLS;
                command.Parameters.Add("@LoaiDichvu", SqlDbType.NVarChar).Value = LoaiDichvu;
                command.Parameters.Add("@MoneyStart", SqlDbType.Int).Value = MoneyStart;
                command.Parameters.Add("@MoneyEnd", SqlDbType.Int).Value = MoneyEnd;
                command.Parameters.Add("@DateStart", SqlDbType.SmallDateTime).Value = DateTime.Parse(DateStart);
                command.Parameters.Add("@DateEnd", SqlDbType.SmallDateTime).Value = DateTime.Parse(DateEnd);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateBalance(int Money, int Id)
        {
            string updateQuery = "UPDATE [TaiKhoan] SET [SoDuTK] = [SoDuTK] + @sodutk WHERE ID = @id";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                // Update for the recipient
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@sodutk", Money);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public DataTable SelectData(string sql, string tukhoa, int id)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.CommandType = CommandType.StoredProcedure; // Khai báo sử dụng storeprocedure 
                command.Parameters.AddWithValue("TuKhoa", tukhoa);
                command.Parameters.AddWithValue("id", id);
                DataTable data = new DataTable();
                data.Load(command.ExecuteReader());
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}







        
    