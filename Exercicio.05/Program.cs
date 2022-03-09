using System;

namespace Exercicio._05
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            do
            {
                Console.WriteLine("Informe o primeiro valor para calculo");

                string primeiroValor = Console.ReadLine();
                decimal valor1Convertido = 0.0m;

                decimal.TryParse(primeiroValor, out valor1Convertido);

                Console.WriteLine("Informe o segundo valor para o calculo");

                string segundoValor = Console.ReadLine();
                decimal valor2Convertido = 0.0m;

                decimal.TryParse(segundoValor, out valor2Convertido);

                Console.WriteLine("Escreva o simbolo da operação matematica que deseja");
                Console.WriteLine("(+)  Soma");
                Console.WriteLine("(-)  Subtração");
                Console.WriteLine("(*)  Multiplicaçao");
                Console.WriteLine("(/)  Divisão");
                Console.WriteLine("(%)  Resto da divisão");


                string operacao = Console.ReadLine();



                switch (operacao)
                {
                    case "+":
                        decimal soma = valor1Convertido + valor2Convertido;
                        Console.WriteLine($"Resultado da soma: {soma} ");
                        break;
                    case "-":
                        decimal subtracao = valor1Convertido - valor2Convertido;
                        Console.WriteLine($"Resultado da subtração: {subtracao} ");
                        break;
                    case "*":
                        decimal multiplicacao = valor1Convertido * valor2Convertido;
                        Console.WriteLine($"Resultado da multiplicação: {multiplicacao} ");
                        break;
                    case "/":
                        decimal divisao = valor1Convertido / valor2Convertido;
                        Console.WriteLine($"Resultado da divisao: {divisao} ");
                        break;
                    case "%":
                        decimal resultFinal = valor1Convertido % valor2Convertido;
                        Console.WriteLine($"Resto da Divisao: {resultFinal} ");
                        break;
                    default:
                        Console.WriteLine("Opção não configurada");
                        break;
                }
                Console.WriteLine("Deseja Sair (S/N)");
                resposta = Console.ReadLine();
            } while (resposta.Equals("n") || resposta.Equals("N"));
            
        }
    }
}
