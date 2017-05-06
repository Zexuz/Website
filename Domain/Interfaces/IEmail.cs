using System.Net.Mail;

namespace Domain.Interfaces
{
    public interface IEmail
    {
            IEmailClient Client { get; }
            MailMessage Message { get; }
    }
}