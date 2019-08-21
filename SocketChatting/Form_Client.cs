using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace SocketChatting
{
    public partial class Form_Client : Form
    {
        TcpClient clientSocket = new TcpClient();

        private string ip = "192.168.0.12";
        private int port = 9999;

        private string clientName="Client";

        public Form_Client()
        {
            InitializeComponent();

            new Thread(delegate ()
            {
                InitSocket();
            }).Start();
        }

        private void InitSocket()
        {
            try
            {
                clientSocket.Connect(ip, port);
                client_nickname.Text = ip+":"+port;
                DisplayText("[-- Client Started --]");
                DisplayText("[-- Client Socket Program - Server Connected ... --]");
            }
            catch (SocketException se)
            {
                DisplayText("[-- Not Connected... --]");
                MessageBox.Show(se.Message, "Error");
            }
            catch (Exception ex)
            {
                DisplayText("[-- Not Connected... --]");
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Form_ClientFormClosing(object sender, FormClosingEventArgs e)
        {
            if (clientSocket != null)
                clientSocket.Close();
        }

        private void DisplayText(string text)
        {
            if (Client_Textarea.InvokeRequired)
            {
                Client_Textarea.BeginInvoke(new MethodInvoker(delegate
                {
                    Client_Textarea.AppendText(Environment.NewLine + " >> " + text);
                }));
            }
            else
                Client_Textarea.AppendText(Environment.NewLine + " >> " + text);
        }

        private void Btn_client_open_Click(object sender, EventArgs e)
        {

        }

        private void Btn_client_exit_Click(object sender, EventArgs e)
        {

        }

        private void Btn_client_nickname_Click(object sender, EventArgs e)
        {
            DisplayText("[--'" + clientName + "'님이 '"+ client_nickname.Text + "'(으)로 이름을 변경하셨습니다--]");
            clientName = client_nickname.Text;
        }

        private void Btn_message_Click(object sender, EventArgs e)
        {
            NetworkStream stream = clientSocket.GetStream();
            byte[] sbuffer = Encoding.Unicode.GetBytes(message.Text + "$");
            stream.Write(sbuffer, 0, sbuffer.Length);
            stream.Flush();

            byte[] rbuffer = new byte[1024];
            stream.Read(rbuffer, 0, rbuffer.Length);
            string msg = Encoding.Unicode.GetString(rbuffer);
            msg = "'"+clientName+"' : " + msg;
            DisplayText(msg);

            message.Text = "";
            message.Focus();
        }

        private void Client_nickname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
