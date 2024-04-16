using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_8_boite_mail
{
    internal class Attachment
    {
        public string AttachmentName { get; set; }

        public Attachment(string initAttachmentName)
        {
            AttachmentName = initAttachmentName;
        }
    }
}
