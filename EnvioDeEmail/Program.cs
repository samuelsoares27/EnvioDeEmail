using System;
using System.Net.Mail;

namespace EnvioDeEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar o Email
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("Remetente");
            mail.To.Add(new MailAddress("Destinatário"));
            mail.Subject = "Ola mundo title!";
            mail.Body = " Ola mundo body! ";

            using (var smtp = new System.Net.Mail.SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("Email Remetente", "Senha Remetente");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }

        }
    }
}
