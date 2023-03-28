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

        Socket client;
        IPEndPoint EP;
        int RemotePort;
        bool IsConnected = false;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                RemotePort = Convert.ToInt32(txtPort.Text);
                EP = new IPEndPoint(IPAddress.Parse(txtIP.Text), RemotePort);
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnSend.Enabled = true;
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Please type the server IP and port", "Warning");
                txtPort.Clear();
                txtIP.Clear();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.ASCII.GetBytes(txtSend.Text);
            try
            {
                client.SendTo(message, EP);
                IsConnected = true;
                UpdateChat(txtSend.Text);
                txtSend.Text = "";
            }
            catch (System.ObjectDisposedException)
            {
                MessageBox.Show("Client is disconnect", "Warning");
                txtSend.Clear();
            }
            
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
                txtChat.Text += "Sending: " + data + "\r\n";
            }
        }

        delegate void UpdateChatCallBack(string text);

        private void txtSend_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Close();
            txtChat.Text += "Disconnected.\r\n";
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnSend.Enabled = false;
        }
    }
}
