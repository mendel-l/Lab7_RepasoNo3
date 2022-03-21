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
    public partial class totalInfo : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();

        List<Resumen> resumen = new List<Resumen>();
        public totalInfo()
        {
            InitializeComponent();

            buttonCuotaxMantenimiento.Enabled = false;
            buttonOrdanar3alta3Baja.Enabled = false;
            buttonPropietarioCuotaAlta.Enabled = false;
        }

        void CargarPropietarios()
        {
            FileStream stream = new FileStream("propietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Propietario();
                dato.Dpi = partes[0];
                dato.Nombre = partes[1];
                dato.Apellido = partes[2];

                propietarios.Add(dato);
            }
            reader.Close();
        }
        void CargarPropiedades()
        {
            FileStream stream = new FileStream("propiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Propiedad();
                dato.NoCasa = partes[0];
                dato.DpiOwner = partes[1];
                dato.CuotaMantenimiento = decimal.Parse(partes[2]);

                propiedades.Add(dato);
            }
            reader.Close();
        }

        void ordenarLista()
        {
            resumen = resumen.OrderByDescending(c => c.PaySuport).ToList();
        }
        private void buttonCuotaxMantenimiento_Click(object sender, EventArgs e)
        {
            //resumen = resumen.OrderByDescending(c => c.PaySuport).ToList();
            ordenarLista();
            CargarGrid(resumen);

            buttonOrdanar3alta3Baja.Enabled = true;
        }

        private void buttonOrdanar3alta3Baja_Click(object sender, EventArgs e)
        {
            labelMayor.Text = resumen[0].PaySuport.ToString();

            int cuantos = resumen.Count();
            labelMenor.Text = resumen[cuantos - 1].PaySuport.ToString();

            buttonPropietarioCuotaAlta.Enabled = true;

            ///////////////////////////////////////

            List<Resumen> lista = new List<Resumen>();
            ordenarLista();
            lista.Add(resumen[0]);
            lista.Add(resumen[1]);
            lista.Add(resumen[2]);
            lista.Add(resumen[resumen.Count -3]);
            lista.Add(resumen[resumen.Count - 2]);
            lista.Add(resumen[resumen.Count - 1]);
            CargarGrid(lista);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = resumen[0].Name + ", " + resumen[0].LastName;

            ///////////////////////////////////////

            List<Resumen> lista = new List<Resumen>();
            ordenarLista();
            lista.Add((Resumen)resumen[0]);
            CargarGrid(lista);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void totalInfo_Load(object sender, EventArgs e)
        {
        }
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            CargarPropiedades();
            CargarPropietarios();

            for (int i = 0; i < propiedades.Count; i++)
            {
                for (int j = 0; j < propietarios.Count; j++)
                {
                    if (propietarios[j].Dpi == propiedades[i].DpiOwner)
                    {
                        Resumen datoResumen = new Resumen();
                        datoResumen.Name = propietarios[j].Nombre;
                        datoResumen.LastName = propietarios[j].Apellido;
                        datoResumen.NoHouse = propiedades[i].NoCasa;
                        datoResumen.PaySuport = propiedades[i].CuotaMantenimiento;

                        resumen.Add(datoResumen);
                    }
                }
            }
            CargarGrid(resumen);

            buttonCuotaxMantenimiento.Enabled = true;
        }
        private void CargarGrid(List<Resumen> auxData)
        {
            dataGridViewPropietarios.DataSource = null;
            dataGridViewPropietarios.Refresh();
            dataGridViewPropietarios.DataSource = auxData;
            dataGridViewPropietarios.Refresh();
        }
    }
}
