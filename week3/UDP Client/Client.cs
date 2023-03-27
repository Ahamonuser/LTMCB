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

        UdpClient client;
        IPEndPoint EP;
        int RemotePort;
        int LocalPort = 4000;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new UdpClient(LocalPort);
            RemotePort = Convert.ToInt32(txtPort.Text);
            EP = new IPEndPoint(IPAddress.Parse(txtIP.Text), RemotePort);
            client.BeginReceive(new AsyncCallback(receive), client);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            client.Connect(EP);
            byte[] message = Encoding.ASCII.GetBytes(txtSend.Text);
            client.Send(message, txtSend.Text.Length);
            UpdateChatSend(txtSend.Text);
            txtSend.Text = "";
        }

        void receive(IAsyncResult ar)
        {
            
            byte[] buff = client.EndReceive(ar, ref EP);
            string received_data = Encoding.UTF8.GetString(buff);
            UpdateChatRecv(received_data);
            client.BeginReceive(new AsyncCallback(receive), client);
        }

        void UpdateChatRecv(string data)
        {
            if (this.txtChat.InvokeRequired)
            {
                UpdateChatCallBack updateChat = new UpdateChatCallBack(UpdateChatRecv);
                this.Invoke(updateChat, new object[] { data });
            }
            else
            {
                txtChat.Text += "Server: " + data + "\r\n";
            }
        }

        delegate void UpdateChatCallBack(string text);

        void UpdateChatSend(string data)
        {
            if (this.txtChat.InvokeRequired)
            {
                UpdateChatCallBack updateChat = new UpdateChatCallBack(UpdateChatSend);
                this.Invoke(updateChat, new object[] { data });
            }
            else
            {
                txtChat.Text += "Client: " + data + "\r\n";
            }
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
