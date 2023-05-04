using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM
{
    internal class GeneradorAleatorioLlegadas
    {
        private Random generador = new Random(DateTime.Now.Millisecond + 30);

        public (string, int) numeroDeLlegadas()
        {
            double numeroRandom = generador.NextDouble();       
            int numeroDeLlegada;
            if (numeroRandom <= 0.12)
            {
                numeroDeLlegada = 0;
            }
            else if (numeroRandom <= 0.29)
            {
                numeroDeLlegada = 1;
            }
            else if (numeroRandom <= 0.44)
            {
                numeroDeLlegada = 2;
            }
            else if (numeroRandom <= 0.69)
            {
                numeroDeLlegada = 3;
            }
            else if (numeroRandom <= 0.89)
            {
                numeroDeLlegada = 4;
            }
            else
            {
                numeroDeLlegada = 5;
            }
            return (((Math.Truncate(numeroRandom * 10000) / 10000)).ToString(), numeroDeLlegada);
        }
    }
}


