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

namespace Server
{
    public partial class ServerForm : Form
    {
        delegate void AppendTextDelegate(string s);
        AppendTextDelegate textAppender;
        Socket serverSocket;
        IPAddress thisAddress;
        List<Socket> connectClientList;

        public ServerForm()
        {
            InitializeComponent();
        }

        // Form Load 시 초기화
        private void ServerForm_Load(object sender, EventArgs e)
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            textAppender = new AppendTextDelegate(AppendText);
            connectClientList = new List<Socket>();

            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress addr in hostEntry.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisAddress = addr;
                    break;
                }

            }

            if (thisAddress == null) thisAddress = IPAddress.Loopback;
            textAddress.Text = thisAddress.ToString();
            dataGridView.ReadOnly = true;
        }

        // 시작 버튼 클릭 시 연결 시작
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            int port;
            if (serverSocket == null)
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                connectClientList = new List<Socket>();
            }
            try { port = Int32.Parse(textPort.Text); }
            catch
            {
                MessageBox.Show("포트 번호가 잘못 입력되었습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPort.Focus();
                textPort.SelectAll();
                return;
            }

            if (serverSocket.IsBound)
                MessageBox.Show("서버가 실행 중입니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (port < 0 || port > 65535)
            {
                MessageBox.Show("포트 번호가 잘못 입력되었습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPort.Focus();
                textPort.SelectAll();
            }
            else
            {
                IPEndPoint endPoint = new IPEndPoint(thisAddress, port);
                serverSocket.Bind(endPoint);
                serverSocket.Listen(20);

                serverSocket.BeginAccept(acceptcallback)
            }
        }

        // Client에서 연결 신호가 들어오면 시작되는 Callback
        private void AcceptCallback(IAsyncResult asyncResult)
        {
            try
            {
                Socket client = serverSocket.EndAccept(asyncResult);

                serverSocket.BeginAccept(AcceptCallback, null);

                Ayncobje

                

            }
            catch { }
        }

        // 메시지, 상태 등의 내역 쓰기
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
