using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class Activity
    {
        private dbConnection conn;
        public Activity()
        {
            conn = new dbConnection();
        }
        //string connectionString = @"Data Source=.;Initial Catalog=Chat;Integrated Security=True";
        public void activityMethod(string argUserName, string argAction, DateTime argTimestamp)
        {
            var command = new SqlCommand("UserAddActivity", conn.openConnection())
            {
                CommandType = CommandType.StoredProcedure
            };


            command.Parameters.AddWithValue("@username", argUserName);
            command.Parameters.AddWithValue("@action", argAction);
            command.Parameters.AddWithValue("@timestamp", argTimestamp);
            command.ExecuteNonQuery();

        }
    }
}
