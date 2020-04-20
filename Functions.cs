using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich
{
    class Functions
    {
        public static SqlConnection conn = new SqlConnection();
        public static string ConnectionString = "Data Source=HH171;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True";
        public static void connect()
        {
            conn.ConnectionString = ConnectionString;
            conn.Open();
        }
        public static void closeConnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }

        public static DataTable LoadDataToTable(string sql)
        {

            SqlDataAdapter MyData = new SqlDataAdapter();
            MyData.SelectCommand = new SqlCommand();
            MyData.SelectCommand.Connection = Functions.conn;
            MyData.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; // Truong gia tri
            cbo.DisplayMember = ma; // Truong hien thi
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
    }
}
