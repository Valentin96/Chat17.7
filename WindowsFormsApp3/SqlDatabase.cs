using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class SqlDatabase : Database
    {
        private dbConnection conn;

        /// <constructor>
        /// Constructor UserDAO
        /// </constructor>
        public SqlDatabase()
        {
            conn = new dbConnection();
        }

        //public override bool CheckCredentials(string argUserName, string argPassoword)
        //{

        //        string query = string.Format("SELECT Count(*) FROM Users WHERE name=\'"+ argUserName + "\' AND pass=\'" + argPassoword+"\'");

        //        return conn.executeSelectQuery(query, new SqlParameter[] { });

        //}

        public override bool CheckCredentials(string argUserName, string argPassoword)
        {
            var command = new SqlCommand("UserCheckPassUser", conn.openConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
           
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(argUserName);
            sqlParameters[1] = new SqlParameter("@pass", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(argPassoword);
            //sqlParameters[2] = new SqlParameter("@phone", SqlDbType.VarChar);
            //sqlParameters[2].Value = Convert.ToString(phoneNumber);
            //sqlParameters[3] = new SqlParameter("@cheie", SqlDbType.VarChar);
            //sqlParameters[3].Value = Convert.ToString(cheie);
            //sqlParameters[4] = new SqlParameter("@administrator", SqlDbType.VarChar);
            //sqlParameters[4].Value = Convert.ToString(phoneNumber);
            command.Parameters.AddRange(sqlParameters);

            int userCount = (int)command.ExecuteScalar();
            if (userCount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool CheckPhone(string argphoneNumber)
        {
            var command = new SqlCommand("UserSelectPhoneNumber", conn.openConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("phone", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(argphoneNumber);
            int userCount = (int)command.ExecuteScalar();
            if (userCount == 1)
            {
                return true;
            }
            else return false;

        }





        //public override void Print()
        //{
        //    Console.WriteLine("SqlDatabase");
        //    //foreach (var item in _users)
        //    //{
        //    //    Console.WriteLine("SqlUsername: {0}", item.Name);
        //    //    Console.WriteLine("SqlPassword: {1}", item.Password);
        //    //    Console.WriteLine();

        //    //}
        //}
    }
}
