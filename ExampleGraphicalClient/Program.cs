using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Craft.Net.Client;

namespace ExampleGraphicalClient
{
    static class Program
    {
        public static Session Session { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var login = new LoginForm();
            login.ShowDialog();
        }
    }
}
