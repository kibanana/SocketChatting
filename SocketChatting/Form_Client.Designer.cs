namespace SocketChatting
{
    partial class Form_Client
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
            this.client_chatinfo_group = new System.Windows.Forms.GroupBox();
            this.btn_client_open = new System.Windows.Forms.Button();
            this.btn_client_exit = new System.Windows.Forms.Button();
            this.client_info_group = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.client_nickname = new System.Windows.Forms.TextBox();
            this.Client_Textarea = new System.Windows.Forms.RichTextBox();
            this.btn_message = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.btn_client_nickname = new System.Windows.Forms.Button();
            this.client_chatinfo_group.SuspendLayout();
            this.client_info_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // client_chatinfo_group
            // 
            this.client_chatinfo_group.BackColor = System.Drawing.SystemColors.Control;
            this.client_chatinfo_group.Controls.Add(this.textBox2);
            this.client_chatinfo_group.Controls.Add(this.textBox1);
            this.client_chatinfo_group.Controls.Add(this.label2);
            this.client_chatinfo_group.Controls.Add(this.label1);
            this.client_chatinfo_group.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_chatinfo_group.ForeColor = System.Drawing.SystemColors.GrayText;
            this.client_chatinfo_group.Location = new System.Drawing.Point(28, 27);
            this.client_chatinfo_group.Name = "client_chatinfo_group";
            this.client_chatinfo_group.Size = new System.Drawing.Size(331, 121);
            this.client_chatinfo_group.TabIndex = 0;
            this.client_chatinfo_group.TabStop = false;
            this.client_chatinfo_group.Text = "접속할 채팅방 정보";
            // 
            // btn_client_open
            // 
            this.btn_client_open.Font = new System.Drawing.Font("나눔바른고딕OTF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_client_open.Location = new System.Drawing.Point(384, 39);
            this.btn_client_open.Name = "btn_client_open";
            this.btn_client_open.Size = new System.Drawing.Size(78, 109);
            this.btn_client_open.TabIndex = 1;
            this.btn_client_open.Text = "참여";
            this.btn_client_open.UseVisualStyleBackColor = true;
            // 
            // btn_client_exit
            // 
            this.btn_client_exit.Font = new System.Drawing.Font("나눔바른고딕OTF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_client_exit.Location = new System.Drawing.Point(481, 39);
            this.btn_client_exit.Name = "btn_client_exit";
            this.btn_client_exit.Size = new System.Drawing.Size(78, 109);
            this.btn_client_exit.TabIndex = 2;
            this.btn_client_exit.Text = "종료";
            this.btn_client_exit.UseVisualStyleBackColor = true;
            // 
            // client_info_group
            // 
            this.client_info_group.Controls.Add(this.btn_client_nickname);
            this.client_info_group.Controls.Add(this.client_nickname);
            this.client_info_group.Controls.Add(this.textBox3);
            this.client_info_group.Controls.Add(this.label4);
            this.client_info_group.Controls.Add(this.label3);
            this.client_info_group.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_info_group.ForeColor = System.Drawing.SystemColors.GrayText;
            this.client_info_group.Location = new System.Drawing.Point(28, 171);
            this.client_info_group.Name = "client_info_group";
            this.client_info_group.Size = new System.Drawing.Size(531, 118);
            this.client_info_group.TabIndex = 3;
            this.client_info_group.TabStop = false;
            this.client_info_group.Text = "Client 정보";
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(99, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "10.96.124.130";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(99, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "5000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(25, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Client 닉네임";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(157, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(328, 25);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "10.96.124.130:51652";
            // 
            // client_nickname
            // 
            this.client_nickname.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_nickname.Location = new System.Drawing.Point(157, 73);
            this.client_nickname.Name = "client_nickname";
            this.client_nickname.Size = new System.Drawing.Size(253, 25);
            this.client_nickname.TabIndex = 3;
            this.client_nickname.Text = "잠만보";
            // 
            // Client_Textarea
            // 
            this.Client_Textarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Client_Textarea.Font = new System.Drawing.Font("나눔스퀘어", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Client_Textarea.Location = new System.Drawing.Point(28, 378);
            this.Client_Textarea.Name = "Client_Textarea";
            this.Client_Textarea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Client_Textarea.Size = new System.Drawing.Size(531, 202);
            this.Client_Textarea.TabIndex = 4;
            this.Client_Textarea.Text = "[-- \'10.96.124.130:51652\'님이 참여하셨습니다 --]";
            // 
            // btn_message
            // 
            this.btn_message.Font = new System.Drawing.Font("나눔바른고딕OTF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_message.Location = new System.Drawing.Point(481, 333);
            this.btn_message.Name = "btn_message";
            this.btn_message.Size = new System.Drawing.Size(75, 28);
            this.btn_message.TabIndex = 5;
            this.btn_message.Text = "보내기";
            this.btn_message.UseVisualStyleBackColor = true;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.message.Location = new System.Drawing.Point(28, 334);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(447, 27);
            this.message.TabIndex = 4;
            this.message.Text = "I\'m sleepy";
            // 
            // btn_client_nickname
            // 
            this.btn_client_nickname.Font = new System.Drawing.Font("나눔바른고딕OTF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_client_nickname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_client_nickname.Location = new System.Drawing.Point(415, 72);
            this.btn_client_nickname.Name = "btn_client_nickname";
            this.btn_client_nickname.Size = new System.Drawing.Size(72, 26);
            this.btn_client_nickname.TabIndex = 16;
            this.btn_client_nickname.Text = "변경";
            this.btn_client_nickname.UseVisualStyleBackColor = true;
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(583, 604);
            this.Controls.Add(this.message);
            this.Controls.Add(this.btn_message);
            this.Controls.Add(this.Client_Textarea);
            this.Controls.Add(this.client_info_group);
            this.Controls.Add(this.btn_client_exit);
            this.Controls.Add(this.btn_client_open);
            this.Controls.Add(this.client_chatinfo_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client - Chatting room";
            this.client_chatinfo_group.ResumeLayout(false);
            this.client_chatinfo_group.PerformLayout();
            this.client_info_group.ResumeLayout(false);
            this.client_info_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox client_chatinfo_group;
        private System.Windows.Forms.Button btn_client_open;
        private System.Windows.Forms.Button btn_client_exit;
        private System.Windows.Forms.GroupBox client_info_group;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox client_nickname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox Client_Textarea;
        private System.Windows.Forms.Button btn_message;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button btn_client_nickname;
    }
}