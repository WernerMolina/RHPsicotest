using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace RHPsicotest.WebSite.Utilities
{
    public class SendEmail
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public SendEmail(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void Send(string email, string html)
        {
            MailMessage message = PrepareteMessage(email, html);

            SendEmailBySmtp(message);
        }

        private MailMessage PrepareteMessage(string email, string html)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(Email);
            mail.To.Add(email);
            mail.Subject = "Acceso a su Evaluación Psicométrica";
            mail.Body = html;
            mail.IsBodyHtml = true;

            return mail;
        }

        private void SendEmailBySmtp(MailMessage message)
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
