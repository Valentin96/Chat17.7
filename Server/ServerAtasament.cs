using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul_Utilizator
{
    public partial class ServerAtasament : Form
    {
        public ServerAtasament()
        {
            InitializeComponent();
            Server.path = "";

        }
        Server server = new Server();
        private void timer1_Tick(object sender, EventArgs e)
        {
            mLabelInfo.Text = Server.MesajCurrent + Environment.NewLine + Server.path;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            server.StartServer();
        }

        private void ServerAtasament_Load(object sender, EventArgs e)
        {
           
        }

        private void mButtonReceiveFille_Click(object sender, EventArgs e)
        {
            Server.path = Application.StartupPath;
            if (Server.path.Length > 0)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
                MessageBox.Show("alta locatie de ales");
        }
    }
}
