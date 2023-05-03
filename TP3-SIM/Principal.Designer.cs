namespace TP3_SIM
{
    
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gdrUnMuelle = new System.Windows.Forms.DataGridView();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.lblVisualizar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gdrMetricas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantSimulaciones = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtDesviacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDesocupacion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrUnMuelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMetricas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdrUnMuelle
            // 
            this.gdrUnMuelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrUnMuelle.Location = new System.Drawing.Point(28, 604);
            this.gdrUnMuelle.Name = "gdrUnMuelle";
            this.gdrUnMuelle.RowHeadersWidth = 123;
            this.gdrUnMuelle.RowTemplate.Height = 46;
            this.gdrUnMuelle.Size = new System.Drawing.Size(2597, 538);
            this.gdrUnMuelle.TabIndex = 0;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVisualizar.FlatAppearance.BorderSize = 2;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(2107, 404);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(502, 104);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // lblVisualizar
            // 
            this.lblVisualizar.AutoSize = true;
            this.lblVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizar.Location = new System.Drawing.Point(1984, 81);
            this.lblVisualizar.Name = "lblVisualizar";
            this.lblVisualizar.Size = new System.Drawing.Size(459, 55);
            this.lblVisualizar.TabIndex = 2;
            this.lblVisualizar.Text = "Rango a Visualizar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1986, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2000, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(2290, 214);
            this.txtDesde.Mask = "999";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(319, 44);
            this.txtDesde.TabIndex = 5;
            this.txtDesde.ValidatingType = typeof(int);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(2290, 316);
            this.txtHasta.Mask = "999";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(319, 44);
            this.txtHasta.TabIndex = 6;
            this.txtHasta.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(556, 73);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puerto San Julian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3019, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = "Métricas:";
            // 
            // gdrMetricas
            // 
            this.gdrMetricas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrMetricas.Location = new System.Drawing.Point(2786, 120);
            this.gdrMetricas.Name = "gdrMetricas";
            this.gdrMetricas.RowHeadersWidth = 123;
            this.gdrMetricas.RowTemplate.Height = 46;
            this.gdrMetricas.Size = new System.Drawing.Size(829, 609);
            this.gdrMetricas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(620, 55);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad de Simulaciones:";
            // 
            // txtCantSimulaciones
            // 
            this.txtCantSimulaciones.Location = new System.Drawing.Point(711, 122);
            this.txtCantSimulaciones.Mask = "9999999";
            this.txtCantSimulaciones.Name = "txtCantSimulaciones";
            this.txtCantSimulaciones.Size = new System.Drawing.Size(319, 44);
            this.txtCantSimulaciones.TabIndex = 12;
            this.txtCantSimulaciones.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 1174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(658, 55);
            this.label6.TabIndex = 13;
            this.label6.Text = "Simulación con dos muelles:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(608, 55);
            this.label7.TabIndex = 14;
            this.label7.Text = "Simulación con un muelle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(479, 55);
            this.label9.TabIndex = 16;
            this.label9.Text = "Costos de Descarga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 55);
            this.label8.TabIndex = 17;
            this.label8.Text = "Media:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 55);
            this.label10.TabIndex = 18;
            this.label10.Text = "Desviación:";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(534, 298);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(319, 44);
            this.txtMedia.TabIndex = 19;
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Location = new System.Drawing.Point(534, 403);
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.Size = new System.Drawing.Size(319, 44);
            this.txtDesviacion.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(912, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(581, 55);
            this.label11.TabIndex = 21;
            this.label11.Text = "Costo de Mantenimiento:";
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Location = new System.Drawing.Point(1620, 300);
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(319, 44);
            this.txtMantenimiento.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(933, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 55);
            this.label12.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(912, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(571, 55);
            this.label13.TabIndex = 24;
            this.label13.Text = "Costo de Desocupación:";
            // 
            // txtDesocupacion
            // 
            this.txtDesocupacion.Location = new System.Drawing.Point(1620, 402);
            this.txtDesocupacion.Name = "txtDesocupacion";
            this.txtDesocupacion.Size = new System.Drawing.Size(319, 44);
            this.txtDesocupacion.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 1560);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(2597, 525);
            this.dataGridView1.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 1250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(802, 55);
            this.label14.TabIndex = 27;
            this.label14.Text = "Distribución Uniforme de Descarga";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 1445);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 44);
            this.textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 1340);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 44);
            this.textBox2.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 1434);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 55);
            this.label15.TabIndex = 29;
            this.label15.Text = "B:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 1329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 55);
            this.label16.TabIndex = 28;
            this.label16.Text = "A:";
            // 
            // Principal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(3696, 2097);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDesocupacion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMantenimiento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDesviacion);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantSimulaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gdrMetricas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVisualizar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.gdrUnMuelle);
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3-Simulacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gdrUnMuelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMetricas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdrUnMuelle;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Label lblVisualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gdrMetricas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCantSimulaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtDesviacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMantenimiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDesocupacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}


