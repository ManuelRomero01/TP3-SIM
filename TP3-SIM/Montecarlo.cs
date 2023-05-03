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
        private string rndNroLlegadas, rndBarcosDescargadosM1, rndBarcosDescargadosM2;
        private int  nroLlegadas, nroBarcosDescargadosM1, nroBarcosDescargadosM2, nroBarcosDescargados;

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
        private int acBarcosSinDescargar = 0;
        private int acDesocupado = 0;
        private double acPorcentajeDescargas = 0;

        // VARIABLES PARAMETRIZADAS
        private int visualizarDesde;
        private double media, desviacion;
        private double costoMant, costoDesocupado;
        private double lambda;
        private int desdeUniforme, hastaUniforme;

        // RESULTADOS
        
        private double porcentajeCostosDescarga;
        private double porcentajeDescarga;
        private double promedioCostosTotales;
        private double promedioBarcosRetrasados;
        private double porcentajeOcupacion;
        private double porcentajeTotalDescargas;


        public  Montecarlo(int cantidadDias, int visualizarDesde, double costoMant, double costoDesocupado, double media, double desviacion)
        {
            this.cantidadDias = cantidadDias;
            this.visualizarDesde = visualizarDesde;
            this.costoMant = costoMant;
            this.costoDesocupado = costoDesocupado;
            this.media = media;
            this.desviacion = desviacion;
        }

        public  Montecarlo(int cantidadDias, int visualizarDesde, double costoMant, double costoDesocupado, double media, double desviacion, double lambda, int desdeUniforme, int hastaUniforme)
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
        public (double[], List<Object[]>) generarMontecarloUnMuelle()
        {
            GeneradorAleatorioBarcos generadorRNDLlegadas = new GeneradorAleatorioBarcos();
            GeneradorAleatorioBarcos generadorRNDDescargas = new GeneradorAleatorioBarcos();
            GeneradorNormal generadorNormal = new GeneradorNormal(media, desviacion, 2);

            List<Object[]> listadoFilas = new List<Object[]>();

            parRndCostos = new string[2];
            parCostosDescarga = new double[2];
            usados = true;

            for (int i = 0; i < cantidadDias; i++)
            {
                (rndNroLlegadas, nroLlegadas) = generadorRNDLlegadas.numeroDeLlegadas();
                barcosEnPuerto = barcosSinDescargar + nroLlegadas;

                (rndBarcosDescargadosM1, nroBarcosDescargados) = generadorRNDDescargas.numeroDeBarcosDescargados();

                if (nroBarcosDescargados > barcosEnPuerto)
                {
                    nroBarcosDescargados = barcosEnPuerto;
                }

                barcosSinDescargar = barcosEnPuerto - nroBarcosDescargados;

                // Obtiene los costos según la distribución normal 
                // Se asegura de usar cada par de números antes de generar uno nuevo
                if (usados)
                {
                    do
                    {
                        (parCostosDescarga, parRndCostos) = generadorNormal.generarDistribucionNormalBM();
                    } while (parCostosDescarga[0] < 0 || parCostosDescarga[1] < 0);

                    rndCostos = parRndCostos[0];
                    costoDescarga = parCostosDescarga[0];
                    usados = false;
                }
                else
                {
                    usados = true;
                    rndCostos = parRndCostos[1];
                    costoDescarga = parCostosDescarga[1];
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
                if (barcosEnPuerto == 0)
                {
                    porcentajeDescarga = 1;
                }
                else
                {
                    porcentajeDescarga = nroBarcosDescargados / barcosEnPuerto;
                }
                acPorcentajeDescargas += porcentajeDescarga;

                if ((i >= visualizarDesde && i <= visualizarDesde + 500) || (i == cantidadDias -1))
                {                                                                                           
                    Object[] vectorResultado = { i + 1, rndNroLlegadas, nroLlegadas, barcosEnPuerto, rndBarcosDescargadosM1, nroBarcosDescargados,
                        barcosSinDescargar, rndCostos, costoDescarga, costoDescargaTotal, costoMantenimientoTotal, costoDesocupacionTotal, 
                        costosTotales, acCostosDescargas, acCostosTotales, acBarcosSinDescargar, acDesocupado, porcentajeDescarga, acPorcentajeDescargas };
                    listadoFilas.Add(vectorResultado);
                }
            }

            // Métricas
            porcentajeCostosDescarga = acCostosDescargas / acCostosTotales;
            porcentajeTotalDescargas = acPorcentajeDescargas / cantidadDias;
            promedioCostosTotales = acCostosTotales / cantidadDias;
            promedioBarcosRetrasados = acBarcosSinDescargar / cantidadDias;
            porcentajeOcupacion = acDesocupado / cantidadDias;

            double [] resultados = { porcentajeCostosDescarga, porcentajeDescarga, promedioCostosTotales, promedioBarcosRetrasados, porcentajeOcupacion};
            return (resultados, listadoFilas);
        }


        //int cantidadDias, int visualizarDesde, double media, double desviacion, double costoMant, double costoDesocupado
        public (double[], List<Object[]>) generarMontecarloDosMuelles()
        {
            List<Object[]> listadoFilas = new List<Object[]>();

            GeneradorPoisson generadorPoisson = new GeneradorPoisson(lambda, 1);
            GeneradorUniforme generadorUniformeM1 = new GeneradorUniforme(desdeUniforme, hastaUniforme, 1);
            GeneradorUniforme generadorUniformeM2 = new GeneradorUniforme(desdeUniforme, hastaUniforme, 1);
            GeneradorNormal generadorNormal = new GeneradorNormal(media, desviacion, 2);
            

            for (int i = 0; i < cantidadDias; i++)
            {
                double [] auxNro;
                string [] auxRND;
                (auxNro, auxRND) = generadorPoisson.generarVariablesAleatorias();
                nroLlegadas = (int)auxNro[0];
                rndNroLlegadas = auxRND[0];
                barcosEnPuerto = barcosSinDescargar + nroLlegadas;

                (auxNro, auxRND) =  generadorUniformeM1.generarRandomUniforme();
                nroBarcosDescargadosM1 = (int)auxNro[0];
                rndBarcosDescargadosM1 = auxRND[0];

                (auxNro, auxRND) = generadorUniformeM2.generarRandomUniforme();
                nroBarcosDescargadosM2 = (int)auxNro[0];
                rndBarcosDescargadosM2 = auxRND[0];

                nroBarcosDescargados = nroBarcosDescargadosM1 + nroBarcosDescargadosM2;

                if (nroBarcosDescargados > barcosEnPuerto)
                {
                    nroBarcosDescargados = barcosEnPuerto;
                } 
                barcosSinDescargar = barcosEnPuerto - nroBarcosDescargados;

                // Calcula los costos con distribución normal, usando un valor rnd generado cada vuelta y almacenando el siguiente
                if (usados)
                {
                    do
                    {
                        (parCostosDescarga, parRndCostos) = generadorNormal.generarDistribucionNormalBM();
                    } while (parCostosDescarga[0] < 0 || parCostosDescarga[1] < 0);

                    rndCostos = parRndCostos[0];
                    costoDescarga = parCostosDescarga[0];
                    usados = false;
                } 
                //parRNDCostos = ["0,33 | 0,56", "0,33 | 0,56"]
                // parCostosDescarga = [ 800, 900 ] 
                else
                {
                    usados = true;
                    rndCostos = parRndCostos[1];
                    costoDescarga = parCostosDescarga[1];
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
                if ((i >= visualizarDesde && (i <= (visualizarDesde + 500))) || i == cantidadDias - 1)
                {
                    Object[] vectorResultado = { i+1, rndNroLlegadas, nroLlegadas, barcosEnPuerto, rndBarcosDescargadosM1, nroBarcosDescargadosM1, 
                        rndBarcosDescargadosM2, nroBarcosDescargadosM2, nroBarcosDescargados, barcosSinDescargar, 
                        rndCostos, costoDescarga, costoDescargaTotal, costoMantenimientoTotal, costoDesocupacionTotal, costosTotales, acCostosDescargas,
                        acCostosTotales, acBarcosSinDescargar, acDesocupado, porcentajeDescarga, acPorcentajeDescargas};
                    listadoFilas.Add(vectorResultado);
                }
            }

            //Metricas
            porcentajeCostosDescarga = acCostosDescargas / acCostosTotales;
            porcentajeTotalDescargas = acPorcentajeDescargas / cantidadDias;
            promedioCostosTotales = acCostosTotales / cantidadDias;
            promedioBarcosRetrasados = acBarcosSinDescargar / cantidadDias;
            porcentajeOcupacion = acDesocupado / cantidadDias;

            double [] resultados = { porcentajeCostosDescarga, porcentajeDescarga, promedioCostosTotales, promedioBarcosRetrasados, porcentajeOcupacion };
            return (resultados, listadoFilas);

        }
    }
}
