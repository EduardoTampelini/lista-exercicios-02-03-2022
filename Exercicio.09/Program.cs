using System;

namespace Exercicio._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var livro = new LivroStruct("Punisher", "Garth Ennis", 120.00m);

            Console.WriteLine(livro.ToString());

            Console.ReadLine();
        }
        
    }
}
