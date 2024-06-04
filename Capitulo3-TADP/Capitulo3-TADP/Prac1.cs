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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capitulo3_TADP
{
    public partial class Prac1 : Form
    {
        public Prac1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                List<string> tabla = Multiplicacion.GenerarTabla(numero);
                listBoxTabla.Items.Clear();
                foreach (string linea in tabla)
                {
                    listBoxTabla.Items.Add(linea);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }
    }
}
