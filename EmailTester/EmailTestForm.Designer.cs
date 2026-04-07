namespace EmailTester
{
    partial class EmailTestForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSMTP = new TextBox();
            txtPort = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmailMessage = new TextBox();
            btnSend = new Button();
            label6 = new Label();
            txtsubject = new TextBox();
            label7 = new Label();
            txtRecipient = new TextBox();
            label8 = new Label();
            txtSenderName = new TextBox();
            label9 = new Label();
            txtSenderEmail = new TextBox();
            lblResult = new Label();
            label10 = new Label();
            cbSecurityType = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(75, 44);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "SMTP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(81, 85);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(46, 123);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(46, 166);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(46, 244);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Message";
            // 
            // txtSMTP
            // 
            txtSMTP.Location = new Point(136, 44);
            txtSMTP.Name = "txtSMTP";
            txtSMTP.Size = new Size(209, 23);
            txtSMTP.TabIndex = 5;
            txtSMTP.Text = "smtp.gov.yk.ca";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(136, 82);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(93, 23);
            txtPort.TabIndex = 6;
            txtPort.Text = "25";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(136, 124);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(209, 23);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 167);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(209, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtEmailMessage
            // 
            txtEmailMessage.Location = new Point(136, 244);
            txtEmailMessage.Multiline = true;
            txtEmailMessage.Name = "txtEmailMessage";
            txtEmailMessage.Size = new Size(531, 160);
            txtEmailMessage.TabIndex = 9;
            txtEmailMessage.Text = "This is an email test";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(136, 421);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(99, 50);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send Email";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(58, 201);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 11;
            label6.Text = "Subject";
            // 
            // txtsubject
            // 
            txtsubject.Location = new Point(136, 205);
            txtsubject.Name = "txtsubject";
            txtsubject.Size = new Size(531, 23);
            txtsubject.TabIndex = 12;
            txtsubject.Text = "Test email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(416, 47);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 13;
            label7.Text = "Recipient";
            // 
            // txtRecipient
            // 
            txtRecipient.Location = new Point(493, 45);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(174, 23);
            txtRecipient.TabIndex = 14;
            txtRecipient.Text = "ygrantz@yukon.ca";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label8.Location = new Point(388, 85);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 15;
            label8.Text = "Sender Name";
            // 
            // txtSenderName
            // 
            txtSenderName.Location = new Point(493, 82);
            txtSenderName.Name = "txtSenderName";
            txtSenderName.Size = new Size(174, 23);
            txtSenderName.TabIndex = 16;
            txtSenderName.Text = "NoReply";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(391, 124);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 17;
            label9.Text = "Sender Email";
            // 
            // txtSenderEmail
            // 
            txtSenderEmail.Location = new Point(493, 123);
            txtSenderEmail.Name = "txtSenderEmail";
            txtSenderEmail.Size = new Size(174, 23);
            txtSenderEmail.TabIndex = 18;
            txtSenderEmail.Text = "noreply@ynet.gov.yk.ca";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(136, 491);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(23, 15);
            lblResult.TabIndex = 19;
            lblResult.Text = "OK";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(395, 166);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 20;
            label10.Text = "SecurityType";
            // 
            // cbSecurityType
            // 
            cbSecurityType.FormattingEnabled = true;
            cbSecurityType.Location = new Point(493, 167);
            cbSecurityType.Name = "cbSecurityType";
            cbSecurityType.Size = new Size(174, 23);
            cbSecurityType.TabIndex = 21;
            // 
            // EmailTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 560);
            Controls.Add(cbSecurityType);
            Controls.Add(label10);
            Controls.Add(lblResult);
            Controls.Add(txtSenderEmail);
            Controls.Add(label9);
            Controls.Add(txtSenderName);
            Controls.Add(label8);
            Controls.Add(txtRecipient);
            Controls.Add(label7);
            Controls.Add(txtsubject);
            Controls.Add(label6);
            Controls.Add(btnSend);
            Controls.Add(txtEmailMessage);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPort);
            Controls.Add(txtSMTP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmailTestForm";
            Text = "EmailTestForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSMTP;
        private TextBox txtPort;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmailMessage;
        private Button btnSend;
        private Label label6;
        private TextBox txtsubject;
        private Label label7;
        private TextBox txtRecipient;
        private Label label8;
        private TextBox txtSenderName;
        private Label label9;
        private TextBox txtSenderEmail;
        private Label lblResult;
        private Label label10;
        private ComboBox cbSecurityType;
    }
}