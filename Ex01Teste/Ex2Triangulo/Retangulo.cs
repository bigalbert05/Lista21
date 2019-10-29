using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Triangulo
{
    class Retangulo
    {
        private int b, h;
        public Retangulo(int b, int h)
        {
            if (b > 0) this.b = b;
            else throw new ArgumentOutOfRangeException();
            if (h > 0) this.h = h;
            else throw new ArgumentOutOfRangeException();
        }
        public int GetArea()
        {
            return b * h;
        }
        public override string ToString()
        {
            return $"{h} - {b}";
        }
    }
}
