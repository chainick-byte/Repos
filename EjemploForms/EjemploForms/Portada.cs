using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //oculto la ventana
            this.Hide();
            //una vez se cierra la portada se invoca la principal
            VentanaPrincipal ventana = new VentanaPrincipal();
            ventana.Show();

        }
    }
}
