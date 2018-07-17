using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class DataLayer
    {
        string connectionString = @"Data Source=.;Initial Catalog=Chat;Integrated Security=True";
        Database db = new SqlDatabase();
        Activity activitate = new Activity();
        SqlDatabase phone = new SqlDatabase();
        internal bool login(string username, string password)
        {
           
            //Database db = new FileDatabase();
            bool ok = false;
            using (SqlConnection sqlConActivity = new SqlConnection(connectionString))
            {
                sqlConActivity.Open();


                ok=db.CheckCredentials(username, password);

                
            }
            return ok;
        }
        internal bool resetPassword(string phoneNumber)
        {
            bool ok = false;
            using (SqlConnection sqlConActivity = new SqlConnection(connectionString))
            {
                sqlConActivity.Open();
                ok = phone.CheckPhone(phoneNumber);
            }
            return ok;
        }

        internal void insertLog(string v1, string v2, DateTime now)
        {
            using (SqlConnection sqlConActivity = new SqlConnection(connectionString))
            {
                sqlConActivity.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAddActivity", sqlConActivity);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", v1.Trim());
                sqlCmd.Parameters.AddWithValue("@action", v2);
                sqlCmd.Parameters.AddWithValue("@timestamp", now);
                sqlCmd.ExecuteNonQuery();
                //  throw new NotImplementedException();
            }
            }
        internal void signUp(string username, string password, string phoneNumber, string cheie, int administrator)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@name", username.Trim());
                sqlCmd.Parameters.AddWithValue("@pass", password.Trim());
                sqlCmd.Parameters.AddWithValue("@phone", phoneNumber.Trim());
                sqlCmd.Parameters.AddWithValue("@cheie", cheie);
                sqlCmd.Parameters.AddWithValue("administrator", administrator);
                sqlCmd.ExecuteNonQuery();
                
            }
        }
        private DataTable dataTable = new DataTable();


        public void PullData(DataTable dataTable)
        {
            string connectionString = @"Data Source=.;Initial Catalog=Chat;Integrated Security=True";
            string query = "select * from Users";
            List<string> aa = new List<string>();

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();
        }




        public bool checkUserNameAtSignUp(string userName)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                bool ok = false;
                con.Open();
                string command = "SELECT * FROM Chat";
                PullData(dataTable);
                using (var cmd = new SqlCommand(command, con))
                {


                    foreach (DataRow row in dataTable.Rows)
                    {
                        string name = row["name"].ToString();
                        //string pass = row["pass"].ToString();
                       // string phone = row["phone"].ToString().Trim();
                        //  MessageBox.Show(phone);
                        //MessageBox.Show(mTextBoxPhoneNumber.Text);
                        if (userName.Trim() == name.Trim() )
                        {
                            ok = true;

                        }
                        else
                        {
                            int t = 0;
                        }



                    }

                    return ok;

                }
            }
        }
        public bool checkPhoneNumberAtSignUp(string phoneNumber)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                bool ok = false;
                con.Open();
                string command = "SELECT * FROM Chat";
                PullData(dataTable);
                using (var cmd = new SqlCommand(command, con))
                {


                    foreach (DataRow row in dataTable.Rows)
                    {
                       // string name = row["name"].ToString();
                        //string pass = row["pass"].ToString();
                         string phone = row["phone"].ToString().Trim();
                        //  MessageBox.Show(phone);
                        //MessageBox.Show(mTextBoxPhoneNumber.Text);
                        if (phoneNumber.Trim() == phone.Trim())
                        {
                            ok = true;

                        }
                        else
                        {
                            int t = 0;
                        }



                    }

                    return ok;

                }
            }
        }












        //internal string signUp1(string username, string password, string passwordverification)
        //{
        //    using (SqlConnection sqlConActivity = new SqlConnection(connectionString))
        //    {
        //        sqlConActivity.Open();



        //            DateTime localData = DateTime.Now;

        //            SqlCommand sqlCmd = new SqlCommand("UserAddActivity", sqlConActivity);
        //            sqlCmd.CommandType = CommandType.StoredProcedure;
        //            sqlCmd.Parameters.AddWithValue("@username", username.Trim());
        //            sqlCmd.Parameters.AddWithValue("@action", "nu s-au completata toate campurile la signup");
        //            sqlCmd.Parameters.AddWithValue("@timestamp", localData);
        //            sqlCmd.ExecuteNonQuery();
        //        return "nu ai completat toate campurile";
        //        }
        //    }
        //internal string signUp2(string username, string password, string passwordverification)
        //{
        //    using (SqlConnection sqlConActivity = new SqlConnection(connectionString))
        //    {
        //        sqlConActivity.Open();
        //        DateTime localData = DateTime.Now;

        //        SqlCommand sqlCmd = new SqlCommand("UserAddActivity", sqlConActivity);
        //        sqlCmd.CommandType = CommandType.StoredProcedure;
        //        sqlCmd.Parameters.AddWithValue("@username", username.Trim());
        //        sqlCmd.Parameters.AddWithValue("@action", "password do not match la signUp");
        //        sqlCmd.Parameters.AddWithValue("@timestamp", localData);
        //        sqlCmd.ExecuteNonQuery();
        //        return "parolele nu se potrivesc";
        //    }
        //}
        //internal string signUp3(string username, string password, string passwordverification) {
        //    using (SqlConnection sqlCon = new SqlConnection(connectionString))
        //    {
        //        SqlConnection sqlConActivity = new SqlConnection(connectionString);
        //        sqlConActivity.Open();
        //        DateTime localData = DateTime.Now;
        //        sqlCon.Open();


        //        SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
        //        SqlCommand sqlCmd1 = new SqlCommand("UserAddActivity", sqlConActivity);
        //        sqlCmd1.CommandType = CommandType.StoredProcedure;
        //        sqlCmd1.Parameters.AddWithValue("@username", username.Trim());
        //        sqlCmd1.Parameters.AddWithValue("@action", "new username signup");
        //        sqlCmd1.Parameters.AddWithValue("@timestamp", localData);


        //        sqlCmd.CommandType = CommandType.StoredProcedure;
        //        sqlCmd.Parameters.AddWithValue("@name", username.Trim());
        //        sqlCmd.Parameters.AddWithValue("@pass", password.Trim());
        //        sqlCmd.ExecuteNonQuery();
        //        sqlCmd1.ExecuteNonQuery();
        //        //  MessageBox.Show("registration succesfull");
        //        // mConfirmPasswordTextBox.Clear();
        //        // Clear();
        //    }
        //    return "inregistrare reusita! bravo, esti cineva";
        //}
    }
}
