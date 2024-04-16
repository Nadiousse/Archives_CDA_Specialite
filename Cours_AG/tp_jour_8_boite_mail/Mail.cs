using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_8_boite_mail
{
    internal class Mail
    {
        public User Sender { get; set; }
        public User Recipient { get; set; }
        public string Subject { get; set; }
        public DateTime SendingDate { get; set; }
        public string Message { get; set; }
        public List<Attachment> Attachments { get; set; }
        public bool ReadOrUnread { get; set; }

        public Mail(User sender, User recipient)
        {
            Sender = sender;
            Recipient = recipient;
            Attachments = new List<Attachment>();

            Console.Write("Objet : ");
            Subject = Console.ReadLine();

            if (Subject == null)
            {
                Subject = "Sans Objet";
            }

            Console.WriteLine("\nEcrivez votre message :\n");
            Message = Console.ReadLine();

            int numberOfAttachments = AttachmentNumber();
            
            for (int i = 0; i < numberOfAttachments; i++)
            {
                Console.Write("\n 3. Entrer le nom de la pièce-jointe : ");

                string attachmentName = Console.ReadLine();
                Attachments.Add(new Attachment(attachmentName));
            }

            SendingDate = DateTime.Now;
            ReadOrUnread = false;

            Console.WriteLine("\n --- Le message a bien été envoyé au detinataire. --- \n");
        }

        public int AttachmentNumber()
        {
            string attachmentYesOrNo = "oui";
            string enterNumberOfAttachments = "";
            int numberOfAttachments = 0;

            while (Choice.IsDefined(typeof(Choice), attachmentYesOrNo.ToLower()))
            {
                Console.Write("\n 1. Voulez ajouter une pièce jointe ? (oui ou non) ");
                attachmentYesOrNo = Console.ReadLine();

                if (attachmentYesOrNo.Contains(Choice.oui.ToString()))
                {
                    while (!int.TryParse(enterNumberOfAttachments, out numberOfAttachments))
                    {
                        Console.Write("\n 2. Entrez le nombre de pièces jointes : ");
                        enterNumberOfAttachments = Console.ReadLine();
                    }

                    numberOfAttachments = int.Parse(enterNumberOfAttachments);

                    return numberOfAttachments;
                }
                else
                {
                    break;
                }
            }
            return numberOfAttachments;
        }

        public void DisplayOneMail()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("De : " + Sender.Mail);
            Console.WriteLine("A : " + Recipient.Mail);
            Console.WriteLine("Envoyé le : " + SendingDate);
            Console.WriteLine("Objet : " + Subject);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(Message);
            Console.WriteLine("--------------------------------------------------");
            
            if (Attachments.Count >= 1)
            {
                foreach (Attachment attachment in Attachments)
                {
                    Console.WriteLine(attachment.AttachmentName);
                }
            }
            else
            {
                Console.WriteLine("Pas de pièces jointes.");
            }

            Console.WriteLine("--------------------------------------------------");
        }
    }
}
