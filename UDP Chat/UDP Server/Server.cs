using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UDP_Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        UdpClient listener;
        IPEndPoint groupEP;
        byte[] buff = new byte[1024];

        private void btnListen_Click(object sender, EventArgs e)
        {
            listener = new UdpClient(11000);
            groupEP = new IPEndPoint(IPAddress.Any, 9050);
            listener.BeginReceive(new AsyncCallback(recv), null);
        }

        void recv(IAsyncResult res)
        {
            byte[] received = listener.EndReceive(res, ref groupEP);
            string received_data = Encoding.UTF8.GetString(received);
            UpdateChat(received_data);
            listener.BeginReceive(new AsyncCallback(recv), null);
        }

        void UpdateChat(string data)
        {
            if(this.txtChat.InvokeRequired)
            {
                UpdateChatCallBack updateChat = new UpdateChatCallBack(UpdateChat);
                this.Invoke(updateChat, new object[] { data });
            }
            else
            {
                txtChat.Text += "Client: " + data + "\r\n";
            }
        }

        delegate void UpdateChatCallBack(string text);

        private void btnSend_Click(object sender, EventArgs e)
        {
            listener.Connect(IPAddress.Parse("127.0.0.1"), 9050);
            string TextToSend = txtSend.Text;
            byte[] msg = Encoding.ASCII.GetBytes(TextToSend);
            listener.BeginSend(msg, msg.Length, new AsyncCallback(sendata), null);
            txtSend.Text = "";
        }

        private void sendata(IAsyncResult ia)
        {
            listener.EndSend(ia);
        }
    }
}
