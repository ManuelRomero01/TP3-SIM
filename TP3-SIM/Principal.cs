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
            dataTableUnMuelle.Columns.Add("Barcos descargados", typeof(int));
            dataTableUnMuelle.Columns.Add("Barcos sin descargar", typeof(int));
            // costos
            dataTableUnMuelle.Columns.Add("RND Costo", typeof(string));
            dataTableUnMuelle.Columns.Add("Costo por barco", typeof(double));
            dataTableUnMuelle.Columns.Add("Costo total de descarga", typeof(double));
            dataTableUnMuelle.Columns.Add("Acumulador costo de descarga", typeof(double));
            dataTableUnMuelle.Columns.Add("Costo Mantenimiento", typeof(double));
            dataTableUnMuelle.Columns.Add("Costo Desocupacion", typeof(double));
            dataTableUnMuelle.Columns.Add("Costos totales", typeof(double));
            // resultados
            dataTableUnMuelle.Columns.Add("Acumulador de costos totales", typeof(double));
            dataTableUnMuelle.Columns.Add("Acumulador de barcos sin descargar", typeof(int));
            dataTableUnMuelle.Columns.Add("Acumulador desocupado", typeof(int));
            dataTableUnMuelle.Columns.Add("Acumulador de barcos descargados", typeof(int));
            dataTableUnMuelle.Columns.Add("Porcentaje de descarga", typeof(double));


            // DOS MUELLES
            dataTableUnMuelle.Columns.Add("Numero Experimento", typeof(int));
            dataTableUnMuelle.Columns.Add("RND nro de llegadas", typeof(string));
            dataTableUnMuelle.Columns.Add("Nro de llegadas", typeof(int));
            dataTableUnMuelle.Columns.Add("Barcos en el puerto", typeof(int));
            // descargas
            dataTableUnMuelle.Columns.Add("RND barcos descargados Muelle 1", typeof(string));
            dataTableUnMuelle.Columns.Add("Barcos descargados Muelle 1", typeof(int));
            dataTableUnMuelle.Columns.Add("RND barcos descargados Muelle 2", typeof(string));
            dataTableUnMuelle.Columns.Add("Barcos descargados Muelle 2", typeof(int));
            dataTableUnMuelle.Columns.Add("Barcos sin descargar", typeof(int));
            // costos
            dataTableUnMuelle.Columns.Add("RND Costo Muelle 1", typeof(string));
            dataTableUnMuelle.Columns.Add("Costo por barco Muelle 1", typeof(double));
            dataTableUnMuelle.Columns.Add("RND Costo Muelle 2", typeof(string));
            dataTableUnMuelle.Columns.Add("Costo por barco Muelle 2", typeof(double));
            dataTableUnMuelle.Columns.Add("Costo total de descarga", typeof(double));
            dataTableUnMuelle.Columns.Add("Acumulador costo de descarga", typeof(double));
            dataTableUnMuelle.Columns.Add("Costo Mantenimiento", typeof(double));
            dataTableUnMuelle.Columns.Add("Costo Desocupacion", typeof(double));
            dataTableUnMuelle.Columns.Add("Costos totales", typeof(double));
            // resultados
            dataTableUnMuelle.Columns.Add("Acumulador de costos totales", typeof(double));
            dataTableUnMuelle.Columns.Add("Acumulador de barcos sin descargar", typeof(int));
            dataTableUnMuelle.Columns.Add("Acumulador desocupado", typeof(int));
            dataTableUnMuelle.Columns.Add("Acumulador de barcos descargados", typeof(int));
            dataTableUnMuelle.Columns.Add("Porcentaje de descarga", typeof(double));
        }


        public void populateDataTableUnMuelle()
        {
            DataRow row = dataTableUnMuelle.NewRow();

            row["Index"] = i + 1;

            dataTableUnMuelle.Rows.Add(row);

            grdUnMuelle.DataSource = dataTableUnMuelle;
            grdUnMuelle.Visible = true;

            grdUnMuelle.Refresh();
        }

        public void populateDataTableDosMuelles()
        {
            DataRow row = dataTableDosMuelles.NewRow();


            row["Index"] = i + 1;






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
            if(txtDesde.Text == "" || int.Parse(txtDesde.Text) <= 0)
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
            if (validarNegativosYVacios() && validarRangos())
            {
                MessageBox.Show("Calcular Montecarlo");
            }
        }

    }
}
