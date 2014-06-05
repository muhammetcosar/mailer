using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Tgs
{
    public class Mailer
    {
        public static bool SendMail(string body, string name, string surname, string mailadres,ref string message)
        {

            mailadres = "muhammetcosar377@gmail.com";
            bool sended = true;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("muhammetcosar377@gmail.com", "fiesta00");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                mail.To.Add(mailadres);
                mail.From = new MailAddress("muhammetcosar377@gmail.com");
                mail.Subject = "TGS Eğitim Atanması Hk.";
                mail.Body = body;
                mail.IsBodyHtml = true;

                client.Send(mail);
            }
            catch (Exception ex)
            {
                sended = false;
                message = ex.Message;
            }
            return sended;
        }
        public static string Template(string tname)
        {
            string path = @"D:\Tgs\Tgs\Templates\";
            return File.ReadAllText(path + tname + ".html");
        }
    }
}
