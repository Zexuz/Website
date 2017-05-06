using Domain.Factories;
using Domain.Interfaces;

namespace Domain.Implementation
{
    public class EmailCredentials:IEmailCredentials
    {
        public string FromEmail { get; }
        public string Password { get; }
        public EmailClients Client { get; }

        public EmailCredentials(string fromEmail, string password, EmailClients client)
        {
            FromEmail = fromEmail;
            Password = password;
            Client = client;
        }
    }
}