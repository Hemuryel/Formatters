using System.Diagnostics;
using System.Globalization;

namespace ConsoleAppValidadorDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2017, 9, 23);
            Debug.WriteLine(data);
            Debug.WriteLine(data.ToString("d"));
            Debug.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            Debug.WriteLine(data.ToString("dd/MM/yyyy"));

            data = new DateTime(2017, 9, 23, 13, 14, 15, 987);
            Debug.WriteLine(data);
            Debug.WriteLine(data.ToString("hh:mm"));
            Debug.WriteLine(data.ToString("HH:mm:ss.fff"));

            //Escrever por extenso
            //sábado, 23 de setembro de 2017
            Debug.WriteLine(data.ToString("D"));

            //23 de setembro
            Debug.WriteLine(data.ToString("m"));

            //setembro de 2017
            Debug.WriteLine(data.ToString("Y"));

            //23/09/2017 13:14:15
            Debug.WriteLine(data.ToString("G"));

            //23/09/2017 13:14
            Debug.WriteLine(data.ToString("g"));

            //Formato ideal para ida/volta, API
            //2017-09-23T13:14:15.9870000
            Debug.WriteLine(data.ToString("O"));

            Debug.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff"));

            //13:14
            Debug.WriteLine(data.ToString("t"));
            //13:14:15
            Debug.WriteLine(data.ToString("T"));
        }
    }
}