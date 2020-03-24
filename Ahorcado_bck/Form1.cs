using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        //almacena la palabra que hay que adivinar
        String palabraOculta ="";
        //variable que almacena el numero de fallos
        int numeroFallos = 0;
        SoundPlayer sonido;
        
           
        public Form1()
        {
            InitializeComponent();
            palabraOculta = eligePalabra();
            String auxiliar = "";
            for(int i = 0; i < palabraOculta.Length; i++)
            {
                auxiliar = auxiliar + "_ ";
                
            }
            label1.Text=auxiliar;

        }
        public String eligePalabra()
        {
           
                String[] listaPalabras = { "ordenador", "cuarentena", "coronavirus", "ejercicios", "nadaenespecial" };
                Random r = new Random();
                //variable que dara posicion dentro del array para elegir una palabra aleatoria
                int posicion = r.Next(listaPalabras.Length);
                Console.WriteLine(listaPalabras[posicion]);
                return listaPalabras[posicion].ToLower();
            
        }
        public void sonidoGameOver()
        {
            try
            {
                sonido = new SoundPlayer(Application.StartupPath + @"\sound\gameOver.wav");
                sonido.Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de sonido" + ex);
            }
        }

        private void letraPulsada(object sender, EventArgs e)
        {
            

            //caste el objeto a boton. Solo va a poder ser boton porque
            //solo se genera en los botones 
            Button boton = (Button)sender;
            String letra = boton.Text;
          

            if (palabraOculta.Contains(letra))
            {
                for (int i = 0; i < palabraOculta.Length  ; i++)
                {
                    if (palabraOculta.Substring(i,1) == letra)
                    {
                        label1.Text = label1.Text.Remove(2 * i, 1).Insert(2 * i, letra);
                    }
                }
            }
            else
            {
                numeroFallos++;
            }
            
            
            if(!label1.Text.Contains('_'))
            {
                numeroFallos = -100;
            }
            switch(numeroFallos)
            {
                case 0: pictureBox1.Image = Properties.Resources.ahorcado_0;break;
                case 1:
                    sonidoGameOver();
                    pictureBox1.Image = Properties.Resources.ahorcado_1; break;
                case 2:
                    sonidoGameOver();
                    pictureBox1.Image = Properties.Resources.ahorcado_2; break;
                case 3:
                    sonidoGameOver();
                    pictureBox1.Image = Properties.Resources.ahorcado_3; break;
                case 4:
                    sonidoGameOver();
                    pictureBox1.Image = Properties.Resources.ahorcado_4; break;
                case 5:
                    sonidoGameOver();
                    pictureBox1.Image = Properties.Resources.ahorcado_5; break;
                case 6: pictureBox1.Image = Properties.Resources.ahorcado_fin; break;
                case -100: pictureBox1.Image = Properties.Resources.acertastetodo;break;
                default:
                 
                    pictureBox1.Image = Properties.Resources.ahorcado_fin;break;

            }

        }
    }
}
