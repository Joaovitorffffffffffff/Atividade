=using Atividade_01_09.Exercicio_1;
using Atividade_01_09.Exercicio_4;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Atividade_01_09
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //Exercicio 1 

            Escola escola = new Escola();
            escola.escola = "";
            escola.cidade = "";
            escola.serie = "";
            escola.estado = "";
            escola.descobrirNome();
            escola.CalcularMedia();

            Sesi sesi = new Sesi();
            sesi.CalcularMedia();

            Senai senai = new Senai();
            senai.CalcularMedia();


            //Exercicio 2



























            // Exercicio 4
            DigitarInformacaoes();











        }

        public static void DigitarInformacaoes()
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade");
            int Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a sua cidade");
            string Cidade = Console.ReadLine();
            Console.WriteLine("Digite o seu rg");
            string rg = Console.ReadLine();
            Console.WriteLine("Digite a sua área");
            string area = Console.ReadLine();
            Programador programador = new Programador();
            programador.nome = nome;
            programador.idade = Idade;
            programador.cidade = Cidade;
            programador.rg = rg;
            programador.area = area;

            
            string JsonString = jsonString.SerializeObject(programador, Formatting.Indented);
            dynamic stringJson = JsonConvert.DeserializeObject(JsonString);

            File.WriteAllText("text.json", JsonString);
            string text = File.ReadAllText("atividade_4.json");
            Console.WriteLine(text);
        }
    }
}
