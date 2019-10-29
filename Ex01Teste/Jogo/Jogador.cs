using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Jogador : IComparable
    {
        private string nome { get; set; }
        public string email { get; set; }
        private DateTime data { get; set; }
        private int PontuaçãoMax { get; set; }

        public Jogador(string n, string e)
        {
            nome = n;
            email = e;
        }
        public void SetPontos(int p, DateTime d)
        {
            if (p < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                PontuaçãoMax = p;
            }
            if (d >= DateTime.Now)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                data = d;
            }
        }
        public override string ToString()
        {
            return $"{nome} - {email} - {data} - {PontuaçãoMax}";
        }
        public int CompareTo(object obj)
        {
            Jogador f = obj as Jogador;
            if (PontuaçãoMax.CompareTo(f.PontuaçãoMax) != 0)
                return PontuaçãoMax.CompareTo(f.PontuaçãoMax);
            else return data.CompareTo(f.data);
        }
    }
}
