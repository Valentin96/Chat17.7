using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class PullData
    {
        // your data table
        private DataTable dataTable = new DataTable();

        public PullData()
        {
        }

        // your method to pull data from database to datatable   
        public void PullDat()
        {
            string connString = @"Data Source =.; Initial Catalog = Chat; Integrated Security = True";
            string query = "select * from Users";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();
        }
    }
}
