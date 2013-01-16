using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Craft.Net.Client;

namespace ExampleGraphicalClient
{
    public partial class ServerListForm : Form
    {
        public ServerList Servers { get; set; }
        public ServerList.Server SelectedServer { get; set; }

        public ServerListForm()
        {
            InitializeComponent();
            try
            {
                Servers = ServerList.Load();
                ReloadServers();
            }
            catch { }
        }

        private void ReloadServers()
        {
            serverListBox.Items.Clear();
            foreach (var server in Servers.Servers)
                serverListBox.Items.Add(server);
        }

        private void serverListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectButton.Enabled = removeServerButton.Enabled = serverListBox.SelectedIndex != -1;
            SelectedServer = (ServerList.Server)serverListBox.SelectedItem;
        }

        private void removeServerButton_Click(object sender, EventArgs e)
        {
            Servers.Servers.RemoveAt(serverListBox.SelectedIndex);
            Servers.Save();
            ReloadServers();
        }

        private void addServerButton_Click(object sender, EventArgs e)
        {
            AddServerForm form = new AddServerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Servers.Servers.Add(form.Server);
                Servers.Save();
                ReloadServers();
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void directConnectButton_Click(object sender, EventArgs e)
        {
            SelectedServer = new ServerList.Server
            {
                Ip = directConnectTextBox.Text
            };
            Close();
        }
    }
}
