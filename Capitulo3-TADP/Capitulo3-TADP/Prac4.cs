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
    public partial class Prac4 : Form
    {
        public Prac4()
        {
            InitializeComponent();
        }

        private void btnObtenerDia_Click(object sender, EventArgs e)
        {
            List<int> primos = Primos.EncontrarPrimos(1, 1000);
            lstPrimos.Items.Clear();
            foreach (int primo in primos)
            {
                lstPrimos.Items.Add(primo);
            }
        }
    }
}
