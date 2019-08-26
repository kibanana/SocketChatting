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
    public partial class Form_Server : Form
    {
        delegate void AppendTextDelegate(string s);
        AppendTextDelegate _textAppender;
        Socket mainSock;
        IPAddress thisAddress;

        private string serverName = "Server";

        public Form_Server()
        {
            InitializeComponent();
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            _textAppender = new AppendTextDelegate(AppendText);
        }

        private void Btn_server_open_Click(object sender, EventArgs e)
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());

            // 처음으로 발견되는 ipv4 주소를 사용한다.
            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisAddress = addr;
                    break;
                }
            }

            // 주소가 없다면..
            if (thisAddress == null)
                thisAddress = IPAddress.Loopback; // 로컬호스트 주소를 사용한다.

            ip_server_info.Text = thisAddress.ToString();

            if (mainSock.Connected)
            {
                MsgBoxHelper.Error("이미 연결되어 있습니다!");
                return;
            }

            int port;
            if (!int.TryParse(port_server_info.Text, out port))
            {
                MsgBoxHelper.Error("포트 번호가 잘못 입력되었거나 입력되지 않았습니다.");
                port_server_info.Focus();
                port_server_info.SelectAll();
                return;
            }

            AppendText("[-- 서버가 연결되었습니다 --]");
            // 서버에서 클라이언트의 연결 요청을 대기하기 위해
            // 소켓을 열어둔다.
            IPEndPoint serverEP = new IPEndPoint(thisAddress, port);
            mainSock.Bind(serverEP);
            mainSock.Listen(10);

            // 비동기적으로 클라이언트의 연결 요청을 받는다.
            mainSock.BeginAccept(AcceptCallback, null);

            ip_server_info.ReadOnly = true;
            port_server_info.ReadOnly = true;
        }

        void AppendText(string s)
        {
            if (Server_Textarea.InvokeRequired)
            {
                Server_Textarea.BeginInvoke(new MethodInvoker(delegate
                {
                    Server_Textarea.AppendText(s + Environment.NewLine);
                }));
            }
            else
                Server_Textarea.AppendText(s + Environment.NewLine);
            Server_Textarea.ScrollToCaret();
        }

        List<Socket> connectedClients = new List<Socket>();
        void AcceptCallback(IAsyncResult ar)
        {
            // 클라이언트의 연결 요청을 수락한다.
            Socket client = mainSock.EndAccept(ar);

            // 또 다른 클라이언트의 연결을 대기한다.
            mainSock.BeginAccept(AcceptCallback, null);

            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = client;

            // 연결된 클라이언트 리스트에 추가해준다.
            connectedClients.Add(client);

            // 텍스트박스에 클라이언트가 연결되었다고 써준다.
            AppendText(string.Format("[-- 클라이언트 (@ {0})가 연결되었습니다. --]", client.RemoteEndPoint));

            // 클라이언트의 데이터를 받는다.
            client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
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
            AppendText(string.Format(Environment.NewLine + "[받음] {0}", text));

            // for을 통해 "역순"으로 클라이언트에게 데이터를 보낸다.
            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                if (socket != obj.WorkingSocket)
                {
                    try { socket.Send(obj.Buffer); }
                    catch
                    {
                        // 오류 발생하면 전송 취소하고 리스트에서 삭제한다.
                        try { socket.Dispose(); } catch { }
                        connectedClients.RemoveAt(i);
                    }
                }
            }

            // 데이터를 받은 후엔 다시 버퍼를 비워주고 같은 방법으로 수신을 대기한다.
            obj.ClearBuffer();

            // 수신 대기
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        private void Btn_server_exit_Click(object sender, EventArgs e)
        {
            try    
            {
                if (mainSock != null)
                {
                    mainSock.Close();
                    mainSock = null;
                    AppendText("[-- 서버 연결이 종료되었습니다 --]");
                }
                connectedClients.Clear();
            }
            catch
            {

            }
            ip_server_info.ReadOnly = false;
            port_server_info.ReadOnly = false;
        }

        private void Btn_server_nickname_Click(object sender, EventArgs e)
        {
            string nickname = server_nickname.Text.Trim();
            if (string.IsNullOrEmpty(nickname))
            {
                MsgBoxHelper.Warn("입력된 닉네임이 없습니다!");
                server_nickname.Focus();
                return;
            }
            string changeNicknameMessage = Environment.NewLine + "[-- Server '" + serverName + "(" + ip_server_info.Text + ")" + "'님이 '" + nickname + "'(으)로 이름을 변경하셨습니다--]";

            // 서버가 대기중인지 확인한다.
            if (!mainSock.IsBound)
            {
                MsgBoxHelper.Warn("서버가 실행되고 있지 않습니다!");
                return;
            }

            // 문자열을 utf8 형식의 바이트로 변환한다.
            byte[] bDts = Encoding.UTF8.GetBytes(changeNicknameMessage);

            // 연결된 모든 클라이언트에게 전송한다.
            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                try { socket.Send(bDts); }
                catch
                {
                    // 오류 발생하면 전송 취소하고 리스트에서 삭제한다.
                    try { socket.Dispose(); } catch { }
                    connectedClients.RemoveAt(i);
                }
            }


            AppendText(string.Format(changeNicknameMessage));
            serverName = server_nickname.Text.Trim();
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

            m = serverName + "(Server) : " + m;

            // 문자열을 utf8 형식의 바이트로 변환한다.
            byte[] bDts = Encoding.UTF8.GetBytes(m);

            // 연결된 모든 클라이언트에게 전송한다.
            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                try { socket.Send(bDts); }
                catch
                {
                    // 오류 발생하면 전송 취소하고 리스트에서 삭제한다.
                    try { socket.Dispose(); } catch { }
                    connectedClients.RemoveAt(i);
                }
            }

            string[] mArr = m.Split(':');

            // 전송 완료 후 텍스트박스에 추가하고, 원래의 내용은 지운다.
            AppendText(string.Format(Environment.NewLine + "[보냄]" + mArr[1]));
            message.Text = "";
        }
        private void Form_Server_Load(object sender, EventArgs e)
        {

        }

        private void Server_chatinfo_group_Enter(object sender, EventArgs e)
        {

        }
    }
}
