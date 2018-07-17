using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Modul_Utilizator
{
     public class Client
    {
        public delegate void ClientReceiverHandler(Client sender, byte[] data);
        public delegate void ClientDisconnectedHandler(Client sender);
        public event ClientReceiverHandler Received;
        public event ClientDisconnectedHandler Dissconected;
        public static string MesajCurrent = "Idle";
        public IPEndPoint Ip{get; private set;}
        public Socket _socket;

        public Client(Socket accepted)
        {
            _socket = accepted;
            Ip = (IPEndPoint)_socket.RemoteEndPoint;
            _socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, Callback, null);
        }
        void Callback(IAsyncResult ar)
        {
            try
            {
                _socket.EndReceive(ar);
                var buffer = new byte[_socket.ReceiveBufferSize];
                var rec = _socket.Receive(buffer, buffer.Length, 0);
                if(rec < buffer.Length)
                {
                    Array.Resize(ref buffer, rec);
                }
                if (Received != null)
                {
                    Received(this, buffer);

                }
                _socket.BeginReceive(new byte[] { 0 }, 0, 0, 0,  Callback, null); 
            }
            catch (Exception)
            {
                Close();
                if (Dissconected != null)
                {
                    Dissconected(this);

                }
            }
        }
        public void Send(string data)
        {
            var buffer = Encoding.ASCII.GetBytes(data);
            _socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, ar => _socket.EndSend(ar), buffer);
        }
        public void Close()
        {
            _socket.Dispose();
            _socket.Close();

        }


         public static void SendFile(string fName)
        {
            try
            {
                IPAddress ip = IPAddress.Parse("82.137.12.162");
                IPEndPoint end = new IPEndPoint(ip, 3014);
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string path = "";
                fName = fName.Replace("\\", "/");
                while (fName.IndexOf("/") > -1)
                {
                    path += fName.Substring(0, fName.IndexOf("/") + 1);
                    fName = fName.Substring(fName.IndexOf("/") + 1);
                }
                byte[] fNameByte = Encoding.ASCII.GetBytes(fName);
                if (fNameByte.Length > 850 * 1024)
                {
                    MesajCurrent = "Fisieru e mai mare de 850 kb";
                    return;
                }
                MesajCurrent = "Buffering...";

                byte[] fileData = File.ReadAllBytes(path + fName);
                byte[] clientData = new byte[4 + fNameByte.Length + fileData.Length];
                byte[] fNameLen = BitConverter.GetBytes(fNameByte.Length);
                fNameLen.CopyTo(clientData, 0);
                fNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fNameByte.Length);
                MesajCurrent = "Conectare la server...";
                sock.Connect(end);
                MesajCurrent = "Fisierul se trimite...";
                sock.Send(clientData);
                MesajCurrent = "Deconectare...";
                sock.Close();
                MesajCurrent = "Fisierul a fost trimis..";

            }
            catch (Exception ex)
            {

            }
        }

    }
}
