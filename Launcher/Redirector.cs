using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Launcher
{
    public class Redirector
    {
        private List<Thread> threads;

        public Redirector()
        {
            threads = new List<Thread>();
        }

        public void Start()
        {
            RouteIP();
            StartTunnels();
        }

        public void End()
        {
            EndTunnels();
            UnrouteIP();
        }

        private static void RouteIP()
        {
            ProcessStartInfo StartInfo = new ProcessStartInfo();
            StartInfo.FileName = "netsh.exe";
            StartInfo.Arguments = string.Format("int ip add addr 1 address={0} mask=255.255.255.0 st=ac", Constants.GMS_IP);
            StartInfo.UseShellExecute = false;
            StartInfo.CreateNoWindow = true;
            Process.Start(StartInfo).WaitForExit();
        }

        private static void UnrouteIP()
        {
            ProcessStartInfo StartInfo = new ProcessStartInfo();
            StartInfo.FileName = "netsh.exe";
            StartInfo.Arguments = string.Format("int ip delete addr 1 {0}", Constants.GMS_IP);
            StartInfo.UseShellExecute = false;
            StartInfo.CreateNoWindow = true;
            Process.Start(StartInfo).WaitForExit();
        }

        private void StartTunnels()
        {
            try
            {
                ushort lowPort = Constants.LOW_PORT;
                ushort highPort = Constants.HIGH_PORT;
                IPAddress fromIP = IPAddress.Parse(Constants.GMS_IP);
                IPAddress toIP = IPAddress.Parse(Constants.SERVER_IP);
                if (!Utilities.IsLocalhost(Constants.SERVER_IP))
                {
                    for (ushort port = lowPort; port <= highPort; port++)
                    {
                        Thread thread = new Thread(() => new TcpForwarderSlim().Start(new IPEndPoint(fromIP, port), new IPEndPoint(toIP, port)));
                        threads.Add(thread);
                        thread.Start();
                    }
                }
            }
            catch
            { }
        }

        private void EndTunnels()
        {
            foreach (Thread thread in threads)
            {
                thread.Abort();
            }
        }
    }
}
