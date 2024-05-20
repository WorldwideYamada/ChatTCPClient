using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatTCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SimpleTcpServer server;
        string clientIP;
       
        private void button1_Click(object sender, EventArgs e)
        {
            server.Start();
            messageList.Text += "Server started.";
            button1.Enabled = false; //Connect button disabled after connecting because why would you want to connect again
            sendButton.Enabled = true;

            clientIPList.Text += userName.Text + "\r\n";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Start server and create event handlers on window launch
            server = new SimpleTcpServer(serverIPBox.Text);
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
            server.Events.DataReceived += DataReceived;
        }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {

                //Convert the data received to UTF8 format and display on message list
                string s = Encoding.UTF8.GetString(e.Data.ToArray());

                messageList.Text += "\r\n" + s;
            });
        }

        private void ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                //string s = Encoding.UTF8.GetString(e.Reason);
                messageList.Text += "\r\n"+ ($"Client at port {e.IpPort}, has disconnected.");
            }
            );
        }

        private void ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {

                messageList.Text += "\r\n" + ($"Client at port {e.IpPort}, has connected.");
                clientIP = e.IpPort;
            });

        }

        private void sendButton_Click(object sender, EventArgs e)
        {

            if (server.IsListening&&(messageBox.Text != ""))
            {
                if(userName.Text != "")
                {

                    //update messageList for server side client
                    messageList.Text += "\r\n";
                    messageList.Text += userName.Text+ ": " +messageBox.Text;

                    //send data to clients if there are any (crashes when 0 clients lol)
                    if (server.Connections > 0)
                    {
                        server.Send(clientIP, (userName.Text + ": " + messageBox.Text));
                    }
                    
                    


                }
                else
                {
                    messageList.Text += "\r\n";
                    messageList.Text += "Anon: " + messageBox.Text;
                }



            }
            messageBox.Text = "";
        }
    }
}
