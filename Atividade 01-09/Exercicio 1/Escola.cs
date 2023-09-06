using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01_09
{
    class Escola
    {
        public string escola;
        public string cidade;
        public string estado;
        public string serie;

        public virtual void CalcularMedia()
        {

        }

        public void descobrirNome()
        {
            Console.WriteLine("Digite o nome da sua escola");
            string escola = Console.ReadLine().ToUpper();
            Console.WriteLine("digite sua cidade");
            string cidade = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite seu estado");
            estado = Console.ReadLine().ToUpper();
            Console.WriteLine("Qual sua serie");
            serie = Console.ReadLine().ToUpper();

            if (escola == "SESI/SENAI" && cidade == "GARÇA")
            {
                Console.WriteLine("Aluno Sesi/Senai");
            }
            else
            {
                Console.WriteLine("Sua escola é:" + escola + "e a cidade é:" + cidade);

            }
            Console.ReadKey();



        }



























    }
}
