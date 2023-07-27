using MassMailling_Core.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassMailling_Core.Database 
{
    public class DataAccessLayer : GlobalOperations
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        int ReturnValue;

        public DataAccessLayer()
        {
            con = new SqlConnection("data source = DESKTOP-57R498V\\SQLEXPRESS01 ; initial catalog = user ; id = sa ; password = 1 ;");
        }
        #region for insert , update and delete Run
        public int Run(SqlCommand cmd)
        {
            cmd.Connection = con;
            con.Open();
            UseTryCatch(() =>
            {
                ReturnValue = cmd.ExecuteNonQuery();
            });
            con.Close();
            return ReturnValue;
        }
        #endregion
        public SqlDataReader BringData()
        {
            cmd.Connection = con;
            con.Open();
            UseTryCatch(() =>
            {
                reader = cmd.ExecuteReader();
            });
            return reader; // we dont close connection 
        }
        #region To check data in database
        public int RunInt(SqlCommand cmd)
        {
            cmd.Connection = con;
            con.Open();
            UseTryCatch(() => { ReturnValue = (int)cmd.ExecuteScalar(); });
            con.Close();
            return ReturnValue;
        }
        #endregion
        private void SetConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            else con.Close();
        }

    }
}
