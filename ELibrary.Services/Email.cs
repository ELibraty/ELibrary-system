using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace ELibrary.Services
{
    class Email
    {
        public void Send(string mailTo, string message, string subject)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("dimitarkole@gmail.com");
                mail.To.Add(mailTo);
                mail.Subject = subject;
                mail.Body = message;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                string a = ex.ToString();

            }

        }
    }
}
