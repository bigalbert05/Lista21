using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Cliente
    {
        private string nome { get; set; }
        private string fone { get; set; }
        private string email { get; set; }
        private List<ContaBanco> conta = new List<ContaBanco>();

        public Cliente(string n, string f, string e)
        {
            nome = n;
            fone = f;
            email = e;
        }
        public void Inserir(ContaBanco c)
        {
            conta.Add(c);
        }
        public List<ContaBanco> Listar()
        {
            return conta;
        }
        public override string ToString()
        {
            return $"{nome} - {fone} - {email}";
        }
    }
}
