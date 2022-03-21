namespace Lab7_RepasoNo3
{
    partial class totalInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPropietarios = new System.Windows.Forms.DataGridView();
            this.buttonCuotaxMantenimiento = new System.Windows.Forms.Button();
            this.buttonOrdanar3alta3Baja = new System.Windows.Forms.Button();
            this.buttonPropietarioCuotaAlta = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMenor = new System.Windows.Forms.Label();
            this.labelMayor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPropietarios
            // 
            this.dataGridViewPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropietarios.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPropietarios.Name = "dataGridViewPropietarios";
            this.dataGridViewPropietarios.Size = new System.Drawing.Size(450, 225);
            this.dataGridViewPropietarios.TabIndex = 22;
            // 
            // buttonCuotaxMantenimiento
            // 
            this.buttonCuotaxMantenimiento.Location = new System.Drawing.Point(468, 68);
            this.buttonCuotaxMantenimiento.Name = "buttonCuotaxMantenimiento";
            this.buttonCuotaxMantenimiento.Size = new System.Drawing.Size(125, 50);
            this.buttonCuotaxMantenimiento.TabIndex = 23;
            this.buttonCuotaxMantenimiento.Text = "Ordanar por Cuota";
            this.buttonCuotaxMantenimiento.UseVisualStyleBackColor = true;
            this.buttonCuotaxMantenimiento.Click += new System.EventHandler(this.buttonCuotaxMantenimiento_Click);
            // 
            // buttonOrdanar3alta3Baja
            // 
            this.buttonOrdanar3alta3Baja.Location = new System.Drawing.Point(468, 124);
            this.buttonOrdanar3alta3Baja.Name = "buttonOrdanar3alta3Baja";
            this.buttonOrdanar3alta3Baja.Size = new System.Drawing.Size(125, 50);
            this.buttonOrdanar3alta3Baja.TabIndex = 24;
            this.buttonOrdanar3alta3Baja.Text = "Mostrar Mayor Menor";
            this.buttonOrdanar3alta3Baja.UseVisualStyleBackColor = true;
            this.buttonOrdanar3alta3Baja.Click += new System.EventHandler(this.buttonOrdanar3alta3Baja_Click);
            // 
            // buttonPropietarioCuotaAlta
            // 
            this.buttonPropietarioCuotaAlta.Location = new System.Drawing.Point(468, 180);
            this.buttonPropietarioCuotaAlta.Name = "buttonPropietarioCuotaAlta";
            this.buttonPropietarioCuotaAlta.Size = new System.Drawing.Size(125, 50);
            this.buttonPropietarioCuotaAlta.TabIndex = 25;
            this.buttonPropietarioCuotaAlta.Text = "Ordenar por Propietario con Cuota mas Alta";
            this.buttonPropietarioCuotaAlta.UseVisualStyleBackColor = true;
            this.buttonPropietarioCuotaAlta.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(343, 258);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(178, 41);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(468, 12);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(125, 50);
            this.buttonMostrar.TabIndex = 28;
            this.buttonMostrar.Text = "Mostrar Datos";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(636, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mostrar Propietario \r\n  Con Cuota Mayor";
            // 
            // labelMenor
            // 
            this.labelMenor.AutoSize = true;
            this.labelMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenor.Location = new System.Drawing.Point(636, 158);
            this.labelMenor.Name = "labelMenor";
            this.labelMenor.Size = new System.Drawing.Size(150, 16);
            this.labelMenor.TabIndex = 30;
            this.labelMenor.Text = "Mostrar Cuota Menor";
            // 
            // labelMayor
            // 
            this.labelMayor.AutoSize = true;
            this.labelMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMayor.Location = new System.Drawing.Point(636, 141);
            this.labelMayor.Name = "labelMayor";
            this.labelMayor.Size = new System.Drawing.Size(150, 16);
            this.labelMayor.TabIndex = 29;
            this.labelMayor.Text = "Mostrar Cuota Mayor";
            // 
            // totalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMenor);
            this.Controls.Add(this.labelMayor);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPropietarioCuotaAlta);
            this.Controls.Add(this.buttonOrdanar3alta3Baja);
            this.Controls.Add(this.buttonCuotaxMantenimiento);
            this.Controls.Add(this.dataGridViewPropietarios);
            this.Name = "totalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total_Info";
            this.Load += new System.EventHandler(this.totalInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPropietarios;
        private System.Windows.Forms.Button buttonCuotaxMantenimiento;
        private System.Windows.Forms.Button buttonOrdanar3alta3Baja;
        private System.Windows.Forms.Button buttonPropietarioCuotaAlta;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMenor;
        private System.Windows.Forms.Label labelMayor;
    }
}