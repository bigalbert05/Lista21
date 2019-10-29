using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Teste
{
    class Teste: ITeste
    {
        private int value;
        public void Setmetodo(int valor)
        {
            if (valor < 0)
            {
                throw new Erro();
            }
            else
            {
                value = valor;
            }
        }
        public int metodo1()
        {
            return value;
        }
    }
}
