using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Craft.Net.Client;

namespace ExampleGraphicalClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            var lastLogin = LastLogin.GetLastLogin();
            if (lastLogin != null)
            {
                usernameTextBox.Text = lastLogin.Username;
                passwordTextBox.Text = lastLogin.Password;
                rememberMeCheckBox.Checked = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginButton.Enabled = false;
            Task.Factory.StartNew(() =>
                {
                    try
                    {
                        Program.Session = Session.DoLogin(usernameTextBox.Text, passwordTextBox.Text);
                        // Login successful
                        if (rememberMeCheckBox.Checked)
                        {
                            var lastLogin = new LastLogin();
                            lastLogin.Username = usernameTextBox.Text;
                            lastLogin.Password = passwordTextBox.Text;
                            LastLogin.SetLastLogin(lastLogin);
                        }
                        else
                        {
                            if (File.Exists(LastLogin.LastLoginFile))
                                File.Delete(LastLogin.LastLoginFile);
                        }
                        if (this.InvokeRequired)
                            this.Invoke(new Action(Close));
                        else
                            this.Close();
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        if (MessageBox.Show(ex.Message + Environment.NewLine +
                            "Would you like to use offline mode?", "Login Error", MessageBoxButtons.YesNo)
                            == DialogResult.Yes)
                        {
                            Program.Session = new Session(usernameTextBox.Text);
                            if (this.InvokeRequired)
                                this.Invoke(new Action(Close));
                            else
                                this.Close();
                        }
                        else
                        {
                            if (loginButton.InvokeRequired)
                                loginButton.Invoke(new Action(() => loginButton.Enabled = true));
                            else
                                loginButton.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                });
        }
    }
}
