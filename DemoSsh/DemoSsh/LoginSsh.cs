using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSsh
{
    public partial class LoginSsh : Form
    {
        public LoginSsh()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            BvSshHelper obj = new BvSshHelper(@"Bitvise SSH Client\BvSsh.exe", @"Bitvise SSH Client\default.bscp", true);
            object a = obj.Login("45.76.180.116", "root", "9Dj.]$_s{$Dg%4CC", 22);
            //obj.Kill();
        }
    }
}
