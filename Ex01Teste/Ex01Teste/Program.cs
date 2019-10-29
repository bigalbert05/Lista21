using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste x = new Teste();
            try
            {
                x.Setmetodo(int.Parse(Console.ReadLine()));
                Console.WriteLine(x.metodo1());
            }
            catch (Erro y)
            {
                Console.WriteLine("Valor invalido!!!!!");
            }

            Console.ReadKey();
        }
    }
}
