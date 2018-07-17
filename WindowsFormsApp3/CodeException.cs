using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class CodeException : Exception
    {
        public int ErrorCode;
        public string mesaj;
        public static int EmptyField = 1;
        public static int SignUpAlreadyExists = 0;
        public static int DifferentPassword = 2;
        public static int ResetPasswordNumberNotKnown = 3;
        
        public CodeException() { }
        //public CodeException(int code)
        //{
        //    ErrorCode = code;
        //}
        public CodeException(int code, string message)
        {
            ErrorCode = code;
            mesaj = message;

        }
    }
}
