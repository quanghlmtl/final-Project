﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi_QuanLyNganHang.Sql
{
    public class DataProvider
    {
        public string connectionSTR = "Data Source=HUYENMYDANG\\SQL;Initial Catalog=QLNH;Integrated Security=True";
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
        public DataTable ExecuteQuery2(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPara[i], parameter[i]);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }
        public bool checkforgot2(string name, string cccd, string phone, string username)
        {
            string query = "forgotpass @name, @cccd, @Phone, @Username";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    command.Parameters.Add("@cccd", SqlDbType.Char).Value = cccd;
                    command.Parameters.Add("@Phone", SqlDbType.Char).Value = phone;
                    command.Parameters.Add("@Username", SqlDbType.Char).Value = username;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
            }

            return false; // Nếu thông tin đăng nhập sai hoặc có lỗi, trả về false
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
    }

}
