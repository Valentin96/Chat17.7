using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class FormServer : Form
    {
        private readonly Listener listener;
        IPEndPoint end;
        Socket sock;
        public static string path;
        public static string MesajCurrent = "Stopped";
        public List<Socket> clients = new List<Socket>(); // store all the clients into a list

        public void BroadcastData(string data) // send to all clients
        {
            foreach (var socket in clients)
            {
                try { socket.Send(Encoding.ASCII.GetBytes(data)); }
                catch (Exception) { }
            }
        }

        public FormServer()
        {

            InitializeComponent();
            listener = new Listener(3000);
            listener.SocketAccepted += listener_SocketAccepted;
            end = new IPEndPoint(IPAddress.Any, 3001);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sock.Bind(end);
        }


        private void listener_SocketAccepted(Socket e)
        {
            var client = new Client(e);
            client.Received += client_Received;
            client.Disconnected += client_Disconnected;
            this.Invoke(() =>
            {
                string ip = client.Ip.ToString().Split(':')[0];
                var item = new ListViewItem(ip); // ip
                item.SubItems.Add(" "); // nickname
                item.SubItems.Add(" "); // status
                item.Tag = client;
                clientList.Items.Add(item);
                clients.Add(e);
            });
        }
       
        public void client_Disconnected( Client sender, byte[] data)
        {
            this.Invoke(() =>
            {
                for (int i = 0; i < clientList.Items.Count; i++)
                {
                    var client = clientList.Items[i].Tag as Client;
                    if (client.Ip == sender.Ip)
                    {
                        txtReceive.Text += "<< " + clientList.Items[i].SubItems[1].Text + " has left the room >>\r\n";
                       
                        clientList.Items.RemoveAt(i);
                        BroadcastData("RefreshChat|" + txtReceive.Text);

                    }
                }
            });
        }
        ListBox ListaUser;
        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 500; // in miliseconds
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaUser.Items.Clear();
            Lista(ListaUser);

        }
        
        
        private ListBox Lista(ListBox listuta)
       {
             listuta.Items.Clear();
            foreach (var item in clients)
            {
                listuta.Items.Add(item);
            }
            return listuta;
        }
        public ListBox getListaClienti()
        {
           // string t = clientList.ToString();
            return ListaUser;
        }

        String users;

        private void client_Received(Client sender, byte[] data)
        {
            this.Invoke(() =>
            {
                for (int i = 0; i < clientList.Items.Count; i++)
                {
                    var client = clientList.Items[i].Tag as Client;
                    if (client == null || client.Ip != sender.Ip) continue;
                    var command = Encoding.ASCII.GetString(data).Split('|');
                    switch (command[0])
                    {
                        case "Connect":
                            txtReceive.Text += "<< " + command[1] + " joined the room >>\r\n";
                            clientList.Items[i].SubItems[1].Text = command[1]; // nickname
                            clientList.Items[i].SubItems[2].Text = command[2]; // status
                             users = string.Empty;
                            for (int j = 0; j < clientList.Items.Count; j++)
                            {
                                users += clientList.Items[j].SubItems[1].Text + "|";
                            }
                            BroadcastData("Users|" + users.TrimEnd('|'));
                            BroadcastData("RefreshChat|" + txtReceive.Text);
                            break;
                        case "Message":
                            users = string.Empty;
                            for (int j = 0; j < clientList.Items.Count; j++)
                            {
                                users += clientList.Items[j].SubItems[1].Text + "|";
                            }
                            BroadcastData("Users|" + users.TrimEnd('|'));
                            txtReceive.Text += command[1] + " says: " + command[2] + "\r\n";
                            BroadcastData("RefreshChat|" + txtReceive.Text);
                            break;
                       

                    }
                }
            });
        }

        private void Main_Load(object sender, EventArgs e)
        {
            listener.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            listener.Stop();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != string.Empty)
            {
                BroadcastData("Message|" + txtInput.Text);
                txtReceive.Text += txtInput.Text + "\r\n";
                txtInput.Text = "Admin says: ";
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var client in from ListViewItem item in clientList.SelectedItems select (Client)item.Tag)
            {
                client.Send("Disconnect|");
                
            }
        }

        //private void chatWithClientToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    foreach (var client in from ListViewItem item in clientList.SelectedItems select (Client) item.Tag)
        //    {
        //        client.Send("Chat|");
        //        pChat = new PrivateChat(this);
        //        pChat.Show();
        //    }
        //}

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {
            txtReceive.SelectionStart = txtReceive.TextLength;
        }
        public void StartServer()
        {
            try
            {
                MesajCurrent = "Starting...";
                sock.Listen(100);
                MesajCurrent = "Functioneaza si asteapta pt fisiere";
                Socket clientSock = sock.Accept();
                byte[] clientData = new byte[1024 * 5000];
                int receivedByteLen = clientSock.Receive(clientData);
                MesajCurrent = "Se primeste fisier...";
                int fNameLen = BitConverter.ToInt32(clientData, 0);
                string fName = Encoding.ASCII.GetString(clientData, 4, fNameLen);
                BinaryWriter write = new BinaryWriter(File.Open(path + "/" + fName, FileMode.Append));
                write.Write(clientData, 4 + fNameLen, receivedByteLen - 4 - fNameLen);
                MesajCurrent = "Saving file....";
                write.Close();
                clientSock.Close();
                MesajCurrent = "Fisierul a fost primit";
            }
            catch
            {
                MesajCurrent = "Eroare, fisierul nu a fost primit";
            }
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}