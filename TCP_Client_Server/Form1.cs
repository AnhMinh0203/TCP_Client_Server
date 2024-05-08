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

namespace TCP_Client_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private static int YOUR_KEY = 3;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(client.IsConnected)
            {
                if(!string.IsNullOrEmpty(txtMessage.Text))
                {
                    client.Send(EnCode(txtMessage.Text, YOUR_KEY));
                    txtInfor.Text += $"Me: {txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = string.Empty;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new (txtIP.Text);
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
            btnSend.Enabled = false;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
           

            this.Invoke((MethodInvoker)delegate
            {
                textInforEncrypt.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";

                // Giải mã dữ liệu và hiển thị
                byte[] decodedData = Encoding.UTF8.GetBytes(DeCode(Encoding.UTF8.GetString(e.Data), YOUR_KEY));
                txtInfor.Text += $"Server: {Encoding.UTF8.GetString(decodedData)}{Environment.NewLine}";
            });

        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            
            this.Invoke((MethodInvoker)delegate
            {
                txtInfor.Text += $"Server disconnected.{Environment.NewLine}";
            });

        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
           
            this.Invoke((MethodInvoker)delegate
            {
                txtInfor.Text += $"Server connected.{Environment.NewLine}";
            });
        }

        private static char Cipher(char c, int key)
        {
            if (!char.IsLetter(c))
            {
                return c;
            }
            char offset = char.IsUpper(c) ? 'A' : 'a';
            return (char)((c + key - offset) % 26 + offset);
        }

        private static string EnCode(string input, int key)
        {
            string output = string.Empty;
            foreach (char c in input)
            {
                output += Cipher(c, key);
            }
            return output;
        }

        private static string DeCode(string input, int key)
        {
            return EnCode(input, 26 - key);
        }
    }
}
