using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejemplo_básico_de_Programación_Concurrente
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int numero = 0;
        int conta = 0;
        static int[] arreglo = new int[60000];
        static int[] arreglo2 = new int[60000];
        static int[] arreglo3 = new int[60000];
        static int[] arreglo4 = new int[60000];
        static int[] arreglo5 = new int[60000];

        string hora;
        string hora2;


        private void button1_Click(object sender, EventArgs e)
        {
            numero++;
            labelnumber.Text = numero.ToString();

        }


        //El programa calcula el factorial de 10 luego el de 20 luego el de 30, después el de 40, y al final 
        //el de 50 de manera secuencial 

        private void button2_Click(object sender, EventArgs e)
        {


           

        }

        public bool MetodoBurbuja(int[] vector)
        {
            bool proceso = false;
            int auxiliar;

            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length - i - 1; j++)
                {
                    if (vector[j + 1] < vector[j])
                    {
                        auxiliar = vector[j + 1];
                        vector[j + 1] = vector[j];
                        vector[j] = auxiliar;
                    }
                }
            }

            proceso = true;
            return proceso;
        }

        static void MetodoBurbujaConcurrente(int[] vector, string hora)
        {
            int auxiliar;

            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length - i - 1; j++)
                {
                    if (vector[j + 1] < vector[j])
                    {
                        auxiliar = vector[j + 1];
                        vector[j + 1] = vector[j];
                        vector[j] = auxiliar;
                    }
                }
            }

            if (vector.Length > 49000)
            {
                MessageBox.Show("Tiempo de inicio: " + hora + " Tiempo final" + DateTime.Now.ToString("HH:mm:ss"));
            }




        }



        private void button4_Click(object sender, EventArgs e)
        {



            


        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 60000; i++)
            {
                Random r = new Random();
                int random = r.Next(1, 100000);

                arreglo[i] = random;

                arreglo2[i] = random;

                arreglo3[i] = random;

                arreglo4[i] = random;

                arreglo5[i] = random;
            }

            MessageBox.Show("Los arreglos han sido creados");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (arreglo[9999] != 0)
            {
                hora = DateTime.Now.ToString("HH:mm:ss");
                Thread hilo1 = new Thread(() => MetodoBurbujaConcurrente(arreglo, hora));
                Thread hilo2 = new Thread(() => MetodoBurbujaConcurrente(arreglo2, hora));
                Thread hilo3 = new Thread(() => MetodoBurbujaConcurrente(arreglo3, hora));
                Thread hilo4 = new Thread(() => MetodoBurbujaConcurrente(arreglo4, hora));
                Thread hilo5 = new Thread(() => MetodoBurbujaConcurrente(arreglo5, hora));
                hilo1.Start();
                hilo2.Start();
                hilo3.Start();
                hilo4.Start();
                hilo5.Start();
            }
            else
            {
                MessageBox.Show("Debe crear los arreglos");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (arreglo[9999] != 0)
            {
                hora = DateTime.Now.ToString("HH:mm:ss");


                lbs10.Text = MetodoBurbuja(arreglo).ToString();
                lbs20.Text = MetodoBurbuja(arreglo2).ToString();
                lbs30.Text = MetodoBurbuja(arreglo3).ToString();
                lbs40.Text = MetodoBurbuja(arreglo4).ToString();
                lbs50.Text = MetodoBurbuja(arreglo5).ToString();
            }
            else
            {
                MessageBox.Show("Debe crear los arreglos");
            }
            hora2 = DateTime.Now.ToString("HH:mm:ss");

            labelTime1.Text = hora + " a " + hora2;
        }
    }
}
