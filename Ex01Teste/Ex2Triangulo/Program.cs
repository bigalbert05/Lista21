using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Retangulo x = new Retangulo(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                Console.WriteLine(x.GetArea());
            }
            catch (ArgumentOutOfRangeException c)
            {
                Console.WriteLine("Valor Invalido");
            }
            Console.ReadKey();
        }
    }
}
