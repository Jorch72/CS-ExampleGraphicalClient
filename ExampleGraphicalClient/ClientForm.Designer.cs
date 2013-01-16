namespace ExampleGraphicalClient
{
    partial class ClientForm
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
            this.chatListBox = new System.Windows.Forms.ListBox();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.sendChatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatListBox
            // 
            this.chatListBox.FormattingEnabled = true;
            this.chatListBox.Location = new System.Drawing.Point(12, 12);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chatListBox.Size = new System.Drawing.Size(873, 446);
            this.chatListBox.TabIndex = 0;
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(12, 468);
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.Size = new System.Drawing.Size(792, 20);
            this.chatTextBox.TabIndex = 1;
            // 
            // sendChatButton
            // 
            this.sendChatButton.Location = new System.Drawing.Point(810, 466);
            this.sendChatButton.Name = "sendChatButton";
            this.sendChatButton.Size = new System.Drawing.Size(75, 23);
            this.sendChatButton.TabIndex = 2;
            this.sendChatButton.Text = "Send Chat";
            this.sendChatButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.sendChatButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 500);
            this.Controls.Add(this.sendChatButton);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.chatListBox);
            this.Name = "Form1";
            this.Text = "Example Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chatListBox;
        private System.Windows.Forms.TextBox chatTextBox;
        private System.Windows.Forms.Button sendChatButton;
    }
}

