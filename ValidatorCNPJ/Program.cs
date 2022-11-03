using System.Diagnostics;
using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;

namespace ValidatorCNPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cnpj1 = "51241758000152";
            string cnpj2 = "14128481000127";

            ValidateCNPJ(cnpj1);
            ValidateCNPJ(cnpj2);
        }

        private static void ValidateCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Debug.WriteLine("CNPJ válido: " + cnpj);
            }
            else
            {
                Debug.WriteLine("CNPJ inválido: " + cnpj);
            }
        }
    }
}