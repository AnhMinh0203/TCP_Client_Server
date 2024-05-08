namespace TCP_Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            txtIP = new System.Windows.Forms.TextBox();
            txtInfor = new System.Windows.Forms.TextBox();
            txtMessage = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnSend = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            listClientIp = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textInforEncrypt = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(75, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Server";
            // 
            // txtIP
            // 
            txtIP.Location = new System.Drawing.Point(161, 46);
            txtIP.Name = "txtIP";
            txtIP.Size = new System.Drawing.Size(423, 27);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1:9000";
            // 
            // txtInfor
            // 
            txtInfor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtInfor.Location = new System.Drawing.Point(161, 222);
            txtInfor.Multiline = true;
            txtInfor.Name = "txtInfor";
            txtInfor.ReadOnly = true;
            txtInfor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtInfor.Size = new System.Drawing.Size(423, 101);
            txtInfor.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Location = new System.Drawing.Point(161, 339);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new System.Drawing.Size(423, 27);
            txtMessage.TabIndex = 3;
            txtMessage.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(75, 339);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Message";
            // 
            // btnSend
            // 
            btnSend.Location = new System.Drawing.Point(379, 383);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(94, 29);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(490, 383);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(94, 29);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // listClientIp
            // 
            listClientIp.FormattingEnabled = true;
            listClientIp.ItemHeight = 20;
            listClientIp.Location = new System.Drawing.Point(604, 93);
            listClientIp.Name = "listClientIp";
            listClientIp.Size = new System.Drawing.Size(265, 324);
            listClientIp.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(604, 46);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 20);
            label3.TabIndex = 8;
            label3.Text = "Client Ip";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(75, 222);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 20);
            label4.TabIndex = 9;
            label4.Text = "Decrypt";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(75, 91);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 20);
            label5.TabIndex = 10;
            label5.Text = "Encrypt";
            // 
            // textInforEncrypt
            // 
            textInforEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textInforEncrypt.Location = new System.Drawing.Point(161, 91);
            textInforEncrypt.Multiline = true;
            textInforEncrypt.Name = "textInforEncrypt";
            textInforEncrypt.ReadOnly = true;
            textInforEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textInforEncrypt.Size = new System.Drawing.Size(423, 101);
            textInforEncrypt.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(904, 440);
            Controls.Add(textInforEncrypt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listClientIp);
            Controls.Add(btnStart);
            Controls.Add(btnSend);
            Controls.Add(label2);
            Controls.Add(txtMessage);
            Controls.Add(txtInfor);
            Controls.Add(txtIP);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtInfor;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listClientIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textInforEncrypt;
    }
}
