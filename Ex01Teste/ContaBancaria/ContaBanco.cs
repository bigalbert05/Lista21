using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class ContaBanco
    {
        private string numero { get; set; }
        private double saldo { get; set; }

        public ContaBanco(string n, double s)
        {
            numero = n;
            saldo = s;
        }

        public void depositar(double valor)
        {
            if (saldo < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                saldo = saldo + valor;
            }
        }
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (valor > saldo)
            {
                throw new InversaoSaldoException();
            }
            else
            {
                saldo = saldo - valor;
            }
        }
        public double Saldo()
        {
            return saldo;
        }
        public override string ToString()
        {
            return $"{numero} - {saldo}";
        }
    }
}
