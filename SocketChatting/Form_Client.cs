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
        delegate void AppendTextDelegate(string s);
        AppendTextDelegate _textAppender;
        Socket mainSock;

        private string clientName="Client";

        public Form_Client()
        {
            InitializeComponent();

            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            _textAppender = new AppendTextDelegate(AppendText);
        }

        void AppendText(string s)
        {
            if(Client_Textarea.InvokeRequired)
            {
                Client_Textarea.BeginInvoke(new MethodInvoker(delegate
                {
                    Client_Textarea.AppendText(s + Environment.NewLine);
                }));
            }
            else
                Client_Textarea.AppendText(s + Environment.NewLine);
        }

        private void Btn_client_open_Click(object sender, EventArgs e)
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());

            // 처음으로 발견되는 ipv4 주소를 사용한다.
            IPAddress defaultHostAddress = null;
            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    defaultHostAddress = addr;
                    break;
                }
            }

            // 주소가 없다면..
            if (defaultHostAddress == null)
                defaultHostAddress = IPAddress.Loopback;

            ip_client_info.Text = defaultHostAddress.ToString(); // 로컬호스트 주소를 사용한다.

            if (mainSock.Connected)
            {
                MsgBoxHelper.Error("이미 연결되어 있습니다!");
                return;
            }

            int port;
            if (!int.TryParse(port_client_info.Text, out port)) {
                MsgBoxHelper.Error("포트 번호가 잘못 입력되었거나 입력되지 않았습니다.");
                port_client_info.Focus();
                port_client_info.SelectAll();
                return;
            }
            ip_client_specific_info.Text = ip_client_info.Text + ":" + port_client_info.Text;

            try { mainSock.Connect(ip_client_info.Text, port); }
            catch (Exception ex) {
                MsgBoxHelper.Error("연결에 실패했습니다!\n오류 내용: {0}", MessageBoxButtons.OK, ex.Message);
                return;
            }

            // 연결 완료되었다는 메세지를 띄워준다.
            AppendText("[-- 서버가 연결되었습니다 --]");

            // 연결 완료, 서버에서 데이터가 올 수 있으므로 수신 대기한다.
            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = mainSock;
            mainSock.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);
        }

        private void Btn_client_exit_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainSock != null)
                {
                    mainSock.Close();
                    mainSock = null;
                    AppendText("[-- 서버 연결이 종료되었습니다 --]");
                }
            }
            catch
            {

            }
            ip_client_info.ReadOnly = false;
            port_client_info.ReadOnly = false;
        }

        private void Btn_client_nickname_Click(object sender, EventArgs e)
        {
            string changeNicknameMessage = "[--'" + clientName +"("+ip_client_info.Text+")"+ "'님이 '" + client_nickname.Text.Trim() + "'(으)로 이름을 변경하셨습니다--]";

            if (string.IsNullOrEmpty(client_nickname.Text.Trim()))
            {
                MsgBoxHelper.Warn("입력된 닉네임이 없습니다!");
                client_nickname.Focus();
                return;
            }

            // 서버가 대기중인지 확인한다.
            if (!mainSock.IsBound)
            {
                MsgBoxHelper.Warn("서버가 실행되고 있지 않습니다!");
                return;
            }

            // 문자열을 utf8 형식의 바이트로 변환한다.
            byte[] bDts = Encoding.UTF8.GetBytes(clientName + '\x01' + changeNicknameMessage);

            // 서버에 전송한다.
            mainSock.Send(bDts);
            
            AppendText(string.Format(changeNicknameMessage));
            clientName = client_nickname.Text.Trim();
        }

        void DataReceived(IAsyncResult ar)
        {
            // BeginReceive에서 추가적으로 넘어온 데이터를 AsyncObject 형식으로 변환한다.
            AsyncObject obj = (AsyncObject)ar.AsyncState;

            // 데이터 수신을 끝낸다.
            int received = obj.WorkingSocket.EndReceive(ar);

            // 받은 데이터가 없으면(연결끊어짐) 끝낸다.
            if (received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }

            // 텍스트로 변환한다.
            string text = Encoding.UTF8.GetString(obj.Buffer);

            // 텍스트박스에 추가해준다.
            // 비동기식으로 작업하기 때문에 폼의 UI 스레드에서 작업을 해줘야 한다.
            // 따라서 대리자를 통해 처리한다.
            AppendText(string.Format("[받음]{0}", text));

            // 클라이언트에선 데이터를 전달해줄 필요가 없으므로 바로 수신 대기한다.
            // 데이터를 받은 후엔 다시 버퍼를 비워주고 같은 방법으로 수신을 대기한다.
            obj.ClearBuffer();

            // 수신 대기
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        private void Btn_message_Click(object sender, EventArgs e)
        {
            // 서버가 대기중인지 확인한다.
            if (!mainSock.IsBound)
            {
                MsgBoxHelper.Warn("서버가 실행되고 있지 않습니다!");
                return;
            }

            // 보낼 텍스트
            string m = message.Text.Trim();
            if (string.IsNullOrEmpty(m))
            {
                MsgBoxHelper.Warn("텍스트가 입력되지 않았습니다!");
                message.Focus();
                return;
            }

            // 서버 ip 주소와 메세지를 담도록 만든다.
            IPEndPoint ip = (IPEndPoint)mainSock.LocalEndPoint;
            string addr = ip.Address.ToString();

            // 문자열을 utf8 형식의 바이트로 변환한다.
            byte[] bDts = Encoding.UTF8.GetBytes(clientName+"("+ip_client_info.Text+")"+ '\x01' + m);

            // 서버에 전송한다.
            mainSock.Send(bDts);

            // 전송 완료 후 텍스트박스에 추가하고, 원래의 내용은 지운다.
            AppendText(string.Format("[보냄]"+clientName + "(" + ip_client_info.Text + ")" + '\x01' + m));
            message.Clear();
        }

        private void Client_nickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ip_server_info_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
