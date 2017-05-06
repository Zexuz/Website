using System;
using System.Configuration;
using System.Net.Mail;
using Domain.Factories;
using Domain.Implementation;
using Domain.Servicies;

namespace Website
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var fromEmail = ConfigurationManager.AppSettings["google_username"];
            var password = ConfigurationManager.AppSettings["google_password"];


            var mail = new MailMessage(fromEmail,"a1471961@mvrht.net");
            mail.Subject = "Test email";
            mail.Body =  "Hello, World!";

            var emailCred = EmailFactory.CrateEmailClient(fromEmail,password, EmailClients.Google);

            var email= new Email(emailCred,mail);

            new EmailSenderService().SendEmail(email);
            Console.WriteLine("email sent");
        }
    }
}