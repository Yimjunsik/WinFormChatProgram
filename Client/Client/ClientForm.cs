using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class ClientForm : Form
    {
        delegate void AppendTextDelegate(string s);
        AppendTextDelegate textAppender;
        Socket serverSocket;

        public ClientForm() { InitializeComponent(); }
        
        // Form Load 시 초기화
        public ClientForm(object sender, EventArgs e)
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            textAppender = new AppendTextDelegate(AppendText);

            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress defaultAddress = null;
            foreach (IPAddress addr in hostEntry.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    defaultAddress = addr;
                    break;
                }
            }

            if (defaultAddress == null) defaultAddress = IPAddress.Loopback;
            textAddress.Text = defaultAddress.ToString();
        }


        // 메세지, 상태 등의 내역 쓰기
        private void AppendText(string message)
        {
            if (textStatus.InvokeRequired) textStatus.Invoke(textAppender, message);
            else textStatus.Text += "\r\n" + message;
        }
    }

    // Callback에 대한 내용 저장을 위한 Class
    public class AsyncObject
    {
        public byte[] Buffer;
        public Socket WorkingSocket;
        public readonly int BufferSize;

        public AsyncObject(int bufferSize)
        {
            BufferSize = bufferSize;
            Buffer = new byte[BufferSize];
        }

        public AsyncObject(int buffersize, Socket tempSocket)
            : this(buffersize) { WorkingSocket = tempSocket; }

        public void ClearBuffer() { Array.Clear(Buffer, 0, BufferSize); }
    }
}
