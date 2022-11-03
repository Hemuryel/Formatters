using System.Diagnostics;
using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;

namespace ValidatorTituloEleitoral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo1 = "075825460159";
            string titulo2 = "325650330100";

            ValidateTituloEleitoral(titulo1);
            ValidateTituloEleitoral(titulo2);
        }

        private static void ValidateTituloEleitoral(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                Debug.WriteLine("Título válido: " + titulo);
            }
            else
            {
                Debug.WriteLine("Título inválido: " + titulo);
            }
        }
    }
}