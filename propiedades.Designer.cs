namespace Lab7_RepasoNo3
{
    partial class propiedades
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPropiedades = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNoHouse = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.dataGridViewPropiedades = new System.Windows.Forms.DataGridView();
            this.comboBoxDPIOwner = new System.Windows.Forms.ComboBox();
            this.textBoxCuotaMantenimiento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(-1, 387);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 25);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPropiedades
            // 
            this.buttonPropiedades.Location = new System.Drawing.Point(359, 387);
            this.buttonPropiedades.Name = "buttonPropiedades";
            this.buttonPropiedades.Size = new System.Drawing.Size(75, 25);
            this.buttonPropiedades.TabIndex = 19;
            this.buttonPropiedades.Text = "propiedades";
            this.buttonPropiedades.UseVisualStyleBackColor = true;
            this.buttonPropiedades.Click += new System.EventHandler(this.buttonPropiedades_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cuota de mantenimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "DPI del Dueño:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Número de Casa:";
            // 
            // textBoxNoHouse
            // 
            this.textBoxNoHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoHouse.Location = new System.Drawing.Point(61, 47);
            this.textBoxNoHouse.Name = "textBoxNoHouse";
            this.textBoxNoHouse.Size = new System.Drawing.Size(150, 22);
            this.textBoxNoHouse.TabIndex = 23;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(257, 86);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(125, 50);
            this.buttonIngresar.TabIndex = 22;
            this.buttonIngresar.Text = "Ingresar Datos";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // dataGridViewPropiedades
            // 
            this.dataGridViewPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropiedades.Location = new System.Drawing.Point(72, 204);
            this.dataGridViewPropiedades.Name = "dataGridViewPropiedades";
            this.dataGridViewPropiedades.Size = new System.Drawing.Size(300, 150);
            this.dataGridViewPropiedades.TabIndex = 21;
            // 
            // comboBoxDPIOwner
            // 
            this.comboBoxDPIOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDPIOwner.FormattingEnabled = true;
            this.comboBoxDPIOwner.Location = new System.Drawing.Point(61, 100);
            this.comboBoxDPIOwner.Name = "comboBoxDPIOwner";
            this.comboBoxDPIOwner.Size = new System.Drawing.Size(150, 24);
            this.comboBoxDPIOwner.TabIndex = 28;
            // 
            // textBoxCuotaMantenimiento
            // 
            this.textBoxCuotaMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCuotaMantenimiento.Location = new System.Drawing.Point(61, 153);
            this.textBoxCuotaMantenimiento.Name = "textBoxCuotaMantenimiento";
            this.textBoxCuotaMantenimiento.Size = new System.Drawing.Size(150, 22);
            this.textBoxCuotaMantenimiento.TabIndex = 30;
            // 
            // propiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.textBoxCuotaMantenimiento);
            this.Controls.Add(this.comboBoxDPIOwner);
            this.Controls.Add(this.textBoxNoHouse);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.dataGridViewPropiedades);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPropiedades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "propiedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propiedades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPropiedades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNoHouse;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.DataGridView dataGridViewPropiedades;
        private System.Windows.Forms.ComboBox comboBoxDPIOwner;
        private System.Windows.Forms.TextBox textBoxCuotaMantenimiento;
    }
}