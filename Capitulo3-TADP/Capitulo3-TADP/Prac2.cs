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
    public partial class Prac2 : Form
    {
        public Prac2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double baseNumero = Convert.ToDouble(txtBase.Text);
                double exponente = Convert.ToDouble(txtExponente.Text);
                double resultado = Potencia.CalcularPotencia(baseNumero, exponente);
                lblResultado.Text = $"Resultado: {baseNumero}^{exponente} = {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce números válidos.");
            }
        }
    }
}
