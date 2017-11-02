using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Attentio.Infrastructure.Helpers
{
    public interface IMailHelper
    {
        void Send(MailMessage mail);
    }
}
