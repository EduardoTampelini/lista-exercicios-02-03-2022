using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._10
{
    class Aluno1 : AbstractAluno
    {
        public override int ObterFalta()
        {
            return 8;
        }

        public override string ObterNome()
        {
            return "Eduardo";
        }

        public override int ObterNota()
        {
           return 90;
        }

        public override string ObterRa()
        {
            return "661";
        }
    }
}
