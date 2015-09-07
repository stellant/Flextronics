using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TCPServer
{
    class Program
    {
        static Socket s = null;
        static void Main(string[] args)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"),654);
                listener.Start();
                Console.WriteLine("Server Started...");
                long i=654654545454545;
                while (true)
                {
                    s = listener.AcceptSocket();
                    Console.WriteLine("Waiting for a Connection...");
                    Console.WriteLine("Connection Accepted " + s.RemoteEndPoint);
                    Console.WriteLine(i.ToString() + "  " + s.Send(new ASCIIEncoding().GetBytes(i.ToString())));
                    i++;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
