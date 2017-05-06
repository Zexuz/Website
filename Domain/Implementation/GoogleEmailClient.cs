using System.Net;
using System.Net.Mail;
using Domain.Factories;
using Domain.Interfaces;
using Domain.Servicies;

namespace Domain.Implementation
{
    public class GoogleEmailClient:IEmailClient
    {

        public int Port => 587;
        public string Host =>"smtp.gmail.com";
        public string Username { get; }
        public string Password { get; }

        public GoogleEmailClient(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

        public void SendEmail(MailMessage mailMessage)
        {
            var client = new SmtpClient();
            client.Port = Port ;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Host = Host;
            client.EnableSsl = true;

            client.Credentials =new NetworkCredential(Username,Password);

            client.Send(mailMessage);
        }

        public new EmailClients GetType()
        {
            return EmailClients.Google;
        }


    }
}