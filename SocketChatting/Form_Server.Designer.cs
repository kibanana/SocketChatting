namespace SocketChatting
{
    partial class Form_Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.server_chatinfo_group = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_server_exit = new System.Windows.Forms.Button();
            this.btn_server_open = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.server_info_group = new System.Windows.Forms.GroupBox();
            this.btn_message = new System.Windows.Forms.Button();
            this.Server_Textarea = new System.Windows.Forms.RichTextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.server_nickname = new System.Windows.Forms.TextBox();
            this.port_server_info = new System.Windows.Forms.TextBox();
            this.ip_server_info = new System.Windows.Forms.TextBox();
            this.btn_server_nickname = new System.Windows.Forms.Button();
            this.server_chatinfo_group.SuspendLayout();
            this.server_info_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // server_chatinfo_group
            // 
            this.server_chatinfo_group.BackColor = System.Drawing.SystemColors.Control;
            this.server_chatinfo_group.Controls.Add(this.port_server_info);
            this.server_chatinfo_group.Controls.Add(this.label2);
            this.server_chatinfo_group.Controls.Add(this.ip_server_info);
            this.server_chatinfo_group.Controls.Add(this.label1);
            this.server_chatinfo_group.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_chatinfo_group.ForeColor = System.Drawing.SystemColors.GrayText;
            this.server_chatinfo_group.Location = new System.Drawing.Point(28, 27);
            this.server_chatinfo_group.Name = "server_chatinfo_group";
            this.server_chatinfo_group.Size = new System.Drawing.Size(331, 121);
            this.server_chatinfo_group.TabIndex = 6;
            this.server_chatinfo_group.TabStop = false;
            this.server_chatinfo_group.Text = "채팅방 정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // btn_server_exit
            // 
            this.btn_server_exit.Font = new System.Drawing.Font("나눔바른고딕OTF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_server_exit.Location = new System.Drawing.Point(481, 39);
            this.btn_server_exit.Name = "btn_server_exit";
            this.btn_server_exit.Size = new System.Drawing.Size(78, 109);
            this.btn_server_exit.TabIndex = 8;
            this.btn_server_exit.Text = "종료";
            this.btn_server_exit.UseVisualStyleBackColor = true;
            // 
            // btn_server_open
            // 
            this.btn_server_open.Font = new System.Drawing.Font("나눔바른고딕OTF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_server_open.Location = new System.Drawing.Point(384, 39);
            this.btn_server_open.Name = "btn_server_open";
            this.btn_server_open.Size = new System.Drawing.Size(78, 109);
            this.btn_server_open.TabIndex = 7;
            this.btn_server_open.Text = "열기";
            this.btn_server_open.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(25, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Server 닉네임";
            // 
            // server_info_group
            // 
            this.server_info_group.Controls.Add(this.btn_server_nickname);
            this.server_info_group.Controls.Add(this.server_nickname);
            this.server_info_group.Controls.Add(this.label3);
            this.server_info_group.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_info_group.ForeColor = System.Drawing.SystemColors.GrayText;
            this.server_info_group.Location = new System.Drawing.Point(28, 180);
            this.server_info_group.Name = "server_info_group";
            this.server_info_group.Size = new System.Drawing.Size(531, 81);
            this.server_info_group.TabIndex = 9;
            this.server_info_group.TabStop = false;
            this.server_info_group.Text = "Server 정보";
            // 
            // btn_message
            // 
            this.btn_message.Font = new System.Drawing.Font("나눔바른고딕OTF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_message.Location = new System.Drawing.Point(481, 332);
            this.btn_message.Name = "btn_message";
            this.btn_message.Size = new System.Drawing.Size(75, 28);
            this.btn_message.TabIndex = 12;
            this.btn_message.Text = "보내기";
            this.btn_message.UseVisualStyleBackColor = true;
            // 
            // Server_Textarea
            // 
            this.Server_Textarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Server_Textarea.Font = new System.Drawing.Font("나눔스퀘어", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Server_Textarea.Location = new System.Drawing.Point(28, 378);
            this.Server_Textarea.Name = "Server_Textarea";
            this.Server_Textarea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Server_Textarea.Size = new System.Drawing.Size(531, 202);
            this.Server_Textarea.TabIndex = 11;
            this.Server_Textarea.Text = "[-- \'10.96.124.130\'님이 \'김철수철수\' (으)로 이름을 변경하셨습니다 --]";
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.message.Location = new System.Drawing.Point(28, 333);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(447, 27);
            this.message.TabIndex = 13;
            this.message.Text = "How are you doing?";
            // 
            // server_nickname
            // 
            this.server_nickname.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_nickname.Location = new System.Drawing.Point(148, 36);
            this.server_nickname.Name = "server_nickname";
            this.server_nickname.Size = new System.Drawing.Size(286, 25);
            this.server_nickname.TabIndex = 14;
            this.server_nickname.Text = "김철수철수";
            // 
            // port_server_info
            // 
            this.port_server_info.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.port_server_info.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.port_server_info.Location = new System.Drawing.Point(92, 77);
            this.port_server_info.Name = "port_server_info";
            this.port_server_info.Size = new System.Drawing.Size(208, 25);
            this.port_server_info.TabIndex = 17;
            this.port_server_info.Text = "5000";
            // 
            // ip_server_info
            // 
            this.ip_server_info.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ip_server_info.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ip_server_info.Location = new System.Drawing.Point(92, 35);
            this.ip_server_info.Name = "ip_server_info";
            this.ip_server_info.Size = new System.Drawing.Size(208, 25);
            this.ip_server_info.TabIndex = 16;
            this.ip_server_info.Text = "10.96.124.130";
            // 
            // btn_server_nickname
            // 
            this.btn_server_nickname.Font = new System.Drawing.Font("나눔바른고딕OTF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_server_nickname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_server_nickname.Location = new System.Drawing.Point(441, 35);
            this.btn_server_nickname.Name = "btn_server_nickname";
            this.btn_server_nickname.Size = new System.Drawing.Size(72, 26);
            this.btn_server_nickname.TabIndex = 15;
            this.btn_server_nickname.Text = "변경";
            this.btn_server_nickname.UseVisualStyleBackColor = true;
            // 
            // Form_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 606);
            this.Controls.Add(this.message);
            this.Controls.Add(this.server_chatinfo_group);
            this.Controls.Add(this.btn_server_exit);
            this.Controls.Add(this.btn_server_open);
            this.Controls.Add(this.server_info_group);
            this.Controls.Add(this.btn_message);
            this.Controls.Add(this.Server_Textarea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server - Chatting room";
            this.server_chatinfo_group.ResumeLayout(false);
            this.server_chatinfo_group.PerformLayout();
            this.server_info_group.ResumeLayout(false);
            this.server_info_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox server_chatinfo_group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_server_exit;
        private System.Windows.Forms.Button btn_server_open;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox server_info_group;
        private System.Windows.Forms.Button btn_message;
        private System.Windows.Forms.RichTextBox Server_Textarea;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox server_nickname;
        private System.Windows.Forms.TextBox port_server_info;
        private System.Windows.Forms.TextBox ip_server_info;
        private System.Windows.Forms.Button btn_server_nickname;
    }
}