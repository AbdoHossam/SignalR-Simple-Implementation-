using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRClient2
{
    public partial class Form1 : Form
    {
        IHubProxy _hub;
            string url = @"http://localhost:8080/";
          
       
        public Form1()
        {
            InitializeComponent();
            
            
          
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var connection = new HubConnection(url);
            _hub = connection.CreateHubProxy("TestHub");
            connection.Start().Wait();
            
            _hub.Invoke("DetermineLength", TbMessage.Text).Wait();
            _hub.On<string>("ReceiveLength",  (message) =>
               this.Invoke((Action)(() =>
                   RichTbShow.AppendText(String.Format("{0} " + Environment.NewLine, message)))));
            TbMessage.Text = String.Empty;
            TbMessage.Focus();
           
        }
     
    }
}
