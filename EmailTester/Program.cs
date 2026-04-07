using Microsoft.Extensions.Configuration;

namespace EmailTester
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Production";

            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .Build();

            SMTPSettings.SMTP = new SMTPDTO()
            {
                Server = config["smtp:server"]?.ToString(),
                Port = int.Parse(config["smtp:port"]),
                Username = config["smtp:username"]?.ToString(),
                Password = config["smtp:password"]?.ToString(),
                SenderEmail = config["smtp:senderEmail"]?.ToString(),
                SenderName = config["smtp:senderName"]?.ToString(),
                TestRecipient = config["smtp:testRecipient"]?.ToString(),
                AuthType = config["smtp:authType"]?.ToString()
            };
            ApplicationConfiguration.Initialize();
            Application.Run(new EmailTestForm());
        }
    }
}