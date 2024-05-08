using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        // Hõ trợ kết nối t, ngắt kết nối và lấy data từ client
        SimpleTcpServer server;
        private static int YOUR_KEY = 3;
        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            txtInfor.Text += $"Starting ... {Environment.NewLine}";
            btnStart.Enabled = false;
            btnSend.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            server = new SimpleTcpServer(txtIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textInforEncrypt.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                byte[] decodedData = Encoding.UTF8.GetBytes(DeCode(Encoding.UTF8.GetString(e.Data), YOUR_KEY));
                txtInfor.Text += $"{e.IpPort}:{Encoding.UTF8.GetString(decodedData)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {

            this.Invoke((MethodInvoker)delegate
            {
                txtInfor.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                listClientIp.Items.Remove(e.IpPort);
            });

        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfor.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                listClientIp.Items.Add(e.IpPort);
            });

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text) && listClientIp.SelectedItems != null) // check message and select client ip  
                {
/*                    string decryptedData = DeCode(txtInfor.Text, YOUR_KEY);
                    textInforEncrypt.Text += decryptedData;*/

                    server.Send(listClientIp.SelectedItem.ToString(), EnCode(txtMessage.Text,YOUR_KEY));
                    txtInfor.Text += $"Server: {txtMessage.Text}{Environment.NewLine}";  
                    txtMessage.Text = string.Empty;
                }
            }
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
