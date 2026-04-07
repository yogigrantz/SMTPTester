using MailKit.Security;
using YGSendMail;

namespace EmailTester
{
    public partial class EmailTestForm : Form
    {
        private SecureSocketOptions[] secureSocketOptions;
        public EmailTestForm()
        {
            InitializeComponent();
            secureSocketOptions = new SecureSocketOptions[]
            {
                SecureSocketOptions.None,
                SecureSocketOptions.Auto,
                SecureSocketOptions.StartTls,
                SecureSocketOptions.StartTlsWhenAvailable,
                SecureSocketOptions.SslOnConnect
            };
            cbSecurityType.DataSource = secureSocketOptions;

            this.txtSMTP.Text = SMTPSettings.SMTP.Server;
            this.txtPort.Text = SMTPSettings.SMTP.Port.ToString();
            this.txtUsername.Text = SMTPSettings.SMTP.Username;
            this.txtPassword.Text = SMTPSettings.SMTP.Password;
            this.txtSenderEmail.Text = SMTPSettings.SMTP.SenderEmail;
            this.txtSenderName.Text = SMTPSettings.SMTP.SenderName;
            this.txtRecipient.Text = SMTPSettings.SMTP.TestRecipient;

            if (Enum.TryParse<SecureSocketOptions>(
                    SMTPSettings.SMTP.AuthType,
                    true, out var selected))
            {
                cbSecurityType.SelectedItem = selected;
            }
            else
            {
                cbSecurityType.SelectedItem = SecureSocketOptions.None; // fallback
            }
            this.lblResult.Text = "Ready";
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {

            string? sendername = null;
            string? senderEmail = null;
            if (!string.IsNullOrEmpty(this.txtSenderEmail.Text))
                senderEmail = this.txtSenderEmail.Text;
            if (!string.IsNullOrEmpty(this.txtSenderName.Text))
                sendername = this.txtSenderName.Text;

            EmailDTO eml = new EmailDTO()
            {
                To = new string[] { txtRecipient.Text },
                Subject = txtsubject.Text,
                Body = $"{txtEmailMessage.Text} \r\nSent from {Environment.MachineName} on {DateTime.Now}",
                SenderEmail = senderEmail,
                SenderName = sendername,
                IsHtml = true
            };

            this.lblResult.Text = await this.SendEmailAsync(eml);
        }

        private async Task<string> SendEmailAsync(EmailDTO emlDTO)
        {
            SecureSocketOptions ssop = SecureSocketOptions.None;
            if (cbSecurityType.SelectedItem != null)
                ssop = (SecureSocketOptions)cbSecurityType.SelectedItem;

            string? username = null;
            string? password = null;
            if (!string.IsNullOrEmpty(this.txtUsername.Text))
                username = this.txtUsername.Text;
            if (!string.IsNullOrEmpty(this.txtPassword.Text))
                password = this.txtPassword.Text;

            try
            {
                using (ISendMail sm = new SendMail(txtSMTP.Text, int.Parse(txtPort.Text), ssop, username, password))   // use whatever SecureSocketOptions works for you
                {
                    string rslt = await sm.SendAsync(emlDTO);
                    return rslt;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
