using Chat;
using Modul_Utilizator;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{


    public partial class Form1 : Form
    {
        private bool checkLogIn = false;
        string connectionString = @"Data Source=.;Initial Catalog=Test;Integrated Security=True";
        BusinessLayer business = new BusinessLayer();
        public ClientSettings Client { get; set; }
        public Form1()
        {
            InitializeComponent();
            Client = new ClientSettings();
        }
        // public readonly LoginForm formLogin = new LoginForm();
        public string getUser()
        {
            return mUserNameTextBox.Text.Trim();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

#if DEBUG
                        
                        mUserNameTextBox.Text = "vali";
                         mPasswordTextBox.Text = "987";
#endif
        }

        private void Client_Connected(object sender, EventArgs e)
        {
            this.Invoke(Close);
        }

        public void LoginForm_Load(object sender, EventArgs e)
        {

        }
        public void label1_Click(object sender, EventArgs e)
        {

        }
        public void Arat()
        {
            this.Show();
        }




        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
        Database db = new SqlDatabase();
        Activity activ = new Activity();
        string ip = "127.0.0.1";
        public bool check = false;
        public async void mLoginButton_Click(object sender, EventArgs e)
        {
            // string phoneNumber = null;
            // business.login(mUserNameTextBox.Text, mPasswordTextBox.Text);

            bool ok = business.login(mUserNameTextBox.Text, mPasswordTextBox.Text);
            if (ok)
            {
                // this.Hide();
                Client.Connected += Client_Connected;
                Client.Connect(ip, 3000);
                Client.Send("Connect|" + mUserNameTextBox.Text.Trim() + "|connected");
                 check = true;

                // Utilizator ss = new Utilizator();
                //FormServer qq = new FormServer();

                //  ss.Show();
                //qq.Show();
                //  await Task.Delay(3000);
                // Utilizator ss = new Utilizator();
                // ss.Show();

                //  Client.Connected += Client_Connected;


            }
            else MessageBox.Show("parola sau username gresite");



        }

        public bool getCkeck()
        {
            return check;
        }


        private void mExitButton_Click(object sender, EventArgs e)
        {
              this.Close();
            Application.Exit();
           
        }



        private void panelSignUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void mPasswordLabelLogin_Click_Click(object sender, EventArgs e)
        {

        }

        public void mUserNameLabel_Click_Click(object sender, EventArgs e)
        {

        }

        private void mSignUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void mPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mUserNameTextBoxSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void mPasswordTextBoxSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void mConfirmPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void mConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //private bool UserExists(string username)
        //{
        //    using (SqlConnection sqlConActivity = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("CheckUserExists", sqlConActivity);

        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new SqlParameter("@name", username));

        //        SqlDataReader reader = cmd.ExecuteReader(); // execute the function


        //        // return the respreonse from the reader (1 if it is true, 0 for false)
        //    }
        //}

        private void mButtonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConActivity = new SqlConnection(connectionString))
                {
                    sqlConActivity.Open();

                    //if (mUserNameTextBoxSignUp.Text == "" || mPasswordTextBoxSignUp.Text == "")
                    //{

                    //    DateTime localData = DateTime.Now;

                    //    SqlCommand sqlCmd = new SqlCommand("UserAddActivity", sqlConActivity);
                    //    sqlCmd.CommandType = CommandType.StoredProcedure;
                    //    sqlCmd.Parameters.AddWithValue("@username", mUserNameTextBoxSignUp.Text.Trim());
                    //    sqlCmd.Parameters.AddWithValue("@action", "nu s-au completata toate campurile la signup");
                    //    sqlCmd.Parameters.AddWithValue("@timestamp", localData);
                    //    sqlCmd.ExecuteNonQuery();
                    //    MessageBox.Show("completeaza campurile obligatorii");
                    //}
                    //else if (mPasswordTextBoxSignUp.Text != mConfirmPasswordTextBox.Text)
                    //{

                    //    DateTime localData = DateTime.Now;
                    //    MessageBox.Show("password do not match");
                    //    SqlCommand sqlCmd = new SqlCommand("UserAddActivity", sqlConActivity);
                    //    sqlCmd.CommandType = CommandType.StoredProcedure;
                    //    sqlCmd.Parameters.AddWithValue("@username", mUserNameTextBoxSignUp.Text.Trim());
                    //    sqlCmd.Parameters.AddWithValue("@action", "password do not match la signUp");
                    //    sqlCmd.Parameters.AddWithValue("@timestamp", localData);
                    //    sqlCmd.ExecuteNonQuery();
                    //}

                    //else
                    //{

                    //    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    //    {
                    //        DateTime localData = DateTime.Now;
                    //        sqlCon.Open();


                    //        SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    //        SqlCommand sqlCmd1 = new SqlCommand("UserAddActivity", sqlConActivity);
                    //        sqlCmd1.CommandType = CommandType.StoredProcedure;
                    //        sqlCmd1.Parameters.AddWithValue("@username", mUserNameTextBoxSignUp.Text.Trim());
                    //        sqlCmd1.Parameters.AddWithValue("@action", "new username signup");
                    //        sqlCmd1.Parameters.AddWithValue("@timestamp", localData);


                    //        sqlCmd.CommandType = CommandType.StoredProcedure;
                    //        sqlCmd.Parameters.AddWithValue("@name", mUserNameTextBoxSignUp.Text.Trim());
                    //        sqlCmd.Parameters.AddWithValue("@pass", mPasswordTextBoxSignUp.Text.Trim());
                    //        sqlCmd.ExecuteNonQuery();
                    //        sqlCmd1.ExecuteNonQuery();
                    //        MessageBox.Show("registration succesfull");
                    //        mConfirmPasswordTextBox.Clear();
                    //        Clear();
                    //    }
                    //}
                    int administrator = 1;
                    string cheie = "cheie";
                    business.signUP(mUserNameTextBoxSignUp.Text, mPasswordTextBoxSignUp.Text, mConfirmPasswordTextBox.Text, mTextBoxPhoneNumberSignUp.Text, cheie, administrator);


                    MessageBox.Show("bravo, esti cineva!");
                }
            }
            catch (Exception exceptie)
            {
                CodeException exc = exceptie as CodeException;
                MessageBox.Show(exc.mesaj.ToString());
            }

        }
        void Clear()
        {
            mUserNameTextBoxSignUp.Text = mPasswordTextBoxSignUp.Text = "";
        }

        private void mButtonResetPassword_Click(object sender, EventArgs e)
        {

            // this.Hide();
            ResetPassword ss = new ResetPassword();
            ss.ShowDialog();
        }

        private void mTextBoxPhoneNumberSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        public void mUserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ControlBox = false;
        }
    }
}

