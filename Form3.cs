using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Ejemplo_básico_de_Programación_Concurrente
{

    
    public partial class Form3 : Form
    {

        static string ruta;
        OpenFileDialog ofd = new OpenFileDialog();
        private static object control = new object();

        

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ruta = ofd.FileName;
                MessageBox.Show(ruta);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Thread hilo1 = new Thread(() => Mensaje1(ruta," primer"));
                Thread hilo2 = new Thread(() => Mensaje1(ruta," segundo"));
                hilo1.Start();
                hilo2.Start();
            
            

        }

        static void Mensaje1(string ruta, string ordinal)
        {
            lock(control)
            {
                StreamWriter escribir = new StreamWriter(ruta,true);
                for (int i = 0; i < 1000; i++)
                {
                    escribir.WriteLine("Este es un mensaje del {0} hilo", ordinal);
                }
                escribir.Close();

            }

        }
        
    }
}
