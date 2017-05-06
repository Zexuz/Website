using System.Net.Mail;
using Domain.Factories;

namespace Domain.Interfaces
{
    public interface IEmailClient
    {
        int Port { get;}
        string Host { get; }
        string Username{ get;}
        string Password{ get; }
        EmailClients GetType();

        void SendEmail(MailMessage mailMessage);
    }
}