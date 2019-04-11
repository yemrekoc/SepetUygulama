using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SepetUygulama.Infrastructure
{
    public class SendMail
    {
        public SendMail(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void MailSender(string mesaj)
        {

            //Burdan devam edersin
            var message = new MailMessage();

            message.To.Add(new MailAddress(Configuration.GetValue<string>("SepetAppMailAddres")));

            message.From = new MailAddress("");  // replace with valid value
            message.Subject = "";
            message.Body = mesaj;
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "",
                    Password = ""
                };
                smtp.Credentials = credential;
                smtp.Host = "";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }

        }
    }
}
