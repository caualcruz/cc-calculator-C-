using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Classes
{
    internal class Operacoes
    {
        double x, y;
        public Operacoes()
        {
            x = 0; y = 0;
        }

        public void setXFromInput(double x)
        {
            this.x = x;
        }

        public void setYFromInput(double y)
        {
            this.y = y;
        }

        public double getX()
        {
            return this.x;
        }

        public double getY()
        {
            return this.y;
        }


        public double soma()
        {
            return this.x + this.y;
        }

        public double sub()
        {
            return this.x - this.y;
        }

        public double mult()
        {
            return this.x * this.y;
        }

        public double div()
        {
            return this.x / this.y;
        }

        public double quad()
        {
            return this.x * this.x;
        }

        public double raiz()
        {
            return Math.Sqrt(this.x);
        }

        public double porc()
        {
            return (this.x / 100.0) * this.y;
        }

        public long bin()
        {
            long xInt = (long)this.x;
            long yInt = (long)this.y;
            return xInt & yInt;
        }

        public double elev()
        {
            return Math.Pow(this.x, this.y);
        }
    }
}