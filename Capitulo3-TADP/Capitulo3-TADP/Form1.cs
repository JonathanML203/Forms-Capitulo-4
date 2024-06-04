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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(childForm);
            this.panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Prac1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Prac2());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Prac3());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Prac4());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Prac5());
        }
    }
}
