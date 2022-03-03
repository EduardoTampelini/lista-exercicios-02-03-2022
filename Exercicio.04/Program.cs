using System;

namespace Exercicio._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o ano de nascimento:");
            string anoNas = Console.ReadLine();
            int anoNasConv = 0;

            int.TryParse(anoNas, out anoNasConv);

            int anoAtual = DateTime.Today.Year;

            int idade = anoAtual - anoNasConv;

            Console.WriteLine($"Sua idade é : {idade}");
            Console.ReadLine();
        }
    }
}
