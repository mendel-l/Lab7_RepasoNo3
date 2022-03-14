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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPropietarios
            // 
            this.dataGridViewPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropietarios.Location = new System.Drawing.Point(86, 23);
            this.dataGridViewPropietarios.Name = "dataGridViewPropietarios";
            this.dataGridViewPropietarios.Size = new System.Drawing.Size(300, 150);
            this.dataGridViewPropietarios.TabIndex = 22;
            // 
            // buttonCuotaxMantenimiento
            // 
            this.buttonCuotaxMantenimiento.Location = new System.Drawing.Point(12, 199);
            this.buttonCuotaxMantenimiento.Name = "buttonCuotaxMantenimiento";
            this.buttonCuotaxMantenimiento.Size = new System.Drawing.Size(125, 50);
            this.buttonCuotaxMantenimiento.TabIndex = 23;
            this.buttonCuotaxMantenimiento.Text = "Ordanar por Cuota";
            this.buttonCuotaxMantenimiento.UseVisualStyleBackColor = true;
            this.buttonCuotaxMantenimiento.Click += new System.EventHandler(this.buttonCuotaxMantenimiento_Click);
            // 
            // buttonOrdanar3alta3Baja
            // 
            this.buttonOrdanar3alta3Baja.Location = new System.Drawing.Point(180, 199);
            this.buttonOrdanar3alta3Baja.Name = "buttonOrdanar3alta3Baja";
            this.buttonOrdanar3alta3Baja.Size = new System.Drawing.Size(125, 50);
            this.buttonOrdanar3alta3Baja.TabIndex = 24;
            this.buttonOrdanar3alta3Baja.Text = "Ordanar por 3 Cuotas";
            this.buttonOrdanar3alta3Baja.UseVisualStyleBackColor = true;
            this.buttonOrdanar3alta3Baja.Click += new System.EventHandler(this.buttonOrdanar3alta3Baja_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 50);
            this.button2.TabIndex = 25;
            this.button2.Text = "Ordenar por Propietario con Cuota mas Alta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(203, 265);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 25);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // totalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 286);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOrdanar3alta3Baja);
            this.Controls.Add(this.buttonCuotaxMantenimiento);
            this.Controls.Add(this.dataGridViewPropietarios);
            this.Name = "totalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total_Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPropietarios;
        private System.Windows.Forms.Button buttonCuotaxMantenimiento;
        private System.Windows.Forms.Button buttonOrdanar3alta3Baja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonExit;
    }
}