using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using RHPsicotest.WebSite.Models;

namespace RHPsicotest.WebSite.Utilities
{
    public class SendEmail
    {
        private static IConfiguration Configuration;

        public static string Email { get; private set; }

        public static string Password { get; private set; }
        
        private static IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        public static void Send(string email, string password)
        {
            Email = configuration.GetValue<string>("E-Mail:Username");
            Password = configuration.GetValue<string>("E-Mail:Password");

            string htmlJson = configuration.GetValue<string>("E-Mail:EmailHtml");

            string html = string.Format(htmlJson, password);

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

            smtpClient.Host = "smtp.gmail.com";
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
