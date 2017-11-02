using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Attentio.Infrastructure.Helpers
{
    public class ArvixeMailHelper : IMailHelper
    {
        public void Send(MailMessage mail)
        {
            var client = new SmtpClient
            {
                Host = "ixia.arvixe.com",
                Credentials = new NetworkCredential("contact@attentiosoftware.biz", "Chamonix61!")
            };
            client.Send(mail);
        }
    }
}
