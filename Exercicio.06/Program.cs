using System;

namespace Exercicio._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            int vogais = 0;
            int consoante = 0;

            foreach (char letra in nome)
            {
                if (letra.Equals('a') || letra.Equals('A') || letra.Equals('e') || letra.Equals('E') 
                    || letra.Equals('i') || letra.Equals('I')
                    || letra.Equals('o') || letra.Equals('O') || letra.Equals('u') || letra.Equals('U'))
                {
                    vogais++;
                }
                else
                {
                    consoante++;
                }
                
            }
            Console.WriteLine($"O numeros de vogais é: {vogais}");

            Console.WriteLine($"O numeros de consoantes é: {consoante}");

            Console.ReadLine();
        }
    }
}
