using System;
using Domain.Implementation;
using Domain.Interfaces;

namespace Domain.Factories
{
    public class EmailFactory
    {

        public static IEmailClient CrateEmailClient(string fromEmail,string password,EmailClients client)
        {
            return GetEmailClient(client, fromEmail, password);
        }

        private static IEmailClient GetEmailClient(EmailClients client, string username, string password)
        {
            switch (client)
            {
                case EmailClients.Google:
                    return new GoogleEmailClient(username,password);
                default:
                    throw new ArgumentOutOfRangeException(nameof(client), client, null);
            }
        }
    }

    public enum EmailClients
    {
        Google
    }
}