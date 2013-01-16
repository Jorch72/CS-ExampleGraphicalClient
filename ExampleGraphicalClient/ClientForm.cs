using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Craft.Net.Client;
using Craft.Net.Client.Events;

namespace ExampleGraphicalClient
{
    public partial class ClientForm : Form
    {
        public IPEndPoint EndPoint { get; set; }
        public MinecraftClient Client { get; set; }

        public ClientForm(IPEndPoint endPoint)
        {
            InitializeComponent();
            EndPoint = endPoint;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Client = new MinecraftClient(Program.Session);
            Client.ChatMessage += Client_ChatMessage;
            Client.LoggedIn += Client_LoggedIn;
            Client.Connect(EndPoint);
        }

        void Client_LoggedIn(object sender, EventArgs e)
        {
            MessageBox.Show("Logged in!");
        }

        void Client_ChatMessage(object sender, ChatMessageEventArgs e)
        {
            if (chatListBox.InvokeRequired)
                chatListBox.Invoke(new Action(() => Client_ChatMessage(sender, e)));
            else
            {
                chatListBox.Items.Add(e.RawMessage);
                // Scroll to bottom of list box
                int visibleItems = chatListBox.ClientSize.Height / chatListBox.ItemHeight;
                chatListBox.TopIndex = Math.Max(chatListBox.Items.Count - visibleItems + 1, 0);
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Client.Disconnect("Closing form");
        }

        private void sendChatButton_Click(object sender, EventArgs e)
        {
            Client.SendChat(chatTextBox.Text);
            chatTextBox.Text = "";
            chatTextBox.Focus();
        }
    }
}
