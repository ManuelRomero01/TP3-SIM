using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM
{
    internal class GeneradorAleatorioDescargas
    {
        private Random generador = new Random(DateTime.Now.Millisecond + 50);

        public (string, int) numeroDeBarcosDescargados()
        {
            double numeroRandom = generador.NextDouble();
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
            return (((Math.Truncate(numeroRandom * 10000) / 10000)).ToString(), numeroBarcosDescargados);
        }
    }
}