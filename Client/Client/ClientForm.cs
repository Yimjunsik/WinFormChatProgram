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

        public ClientForm()
        {
            InitializeComponent();
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
