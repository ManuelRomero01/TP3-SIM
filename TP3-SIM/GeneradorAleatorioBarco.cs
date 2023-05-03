using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM
{
    internal class GeneradorAleatorioBarcos
    {

        

        Random generador = new Random();
        double numeroRandom;

        public (string, int) numeroDeLlegadas()
        {
            numeroRandom = generador.NextDouble();
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
            return (numeroRandom.ToString(), numeroDeLlegada);
        }

        public (string, int) numeroDeBarcosDescargados()
        {
            numeroRandom = generador.NextDouble();
            int numeroBarcosDescargados;
            if (numeroRandom <= 0.04)
            {
                numeroBarcosDescargados = 1;
            }
            else if (numeroRandom <= 0.19)
            {
                numeroBarcosDescargados = 2;
            }
            else if (numeroRandom <= 0.69)
            {
                numeroBarcosDescargados = 3;
            }
            else if (numeroRandom <= 0.89)
            {
                numeroBarcosDescargados = 4;
            }
            else
            {
                numeroBarcosDescargados = 5;
            }
            return (numeroRandom.ToString(), numeroBarcosDescargados);
        }
    }
}


