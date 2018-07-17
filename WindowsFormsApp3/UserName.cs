using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class UserName
    {
        private String _name;
        private String _password;
        private String _phoneNumber;
        #region Properties
        public string Password { get => _password; set => _password = value; }
        public string Name { get => _name; set => _name = value; }
        #endregion

        public UserName(string argName, string argPassword, string argPhoneNumber)
        {
            _name = argName;
            _password = argPassword;
            _phoneNumber = argPhoneNumber;

        }

    }
}
