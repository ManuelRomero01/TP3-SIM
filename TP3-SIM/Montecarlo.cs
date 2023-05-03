using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LibGeneradores;

namespace TP3_SIM
{
    internal class Montecarlo
    {
        // NRO EXPERIMENTO
        private int cantidadDias;

        // LLEGADAS Y DESCARGAS
        private string rndNroLlegadas, rndBarcosDescargados;
        private int  nroLlegadas, nroBarcosDescargados;

        // CANT DE BARCOS
        private int barcosEnPuerto = 0;
        private int barcosSinDescargar = 0;

        // COSTOS DE DESCARGA
        private string[][] rndCostosNormales;
        private double[][] costosDescargaNormales;
        private string[] rndCostos;
        private double[] costosDescarga;
        bool[] usados;
        private double costoDescargaTotal;

        // OTROS COSTOS
        private double costoMantenimientoTotal, costoDesocupacionTotal, costosTotales;

        // ACUMULADORES
        private double acCostosTotales = 0;
        private double acCostosDescargas = 0;
        private double acBarcosSinDescargar = 0;
        private double acDesocupado = 0;
        private double acPorcentajeDescargas = 0;

        // VARIABLES PARAMETRIZADAS
        private int visualizarDesde, visualizarHasta;
        private double media, desviacion;
        private double costoMant, costoDesocupado;
        private double lambda;
        private int desdeUniforme, hastaUniforme;

        // RESULTADOS
        private double[] resultados;
        private double porcentajeCostosDescarga;
        private double porcentajeDescarga;
        private double promedioCostosTotales;
        private double promedioBarcosRetrasados;
        private double porcentajeOcupación;

        private double[] vectorResultado;
        bool guardar = false;

        public void MontecarloUnMuelle(int cantidadDias, int visualizarDesde, int visualizarHasta, double costoMant, double costoDesocupado, double media, double desviacion)
        {
            this.cantidadDias = cantidadDias;
            this.visualizarDesde = visualizarDesde;
            this.visualizarHasta = visualizarHasta;
            this.costoMant = costoMant;
            this.costoDesocupado = costoDesocupado;
            this.media = media;
            this.desviacion = desviacion;
        }

        public void MontecarloDosMuelles(int cantidadDias, int visualizarDesde, int visualizarHasta, double costoMant, double costoDesocupado, double medio, double desviacion, double lambda, int desdeUniforme, int hastaUniforme)
        {
            this.cantidadDias = cantidadDias;
            this.visualizarDesde = visualizarDesde;
            this.visualizarHasta = visualizarHasta;
            this.costoMant = costoMant;
            this.costoDesocupado = costoDesocupado;
            this.media = media;
            this.desviacion = desviacion;
            this.lambda = lambda;
            this.desdeUniforme = desdeUniforme;
            this.hastaUniforme = hastaUniforme;
        }

        //int cantidadDias, int visualizarDesde, int visualizarHasta, double media, double desviacion, double costoMant, double costoDesocupado
        public double[] generarMontecarloUnMuelle()

        {
            GeneradorAleatorioBarcos generadorRNDLlegadas = new GeneradorAleatorioBarcos();
            GeneradorAleatorioBarcos generadorRNDDescargas = new GeneradorAleatorioBarcos();
            GeneradorNormal[] arrayGeneradores = new GeneradorNormal[5];


            rndCostosNormales = new string[5][];
            costosDescargaNormales = new double[5][];
            rndCostos = new string[5];
            costosDescarga = new double[5];
            usados = new bool[5];

            for (int i = 0; i < 5; i++)
            {
                arrayGeneradores[i] = new GeneradorNormal(media, desviacion, 2);
            }

            for (int i = 0; i < cantidadDias; i++)
            {
                (rndNroLlegadas, nroLlegadas) = generadorRNDLlegadas.numeroDeLlegadas();
                barcosEnPuerto = barcosSinDescargar + nroLlegadas;

                (rndBarcosDescargados, nroBarcosDescargados) = generadorRNDDescargas.numeroDeBarcosDescargados();
                barcosSinDescargar = barcosEnPuerto - nroBarcosDescargados;

                // Obtiene los costos según la distribución normal 
                // Se asegura de usar cada par de números antes de generar uno nuevo
                for (int j = 0; j < nroBarcosDescargados; j++)
                {
                    if (usados[j])
                    {
                        (costosDescargaNormales[j], rndCostosNormales[j]) = arrayGeneradores[j].generarDistribucionNormalBM();
                        rndCostosNormales[j][0] = rndCostos[j];
                        costosDescargaNormales[j][0] = costosDescarga[j];
                        usados[j] = false;
                    }

                    else
                    {
                        usados[j] = true;
                        rndCostosNormales[j][1] = rndCostos[j];
                        costosDescargaNormales[j][1] = costosDescarga[j];
                    }
                }

                costoMantenimientoTotal = costoMant * barcosSinDescargar;
                costoDesocupacionTotal = 0;
                if (barcosSinDescargar == 0)
                {
                    costoDesocupacionTotal = costoDesocupado;
                    // Cuenta un desocupado
                    acDesocupado++;
                }
                costosTotales = costoMantenimientoTotal + costoDesocupacionTotal + costoDescargaTotal;

                // Acumuladores
                acCostosTotales += costosTotales;
                acCostosDescargas += costoDescargaTotal;
                acBarcosSinDescargar += barcosSinDescargar;
                acPorcentajeDescargas += nroBarcosDescargados / barcosEnPuerto;

                if (i == visualizarDesde - 1)
                {
                    guardar = true;
                }

                if (i == visualizarHasta)
                {
                    guardar = false;
                }

                if (guardar)
                {
                    // Generar línea en tabla
                }
            }

            // Guardar última línea

            // Métricas
            porcentajeCostosDescarga = acCostosDescargas / acCostosTotales;
            porcentajeDescarga = acPorcentajeDescargas / cantidadDias;
            promedioCostosTotales = acCostosTotales / cantidadDias;
            promedioBarcosRetrasados = acBarcosSinDescargar / cantidadDias;
            porcentajeOcupación = acDesocupado / cantidadDias;

            resultados = [porcentajeCostosDescarga, porcentajeDescarga, promedioCostosTotales, promedioBarcosRetrasados, porcentajeOcupación];
            return resultados;
        }


        //int cantidadDias, int visualizarDesde, int visualizarHasta, double media, double desviacion, double costoMant, double costoDesocupado
        public double[] generarMontecarloDosMuelles()
        {
            double[] vectorResultado = new double[27];
            GeneradorPoisson generadorPoisson = new GeneradorPoisson(lambda, 1);
            GeneradorUniforme generadorUniforme = new GeneradorUniforme(desdeUniforme, hastaUniforme, );
            for (int i = 0; i < 5; i++)
            {
                arrayGeneradores[i] = new GeneradorNormal(lambda, desviacion, 2);
            }

            for (int i = 0; i < cantidadDias; i++)
            {
                (nroLlegadas , rndNroLlegadas) = generadorPoisson.generarVariablesAleatorias();  //castear a string el rnd
                barcosEnPuerto = barcosSinDescargar + nroLlegadas;

                (rndBarcosDescargados, nroBarcosDescargados) = generadorUniforme.generarRandomUniforme();
                barcosSinDescargar = barcosEnPuerto - nroBarcosDescargados;

                //HACER LO DE LOS COSTOS CON NORMAL
                costoDescargaTotal;
                //calculo de costos totales
                costoMantenimientoTotal = costoMant * barcosSinDescargar;
                costoDesocupacionTotal = 0;
                if (barcosSinDescargar == 0)
                {
                    costoDesocupacionTotal = costoDesocupado;
                    // Cuenta un desocupado
                    acDesocupado++;
                }
                costosTotales = costoMantenimientoTotal + costoDesocupacionTotal + costoDescargaTotal;

                // Acumuladores
                acCostosTotales += costosTotales;
                acCostosDescargas += costoDescargaTotal;
                acBarcosSinDescargar += barcosSinDescargar;
                acPorcentajeDescargas += nroBarcosDescargados / barcosEnPuerto;

                if (i >= visualizarDesde || i == visualizarHasta)
                {
                    vectorResultado = { i, rndNroLlegadas, nroLlegadas, barcosEnPuerto, rndBarcosDescargados, barcosDescargados, barcosSinDescargar };
                }

            }


            //Metricas
            porcentajeCostosDescarga = acCostosDescargas / acCostosTotales;
            porcentajeDescarga = acPorcentajeDescargas / cantidadDias;
            promedioCostosTotales = acCostosTotales / cantidadDias;
            promedioBarcosRetrasados = acBarcosSinDescargar / cantidadDias;
            porcentajeOcupación = acDesocupado / cantidadDias;

            resultados = { porcentajeCostosDescarga, porcentajeDescarga, promedioCostosTotales, promedioBarcosRetrasados, porcentajeOcupacion };
            return resultados;

        }

        
    }
}
