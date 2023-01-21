using System.Net.Mail;
using System.Net;
using System;

namespace RHPsicotest.WebSite.Utilities
{
    public class SendEmail
    {
        public static string Email { get; private set; } = "ML22002@esfe.agape.edu.sv";
        public static string Password { get; private set; } = "ccehifihiztcfmfv";

        public static void Send(string email, string subject, string body)
        {
            var message = PrepareteMessage(email, subject, body);

            SendEmailBySmtp(message);
        }

        private static MailMessage PrepareteMessage(string email, string subject, string body)
        {
            var mail = new MailMessage();

            mail.From = new MailAddress(Email);
            mail.To.Add(email);
            mail.Subject = subject;
            mail.Body = body;
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
