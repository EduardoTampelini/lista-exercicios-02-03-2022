using System;

namespace Exercicio._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em Dolar:");
            string valorDigitado = Console.ReadLine();
            decimal valorConvertido = 0.0m;
            decimal valorCambio = 5.22m;

            decimal.TryParse(valorDigitado, out valorConvertido);

            decimal valorCambioConvertido = valorConvertido * valorCambio;

            Console.WriteLine($"valor em R${valorCambioConvertido}");
            Console.ReadLine();
        }
    }
}
