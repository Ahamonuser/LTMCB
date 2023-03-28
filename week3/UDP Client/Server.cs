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
        int LocalPort;

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                LocalPort = Convert.ToInt32(txtPort.Text);
                server = new UdpClient(LocalPort);
                EP = new IPEndPoint(IPAddress.Any, RemotePort);
                server.BeginReceive(new AsyncCallback(receive), server);
                btnListen.Enabled = false;
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Please type the server port", "Warning");
                txtPort.Clear();
            }
            
        }

        void receive(IAsyncResult ar)
        {
            byte[] buff = server.EndReceive(ar, ref EP);
            string ReceivedData = Encoding.UTF8.GetString(buff);
            UpdateChat(ReceivedData);
            server.BeginReceive(new AsyncCallback(receive), server);
        }

        void UpdateChat(string data)
        {
            if(this.txtChat.InvokeRequired)
            {
                UpdateChatViewCallBack updateChat = new UpdateChatViewCallBack(UpdateChat);
                this.Invoke(updateChat, new object[] { data });
            }
            else
            {
                txtChat.Text += "Client: " + data + "\r\n";
            }
        }

        delegate void UpdateChatViewCallBack(string text);
    }
}
