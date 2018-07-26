using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;
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

namespace WindowsFormClient
{
    public partial class Form1 : Form
    {
        IHubProxy _hub;
        string url = @"http://localhost:8080/";
        
        public Form1()
        {
            InitializeComponent();
            TbMessage.Visible = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TbMessage.Text = String.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TbName.Text != null && TbName.Text !=" ")
            {
                var connection = new HubConnection(url);
                _hub = connection.CreateHubProxy("MyHub");
                connection.Start().Wait();
                TbName.Visible = false;
                TbMessage.Visible= true;
                btnLogin.Visible = false;
                btnLogin.Enabled = false;
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
                _hub.Invoke("Send", TbName.Text, TbMessage.Text);
            _hub.On<string, string>("addMessage", (_name, _message) =>
                    Invoke((Action)(() =>
                   RtbShow.Text += _name + " "+ _message + "\r")));

            TbMessage.Text = string.Empty;
            RtbShow.Text = string.Empty;
            TbMessage.Focus();
            _hub.Subscribe("addMessage");
            
        }
    }
}
