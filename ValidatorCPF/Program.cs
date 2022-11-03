using System.Diagnostics;
using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;

namespace ValidatorCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            ValidateCPF(cpf1);
            ValidateCPF(cpf2);
            ValidateCPF(cpf3);

            string cpf1Formatado = new CPFFormatter().Format(cpf1);
            Debug.WriteLine(cpf1Formatado);

            string cpf1DesFormatado = new CPFFormatter().Unformat(cpf1Formatado);
            Debug.WriteLine(cpf1DesFormatado);
        }

        private static void ValidateCPF(string cpf)
        {
            if (new CPFValidator().IsValid(cpf))
            {
                Debug.WriteLine("CPF válido: " + cpf);
            }
            else
            {
                Debug.WriteLine("CPF inválido: " + cpf);
            }
        }
    }
}