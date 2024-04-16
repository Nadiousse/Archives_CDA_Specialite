using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_8_boite_mail
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get;}

        const string MailDomain = "@lemail.fr";

        public List<Mail> SendMailsList { get; set; }
        public List<Mail> UnreadMailsInboxList { get; set; }
        public List<Mail> ReadMailsInboxList { get; set; }  

        public User(string initFirstName, string initLastName)
        {
            FirstName = initFirstName;
            LastName = initLastName;

            Mail += FirstName + "." + LastName + MailDomain;

            SendMailsList = new List<Mail>();
            UnreadMailsInboxList = new List<Mail>();
            ReadMailsInboxList = new List<Mail>();
        }

        public void SendMail(User recipient)
        {
            Mail newMail = new Mail(this, recipient);

            this.SendMailsList.Add(newMail);
            recipient.UnreadMailsInboxList.Add(newMail);
        }
        public void DisplayInboxMail()
        {
            DisplayMails(UnreadMailsInboxList);

            DisplayMails(ReadMailsInboxList);
        }

        public void DisplayUnreadMails()
        {
            DisplayMails(UnreadMailsInboxList);
        }
        public void DisplaySendMail()
        {
            DisplayMails(SendMailsList);
        }
        public void ReadAnUnreadEmailInboxMail()
        {
            Console.Write("Veuillez saisir le numéro du mail à lire : ");
            string mailNumberEntry = Console.ReadLine();
            int mailNumber = int.Parse(mailNumberEntry);
            Console.WriteLine("\n\n");

            UnreadMailsInboxList[mailNumber-1].DisplayOneMail();

            EraseAnInboxEmail(UnreadMailsInboxList[mailNumber - 1]);

            UnreadMailsInboxList[mailNumber-1].ReadOrUnread = true;
        }


        private void DisplayMails(List<Mail> Mails)
        {
            int i = 1;

            foreach (Mail mail in Mails)
            {
                Console.WriteLine($"{i}. Envoyé le {mail.SendingDate} de la part de {mail.Sender.FirstName} {mail.Sender.LastName}, Objet :{mail.Subject}.");
                i++;
            }
        }
        public void ReadAReadMail(int mailNumber)
        {
            ReadMailsInboxList[mailNumber - 1].DisplayOneMail();
        }

        public void ReadSendMail()
        {
            string entryMailNumber = Console.ReadLine();
            int mailNumber = int.Parse(entryMailNumber);

            UnreadMailsInboxList[mailNumber-1].DisplayOneMail();
        }

        public void EraseAnInboxEmail(Mail mail)
        {
            Console.WriteLine("Voulez-vous supprimer le mail ? (oui ou non)");
            string choice = "";

            if (!mail.ReadOrUnread == false)
            {
                while (Choice.IsDefined(typeof(Choice), choice.ToLower()))
                {
                    Console.Write("Voulez ajouter une pièce jointe ? (oui ou non)");
                    choice = Console.ReadLine();

                    if (choice.Contains(Choice.oui.ToString()))
                    {
                        UnreadMailsInboxList.Remove(mail);
                    }
                    else
                    {
                        ReadMailsInboxList.Add(mail);
                        UnreadMailsInboxList.Remove(mail);
                    }
                }
            }
            else
            {
                while (Choice.IsDefined(typeof(Choice), choice.ToLower()))
                {
                    Console.Write("Voulez ajouter une pièce jointe ? (oui ou non)");
                    choice = Console.ReadLine();

                    if (choice.Contains(Choice.oui.ToString()))
                    {
                        ReadMailsInboxList.Remove(mail);
                    }
                }
            }

            
        }
    }
}
