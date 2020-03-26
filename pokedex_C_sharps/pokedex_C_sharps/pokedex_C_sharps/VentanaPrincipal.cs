﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex_C_sharps
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1;//el pokemon que estamos viendo
        public VentanaPrincipal()
        {
            InitializeComponent();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            //label1.BackColor = Color.FromArgb(150, 0, 0, 0);



        }
        private Image convierteBlobAImagen(byte[]img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            if(idActual<=0)
            {
                idActual = 1;
            }
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox2.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151)
            {
                idActual = 151;
            }
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox2.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }
    }
}
