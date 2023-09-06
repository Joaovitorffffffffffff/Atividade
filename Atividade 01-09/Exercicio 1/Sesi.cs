using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01_09
{
    class Sesi : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("digite 3 notas de aluno para calcular a média");
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());

            double total = n1 + n2 + n3; 
            double media = total / 3;

            if (media >+7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (media <= 5)
            {
                Console.WriteLine("Aluno em recuperação");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
        }
    }
}
