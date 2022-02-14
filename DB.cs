using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SalesApp
{
    class DB
    {

        public static SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|MySales.mdf;Integrated Security=True;User Instance=True");
        public static SqlCommand cmd = new SqlCommand("", conn);
        public static void Open()
        {
            try
            {
                if(conn.State==ConnectionState.Closed) conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void Close()
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
        public static DataTable GetData(string SQL)
        {
            DataTable tbl = new DataTable();
            cmd.CommandText = SQL;
            tbl.Load(cmd.ExecuteReader());
            return tbl;
        }
        public static bool exist(string SQL,string value)
        {
            cmd.CommandText = SQL;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0].ToString() == value)
                {
                    rd.Close();
                    return true;
                }
            }
            rd.Close();
            return false;
        }
        public static void Run(string SQL)
        {
            cmd.CommandText = SQL;
            cmd.ExecuteNonQuery();
        }
    }
}
