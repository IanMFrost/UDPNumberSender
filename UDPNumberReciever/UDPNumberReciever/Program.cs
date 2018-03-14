using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPNumberReciever
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a UdpClient for reading incoming data.
            UdpClient udpServer = new UdpClient(9876);

            //Creates an IPEndPoint to record the IP Address and port number of the sender.  
            IPAddress ip = IPAddress.Parse("192.168.6.51");
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip, 9999);

            while(true)
            {
                Byte[] RecieveBytes = udpServer.Receive(ref RemoteIpEndPoint);
                string recieveData = Encoding.ASCII.GetString(RecieveBytes);

                Console.WriteLine(recieveData);
            }
        }
    }
}
