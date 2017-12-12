using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSsh
{
    public partial class ScanPort : Form
    {
        public ScanPort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                txtStaus.Text = "";
                try
                {
                    tcpClient.Connect("216.58.200.4", 22);
                    Console.WriteLine("Port open");
                    txtStaus.Text ="Port open";
                }
                catch (Exception ex)
                {
                    txtStaus.Text = "Port close (" + ex.Message+")";
                }
            }
        }
    }
}
