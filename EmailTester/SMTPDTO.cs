namespace EmailTester;

public class SMTPDTO
{
    public string? Server { get; set; }
    public int Port { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? AuthType { get; set; }
    public string? SenderName { get; set; }
    public string? SenderEmail { get; set; } 
    public string? TestRecipient { get; set; } 
}

public static class SMTPSettings
{
    public static SMTPDTO SMTP { get; set; } = new SMTPDTO();
}
