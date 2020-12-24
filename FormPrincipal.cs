using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_básico_de_Programación_Concurrente
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form Factividad1 = new Form1();
            Factividad1.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form Factividad1 = new Form2();
            Factividad1.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form Factividad3 = new Form3();
            Factividad3.Show();
        }
    }
}
