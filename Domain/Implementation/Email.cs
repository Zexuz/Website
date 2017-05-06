using System.Net.Mail;
using Domain.Interfaces;

namespace Domain.Implementation
{
    public class Email:IEmail
    {
        public Email(IEmailClient client, MailMessage message)
        {
            Client = client;
            Message = message;
        }

        public IEmailClient Client { get; }
        public MailMessage Message { get; }
    }
}