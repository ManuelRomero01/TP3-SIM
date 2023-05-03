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
        private string[] parRndCostos;
        private double[] parCostosDescarga;
        private string rndCostos;
        private double costoDescarga;
        bool usados;
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
        private int visualizarDesde;
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
        private double porcentajeTotalDescargas;


        private Object[] vectorResultado;

        public void MontecarloUnMuelle(int cantidadDias, int visualizarDesde, double costoMant, double costoDesocupado, double media, double desviacion)
        {
            this.cantidadDias = cantidadDias;
            this.visualizarDesde = visualizarDesde;
            this.costoMant = costoMant;
            this.costoDesocupado = costoDesocupado;
            this.media = media;
            this.desviacion = desviacion;
        }

        public void MontecarloDosMuelles(int cantidadDias, int visualizarDesde, double costoMant, double costoDesocupado, double medio, double desviacion, double lambda, int desdeUniforme, int hastaUniforme)
        {
            this.cantidadDias = cantidadDias;
            this.visualizarDesde = visualizarDesde;
            this.costoMant = costoMant;
            this.costoDesocupado = costoDesocupado;
            this.media = media;
            this.desviacion = desviacion;
            this.lambda = lambda;
            this.desdeUniforme = desdeUniforme;
            this.hastaUniforme = hastaUniforme;
        }

        //int cantidadDias, int visualizarDesde, double media, double desviacion, double costoMant, double costoDesocupado
        public double[] generarMontecarloUnMuelle()
        {
            GeneradorAleatorioBarcos generadorRNDLlegadas = new GeneradorAleatorioBarcos();
            GeneradorAleatorioBarcos generadorRNDDescargas = new GeneradorAleatorioBarcos();
            GeneradorNormal generadorNormal = new GeneradorNormal();
            vectorResultado = new Object[19]; // Ver cantidad


            parRndCostos = new string[2];
            parCostosDescarga = new double[2];
            usados = true;

            for (int i = 0; i < cantidadDias; i++)
            {
                (rndNroLlegadas, nroLlegadas) = generadorRNDLlegadas.numeroDeLlegadas();
                barcosEnPuerto = barcosSinDescargar + nroLlegadas;

                (rndBarcosDescargados, nroBarcosDescargados) = generadorRNDDescargas.numeroDeBarcosDescargados();
                barcosSinDescargar = barcosEnPuerto - nroBarcosDescargados;

                // Obtiene los costos según la distribución normal 
                // Se asegura de usar cada par de números antes de generar uno nuevo
                if (usados)
                {
                    (parCostosDescarga, parRndCostos) = generadorNormal.generarDistribucionNormalBM();
                    parRndCostos[0] = rndCostos;
                    parCostosDescarga[0] = costoDescarga;
                    usados = false;
                }
                else
                {
                    usados = true;
                    parRndCostos[1] = rndCostos;
                    parCostosDescarga[1] = costoDescarga;
                }

                costoDescargaTotal = costoDescarga * nroBarcosDescargados;
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
                porcentajeDescarga = nroBarcosDescargados / barcosEnPuerto;
                acPorcentajeDescargas += porcentajeDescarga;

                if (i >= visualizarDesde && i <= visualizarDesde + 500)
                {
                    vectorResultado = { i+1, rndNroLlegadas, nroLlegadas, barcosEnPuerto, rndBarcosDescargados, nroBarcosDescargados, barcosSinDescargar, rndCostos, costoDescarga, costoDescargaTotal, costoMantenimientoTotal, costoDesocupacionTotal, costosTotales, acCostosDescargas, acCostosTotales, porcentajeDescarga, acPorcentajeDescargas }  
                    // mostrarTabla
                }

            }
            vectorResultado = { i + 1, rndNroLlegadas, nroLlegadas, barcosEnPuerto, rndBarcosDescargados, nroBarcosDescargados, barcosSinDescargar, rndCosto}
            // mostrarTabla

            // Guardar última línea

            // Métricas
            porcentajeCostosDescarga = acCostosDescargas / acCostosTotales;
            porcentajeTotalDescargas = acPorcentajeDescargas / cantidadDias;
            promedioCostosTotales = acCostosTotales / cantidadDias;
            promedioBarcosRetrasados = acBarcosSinDescargar / cantidadDias;
            porcentajeOcupación = acDesocupado / cantidadDias;

            resultados = [porcentajeCostosDescarga, porcentajeDescarga, promedioCostosTotales, promedioBarcosRetrasados, porcentajeOcupación];
            return resultados;
        }


        //int cantidadDias, int visualizarDesde, double media, double desviacion, double costoMant, double costoDesocupado
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

                // Calcula los costos con distribución normal, usando un valor rnd generado cada vuelta y almacenando el siguiente
                if (usados)
                {
                    (parCostosDescarga, parRndCostos) = generadorNormal.generarDistribucionNormalBM();
                    parRndCostos[0] = rndCostos;
                    parCostosDescarga[0] = costoDescarga;
                    usados = false;
                }
                else
                {
                    usados = true;
                    parRndCostos[1] = rndCostos;
                    parCostosDescarga[1] = costoDescarga;
                }

                costoDescargaTotal = costoDescarga * nroBarcosDescargados;

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
                porcentajeDescarga = nroBarcosDescargados / barcosEnPuerto;
                acPorcentajeDescargas += porcentajeDescarga;

                //VECTOR PARA VISUALIZAR EN PANTALLA
                if (i >= visualizarDesde && (i <= (visualizarDesde + 500)))
                {
                    //tabla[intervalosDePrueba] = generarCelda(limInf, limSup, fo, fe, difFrec, c, cAcum);
                    vectorResultado  = { i+1, rndNroLlegadas, nroLlegadas, barcosEnPuerto, rndBarcosDescargados, barcosDescargados, barcosSinDescargar, rndCostoMuelleUno, costoMuelleUno, rndCostoMuelleDos, costoMuelleDos, costoDesocupado, costosTotalDescarga, costoMantenimiento, costoDesocupacion, costosTotales, acCostosTotales, acBarcosSinDescargar, acDesocupado, acBarcosDescargados, porcentajeDescarga, acPorcentajeDescargas};
                    //mostrarTabla(vectorResultado)
                }
            }


            //Metricas
            porcentajeCostosDescarga = acCostosDescargas / acCostosTotales;
            porcentajeTotalDescargas = acPorcentajeDescargas / cantidadDias;
            promedioCostosTotales = acCostosTotales / cantidadDias;
            promedioBarcosRetrasados = acBarcosSinDescargar / cantidadDias;
            porcentajeOcupación = acDesocupado / cantidadDias;

            resultados = { porcentajeCostosDescarga, porcentajeDescarga, promedioCostosTotales, promedioBarcosRetrasados, porcentajeOcupacion };
            return resultados;

        }

        
    }
}
