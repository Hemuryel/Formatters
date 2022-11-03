using Caelum.Stella.CSharp.Http;
using System.Diagnostics;

namespace ConsoleAppCEP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cep = "80230085";
            string result = GetEndereco(cep);
            Debug.WriteLine(result);

            ViaCEP viaCEP = new ViaCEP();
            string enderecoJson = viaCEP.GetEnderecoJson(cep);
            Debug.WriteLine(enderecoJson);

            string enderecoXml = viaCEP.GetEnderecoXml(cep);
            Debug.WriteLine(enderecoXml);

            var task = viaCEP.GetEnderecoJsonAsync(cep);
            Debug.WriteLine(task.Result);

            var endereco = viaCEP.GetEndereco(cep);
            Debug.WriteLine($"Logradouro: {endereco.Logradouro}, Bairro: {endereco.Bairro}");
        }

        private static string GetEndereco(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json";
            string result = new HttpClient().GetStringAsync(url).Result;
            return result;
        }
    }
}