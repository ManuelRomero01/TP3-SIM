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
        private int cantidadDias, cantDiasDescarga;

        // LLEGADAS Y DESCARGAS
        private string rndNroLlegadas;
        private string rndBarcosDescargadosM1;
        private string rndBarcosDescargadosM2;
        private int nroLlegadas;
        private int nroBarcosDescargadosM1;
        private int nroBarcosDescargadosM2;
        private int nroBarcosDescargados;

        // CANT DE BARCOS
        private int barcosEnPuerto = 0;
        private int barcosSinDescargar = 0;
        private int barcosDeAyer = 0;

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
        private int acOcupado = 0;
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
            GeneradorAleatorioLlegadas generadorRNDLlegadas = new GeneradorAleatorioLlegadas();
            GeneradorAleatorioDescargas generadorRNDDescargas = new GeneradorAleatorioDescargas();
            GeneradorNormal generadorNormal = new GeneradorNormal(media, desviacion, 2);

            List<Object[]> listadoFilas = new List<Object[]>();

            parRndCostos = new string[2];
            parCostosDescarga = new double[2];
            usados = true;

            for (int i = 0; i < cantidadDias; i++)
            {
                (rndNroLlegadas, nroLlegadas) = generadorRNDLlegadas.numeroDeLlegadas();
                barcosEnPuerto = barcosSinDescargar + nroLlegadas;

                if ( barcosEnPuerto == 0)
                {
                    nroBarcosDescargadosM1 = 0;
                    rndBarcosDescargadosM1 = "-";
                    rndCostos = "-";
                    costoDescarga = 0;
                }
                else
                {
                    (rndBarcosDescargadosM1, nroBarcosDescargadosM1) = generadorRNDDescargas.numeroDeBarcosDescargados();
                    if (usados)
                    {
                        do
                        {
                            (parCostosDescarga, parRndCostos) = generadorNormal.generarDistribucionNormalBM();
                        } 
                        while (parCostosDescarga[0] < 0 || parCostosDescarga[1] < 0);

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

                }

                nroBarcosDescargados = nroBarcosDescargadosM1;

                if (nroBarcosDescargados > barcosEnPuerto)
                {
                    nroBarcosDescargados = barcosEnPuerto;
                }

                barcosSinDescargar = barcosEnPuerto - nroBarcosDescargados;

                // Obtiene los costos según la distribución normal 
                // Se asegura de usar cada par de números antes de generar uno nuevo
                
                costoDescargaTotal = costoDescarga * nroBarcosDescargados;
                costoMantenimientoTotal = costoMant * barcosSinDescargar;
                costoDesocupacionTotal = 0;
                if (barcosSinDescargar == 0)
                {
                    costoDesocupacionTotal = costoDesocupado; 
                    
                }
                else
                {
                    // Acumula un ocupado
                    acOcupado++;
                }
                costosTotales = costoMantenimientoTotal + costoDesocupacionTotal + costoDescargaTotal;

                // Acumuladores
                acCostosTotales += costosTotales;
                acCostosDescargas += costoDescargaTotal;

                // Acumulador de barcos retrasados
                if (barcosDeAyer > nroBarcosDescargados)
                {
                    acBarcosSinDescargar += nroLlegadas;
                }
                else
                {
                    acBarcosSinDescargar += barcosSinDescargar;
                }
                
                if (barcosEnPuerto == 0)
                {
                    porcentajeDescarga = 0;
                }
                else
                {
                
                    porcentajeDescarga = ((double) nroBarcosDescargados / (double)barcosEnPuerto) * 100;
                    cantDiasDescarga += 1;
                }

                acPorcentajeDescargas += porcentajeDescarga;

                if ((i >= visualizarDesde - 1 && i <= visualizarDesde + 498) || (i == cantidadDias -1))
                {                                                                                           
                    Object[] vectorResultado = { i + 1, barcosDeAyer, rndNroLlegadas, nroLlegadas, barcosEnPuerto, rndBarcosDescargadosM1, nroBarcosDescargadosM1, nroBarcosDescargados,
                        barcosSinDescargar, rndCostos, costoDescarga, costoDescargaTotal, costoMantenimientoTotal, costoDesocupacionTotal, 
                        costosTotales, acCostosDescargas, acCostosTotales, acBarcosSinDescargar, acOcupado, porcentajeDescarga, acPorcentajeDescargas };
                    listadoFilas.Add(vectorResultado);
                }

                barcosDeAyer = barcosSinDescargar;
            }

            // Métricas
            porcentajeCostosDescarga = ((double) acCostosDescargas / (double)acCostosTotales) * 100;
            porcentajeTotalDescargas =  (double) acPorcentajeDescargas / (double) cantDiasDescarga;
            promedioCostosTotales = (double) acCostosTotales / cantidadDias;
            porcentajeOcupacion = ((double) acOcupado / cantidadDias) * 100;

            double [] resultados = { porcentajeCostosDescarga, porcentajeTotalDescargas, promedioCostosTotales, acBarcosSinDescargar, porcentajeOcupacion};
            return (resultados, listadoFilas);
        }


        //int cantidadDias, int visualizarDesde, double media, double desviacion, double costoMant, double costoDesocupado
        public (double[], List<Object[]>) generarMontecarloDosMuelles()
        {
            List<Object[]> listadoFilas = new List<Object[]>();

            GeneradorPoisson generadorPoisson = new GeneradorPoisson(lambda, 1);
            GeneradorUniforme generadorUniformeM1 = new GeneradorUniforme(desdeUniforme, hastaUniforme, 1, 8);
            GeneradorUniforme generadorUniformeM2 = new GeneradorUniforme(desdeUniforme, hastaUniforme, 1, 9);
            GeneradorNormal generadorNormal = new GeneradorNormal(media, desviacion, 2);
            

            parRndCostos = new string[2];
            parCostosDescarga = new double[2];
            usados = true;

            double[] auxNro;
            string[] auxRND;


            for (int i = 0; i < cantidadDias; i++)
            {
                (auxNro, auxRND) = generadorPoisson.generarVariablesAleatorias();
                nroLlegadas = (int)auxNro[0];
                rndNroLlegadas = auxRND[0];
                barcosEnPuerto = barcosSinDescargar + nroLlegadas;

                if (barcosEnPuerto == 0)
                {
                    nroBarcosDescargadosM1 = 0;
                    nroBarcosDescargadosM2 = 0;
                    rndBarcosDescargadosM1 = "-";
                    rndBarcosDescargadosM2 = "-";
                    rndCostos = "-";
                    costoDescarga = 0;
                }
                else
                {
                    (auxNro, auxRND) = generadorUniformeM1.generarRandomUniforme();
                    nroBarcosDescargadosM1 = (int)auxNro[0];
                    rndBarcosDescargadosM1 = auxRND[0];
                    (auxNro, auxRND) = generadorUniformeM2.generarRandomUniforme();
                    nroBarcosDescargadosM2 = (int)auxNro[0];
                    rndBarcosDescargadosM2 = auxRND[0];

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
                    else
                    {
                        usados = true;
                        rndCostos = parRndCostos[1];
                        costoDescarga = parCostosDescarga[1];
                    }
                }

                nroBarcosDescargados = nroBarcosDescargadosM1 + nroBarcosDescargadosM2;

                if (nroBarcosDescargados > barcosEnPuerto)
                {
                    nroBarcosDescargados = barcosEnPuerto;
                }
                barcosSinDescargar = barcosEnPuerto - nroBarcosDescargados;

                costoDescargaTotal = costoDescarga * nroBarcosDescargados;

                //calculo de costos totales
                costoMantenimientoTotal = costoMant * barcosSinDescargar;
                costoDesocupacionTotal = 0;
                if (barcosSinDescargar == 0)
                {
                    costoDesocupacionTotal = costoDesocupado;
                }
                else
                {
                    acOcupado++;
                }
                costosTotales = costoMantenimientoTotal + costoDesocupacionTotal + costoDescargaTotal;

                // Acumuladores
                acCostosTotales += costosTotales;
                acCostosDescargas += costoDescargaTotal;

                // Cálculo de barcos retrasados 
                if (barcosDeAyer > nroBarcosDescargados)
                {
                    acBarcosSinDescargar += nroLlegadas;
                }
                else
                {
                    acBarcosSinDescargar += barcosSinDescargar;
                }

                if (barcosEnPuerto == 0)   
                {
                    porcentajeDescarga = 0;
                }
                else
                {
                    porcentajeDescarga = ((double) nroBarcosDescargados / (double)barcosEnPuerto ) * 100;
                    cantDiasDescarga += 1;
                }

                acPorcentajeDescargas += porcentajeDescarga;

                //Vector para visualizar en pantalla
                if ((i >= (visualizarDesde - 1) && (i <= (visualizarDesde + 498))) || i == cantidadDias - 1)
                {
                    Object[] vectorResultado = { i+1, barcosDeAyer, rndNroLlegadas, nroLlegadas, barcosEnPuerto, rndBarcosDescargadosM1, nroBarcosDescargadosM1, 
                        rndBarcosDescargadosM2, nroBarcosDescargadosM2, nroBarcosDescargados, barcosSinDescargar, 
                        rndCostos, costoDescarga, costoDescargaTotal, costoMantenimientoTotal, costoDesocupacionTotal, costosTotales, acCostosDescargas,
                        acCostosTotales, acBarcosSinDescargar, acOcupado, porcentajeDescarga, acPorcentajeDescargas};
                    listadoFilas.Add(vectorResultado);
                }

                barcosDeAyer = barcosSinDescargar;
            }

            //Metricas
            porcentajeCostosDescarga = ((double) acCostosDescargas / (double)acCostosTotales) * 100;
            porcentajeTotalDescargas = (double) acPorcentajeDescargas / (double) cantDiasDescarga;
            promedioCostosTotales = (double) acCostosTotales / (double) cantidadDias;
            porcentajeOcupacion = ((double) acOcupado / cantidadDias) * 100;

            double [] resultados = { porcentajeCostosDescarga, porcentajeTotalDescargas, promedioCostosTotales, acBarcosSinDescargar, porcentajeOcupacion };
            return (resultados, listadoFilas);

        }
    }
}
