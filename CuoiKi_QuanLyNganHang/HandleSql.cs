﻿using CuoiKi_QuanLyNganHang.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi_QuanLyNganHang
{
    public class HandleSql
    {
        public DataTable GetAllDataNew(string query)
        {
            DataProvider provider = new DataProvider();

            DataTable dataTable = provider.ExecuteQuery(query);

            return dataTable;
        }

    }
}
