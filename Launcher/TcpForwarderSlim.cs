using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Launcher
{
    class TcpForwarderSlim
    {
        // Token: 0x06000004 RID: 4 RVA: 0x00002404 File Offset: 0x00000604
        public Thread Start(IPEndPoint local, IPEndPoint remote)
        {
            this._mainSocket.Bind(local);
            this._mainSocket.Listen(10);
            return new Thread(() =>
            {
                for (; ; )
                {
                    Socket socket = this._mainSocket.Accept();
                    TcpForwarderSlim tcpForwarderSlim = new TcpForwarderSlim();
                    TcpForwarderSlim.State state = new TcpForwarderSlim.State(socket, tcpForwarderSlim._mainSocket);
                    tcpForwarderSlim.Connect(remote, socket);
                    socket.BeginReceive(state.Buffer, 0, state.Buffer.Length, SocketFlags.None, new AsyncCallback(TcpForwarderSlim.OnDataReceive), state);

                }
            });
        }

        // Token: 0x06000005 RID: 5 RVA: 0x00002478 File Offset: 0x00000678
        private void Connect(EndPoint remoteEndpoint, Socket destination)
        {
            TcpForwarderSlim.State state = new TcpForwarderSlim.State(this._mainSocket, destination);
            this._mainSocket.Connect(remoteEndpoint);
            this._mainSocket.BeginReceive(state.Buffer, 0, state.Buffer.Length, SocketFlags.None, new AsyncCallback(TcpForwarderSlim.OnDataReceive), state);
        }

        // Token: 0x06000006 RID: 6 RVA: 0x000024C8 File Offset: 0x000006C8
        private static void OnDataReceive(IAsyncResult result)
        {
            TcpForwarderSlim.State state = (TcpForwarderSlim.State)result.AsyncState;
            try
            {
                int num = state.SourceSocket.EndReceive(result);
                if (num > 0)
                {
                    state.DestinationSocket.Send(state.Buffer, num, SocketFlags.None);
                    state.SourceSocket.BeginReceive(state.Buffer, 0, state.Buffer.Length, SocketFlags.None, new AsyncCallback(TcpForwarderSlim.OnDataReceive), state);
                }
            }
            catch
            {
                state.DestinationSocket.Close();
                state.SourceSocket.Close();
            }
        }

        // Token: 0x04000001 RID: 1
        private readonly Socket _mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // Token: 0x02000007 RID: 7
        private class State
        {
            // Token: 0x17000004 RID: 4
            // (get) Token: 0x06000016 RID: 22 RVA: 0x000026E2 File Offset: 0x000008E2
            // (set) Token: 0x06000017 RID: 23 RVA: 0x000026EA File Offset: 0x000008EA
            public Socket SourceSocket { get; private set; }

            // Token: 0x17000005 RID: 5
            // (get) Token: 0x06000018 RID: 24 RVA: 0x000026F3 File Offset: 0x000008F3
            // (set) Token: 0x06000019 RID: 25 RVA: 0x000026FB File Offset: 0x000008FB
            public Socket DestinationSocket { get; private set; }

            // Token: 0x17000006 RID: 6
            // (get) Token: 0x0600001A RID: 26 RVA: 0x00002704 File Offset: 0x00000904
            // (set) Token: 0x0600001B RID: 27 RVA: 0x0000270C File Offset: 0x0000090C
            public byte[] Buffer { get; private set; }

            // Token: 0x0600001C RID: 28 RVA: 0x00002715 File Offset: 0x00000915
            public State(Socket source, Socket destination)
            {
                this.SourceSocket = source;
                this.DestinationSocket = destination;
                this.Buffer = new byte[8192];
            }
        }
    }
}
