namespace ChatTCPClient
{
    partial class Form1
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
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverIPBox = new System.Windows.Forms.TextBox();
            this.messageList = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.clientIPList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(43, 39);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(148, 20);
            this.userName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server IP:";
            // 
            // serverIPBox
            // 
            this.serverIPBox.Location = new System.Drawing.Point(43, 103);
            this.serverIPBox.Name = "serverIPBox";
            this.serverIPBox.Size = new System.Drawing.Size(148, 20);
            this.serverIPBox.TabIndex = 3;
            this.serverIPBox.Text = "127.0.0.1:9000";
            // 
            // messageList
            // 
            this.messageList.Location = new System.Drawing.Point(217, 39);
            this.messageList.Multiline = true;
            this.messageList.Name = "messageList";
            this.messageList.ReadOnly = true;
            this.messageList.Size = new System.Drawing.Size(529, 326);
            this.messageList.TabIndex = 4;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(217, 384);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(443, 53);
            this.messageBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "コンネクト！";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(675, 385);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(70, 51);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "センド";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clientIPList
            // 
            this.clientIPList.FormattingEnabled = true;
            this.clientIPList.Location = new System.Drawing.Point(47, 225);
            this.clientIPList.Name = "clientIPList";
            this.clientIPList.Size = new System.Drawing.Size(138, 134);
            this.clientIPList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Server IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientIPList);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.messageList);
            this.Controls.Add(this.serverIPBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Name = "Form1";
            this.Text = "TCP Server Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverIPBox;
        private System.Windows.Forms.TextBox messageList;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ListBox clientIPList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

