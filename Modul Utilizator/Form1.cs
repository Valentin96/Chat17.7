using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using Server;
using NonCiclic;
using WindowsFormsApp3;

namespace Modul_Utilizator
{
    public partial class Utilizator : Form
    {
         public ClientSettings Client { get; set; }
        public Form1 formLogin = new Form1();
        Form1 ff = new Form1();
        // Client = new ClientSettings();

        String ip = "127.0.0.1";
        //String userName = "aa";
         
        
        public Utilizator()
        {
           

                InitializeComponent();



                // FormServer qq = new FormServer();
                Client = new ClientSettings();
           
          //  this.Text = "TCP Chat - " + ip + " - (Connected as: " + formLogin.getUser() + ")";
        }
        private Timer timer1;
        //public void InitTimer()
        //{
        //    timer1 = new Timer();
        //    timer1.Tick += new EventHandler(timer1_Tick);
        //    timer1.Interval = 500; // in miliseconds
        //    timer1.Start();
        //}



        ClasaPtProsti fs = new ClasaPtProsti();
        private void timer1_Tick(object sender, EventArgs e)
        {
            mListBoxUsersList.Items.Clear();
            mListBoxUsersList = fs.tare();

        }

       
        private void Client_Disconnected(WindowsFormsApp3.ClientSettings cs)
        {
            //this.Invoke(() =>
            //{

            //   // mListBoxUsersList.Items.Remove(this);
            //    //for (int i = 0; i < mListBoxUsersList.Items.Count; i++)
            //    //{


            //    //    var client = mListBoxUsersList.Items[i].Tag as Client;
            //    //    if (client.Ip == sender.Ip)
            //    //    {
            //    //        txtReceive.Text += "<< " + clientList.Items[i].SubItems[1].Text + " has left the room >>\r\n";
            //    //        BroadcastData("RefreshChat|" + txtReceive.Text);
            //    //        clientList.Items.RemoveAt(i);

            //    //    }
            //    //}
            //});
        }
        
        protected override void OnLoad(EventArgs e)
        {
            //if (formLogin.getCkeck() == true)
            //{
                base.OnLoad(e);

                // Client.Connected += Client_Connected;
                //Client.Connect(ip, 2014);
                //Client.Send("Connect|" + userName + "|connected");
                //Client.Received += _client_Received;
                //Client.Disconnected += Client_Disconnected;

                formLogin.Client.Received += _client_Received;
                formLogin.Client.Disconnected += Client_Disconnected;
                Text = "TCP Chat - " + ip + " - (Connected as: " + "user" + ")";
                formLogin.ShowDialog();
                //loginForm.ShowDialog();
          //  }
           // else Application.Exit();
          
        }
        public void _client_Received(WindowsFormsApp3.ClientSettings cs, string received)
        {
            var cmd = received.Split('|');
            switch (cmd[0])
            {
                case "Users":
                    this.Invoke(() =>
                    {
                        mListBoxUsersList.Items.Clear();
                        for (int i = 1; i < cmd.Length; i++)
                        {
                            if (cmd[i] != "Connected" | cmd[i] != "RefreshChat")
                            {
                                mListBoxUsersList.Items.Add(cmd[i]);
                            }
                        }
                    });
                    break;
                case "Message":
                    this.Invoke(() =>
                    {

                        mTextBoxReceiveMessages.Text += cmd[1] + "\r\n";

                        if (cmd[1] == "RefreshChat")
                        {
                            mListBoxUsersList.Items.Clear();
                            for (int i = 2; i < cmd.Length; i++)
                            {
                                if (cmd[i] != "Connected" | cmd[i] != "RefreshChat" | cmd[i] != "Message")
                                {
                                    mListBoxUsersList.Items.Add(cmd[i]);
                                }
                                // mTextBoxReceiveMessages.Text += cmd[1] + "\r\n";
                            }
                        }

                    });
                    break;
                //case "Chat":
                //    this.Invoke(() =>
                //    {
                //        pChat.Text = pChat.Text.Replace("user", formLogin.mUserNameTextBox.Text);
                //        pChat.Show();
                //    });
                //    break;
                case "RefreshChat":
                    this.Invoke(() =>
                    {

                        //  mListBoxUsersList.Items.Clear();
                        //mListBoxUsersList.Items.Clear();
                        mTextBoxReceiveMessages.Text = cmd[1];
                        //for (int i = 2; i < cmd.Length; i++)
                        //{
                        //    if (cmd[i] != "Connected" | cmd[i] != "RefreshChat" | cmd[i] != "Message")
                        //    {
                        //        mListBoxUsersList.Items.Add(cmd[i]);
                        //    }
                        //    // mTextBoxReceiveMessages.Text += cmd[1] + "\r\n";
                        //}
                        //foreach (var item in cmd[2])
                        //{
                        //    mListBoxUsersList.Items.Add(cmd[2]);
                        //}

                    });
                    break;


                case "Disconnect":
                    mListBoxUsersList.Items.Clear();
                    Application.Exit();
                    break;
           //     default:
           //         this.Invoke(() =>
           //{
           //    mListBoxUsersList.Items.Clear();
           //    for (int i = 1; i < cmd.Length; i++)
           //    {
           //        if (cmd[i] != "Users" | cmd[i] != "Connected" | cmd[i] != "RefreshChat" | cmd[i] != "Message")
           //        {
           //            mListBoxUsersList.Items.Add(cmd[i]);
           //        }
           //        mTextBoxReceiveMessages.Text += cmd[1] + "\r\n";
           //    }
           //});
           //         break;
            }
        }


        private void Client_Connected(object sender, EventArgs e)
        {
            this.Invoke(Close);
        }

        private void mTextBoxMessages_TextChanged(object sender, EventArgs e)
        {

        }

        private void mButtonSend_Click(object sender, EventArgs e)
        {
            if (mTextBoxInput.Text != string.Empty)
            {
                formLogin.Client.Send("Message|" + "user" + "|" + mTextBoxInput.Text);
                mTextBoxReceiveMessages.Text += "user" + " says: " + mTextBoxInput.Text + "\r\n";
                mTextBoxInput.Text = string.Empty;
            }
        }

        private void mTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    mButtonSend.PerformClick();
            //}
        }

        private void mTextBoxReceiveMessages_TextChanged(object sender, EventArgs e)
        {
            mTextBoxReceiveMessages.SelectionStart = mTextBoxReceiveMessages.TextLength;
        }














        // OpenFileDialog dlg_open_file = new OpenFileDialog();
        private void mButtonSendAttachment_Click(object sender, EventArgs e)
        {





            Atasament at = new Atasament();
            ServerAtasament s = new ServerAtasament();
            s.Show();
            at.Show();






























            //if (dlg_open_file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    String selected_file = dlg_open_file.FileName;
            //    String file_name = Path.GetFileName(selected_file);
            //    FileStream fs = new FileStream(selected_file, FileMode.Open);
            //    TcpClient tc = new TcpClient("127.0.0.1", 2014);
            //    NetworkStream ns = tc.GetStream();
            //    byte[] data_tosend = CreateDataPacket(Encoding.UTF8.GetBytes("125"), Encoding.UTF8.GetBytes(file_name));
            //    ns.Write(data_tosend, 0, data_tosend.Length);
            //    ns.Flush();
            //    Boolean loop_break = false;
            //    while (true)
            //    {
            //        if (ns.ReadByte() == 2)
            //        {
            //            byte[] cmd_buff = new byte[3];
            //            ns.Read(cmd_buff, 0, cmd_buff.Length);
            //            byte[] recv_data = ReadStream(ns);
            //            switch (Convert.ToInt32(Encoding.UTF8.GetString(cmd_buff)))
            //            {
            //                case 126:
            //                    long recv_file_pointer = long.Parse(Encoding.UTF8.GetString(recv_data));
            //                    if (recv_file_pointer != fs.Length)
            //                    {
            //                        fs.Seek(recv_file_pointer, SeekOrigin.Begin);
            //                        int temp_buff_length = (int)(fs.Length - recv_file_pointer < 20000 ? fs.Length - recv_file_pointer : 20000);
            //                        byte[] temp_buff = new byte[temp_buff_length];
            //                        fs.Read(temp_buff, 0, temp_buff.Length);
            //                        byte[] data_to_send = CreateDataPacket(Encoding.UTF8.GetBytes("127"), temp_buff);
            //                        ns.Write(data_to_send, 0, data_to_send.Length);
            //                        ns.Flush();
            //                        pb_upload.Value = (int)Math.Ceiling((double)recv_file_pointer / (double)fs.Length * 100);
            //                    }
            //                    else 
            //                    {
            //                        byte[] data_to_send = CreateDataPacket(Encoding.UTF8.GetBytes("128"), Encoding.UTF8.GetBytes("Close"));
            //                        ns.Write(data_to_send, 0, data_to_send.Length);
            //                        ns.Flush();
            //                        fs.Close();
            //                        loop_break = true;
            //                    }
            //                    break;
            //                default:
            //                    break;
            //            }
            //        }
            //        if (loop_break == true)
            //        {
            //            ns.Close();
            //            break;
            //        }
            //    }
            //}
        }

        private void mListBoxUsersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Utilizator_Load(object sender, EventArgs e)
        {

        }

       


        //public byte[] ReadStream(NetworkStream ns)
        //{
        //    byte[] data_buff = null;

        //    int b = 0;
        //    String buff_length = "";
        //    while ((b = ns.ReadByte()) != 4)
        //    {
        //        buff_length += (char)b;
        //    }
        //    int data_length = Convert.ToInt32(buff_length);
        //    data_buff = new byte[data_length];
        //    int byte_read = 0;
        //    int byte_offset = 0;
        //    while (byte_offset < data_length)
        //    {
        //        byte_read = ns.Read(data_buff, byte_offset, data_length - byte_offset);
        //        byte_offset += byte_read;
        //    }

        //    return data_buff;
        //}
        //private byte[] CreateDataPacket(byte[] cmd, byte[] data)
        //{
        //    byte[] initialize = new byte[1];
        //    initialize[0] = 2;
        //    byte[] separator = new byte[1];
        //    separator[0] = 4;
        //    byte[] datalength = Encoding.UTF8.GetBytes(Convert.ToString(data.Length));
        //    MemoryStream ms = new MemoryStream();
        //    ms.Write(initialize, 0, initialize.Length);
        //    ms.Write(cmd, 0, cmd.Length);
        //    ms.Write(datalength, 0, datalength.Length);
        //    ms.Write(separator, 0, separator.Length);
        //    ms.Write(data, 0, data.Length);
        //    return ms.ToArray();
        //}
    }
}

