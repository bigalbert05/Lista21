using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cliente y = new Cliente(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                ContaBanco x = new ContaBanco(Console.ReadLine(), double.Parse(Console.ReadLine()));
                y.Inserir(x);
            }
            catch (ArgumentOutOfRangeException f)
            {
                Console.WriteLine("Valor invalido!!!!!!!!");
            }
            catch (InversaoSaldoException a)
            {
                Console.WriteLine("Valor absurdo!!!!!");
            }
            Console.ReadKey();
        }
    }
}
