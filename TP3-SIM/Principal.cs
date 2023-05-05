using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP3_SIM
{
    public partial class Principal : Form
    {
        private DataTable dataTableUnMuelle = new DataTable();
        private DataTable dataTableDosMuelles = new DataTable();
        private DataTable dataTableMetricas = new DataTable();

        private double[] resultados1;
        private double[] resultados2;
        private List<Object[]> tabla1;
        private List<Object[]> tabla2;

        private System.Windows.Forms.ToolTip toolTip1;

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
            txtLambda.Text = "2";

            toolTip1 = new System.Windows.Forms.ToolTip();
            
        }
        

        public void createDataTable()
        {
            // UN MUELLE
            dataTableUnMuelle.Columns.Add("Numero Experimento", typeof(int));
            dataTableUnMuelle.Columns.Add("Barcos de ayer", typeof(int));
            dataTableUnMuelle.Columns.Add("RND nro de llegadas", typeof(string));
            dataTableUnMuelle.Columns.Add("Nro de llegadas", typeof(int));
            dataTableUnMuelle.Columns.Add("Barcos en el puerto", typeof(int));
            // descargas
            dataTableUnMuelle.Columns.Add("RND barcos descargados", typeof(string));
            dataTableUnMuelle.Columns.Add("Nro Barcos descargados", typeof(int));
            dataTableUnMuelle.Columns.Add("Nro Barcos efectivamente descargados", typeof(int));
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
            dataTableUnMuelle.Columns.Add("Acumulador ocupado", typeof(int));
            dataTableUnMuelle.Columns.Add("Porcentaje de descarga", typeof(double));
            dataTableUnMuelle.Columns.Add("Acumulador de porcentaje de descarga", typeof(double));


            // DOS MUELLES
            dataTableDosMuelles.Columns.Add("Numero Experimento", typeof(int));
            dataTableDosMuelles.Columns.Add("Barcos de ayer", typeof(int));
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
            dataTableDosMuelles.Columns.Add("Acumulador ocupado", typeof(int));
            dataTableDosMuelles.Columns.Add("Porcentaje de descarga", typeof(double));
            dataTableDosMuelles.Columns.Add("Acumulador de porcentaje de descarga", typeof(double));


            //METRICAS
            dataTableMetricas.Columns.Add("-", typeof(string));
            dataTableMetricas.Columns.Add("Un muelle", typeof(double));
            dataTableMetricas.Columns.Add("Dos muelles", typeof(double));
        }

        public void populateDataTableUnMuelle(List<object[]> vector)
        {
            for (int i = 0; i < vector.Count; i++)
            {
                DataRow row = dataTableUnMuelle.NewRow();

                row["Numero Experimento"] = vector[i][0];
                row["Barcos de ayer"] = vector[i][1];
                row["RND nro de llegadas"] = vector[i][2];
                row["Nro de llegadas"] = vector[i][3];
                row["Barcos en el puerto"] = vector[i][4];
                // descargas
                row["RND barcos descargados"] = vector[i][5];
                row["Nro Barcos descargados"] = vector[i][6];
                row["Nro Barcos efectivamente descargados"] = vector[i][7];
                row["Barcos sin descargar"] = vector[i][8];
                // costos
                row["RND Costo"] = vector[i][9];
                row["Costo por barco"] = (Math.Truncate((double)vector[i][10] * 10000) / 10000).ToString();
                row["Costo total de descarga"] = (Math.Truncate((double)vector[i][11] * 10000) / 10000).ToString();
                row["Costo Mantenimiento"] = vector[i][12];
                row["Costo Desocupacion"] = vector[i][13];
                row["Costos totales"] = (Math.Truncate((double)vector[i][14] * 10000) / 10000).ToString();
                // resultados
                row["Acumulador costo de descarga"] = (Math.Truncate((double)vector[i][15] * 10000) / 10000).ToString();
                row["Acumulador de costos totales"] = (Math.Truncate((double)vector[i][16] * 10000) / 10000).ToString();
                row["Acumulador de barcos sin descargar"] = vector[i][17];
                row["Acumulador ocupado"] = vector[i][18];
                row["Porcentaje de descarga"] = (Math.Truncate((double)vector[i][19] * 10000) / 10000).ToString();
                row["Acumulador de porcentaje de descarga"] = (Math.Truncate((double)vector[i][20] * 10000) / 10000).ToString();

                dataTableUnMuelle.Rows.Add(row);
            }

            grdUnMuelle.DataSource = dataTableUnMuelle;
            grdUnMuelle.Visible = true;

            grdUnMuelle.Refresh();
        }

        public void populateDataTableDosMuelles(List<object[]> vector)
        {
            for (int i = 0; i < vector.Count; i++)
            {
                DataRow row = dataTableDosMuelles.NewRow();

                row["Numero Experimento"] = vector[i][0];
                row["Barcos de ayer"] = vector[i][1];
                row["RND nro de llegadas"] = vector[i][2];
                row["Nro de llegadas"] = vector[i][3];
                row["Barcos en el puerto"] = vector[i][4];
                // descargas
                row["RND barcos descargados Muelle 1"] = vector[i][5];
                row["Barcos descargados Muelle 1"] = vector[i][6];
                row["RND barcos descargados Muelle 2"] = vector[i][7];
                row["Barcos descargados Muelle 2"] = vector[i][8];
                row["Barcos descargados"] = vector[i][9];
                row["Barcos sin descargar"] = vector[i][10];
                // costos
                row["RND Costo"] = vector[i][11];
                row["Costo por barco"] = (Math.Truncate((double)vector[i][12] * 10000) / 10000).ToString();
                row["Costo total de descarga"] = (Math.Truncate((double)vector[i][13] * 10000) / 10000).ToString();
                row["Costo Mantenimiento"] = vector[i][14];
                row["Costo Desocupacion"] = vector[i][15];
                row["Costos totales"] = (Math.Truncate((double)vector[i][16] * 10000) / 10000).ToString();
                // resultados
                row["Acumulador costo de descarga"] = (Math.Truncate((double)vector[i][17] * 10000) / 10000).ToString();
                row["Acumulador de costos totales"] = (Math.Truncate((double)vector[i][18] * 10000) / 10000).ToString();
                row["Acumulador de barcos sin descargar"] = vector[i][19];
                row["Acumulador ocupado"] = vector[i][20];
                row["Porcentaje de descarga"] = (Math.Truncate((double)vector[i][21] * 10000) / 10000).ToString();
                row["Acumulador de porcentaje de descarga"] = (Math.Truncate((double)vector[i][22] * 10000) / 10000).ToString();

                dataTableDosMuelles.Rows.Add(row);
            }

            grdDosMuelles.DataSource = dataTableDosMuelles;
            grdDosMuelles.Visible = true;

            grdDosMuelles.Refresh();
        }

        public void populateDataTableMetricas(double[] vectorUnMuelle, double[] vectorDosMuelles)
        {
            string[] metricas = { "Porcentaje costo descarga", "Porcentaje descarga", "Promedio costo totales", "Cant. de barcos retrasados", "Porcentaje ocupacion" };

            for (int i = 0; i < 5; i++)
            {
                DataRow row = dataTableMetricas.NewRow();

                row["-"] = metricas[i];
                row["Un muelle"] = Math.Truncate( (double) vectorUnMuelle[i] * 10000) / 10000;
                row["Dos muelles"] = Math.Truncate( (double)vectorDosMuelles[i] * 10000) / 10000 ;
                dataTableMetricas.Rows.Add(row);
            }

            gdrMetricas.DataSource = dataTableMetricas;
            gdrMetricas.Visible = true;
            

            gdrMetricas.Refresh();
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
            
            if (txtDesde.Text == "" || int.Parse(txtDesde.Text) <= 0 || int.Parse(txtDesde.Text) > int.Parse(txtCantSimulaciones.Text))
            {
                bandera = true;
                mensaje += "  Desde";
            }            
            if(txtMantenimiento.Text == "" || int.Parse(txtMantenimiento.Text) < 0)
            {
                bandera = true;
                mensaje += "  Costo de mantenimiento";
            }            
            if(txtDesocupacion.Text == "" || int.Parse(txtDesocupacion.Text) < 0)
            {
                bandera = true;
                mensaje += "  Costo de desocupacion";
            }            
            if(txtMedia.Text == "" || int.Parse(txtMedia.Text) < 0)
            {
                bandera = true;
                mensaje += "  Media";
            }            
            if(txtDesviacion.Text == "" || int.Parse(txtDesviacion.Text) < 0)
            {
                bandera = true;
                mensaje += "  Desviacion";
            }            
            if(txtA.Text == "" || int.Parse(txtA.Text) < 0)
            {
                bandera = true;
                mensaje += "  A";
            }            
            if(txtB.Text == "" || int.Parse(txtB.Text) < 1)
            {
                bandera = true;
                mensaje += "  B";
            }
            if (txtLambda.Text == "" || int.Parse(txtLambda.Text) < 0)
            {
                bandera = true;
                mensaje += "  Lambda";
            }

            if (bandera)
            {
                MessageBox.Show("Las siguientes variables tienen un valor inválido:\n" + mensaje);
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
            dataTableUnMuelle = new DataTable();
            dataTableDosMuelles = new DataTable();
            dataTableMetricas = new DataTable();
            
            createDataTable();

            if (validarNegativosYVacios() && validarRangos())
            {
                Montecarlo montecarlo1 = new Montecarlo(int.Parse(txtCantSimulaciones.Text), int.Parse(txtDesde.Text), double.Parse(txtMantenimiento.Text),
                    double.Parse(txtDesocupacion.Text), double.Parse(txtMedia.Text), double.Parse(txtDesviacion.Text));

                Montecarlo montecarlo2 = new Montecarlo(int.Parse(txtCantSimulaciones.Text), int.Parse(txtDesde.Text), double.Parse(txtMantenimiento.Text),
                    double.Parse(txtDesocupacion.Text), double.Parse(txtMedia.Text), double.Parse(txtDesviacion.Text), double.Parse(txtLambda.Text),
                    int.Parse(txtA.Text), int.Parse(txtB.Text));

                (resultados1, tabla1) = montecarlo1.generarMontecarloUnMuelle();

                populateDataTableUnMuelle(tabla1);

                (resultados2, tabla1) = montecarlo2.generarMontecarloDosMuelles();

                populateDataTableDosMuelles(tabla1);
                
                populateDataTableMetricas(resultados1, resultados2);
                
            }
        }

        private void gdrMetricas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string message = "";
            if (e.RowIndex == 0)
            {
                message = "Costo Total Descarga / Costo Total";
            }
            else if (e.RowIndex == 1)
            {
                message = "Porcentaje acumulado de descarga por día con respecto a los barcos en el puerto / Cantidad de días";
            }
            else if (e.RowIndex == 2)
            {
                message = "Costo Total / Cantidad de Días";
            }
            else if (e.RowIndex == 3)
            {
                message = "Acumulador de barcos retrasados";
            }
            else if (e.RowIndex == 4)
            {
                message = "Acumulador de días ocupados / Cantidad de días";
            }
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y; 
            toolTip1.Show(message, this, x, y);
        }

        private void gdrMetricas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            toolTip1.Hide(this);
        }
    }
}
