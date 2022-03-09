using System;

namespace Exercicio._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua data de aniversario: ");
            String dataNasc = Console.ReadLine();

            DateTime.TryParse(dataNasc, out DateTime dataNascFormatada);

            int idade = DateTime.Today.Year - dataNascFormatada.Year;

            if (idade >= 0 && idade <= 19)
            {
                Console.WriteLine($"{nome} Você é Joven");
            }else if(idade >= 20 && idade <= 59)
            {
                Console.WriteLine($"{nome} Você é Adulto");
            }else if (idade >= 60)
            {
                Console.WriteLine($"{nome} Você é Idoso");
            }
            else
            {
                Console.WriteLine("Idade digitada errada");
            }

            Console.ReadLine();
        }
    }
}
