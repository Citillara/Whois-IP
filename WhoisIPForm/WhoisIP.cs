using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhoisIPForm
{
    static class WhoisIP
    {
        public static string Query(string ip, string host)
        {
            string retval = "";
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(host, 43);
                NetworkStream ns = client.GetStream();
                StreamWriter writer = new StreamWriter(ns);
                
                StringBuilder sb = new StringBuilder();
                ns.ReadTimeout = 5000;

                writer.WriteLine(ip);
                writer.Flush();
                StreamReader reader = new StreamReader(ns);
                retval  = reader.ReadToEnd();
                //do
                //{
                //    byte[] buffer = new byte[1024];
                //    int read = ns.Read(buffer, 0, 1024);
                //    sb.Append(Encoding.UTF8.GetString(buffer, 0, read));
                //} while (ns.DataAvailable);

                //ns.Close();
                //client.Close();
                //retval = sb.ToString();
            }
            catch
            {
            }
            return retval;
        }
    }
}
