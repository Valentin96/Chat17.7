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
    public partial class LoginForm : Form
    {
        public ClientSettings Client { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            Client = new ClientSettings();
          
        }

        private void txtNickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Client.Connected += Client_Connected;
            Client.Connect(txtIP.Text.Trim(), 2014);
            Client.Send("Connect|" + txtNickname.Text.Trim() + "|connected");
        }
        private void Client_Connected(object sender, EventArgs e)
        {
            this.Invoke(Close);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
