using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca4
{
    public interface IMailConstructor
    {
        Mail Construct();
        IMailConstructor AddSubject(string subject);
        IMailConstructor AddContent(string content);
        IMailConstructor AddRecipient(string recipient);
        IMailConstructor AddAttachments(string attachment);


    }
}
