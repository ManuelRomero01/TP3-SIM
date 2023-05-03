using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_SIM
{
    public partial class Principal : Form
    {
        private DataTable dataTableUnMuelle = new DataTable();
        private DataTable dataTableDosMuelles = new DataTable();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //GENERAL
            txtMantenimiento.Text = "1500";
            txtDesocupacion.Text = "3200";

            //UN MUELLE
            txtMedia.Text = "800";
            txtDesviacion.Text = "200";
            
            //DOS MUELLES
            txtA.Text = "0";
            txtB.Text = "9";

            createDataTable();

        }
        

        public void createDataTable()
        {
            // UN MUELLE
            dataTableUnMuelle.Columns.Add("Numero Experimento", typeof(int));
            dataTableUnMuelle.Columns.Add("RND nro de llegadas", typeof(string));
            dataTableUnMuelle.Columns.Add("Nro de llegadas", typeof(int));
            dataTableUnMuelle.Columns.Add("Barcos en el puerto", typeof(int));
            // descargas
            dataTableUnMuelle.Columns.Add("RND barcos descargados", typeof(string));
            dataTableUnMuelle.Columns.Add("Nro Barcos descargados", typeof(int));
            dataTableUnMuelle.Columns.Add("Barcos sin descargar", typeof(int));
            // costos
            dataTableUnMuelle.Columns.Add("RND Costo", typeof(string));
            dataTableUnMuelle.Columns.Add("Costo por barco", typeof(double));
            dataTableUnMuelle.Columns.Add("Costo total de descarga", typeof(double));
            dataTableUnMuelle.Columns.Add("Costo Mantenimiento", typeof(double));
            dataTableUnMuelle.Columns.Add("Costo Desocupacion", typeof(double));
            dataTableUnMuelle.Columns.Add("Costos totales", typeof(double));
            // resultados
            dataTableUnMuelle.Columns.Add("Acumulador costo de descarga", typeof(double));
            dataTableUnMuelle.Columns.Add("Acumulador de costos totales", typeof(double));
            dataTableUnMuelle.Columns.Add("Acumulador de barcos sin descargar", typeof(int));
            dataTableUnMuelle.Columns.Add("Acumulador desocupado", typeof(int));
            dataTableUnMuelle.Columns.Add("Porcentaje de descarga", typeof(double));
            dataTableUnMuelle.Columns.Add("Acumulador de porcentaje de descarga", typeof(double));


            // DOS MUELLES
            dataTableDosMuelles.Columns.Add("Numero Experimento", typeof(int));
            dataTableDosMuelles.Columns.Add("RND nro de llegadas", typeof(string));
            dataTableDosMuelles.Columns.Add("Nro de llegadas", typeof(int));
            dataTableDosMuelles.Columns.Add("Barcos en el puerto", typeof(int));
            // descargas
            dataTableDosMuelles.Columns.Add("RND barcos descargados Muelle 1", typeof(string));
            dataTableDosMuelles.Columns.Add("Barcos descargados Muelle 1", typeof(int));
            dataTableDosMuelles.Columns.Add("RND barcos descargados Muelle 2", typeof(string));
            dataTableDosMuelles.Columns.Add("Barcos descargados Muelle 2", typeof(int));
            dataTableDosMuelles.Columns.Add("Barcos descargados", typeof(int));
            dataTableDosMuelles.Columns.Add("Barcos sin descargar", typeof(int));
            // costos
            dataTableDosMuelles.Columns.Add("RND Costo", typeof(string));
            dataTableDosMuelles.Columns.Add("Costo por barco", typeof(double));
            dataTableDosMuelles.Columns.Add("Costo total de descarga", typeof(double));
            dataTableDosMuelles.Columns.Add("Costo Mantenimiento", typeof(double));
            dataTableDosMuelles.Columns.Add("Costo Desocupacion", typeof(double));
            dataTableDosMuelles.Columns.Add("Costos totales", typeof(double));
            // resultados
            dataTableDosMuelles.Columns.Add("Acumulador costo de descarga", typeof(double));
            dataTableDosMuelles.Columns.Add("Acumulador de costos totales", typeof(double));
            dataTableDosMuelles.Columns.Add("Acumulador de barcos sin descargar", typeof(int));
            dataTableDosMuelles.Columns.Add("Acumulador desocupado", typeof(int));
            dataTableDosMuelles.Columns.Add("Porcentaje de descarga", typeof(double));
            dataTableDosMuelles.Columns.Add("Acumulador de porcentaje de descarga", typeof(double));
        }


        public void populateDataTableUnMuelle(object[] vector)
        {
            DataRow row = dataTableUnMuelle.NewRow();

            row["Numero Experimento"] = vector[0];
            row["RND nro de llegadas"] = vector[1];
            row["Nro de llegadas"] = vector[2];
            row["Barcos en el puerto"] = vector[3];
            // descargas
            row["RND barcos descargados"] = vector[4];
            row["Nro Barcos descargados"] = vector[5];
            row["Barcos sin descargar"] = vector[6];
            // costos
            row["RND Costo"] = vector[7];
            row["Costo por barco"] = vector[8];
            row["Costo total de descarga"] = vector[9];
            row["Costo Mantenimiento"] = vector[10];
            row["Costo Desocupacion"] = vector[11];
            row["Costos totales"] = vector[12];
            // resultados
            row["Acumulador costo de descarga"] = vector[13];
            row["Acumulador de costos totales"] = vector[14];
            row["Acumulador de barcos sin descargar"] = vector[15];
            row["Acumulador desocupado"] = vector[16];
            row["Porcentaje de descarga"] = vector[17];
            row["Acumulador de porcentaje de descarga"] = vector[18];

            dataTableUnMuelle.Rows.Add(row);

            grdUnMuelle.DataSource = dataTableUnMuelle;
            grdUnMuelle.Visible = true;

            grdUnMuelle.Refresh();
        }

        public void populateDataTableDosMuelles(object[] vector)
        {
            DataRow row = dataTableDosMuelles.NewRow();
            
            row["Numero Experimento"] = vector[0];
            row["RND nro de llegadas"] = vector[1];
            row["Nro de llegadas"] = vector[2];
            row["Barcos en el puerto"] = vector[3];
            // descargas
            row["RND barcos descargados Muelle 1"] = vector[4];
            row["Barcos descargados Muelle 1"] = vector[5];
            row["RND barcos descargados Muelle 2"] = vector[6];
            row["Barcos descargados Muelle 2"] = vector[7];
            row["Barcos descargados"] = vector[8];
            row["Barcos sin descargar"] = vector[9];
            // costos
            row["RND Costo"] = vector[10];
            row["Costo por barco"] = vector[11];
            row["Costo total de descarga"] = vector[12];
            row["Costo Mantenimiento"] = vector[13];
            row["Costo Desocupacion"] = vector[14];
            row["Costos totales"] = vector[15];
            // resultados
            row["Acumulador costo de descarga"] = vector[16];
            row["Acumulador de costos totales"] = vector[17];
            row["Acumulador de barcos sin descargar"] = vector[18];
            row["Acumulador desocupado"] = vector[19];
            row["Porcentaje de descarga"] = vector[20];
            row["Acumulador de porcentaje de descarga"] = vector[21];

            dataTableDosMuelles.Rows.Add(row);

            grdDosMuelles.DataSource = dataTableDosMuelles;
            grdDosMuelles.Visible = true;

            grdDosMuelles.Refresh();
        }


        private bool validarNegativosYVacios()
        {
            bool bandera = false;
            string mensaje = "";

            if(txtCantSimulaciones.Text == "" || int.Parse(txtCantSimulaciones.Text) < 0)
            {
                bandera = true;
                mensaje += "Cantidad de simulaciones";
            }
            
            if (txtDesde.Text == "" || int.Parse(txtDesde.Text) <= 0)
            {
                bandera = true;
                mensaje += ", Desde";
            }            
            if(txtMantenimiento.Text == "" || int.Parse(txtMantenimiento.Text) < 0)
            {
                bandera = true;
                mensaje += ", Costo de mantenimiento";
            }            
            if(txtDesocupacion.Text == "" || int.Parse(txtDesocupacion.Text) < 0)
            {
                bandera = true;
                mensaje += ", Costo de desocupacion";
            }            
            if(txtMedia.Text == "" || int.Parse(txtMedia.Text) < 0)
            {
                bandera = true;
                mensaje += ", Media";
            }            
            if(txtDesviacion.Text == "" || int.Parse(txtDesviacion.Text) < 0)
            {
                bandera = true;
                mensaje += ", Desviacion";
            }            
            if(txtA.Text == "" || int.Parse(txtA.Text) < 0)
            {
                bandera = true;
                mensaje += ", A";
            }            
            if(txtB.Text == "" || int.Parse(txtB.Text) < 1)
            {
                bandera = true;
                mensaje += ", B";
            }
            if (txtLambda.Text == "" || int.Parse(txtLambda.Text) < 0)
            {
                bandera = true;
                mensaje += ", Lambda";
            }

            if (bandera)
            {
                MessageBox.Show("Las siguientes variables estan vacias o son negativas:\n" + mensaje);
                return false;
            }
            return true;
        }

        private bool validarRangos()
        {
            
            if (int.Parse(txtA.Text) < int.Parse(txtB.Text))
            {
                return true;
                   
            }
            else
            {
                MessageBox.Show("El valor de la variable A debe ser menor al de la variable B");
            }
            return false;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            /*
             * public void MontecarloUnMuelle(int cantidadDias, int visualizarDesde, double costoMant, double costoDesocupado, double media, double desviacion)
        {
            this.cantidadDias = cantidadDias;
            this.visualizarDesde = visualizarDesde;
            this.costoMant = costoMant;
            this.costoDesocupado = costoDesocupado;
            this.media = media;
            this.desviacion = desviacion;
        }

        public void MontecarloDosMuelles(int cantidadDias, int visualizarDesde, double costoMant, double costoDesocupado, double media, double desviacion, double lambda, int desdeUniforme, int hastaUniforme)
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
             */
            if (validarNegativosYVacios() && validarRangos())
            {

                Montecarlo montecarlo1 = new Montecarlo(int.Parse(txtCantSimulaciones.Text), int.Parse(txtDesde.Text), double.Parse(txtMantenimiento.Text),
                    double.Parse(txtDesocupacion.Text), double.Parse(txtMedia.Text), double.Parse(txtDesviacion.Text));

                Montecarlo montecarlo2 = new Montecarlo(int.Parse(txtCantSimulaciones.Text), int.Parse(txtDesde.Text), double.Parse(txtMantenimiento.Text),
                    double.Parse(txtDesocupacion.Text), double.Parse(txtMedia.Text), double.Parse(txtDesviacion.Text), double.Parse(txtLambda.Text),
                    int.Parse(txtA.Text), int.Parse(txtB.Text));
                montecarlo1.generarMontecarloUnMuelle();
                montecarlo2.generarMontecarloDosMuelles();
            }
            
        }

    }
}
