﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UDPNumberSender
{
    class Program
    {
        void Main(string[] args)
        {
            int number = 0;

            IPAddress ip = IPAddress.Parse("127.0.0.1"); 
            UdpClient udpClient = new UdpClient("127.0.0.1", 9999);

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip, 9999); 




            while(true)
            {
                Console.WriteLine("The number is:" + number);
                number++;
                string sendData = "The number is:" + number;
                Byte[] sendBytes = Encoding.ASCII.GetBytes(sendData);

                udpClient.Send(sendBytes, sendBytes.Length);
                Thread.Sleep(100);
            }



            //udpClient.Connect(RemoteIpEndPoint); //
        }
    }
}
