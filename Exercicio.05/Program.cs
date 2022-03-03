using System;

namespace Exercicio._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor para calculo");

            string primeiroValor = Console.ReadLine();
            decimal valor1Convertido = 0.0m;

            decimal.TryParse(primeiroValor, out valor1Convertido);

            Console.WriteLine("Informe o segundo valor para o calculo");

            string segundoValor = Console.ReadLine();
            decimal valor2Convertido = 0.0m;

            decimal.TryParse(segundoValor, out valor2Convertido);

            decimal soma = valor1Convertido + valor2Convertido;
            Console.WriteLine($"Resultado da soma: {soma} ");

            decimal subtracao = valor1Convertido - valor2Convertido;
            Console.WriteLine($"Resultado da subtração: {subtracao} ");

            decimal multiplicacao = valor1Convertido * valor2Convertido;
            Console.WriteLine($"Resultado da multiplicação: {multiplicacao} ");

            decimal divisao = valor1Convertido / valor2Convertido;
            Console.WriteLine($"Resultado da divisao: {divisao} ");

            decimal resultFinal = valor1Convertido % valor2Convertido;

            Console.WriteLine($"Resto da Divisao: {resultFinal} ");

            Console.ReadLine();
        }
    }
}
