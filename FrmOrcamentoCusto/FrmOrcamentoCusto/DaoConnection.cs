﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DaoConnection
{
    public static SqlConnection GetConexao()
    {
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=movtech;Integrated Security=True");
        connection.Open();
        return connection;
    }
}