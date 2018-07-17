using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class BusinessLayer
    {
        DataLayer data = new DataLayer();

        

        public bool login(string username, string password)
        {
           // data.login(username, password);
            bool ok= data.login(username, password );
            if (ok)
            {
                data.insertLog(username.Trim(), "nou login ", DateTime.Now);
            } 
            else if (!ok)
            {
                data.insertLog(username.Trim(), "eroare parola sau username gresite", DateTime.Now);
               // throw new Exception("Login failed");
            }
            return ok;
        }
        public bool resetPassword(string phoneNumber)
        {
            bool ok = data.resetPassword(phoneNumber);
            return ok; 
        }
        public int signUP(string username, string password, string passwordverification, string phoneNumber, string cheie, int administrator)
        {

            try
            {
               
                int ok = 300;
                if (username == "" || password == "")
                {
                    ok = 1;
                    data.insertLog(username, "empty username or password", DateTime.Now);
                    throw new CodeException(CodeException.EmptyField, "empty username or password");
                    
                    
                }
                else if (password != passwordverification)
                {
                    ok = 2;
                    data.insertLog(username, "password dont match", DateTime.Now);
                    throw new CodeException(CodeException.DifferentPassword,"password dont match");
                    
                    

                }
                else if(data.checkUserNameAtSignUp(username) == true)
                {
                    ok = 3;
                    data.insertLog(username, "username already in database", DateTime.Now);
                    throw new CodeException(CodeException.SignUpAlreadyExists, "username existent");
                }
                else if(data.checkPhoneNumberAtSignUp(phoneNumber) == true)
                {
                    ok = 3;
                    data.insertLog(username, "phone already in database", DateTime.Now);
                    throw new CodeException(CodeException.SignUpAlreadyExists, "nr de telefon existent");
                }
                
              
                else
                {
                   
                    ok = 0;
                   
                        data.insertLog(username.Trim(), "nou signUp", DateTime.Now);
                        data.signUp(username, password, phoneNumber, cheie, administrator);
                
                    

                }

                return ok;

            }
            catch(SqlException e)
            {
                return CodeException.SignUpAlreadyExists;
            }
            
            
            }

    }
}
