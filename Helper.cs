using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Helper
    {
        public static string SenttMsg(string to,
            string subject, string body, out bool result)
        {
            try
            {
                MailMessage msg = new MailMessage();
            msg.From = new MailAddress("gersen.e.a@gmail.com",
                "Yevgeniy Gertsen");

            msg.To.Add(to);
            //msg.CC.Add("");
            msg.Subject = subject;
            msg.Priority = MailPriority.High;
            msg.Body = body;
            //msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            //smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("login", "password");

          
                smtp.Send(msg);
                result = true;
                return "Сообщение отправлено";
            }
            catch (Exception ex)
            {
                result = false;
                return ex.Message;
            }
        }
    }
}
