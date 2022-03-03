using System;

namespace Exercicio._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distancia percorrida: ");
            string valorDiastancia = Console.ReadLine();
            decimal distanciaConvertida = 0.0m;

            Console.WriteLine("Informe o consumo percorrida: ");
            string valorConsumo = Console.ReadLine();
            decimal consumoConvertido = 0.0m;

            decimal.TryParse(valorDiastancia, out distanciaConvertida);
            decimal.TryParse(valorConsumo, out consumoConvertido);

            decimal valorMedio = distanciaConvertida / consumoConvertido;

            Console.WriteLine($"O calculo da media é : {valorMedio}");
            Console.ReadLine();
        }
    }
}
