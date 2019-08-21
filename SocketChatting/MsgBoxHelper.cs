using System.Windows.Forms;

namespace SocketChatting
{
    /// <summary>
    /// 메세지박스를 쉽게 표시할 수 있도록 도와주는 함수를 노출하는 클래스입니다.
    /// </summary>
    public static class MsgBoxHelper
    {
        public static DialogResult Warn(string s, MessageBoxButtons buttons = MessageBoxButtons.OK, params object[] args)
        {
            return MessageBox.Show(f(s, args), "경고", buttons, MessageBoxIcon.Exclamation);
        }
        public static DialogResult Error(string s, MessageBoxButtons buttons = MessageBoxButtons.OK, params object[] args)
        {
            return MessageBox.Show(f(s, args), "오류", buttons, MessageBoxIcon.Error);
        }
        public static DialogResult Info(string s, MessageBoxButtons buttons = MessageBoxButtons.OK, params object[] args)
        {
            return MessageBox.Show(f(s, args), "알림", buttons, MessageBoxIcon.Information);
        }
        public static DialogResult Show(string s, MessageBoxButtons buttons = MessageBoxButtons.OK, params object[] args)
        {
            return MessageBox.Show(f(s, args), "알림", buttons, 0);
        }


        static string f(string s, params object[] args)
        {
            if (args == null) return s;
            return string.Format(s, args);
        }
    }
}
