using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Jogo
    {
        private string nome { get; set; }
        private List<Jogador> jogadores = new List<Jogador>();

        public Jogo(string n)
        {
            nome = n;
        }

        public void Inserir(Jogador c)
        {
            foreach (Jogador j in jogadores)
            {
                if (j.email == c.email)
                {
                    throw new EmailExistenteException();
                }
                else
                {
                    jogadores.Add(c);
                }
            }
        }

        public List<Jogador> Listar()
        {
            return jogadores;
        }
        public Jogador Top1()
        {
            jogadores.Sort();
            return jogadores[0];
        }
        public List<Jogador> Top10()
        {
            List<Jogador> k = new List<Jogador>();
            jogadores.Sort();
            jogadores.CopyTo(0, k.ToArray(), 0, 10);
            return k;
        }
    }
}
