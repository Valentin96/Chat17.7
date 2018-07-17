using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Modul_Utilizator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
                //FormServer qq = new FormServer();
                //qq.Show();

                Application.Run(new Utilizator());
            
        }
        public static void Invoke(this Control control, Action action)
        {
            control.Invoke(action);
        }

    }
}
