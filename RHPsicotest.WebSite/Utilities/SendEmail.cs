using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace RHPsicotest.WebSite.Utilities
{
    public class SendEmail
    {
        private static string Email { get; set; }

        private static string Password { get; set; }

        private static IConfiguration Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        public static void Send(string email, string password)
        {
            Email = Configuration.GetValue<string>("E-Mail:Username");
            Password = Configuration.GetValue<string>("E-Mail:Password");

            string htmlJson = Configuration.GetValue<string>("E-Mail:EmailHtml");

            string html = string.Format(htmlJson, password, email, password);

            MailMessage message = PrepareteMessage(email, html);

            SendEmailBySmtp(message);
        }

        private static MailMessage PrepareteMessage(string email, string html)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(Email);
            mail.To.Add(email);
            mail.Subject = "Acceso a su Evaluación Psicométrica";
            mail.Body = html;
            mail.IsBodyHtml = true;

            return mail;
        }

        private static void SendEmailBySmtp(MailMessage message)
        {
            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Host = "smtp.titan.email";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Timeout = 50000;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(Email, Password);

            smtpClient.Send(message);
            smtpClient.Dispose();
        }
    }
}
