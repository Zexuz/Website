using Domain.Factories;

namespace Domain.Interfaces
{
    public interface IEmailCredentials
    {
        string FromEmail { get; }
        string Password { get; }
        EmailClients Client { get; }
    }
}