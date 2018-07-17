using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public abstract class Database
    {
        protected List<UserName> _users;

        public Database()
        {
            _users = new List<UserName>();
        }

        public abstract bool CheckCredentials(String argUserName, String argPassoword);
        
       //public abstract bool CheckConfirmPassword(String argPassword, String argCheckPassword);
        public void Print()
        {
            foreach (var item in _users)  
            {
                Console.WriteLine("Username: {0}", item.Name);
                Console.WriteLine("Password:{0}",item.Password);
                //Console.WriteLine("Password: {0}{1}", item.Password, item.Name);
                Console.WriteLine();

            }
        }
    }
}
