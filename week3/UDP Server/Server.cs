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
using System.Linq.Expressions;

namespace UDP_Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        UdpClient server;
        IPEndPoint EP;
        int RemotePort = 4000;
        int LocalPort = 11000;

        private void btnListen_Click(object sender, EventArgs e)
        {
            server = new UdpClient(LocalPort);
            EP = new IPEndPoint(IPAddress.Any, RemotePort);
            server.BeginReceive(new AsyncCallback(receive), server);
        }

        void receive(IAsyncResult ar)
        {
            byte[] buff = server.EndReceive(ar, ref EP);
            string ReceivedData = Encoding.UTF8.GetString(buff);
            UpdateChatRecv(ReceivedData);
            server.BeginReceive(new AsyncCallback(receive), server);
        }

        void UpdateChatRecv(string data)
        {
            if(this.txtChat.InvokeRequired)
            {
                UpdateChatViewCallBack updateChat = new UpdateChatViewCallBack(UpdateChatRecv);
                this.Invoke(updateChat, new object[] { data });
            }
            else
            {
                txtChat.Text += "Client: " + data + "\r\n";
            }
        }

        void UpdateChatSend(string data)
        {
            if (this.txtChat.InvokeRequired)
            {
                UpdateChatViewCallBack updateChat = new UpdateChatViewCallBack(UpdateChatSend);
                this.Invoke(updateChat, new object[] { data });
            }
            else
            {
                txtChat.Text += "Server: " + data + "\r\n";
            }
        }

        delegate void UpdateChatViewCallBack(string text);

        private void btnSend_Click(object sender, EventArgs e)
        {
            server.Connect(EP);
            byte[] message= Encoding.ASCII.GetBytes(txtSend.Text);
            server.Send(message, txtSend.Text.Length);
            UpdateChatSend(txtSend.Text);
            txtSend.Text = "";
        }

        private void txtSend_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }
    }
}
