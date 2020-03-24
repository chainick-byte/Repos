using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
   
    public partial class Form1 : Form
    {
        //aqui se declaran las variables de instancias
        //operando1 es la auxiliar que guarda el numero de la pantalla
        double operando1 = 0;
        // en el string guardamos la operacion que se ha pulasado
        String operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else
            {
                label1.Text = label1.Text + boton.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            if(operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if(operacion =="-" )
            {
                resultado = operando1 - operando2;
            }
            else if(operacion=="/")
            {
                resultado = operando1 / operando2;
            }
            else if(operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            else if(operacion == "exp")
            {
                resultado = Math.Pow(operando1, operando2);
            }
            else if(operacion == "%")
            {
                resultado = (operando2 * operando1) / 100;
            }
            else if (operacion == "Raiz")
            {
                resultado = Math.Sqrt(operando1);
            }
            label1.Text = Convert.ToString(resultado);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
           
                
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            operando1 = 0;
           
        }
    }
}
