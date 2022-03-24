using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._09
{
    internal struct LivroStruct
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public decimal Valor { get; private set; }

        public LivroStruct(string titulo, string autor, decimal valor)
        {
            Titulo = titulo;
            Autor = autor;
            Valor = valor;

        }
        public override string ToString()
        {
            return $"Titulo: {Titulo} \n" +
                $"Autor: {Autor} \n" +
                $"valor: {Valor} \n";
        }
    }
}
