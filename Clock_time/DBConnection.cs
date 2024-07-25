﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_time
{
    internal class DBConnection
    {
        //DBConnection.cs Code;
        static SqlConnection sqlConnection;
        static string connectionString = "server = DESKTOP-FT55N3M\\SA;initial catalog=time_clock; user id=sa; password=1234;TrustServerCertificate=Yes";
        public static bool Connect()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static string runSQL(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    object resolt = cmd.ExecuteScalar();
                    return resolt.ToString();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }

            return "";

        }
        public static string runSQLallresolt(string sql, string[] parameters = null, string[] values = null)
        {
        }


    }
}