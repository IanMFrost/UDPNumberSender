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
    class UDPNumberSenderBroad
    {
        static void Main(string[] args)
        {
            UdpClient Udpsender = new UdpClient(0);
            Udpsender.EnableBroadcast = true;
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Broadcast, 1111);

            int number = 0;
            while(true)
            {
                number++;
                string sendData = "The number is:" + number;
                Byte[] sendBytes = Encoding.ASCII.GetBytes(sendData);
                Udpsender.Send(sendBytes, sendBytes.Length, endpoint);
                Thread.Sleep(100);
            }


           
        }
       
    }
}
