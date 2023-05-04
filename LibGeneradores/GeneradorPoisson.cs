using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibGeneradores
{
    public class GeneradorPoisson
    {
        // Definición de atributos
        private double lambda;
        private int datos;

        // Generador de números pseudoaleatorios
        private Random random = new Random(DateTime.Now.Millisecond + 2);
        private List<double> rnd;

        // Constructor de la clase
        public GeneradorPoisson(double lambda, int datos)
        {
            this.lambda = lambda;
            this.datos = datos;
        }

        // Generador de variables aleatorias uniformes
        public (double[], string[]) generarVariablesAleatorias()
        {
            double[] x = new double[this.datos];
            string[] y = new string[this.datos];
            for (int i = 0; i < this.datos; i++)
            {
                (x[i], y[i]) = generarValorX();
            }

            return (x, y);
        }

        //Metodo para generar la variable de Poisson
        public (double, string) generarValorX()
        {
            double p = 1;
            double x = -1;
            string y = "";
            double u;
            double a = Math.Exp(-(this.lambda));

            do
            {
               
                u = Math.Truncate(random.NextDouble() * 10000) / 10000;
                p = p * u;
                x = x + 1;
                if (x == 0)
                {
                    y += u;
                }
                else
                {
                    y += "  |  " + u;
                }


            } while (p >= a);

            return (x, y);
        }
    }
}
