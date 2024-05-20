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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChatTCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        string[] clientDataArr = new string[10];
        /*
         * Array Index Data:
         * [0] = userName of client
         * [1] = IP address of client
         * [2] = Message sent by client
         * 
         * */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                sendButton.Enabled = true;
                clientDataArr[1] = clientServerIP.Text;
                if (userName.Text != "")
                {
                    clientDataArr[0] = userName.Text;
                }
                else
                {
                    clientDataArr[0] = "Anonymous";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            //add branch for if data received is server closure
            
            this.Invoke((MethodInvoker)delegate
            {
                
                //Convert the data received to UTF8 format and display on message list
                messageList.Text += "\r\n" + Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count);
            });
        }
            
            // messageList.Text += Encoding.UTF8.GetString(e.Data.ToArray()) + "\r\n";

            //messageList.Text += Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count);
        


        private void Disconnected(object sender, ConnectionEventArgs e)
        {
            //Send client disconnected information to server
            client.Send(userName.Text + " disconnected.");
        }

        private void Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                messageList.Text += "\r\n" + userName.Text + " connected.";
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(clientServerIP.Text);
            client.Events.Connected += Connected;
            client.Events.Disconnected += Disconnected;
            client.Events.DataReceived += DataReceived;
            sendButton.Enabled = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                //client.Send(messageBoxClient.Text.ToString());
                client.Send(userName.Text + ": "+ messageBoxClient.Text.ToString()) ;
                messageList.Text += "\r\n" + userName.Text + ": " + messageBoxClient.Text.ToString();
                messageBoxClient.Text = "";
            }
        }
    }
}
