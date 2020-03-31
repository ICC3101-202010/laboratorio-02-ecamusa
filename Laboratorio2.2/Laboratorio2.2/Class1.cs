using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2._2
{
    class Cancion
    {
        public string nombre;
        public string genero;
        public string artista;
        public string album;
        public Cancion(string agenero, string aartista, string aalbum, string anombre)
        {
            nombre = anombre;
            genero = agenero;
            artista = aartista;
            album = aalbum;

        }

        public string informacion()
        {
            return " genero:" + genero + " artista:" + artista + " album:" + album + " nombre:" + nombre;

        }


    }
}
