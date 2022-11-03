using System.Diagnostics;
using System.Net.Mail;

namespace ValidatorEmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email1 = "emailteste@gmail.com";
            string email2 = "emailteste";

            ValidateEmail(email1);
            ValidateEmail(email2);
        }

        private static void ValidateEmail(string email)
        {
            try
            {
                new MailAddress(email);
                Debug.WriteLine("E-mail válido: " + email);
            }
            catch (Exception)
            {
                Debug.WriteLine("E-mail inválido: " + email);
            }
        }
    }
}