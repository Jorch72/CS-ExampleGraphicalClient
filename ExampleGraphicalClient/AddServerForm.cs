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
    public partial class AddServerForm : Form
    {
        public ServerList.Server Server 
        {
            get
            {
                return new ServerList.Server
                {
                    Name = nameTextBox.Text,
                    Ip = addressTextBox.Text,
                    HideAddress = hideAddressCheckBox.Checked
                };
            }
        }

        public AddServerForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
