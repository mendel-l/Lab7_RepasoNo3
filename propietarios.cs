using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_RepasoNo3
{
    public partial class propietarios : Form
    {
        List<Propietario> Propietarios = new List<Propietario>();
        string nameTxt = "propietarios.txt";

        Random codigo = new Random();
        public propietarios()
        {
            InitializeComponent();
            ReadTxtPropietarios();
            ActualizarGridPropietarios();

            string numeros = "";
            int valor = 0;

            for (int i = 0; i < 4; i++)
            {
                valor = Convert.ToInt32(codigo.Next(100, 999));
                numeros = numeros + valor.ToString();
                numeros = numeros + " ";
            }
            textBoxDPI.Text = numeros;
        }
        private void SaveTxtPropietarios()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (Propietario dato in Propietarios)
            {
                var AgregartxtCliente = dato.Dpi + "|" + dato.Nombre + "|" + dato.Apellido;
                writer.WriteLine(AgregartxtCliente);
            }
            writer.Close();
        }
        private void ReadTxtPropietarios()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Propietario();
                dato.Dpi = partes[0];
                dato.Nombre = partes[1];
                dato.Apellido = partes[2];

                Propietarios.Add(dato);
            }
            reader.Close();
        }
        private void ActualizarGridPropietarios()
        {
            dataGridViewPropietarios.DataSource = null;
            dataGridViewPropietarios.Refresh();
            dataGridViewPropietarios.DataSource = Propietarios;
            dataGridViewPropietarios.Refresh();
        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Propietario prop = new Propietario();
            prop.Dpi = textBoxDPI.Text;
            prop.Nombre = textBoxName.Text;
            prop.Apellido = textBoxLastName.Text;

            Propietarios.Add(prop);

            string numeros = "";
            int valor = 0;

            for (int i = 0; i < 4; i++)
            {
                valor = Convert.ToInt32(codigo.Next(100, 999));
                numeros = numeros + valor.ToString();
                numeros = numeros + " ";
            }
            textBoxDPI.Text = numeros;

            textBoxName.Text = "";
            textBoxLastName.Text = "";

            SaveTxtPropietarios();
            ActualizarGridPropietarios();
        }

        private void buttonPropiedades_Click(object sender, EventArgs e)
        {
            Form propiedades = new propiedades();
            propiedades.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
