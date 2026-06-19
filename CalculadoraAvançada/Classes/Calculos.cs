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

        public string Binario(int numero)
        {
            return Convert.ToString(numero, 2);
        }

        public long Fatorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }

            long resultado = 1;

            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;

        }
    }
}
