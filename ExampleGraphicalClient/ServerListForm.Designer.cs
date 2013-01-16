namespace ExampleGraphicalClient
{
    partial class ServerListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverListBox = new System.Windows.Forms.ListBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.directConnectButton = new System.Windows.Forms.Button();
            this.directConnectTextBox = new System.Windows.Forms.TextBox();
            this.addServerButton = new System.Windows.Forms.Button();
            this.removeServerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverListBox
            // 
            this.serverListBox.FormattingEnabled = true;
            this.serverListBox.Location = new System.Drawing.Point(12, 12);
            this.serverListBox.Name = "serverListBox";
            this.serverListBox.Size = new System.Drawing.Size(393, 173);
            this.serverListBox.TabIndex = 0;
            this.serverListBox.SelectedIndexChanged += new System.EventHandler(this.serverListBox_SelectedIndexChanged);
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(309, 191);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(96, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // directConnectButton
            // 
            this.directConnectButton.Location = new System.Drawing.Point(309, 217);
            this.directConnectButton.Name = "directConnectButton";
            this.directConnectButton.Size = new System.Drawing.Size(96, 23);
            this.directConnectButton.TabIndex = 2;
            this.directConnectButton.Text = "Direct Connect";
            this.directConnectButton.UseVisualStyleBackColor = true;
            this.directConnectButton.Click += new System.EventHandler(this.directConnectButton_Click);
            // 
            // directConnectTextBox
            // 
            this.directConnectTextBox.Location = new System.Drawing.Point(12, 220);
            this.directConnectTextBox.Name = "directConnectTextBox";
            this.directConnectTextBox.Size = new System.Drawing.Size(291, 20);
            this.directConnectTextBox.TabIndex = 3;
            // 
            // addServerButton
            // 
            this.addServerButton.Location = new System.Drawing.Point(12, 191);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(91, 23);
            this.addServerButton.TabIndex = 4;
            this.addServerButton.Text = "Add Server";
            this.addServerButton.UseVisualStyleBackColor = true;
            this.addServerButton.Click += new System.EventHandler(this.addServerButton_Click);
            // 
            // removeServerButton
            // 
            this.removeServerButton.Enabled = false;
            this.removeServerButton.Location = new System.Drawing.Point(199, 191);
            this.removeServerButton.Name = "removeServerButton";
            this.removeServerButton.Size = new System.Drawing.Size(104, 23);
            this.removeServerButton.TabIndex = 5;
            this.removeServerButton.Text = "Remove Selected";
            this.removeServerButton.UseVisualStyleBackColor = true;
            this.removeServerButton.Click += new System.EventHandler(this.removeServerButton_Click);
            // 
            // ServerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 249);
            this.Controls.Add(this.removeServerButton);
            this.Controls.Add(this.addServerButton);
            this.Controls.Add(this.directConnectTextBox);
            this.Controls.Add(this.directConnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.serverListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ServerListForm";
            this.Text = "Server List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox serverListBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button directConnectButton;
        private System.Windows.Forms.TextBox directConnectTextBox;
        private System.Windows.Forms.Button addServerButton;
        private System.Windows.Forms.Button removeServerButton;
    }
}