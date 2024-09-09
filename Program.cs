using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string nomeCompleto = Console.ReadLine();

            NomeProprio nome = new NomeProprio(nomeCompleto);
            nome.ImprimeNomePaper();
            Console.ReadLine();
        }
    }
}
