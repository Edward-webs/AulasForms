using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAvançada.Classes
{
    public class Calculos
    {
        public double Seno(double angulo)
        {
            return Math.Sin(angulo * Math.PI / 180);
        }

        public double Cosseno(double angulo)
        {
            return Math.Cos(angulo * Math.PI / 180);
        }

        public double Tangente(double angulo)
        {
            return Math.Tan(angulo * Math.PI / 180);
        }
    }
}
