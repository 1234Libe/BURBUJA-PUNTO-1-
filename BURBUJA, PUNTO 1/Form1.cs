using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURBUJA__PUNTO_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ordenamientoBurbujaBi(int[] vector)

        {

            int der = 0;
            int aux = 0;
            int izq = 0;

            der = vector.Length - 1;

            do
            {
                for (int i = izq; i < der; i++)
                {

                    if (vector[i] > vector[i + 1])
                    {

                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;

                    }

                }

                for (int j = der; j > izq; j--)
                {

                    if (vector[j] < vector[j - 1])
                    {

                        aux = vector[j];
                        vector[j] = vector[j - 1];
                        vector[j - 1] = aux;

                    }

                }

                //Siguiente vuelta quitamos uno a derecha y uno a izqquieda porque tenemos el primero y el ultimo elemento ordenados

                izq++;
                der--;

            } while (izq < der);


            txtVector.Text += "Cantidad ordenada: " + Environment.NewLine;

            foreach (int element in vector)
              
              {


                txtVector.Text += element + Environment.NewLine; 


              } 
        }

        private void bntOrdenar_Click(object sender, EventArgs e)
        {
            int[] vector = { 50, 32, 58, 79, 104, 1, 12 };
            txtVector.Text = "Cantidad desordenada" + Environment.NewLine;

            foreach (int elem in vector)
            {

                txtVector.Text += elem + Environment.NewLine; 

            }

            ordenamientoBurbujaBi(vector); 
        }

        }
    }

