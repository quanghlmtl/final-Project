﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang.Sql
{
    public class DataProvider
    {
        public string connectionSTR = "Data Source=HUYENMYDANG\\SQL;Initial Catalog=QLNH;Integrated Security=True";
            //"Data Source=.;Initial Catalog=QLNH;Integrated Security=True";

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

        public void ExecuteNonQueryProvider(string name, string query, object[] parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(name, connection);
                command.CommandType = CommandType.StoredProcedure;
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
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable ExecuteQueryProc(string procName, string username)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure; // Xác định loại command là stored procedure

                command.Parameters.AddWithValue("@userName", username); // Truyền tham số cho stored procedure

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            return data;
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
        public void add_newacc(string query, string name, string cccd, string phone, string user, string pass, int id, string date, int loaitk,int bank,int stk)
        {


            DataTable data = new DataTable();
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
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
            }
            
        }
    }
}







        
    