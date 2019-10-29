using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Jogo y = new Jogo(Console.ReadLine());
                Jogador x = new Jogador(Console.ReadLine(), Console.ReadLine());
                x.SetPontos(int.Parse(Console.ReadLine()), DateTime.Parse(Console.ReadLine()));
                y.Inserir(x);
                y.Listar();
            }
            catch (EmailExistenteException o)
            {
                Console.WriteLine("Email ja Cadastrado!!!!!!!!");
            }
            catch (ArgumentOutOfRangeException s)
            {
                Console.WriteLine("Valor Invalido!!!!!/Data Invalida");
            }

            Console.ReadKey();
        }
    }
}
