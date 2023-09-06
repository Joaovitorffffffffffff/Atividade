using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01_09.Exercicio_1
{
    class Senai : Escola
    {
        public override void CalcularMedia()
        {

            Console.WriteLine("Digite 4 notas de 0 a 100");
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());
            double n4 = Convert.ToDouble(Console.ReadLine());

            double total = n1 + n2 + n3 + n4;
            double media = total / 4;

            Console.WriteLine("Agora digite a frequencia");
            double freq = Convert.ToDouble(Console.ReadLine());

            if (freq > 90 && media > 7)
            {
                Console.WriteLine("Parabens voce foi aprovado no curso tecnico do senai");
            }
            else if (freq >= 90 && media < 7)
            {
                Console.WriteLine("Voce precisa fazer trabalho de recuperação");
            }
            else if (freq < 90 && media >= 7)
            {
                Console.WriteLine("Voce foi reprovador por faltar");
            }
            else
            {
                Console.WriteLine("Voce foi reprovado");
            }
        }
    }
}

