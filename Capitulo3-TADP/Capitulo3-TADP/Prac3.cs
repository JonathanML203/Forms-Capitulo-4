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
    public partial class Prac3 : Form
    {
        public Prac3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double tempActual = Convert.ToDouble(txtTempActual.Text);
                double tempDeseada = Convert.ToDouble(txtTempDeseada.Text);

                if (tempDeseada >= tempActual)
                {
                    lblResultado.Text = "La temperatura deseada debe ser menor que la temperatura actual.";
                    return;
                }

                double reduccion = Caldera.ReducirTemperatura(tempActual, tempDeseada);
                lblResultado.Text = $"Reducción necesaria: {reduccion}°C";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce temperaturas válidas.");
            }
        }
    }
}
