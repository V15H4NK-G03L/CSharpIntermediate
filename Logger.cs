using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace CSharpIntermediate
{
    public class IpAddress
    {
        public IPAddress[] ipAddressArray = Dns.GetHostAddresses(Dns.GetHostName());
    }
    public static class Logger
    {
        public static void WriteLog(string message)
        {
            string logPath = ConfigurationManager.AppSettings["logPath"];

            IpAddress CurrentIpAddress = new IpAddress();
            int IpIndex=0;

            for (int i = 0; i < CurrentIpAddress.ipAddressArray.Length; i++)
            {
                if (CurrentIpAddress.ipAddressArray[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    IpIndex = i;
                    //Console.WriteLine(IpIndex);
                    break;
                }
            }
            //Console.WriteLine(IpIndex);
            //Console.Read();
            string IPAddress = CurrentIpAddress.ipAddressArray[IpIndex].ToString();

            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"[{DateTime.Now}] [{IPAddress}] : {message}");
            }
        }
    }
}
