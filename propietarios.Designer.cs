﻿namespace Lab7_RepasoNo3
{
    partial class propietarios
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
            this.dataGridViewPropietarios = new System.Windows.Forms.DataGridView();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonPropiedades = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPropietarios
            // 
            this.dataGridViewPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropietarios.Location = new System.Drawing.Point(68, 206);
            this.dataGridViewPropietarios.Name = "dataGridViewPropietarios";
            this.dataGridViewPropietarios.Size = new System.Drawing.Size(300, 150);
            this.dataGridViewPropietarios.TabIndex = 0;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(243, 89);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(125, 50);
            this.buttonIngresar.TabIndex = 2;
            this.buttonIngresar.Text = "Ingresar Datos";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDPI.Location = new System.Drawing.Point(68, 50);
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(150, 22);
            this.textBoxDPI.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DPI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(68, 103);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(68, 156);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(150, 22);
            this.textBoxLastName.TabIndex = 7;
            // 
            // buttonPropiedades
            // 
            this.buttonPropiedades.Location = new System.Drawing.Point(359, 386);
            this.buttonPropiedades.Name = "buttonPropiedades";
            this.buttonPropiedades.Size = new System.Drawing.Size(75, 25);
            this.buttonPropiedades.TabIndex = 9;
            this.buttonPropiedades.Text = "propiedades";
            this.buttonPropiedades.UseVisualStyleBackColor = true;
            this.buttonPropiedades.Click += new System.EventHandler(this.buttonPropiedades_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(-1, 386);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 25);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // propietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPropiedades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDPI);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.dataGridViewPropietarios);
            this.Name = "propietarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propietarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPropietarios;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonPropiedades;
        private System.Windows.Forms.Button buttonExit;
    }
}

