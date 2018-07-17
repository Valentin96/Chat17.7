using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class ResetPassword : Form
    {
        string connectionString = @"Data Source=.;Initial Catalog=Chat;Integrated Security=True";
        
        private DataTable dataTable = new DataTable();
        Activity activitate = new Activity();
        public ResetPassword()
        {
            InitializeComponent();
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

       














        private void mTextBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void mTextBoxNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void mTextBoxNewPasswordConfirmation_TextChanged(object sender, EventArgs e)
        {
            

        }

        private bool checkUserName()
        {
            return true;
        }
        bool what;
        private void mButtonConfirmation_Click(object sender, EventArgs e)
        {
            if (mTextBoxNewPassword.Text.Trim() != mTextBoxNewPasswordConfirmation.Text.Trim())
            {
                insertLog(mTextBoxPhoneNumber.Text.Trim(), "password dont match at resetPassword",DateTime.Now);
                MessageBox.Show("password dont match!");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    bool ok = false;
                    con.Open();
                    string command = "SELECT * FROM Chat";
                    PullData(dataTable);
                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {


                        foreach (DataRow row in dataTable.Rows)
                        {
                            string name = row["name"].ToString();
                            // string pass = row["pass"].ToString();
                            string phoneNr = row["phone"].ToString().Trim();
                            //  MessageBox.Show(phone);
                            //MessageBox.Show(mTextBoxPhoneNumber.Text);
                            if (mTextBoxPhoneNumber.Text.Trim() == phoneNr)
                            {
                                ok = true;
                                SqlCommand cmd2 = new SqlCommand(@"UPDATE USERS set pass='" + mTextBoxNewPassword.Text.Trim() + "' where phone= '" + mTextBoxPhoneNumber.Text.Trim() + "'", con);

                                cmd2.ExecuteNonQuery();
                                insertLog(name, "ResetPassword", DateTime.Now);

                            }



                        }
                        what = ok;
                        if (ok == true)
                        {
                            MessageBox.Show("Update facut");
                            
                        }
                        else
                        {
                            insertLog("unknownName", "ResetPassword", DateTime.Now);
                            MessageBox.Show("Nu exista acest numar de telefon in baza de date");
                        }

                    }
                }
            }
        }
        public bool getValue()
        {
            
            return what;
        }
        public void Inchidere()
        {
            this.Close();
        }
        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
