using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SocketChatting
{
    public partial class Form1 : Form
    {
        private int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_server_Click(object sender, EventArgs e)
        {
            Form_Server m = new Form_Server();
            m.Show(); // 모달리스창
            flag = 1;
        }

        private void Btn_client_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                Form_Client m = new Form_Client();
                m.Show(); // 모달리스창
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
