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

        List<Total> Total_ = new List<Total>();
        string nameTxt = "Total.txt";
        public totalInfo()
        {
            InitializeComponent();

            ReadTotal();
            Propietarios();
            Propiedades();

            /*Total tot = new Total();
            tot.Name = ((Propietario)dataGridViewPropietarios.DataSource).Nombre;
            tot.LastName = ((Propietario)dataGridViewPropietarios.DataSource).Apellido;
            tot.NoHouse = ((Propiedad)dataGridViewPropietarios.DataSource).NoCasa;
            tot.PaySuport = ((Propiedad)dataGridViewPropietarios.DataSource).CuotaMantenimiento;

            Total_.Add(tot);
            */
            ActualizarGred();
            SaveTotal();
        }
        private void SaveTotal()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (Total dato in Total_)
            {
                var AgregarTotal = dato.Name + "|" + dato.LastName + "|" + dato.NoHouse + "|" + dato.PaySuport;
            }
            writer.Close();
        }
        private void ReadTotal()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Total();
                dato.Name = partes[0];
                dato.LastName = partes[1];
                dato.NoHouse = partes[2];
                dato.PaySuport = partes[3];

                Total_.Add(dato);
            }
            reader.Close();
        }
        void Propietarios()
        {
            FileStream stream = new FileStream(@"propietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Propietario();
                dato.Nombre = partes[1];
                dato.Apellido = partes[2];
                propietarios.Add(dato);
            }
            reader.Close();
        }
        void Propiedades()
        {
            FileStream stream = new FileStream(@"propiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Propiedad();
                dato.NoCasa = partes[0];
                dato.CuotaMantenimiento = partes[2];
                propiedades.Add(dato);
            }
            reader.Close();
        }
        void ActualizarGred()
        {
            dataGridViewPropietarios.DataSource = null;
            dataGridViewPropietarios.Refresh();
            dataGridViewPropietarios.DataSource = Total_;
            dataGridViewPropietarios.Refresh();
        }


        private void buttonCuotaxMantenimiento_Click(object sender, EventArgs e)
        {
        }

        private void buttonOrdanar3alta3Baja_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
