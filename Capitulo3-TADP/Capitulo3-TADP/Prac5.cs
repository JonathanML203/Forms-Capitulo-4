using Capitulo3_TADP.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo3_TADP
{
    public partial class Prac5 : Form
    {

        private List<int> edades;

        public Prac5()
        {
            InitializeComponent();
            edades = new List<int>();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double promedio = EstadisticasEdad.CalcularPromedio(edades);
            int edadMayor = EstadisticasEdad.EncontrarEdadMayor(edades);
            int edadMenor = EstadisticasEdad.EncontrarEdadMenor(edades);

            lblResultado.Text = $"Promedio: {promedio:F2}\nEdad Mayor: {edadMayor}\nEdad Menor: {edadMenor}";
        }

        private void btnAgregarEdad_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = Convert.ToInt32(txtEdad.Text);
                edades.Add(edad);
                lstEdades.Items.Add(edad);
                txtEdad.Clear();
                txtEdad.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce una edad válida.");
            }
        }
    }
}
