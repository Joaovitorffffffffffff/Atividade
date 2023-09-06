using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01_09.Exercicio_3
{
    class Projeto
    {
        public string dataDoProjeto { get; set; }

        public Estudante Estudante { get; set; }

        public void EscolherProfissão()
        {
            Console.WriteLine("Digite responda as informações abaixo" + "\n");

            Console.WriteLine("Qual profissão gostaria de escolher?");
            string profissao = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Qual faculdade gostaria de cursar?");
            string faculdade = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Citar 3 coisas que gostaria de estar fazendo daqui a 5 anos?");
            string citar1 = Convert.ToString(Console.ReadLine());
            string citar2 = Convert.ToString(Console.ReadLine());
            string citar3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Quais são as suas expectativas quando finalizar o ensino médio?");
            string ensino = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Citar 3 características de quais são os seus projetos para o futuro?");
            string caracteristica1 = Convert.ToString(Console.ReadLine());
            string caracteristica2 = Convert.ToString(Console.ReadLine());
            string caracteristica3 = Convert.ToString(Console.ReadLine());
        }
    }
}
