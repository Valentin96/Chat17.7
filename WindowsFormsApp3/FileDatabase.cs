using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{

    public class FileDatabase : Database
    {
        private string pathUserName = @"C:\DataBase\UserName.txt";
        private string pathPassword = @"C:\DataBase\Password";

        public override bool CheckCredentials(string argUserName, string argPassoword)
        {
            LoadUsersfromFile();
           
            foreach (var user in _users)
            {
                if(argUserName == user.Name && argPassoword == user.Password)
                {
                    return true;

                }
                
            }

            return false;
        }

        private void LoadUsersfromFile()
        {
            using (StreamReader s = File.OpenText(pathUserName))
            {

                string str = "";
                while ((str = s.ReadLine()) != null)
                {
                    string[] words = str.Split(' ');
                    UserName user = new UserName(words[0], words[1],words[2]);
                    _users.Add(user);

                }
            }
        }

        //public override void Print()
        //{
        //    Console.WriteLine("FileDatabase");
        //    //foreach (var item in _users)
        //    //{
        //    //    Console.WriteLine("FileUsername: {0}", item.Name);
        //    //    Console.WriteLine("FilePassword: {1}", item.Password);
        //    //    Console.WriteLine();

        //    //}
        //}
    }
}
