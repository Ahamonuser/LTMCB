using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        IPEndPoint ep;
        byte[] buff = new byte[1024];

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //string ServerIP = txtIP.Text;
            //int ServerPort = Convert.ToInt32(txtPort.Text);
            ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
            socket.Connect(ep);
            socket.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(recv), socket);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string TextToSend = txtSend.Text;
            byte[] msg = Encoding.ASCII.GetBytes(TextToSend);
            socket.SendTo(msg, ep);
            txtSend.Text = "";
        }

        void recv(IAsyncResult res)
        {
            int received = socket.EndReceive(res);
            byte[] buff = new byte[received];
            string received_data = Encoding.UTF8.GetString(buff);
            UpdateChat(received_data);
            socket.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(recv), socket);
        }

        void UpdateChat(string data)
        {
            if (this.txtChat.InvokeRequired)
            {
                UpdateChatCallBack updateChat = new UpdateChatCallBack(UpdateChat);
                this.Invoke(updateChat, new object[] { data });
            }
            else
            {
                txtChat.Text += "Server: " + data + "\r\n";
            }
        }

        delegate void UpdateChatCallBack(string text);
    }
}
