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
    public partial class propiedades : Form
    {
        List<Propiedad> Propiedades = new List<Propiedad>();
        string nameTxt = "propiedades.txt";

        List<Propietario> Propietarios = new List<Propietario>();

        Random codigo = new Random();
        public propiedades()
        {
            InitializeComponent();
            ReadTxtPropiedades();
            ActualizarGridPropiedades();
            Propietario();

            string numeros = "";
            int valor = 0;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    valor = Convert.ToInt32(codigo.Next(1, 9));
                    numeros = numeros + valor.ToString();
                    numeros = numeros + " - ";
                }
                valor = Convert.ToInt32(codigo.Next(10, 99));
                numeros = numeros + valor.ToString();
            }
            textBoxNoHouse.Text = numeros;
        }
        private void SaveTxtPropiedades()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (Propiedad dato in Propiedades)
            {
                var AgregartxtCliente = dato.NoCasa + "|" + dato.DpiOwner + "|" + dato.CuotaMantenimiento;
                writer.WriteLine(AgregartxtCliente);
            }
            writer.Close();
        }
        private void ReadTxtPropiedades()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Propiedad();
                dato.NoCasa = partes[0];
                dato.DpiOwner = partes[1];
                dato.CuotaMantenimiento = decimal.Parse(partes[2]);

                Propiedades.Add(dato);
            }
            reader.Close();
        }
        private void ActualizarGridPropiedades()
        {
            dataGridViewPropiedades.DataSource = null;
            dataGridViewPropiedades.Refresh();
            dataGridViewPropiedades.DataSource = Propiedades;
            dataGridViewPropiedades.Refresh();
        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Propiedad prop = new Propiedad();
            prop.NoCasa = textBoxNoHouse.Text;
            prop.DpiOwner = comboBoxDPIOwner.Text;
            prop.CuotaMantenimiento = Convert.ToDecimal(textBoxCuotaMantenimiento.Text);

            Propiedades.Add(prop);

            string numeros = "";
            int valor = 0;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    valor = Convert.ToInt32(codigo.Next(1, 9));
                    numeros = numeros + valor.ToString();
                    numeros = numeros + " - ";
                }
                valor = Convert.ToInt32(codigo.Next(10, 99));
                numeros = numeros + valor.ToString();
            }
            textBoxNoHouse.Text = numeros;

            comboBoxDPIOwner.Text = "";
            textBoxCuotaMantenimiento.Text = "";

            SaveTxtPropiedades();
            ActualizarGridPropiedades();
        }
        void Propietario()
        {
            FileStream stream = new FileStream(@"propietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Propietario();
                dato.Dpi = partes[0];

                Propietarios.Add(dato);
            }
            reader.Close();
            comboBoxDPIOwner.DataSource = Propietarios;
            comboBoxDPIOwner.DisplayMember = "Dpi";
            comboBoxDPIOwner.Refresh();
        }
        private void buttonPropiedades_Click(object sender, EventArgs e)
        {
            Form total = new totalInfo();
            total.Show();
            this.Hide();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
