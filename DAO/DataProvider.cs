using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }
        private DataProvider()
        {}
        private string connectionstr = @"Data Source=./;Initial Catalog=QLSinhVien;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            DataTable Data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(Data);
                conn.Close();
            }
            return Data;
        }
        
    }
}
