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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.grdUnMuelle = new System.Windows.Forms.DataGridView();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.lblVisualizar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
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
            this.grdDosMuelles = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnMuelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMetricas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDosMuelles)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUnMuelle
            // 
            this.grdUnMuelle.AllowUserToAddRows = false;
            this.grdUnMuelle.AllowUserToDeleteRows = false;
            this.grdUnMuelle.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdUnMuelle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdUnMuelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnMuelle.Location = new System.Drawing.Point(29, 848);
            this.grdUnMuelle.Name = "grdUnMuelle";
            this.grdUnMuelle.ReadOnly = true;
            this.grdUnMuelle.RowHeadersVisible = false;
            this.grdUnMuelle.RowHeadersWidth = 123;
            this.grdUnMuelle.RowTemplate.Height = 46;
            this.grdUnMuelle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdUnMuelle.Size = new System.Drawing.Size(2597, 377);
            this.grdUnMuelle.TabIndex = 0;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVisualizar.FlatAppearance.BorderSize = 2;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(2014, 281);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(612, 164);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // lblVisualizar
            // 
            this.lblVisualizar.AutoSize = true;
            this.lblVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizar.Location = new System.Drawing.Point(2004, 77);
            this.lblVisualizar.Name = "lblVisualizar";
            this.lblVisualizar.Size = new System.Drawing.Size(459, 55);
            this.lblVisualizar.TabIndex = 2;
            this.lblVisualizar.Text = "Rango a Visualizar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2004, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(2308, 210);
            this.txtDesde.Mask = "999";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(318, 44);
            this.txtDesde.TabIndex = 5;
            this.txtDesde.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(556, 73);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puerto San Julian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2968, 949);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 82);
            this.label4.TabIndex = 8;
            this.label4.Text = "Métricas:";
            // 
            // gdrMetricas
            // 
            this.gdrMetricas.AllowUserToAddRows = false;
            this.gdrMetricas.AllowUserToDeleteRows = false;
            this.gdrMetricas.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gdrMetricas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gdrMetricas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrMetricas.Location = new System.Drawing.Point(2743, 1052);
            this.gdrMetricas.Name = "gdrMetricas";
            this.gdrMetricas.ReadOnly = true;
            this.gdrMetricas.RowHeadersVisible = false;
            this.gdrMetricas.RowHeadersWidth = 123;
            this.gdrMetricas.RowTemplate.Height = 46;
            this.gdrMetricas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gdrMetricas.Size = new System.Drawing.Size(791, 479);
            this.gdrMetricas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(620, 55);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad de Simulaciones:";
            // 
            // txtCantSimulaciones
            // 
            this.txtCantSimulaciones.Location = new System.Drawing.Point(712, 122);
            this.txtCantSimulaciones.Mask = "9999999";
            this.txtCantSimulaciones.Name = "txtCantSimulaciones";
            this.txtCantSimulaciones.Size = new System.Drawing.Size(318, 44);
            this.txtCantSimulaciones.TabIndex = 12;
            this.txtCantSimulaciones.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 1250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(658, 55);
            this.label6.TabIndex = 13;
            this.label6.Text = "Simulación con dos muelles:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 765);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(608, 55);
            this.label7.TabIndex = 14;
            this.label7.Text = "Simulación con un muelle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(479, 55);
            this.label9.TabIndex = 16;
            this.label9.Text = "Costos de Descarga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 55);
            this.label8.TabIndex = 17;
            this.label8.Text = "Media:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 55);
            this.label10.TabIndex = 18;
            this.label10.Text = "Desviación:";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(535, 299);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(318, 44);
            this.txtMedia.TabIndex = 19;
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Location = new System.Drawing.Point(535, 404);
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.Size = new System.Drawing.Size(318, 44);
            this.txtDesviacion.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(912, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(581, 55);
            this.label11.TabIndex = 21;
            this.label11.Text = "Costo de Mantenimiento:";
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Location = new System.Drawing.Point(1621, 299);
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(318, 44);
            this.txtMantenimiento.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(934, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 55);
            this.label12.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(912, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(571, 55);
            this.label13.TabIndex = 24;
            this.label13.Text = "Costo de Desocupación:";
            // 
            // txtDesocupacion
            // 
            this.txtDesocupacion.Location = new System.Drawing.Point(1621, 401);
            this.txtDesocupacion.Name = "txtDesocupacion";
            this.txtDesocupacion.Size = new System.Drawing.Size(318, 44);
            this.txtDesocupacion.TabIndex = 25;
            // 
            // grdDosMuelles
            // 
            this.grdDosMuelles.AllowUserToAddRows = false;
            this.grdDosMuelles.AllowUserToDeleteRows = false;
            this.grdDosMuelles.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdDosMuelles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDosMuelles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDosMuelles.Location = new System.Drawing.Point(29, 1345);
            this.grdDosMuelles.Name = "grdDosMuelles";
            this.grdDosMuelles.ReadOnly = true;
            this.grdDosMuelles.RowHeadersVisible = false;
            this.grdDosMuelles.RowHeadersWidth = 123;
            this.grdDosMuelles.RowTemplate.Height = 46;
            this.grdDosMuelles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdDosMuelles.Size = new System.Drawing.Size(2597, 330);
            this.grdDosMuelles.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(683, 508);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(517, 55);
            this.label14.TabIndex = 27;
            this.label14.Text = "Distribución Uniforme ";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(844, 704);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(318, 44);
            this.txtB.TabIndex = 31;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(844, 599);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(318, 44);
            this.txtA.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(707, 692);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 55);
            this.label15.TabIndex = 29;
            this.label15.Text = "B:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(707, 587);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 55);
            this.label16.TabIndex = 28;
            this.label16.Text = "A:";
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(1621, 625);
            this.txtLambda.Mask = "999";
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(318, 44);
            this.txtLambda.TabIndex = 32;
            this.txtLambda.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1396, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 55);
            this.label2.TabIndex = 33;
            this.label2.Text = "Poisson Llegada";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1317, 613);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(219, 55);
            this.label17.TabIndex = 34;
            this.label17.Text = "Lambda:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 508);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(425, 55);
            this.label18.TabIndex = 35;
            this.label18.Text = "Para dos muelles:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.InfoText;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1, 468);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(2620, 9);
            this.label19.TabIndex = 36;
            this.label19.Text = resources.GetString("label19.Text");
            // 
            // Principal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(3602, 1687);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grdDosMuelles);
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
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVisualizar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.grdUnMuelle);
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3-Simulacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnMuelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMetricas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDosMuelles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUnMuelle;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Label lblVisualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDesde;
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
        private System.Windows.Forms.DataGridView grdDosMuelles;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtLambda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}


