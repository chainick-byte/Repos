using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PokedexC_sharp
{
    class Conexion
    { 
        public MySqlConnection conexion;
        
        conexion = new MySqlConnection("Server = 192.168.182.146;Datebase=listapokemons;Uid=root;Pwd=;Port=3306");

    
    }
}
