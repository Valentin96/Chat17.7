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
    class Server
    {
        IPEndPoint end;
        Socket sock;

        public Server()
        {
            end = new IPEndPoint(IPAddress.Any, 3014);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sock.Bind(end);
        }

        public static string path;
        public static string MesajCurrent = "Stopped";

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
    }
}
