using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncIntegration
{
    public class Integration
    {
        //Определение границ интегрирования
        public readonly double X1;
        public readonly double X2;
        public readonly double func;

        public Integration(double x1 = 0, double x2 = 0, double func = 0)
        {
            this.X1 = x1;
            this.X2 = x2;
        }

        public static double Antiderivative()
        {

        }

        public double RectangleM(double accurancy)
        {
            double S = 0;
            for (double i = this.X1; i < this.X2; i = i + (X1-X2)/100)
            {
                S += ();
            }
            return S;
        }
    }
}
