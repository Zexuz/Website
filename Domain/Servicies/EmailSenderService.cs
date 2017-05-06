using System.Net.Mail;
using Domain.Factories;
using Domain.Interfaces;

namespace Domain.Servicies
{
    public class EmailSenderService
    {
        public void SendEmail(IEmail email)
        {
            var emailClient = EmailFactory.CrateEmailClient(email.Client.Username,email.Client.Password, email.Client.GetType());
            emailClient.SendEmail(email.Message);
        }
    }
}