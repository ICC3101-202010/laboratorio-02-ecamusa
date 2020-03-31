using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2._2
{
    class espotifai
    {
        public espotifai()
        {
        }

        List<string> listachica = new List<string>();

        List<List<string>> listagrande = new List<List<string>>();

        List<string> canciones = new List<string>();



        public bool agregarcancion(Cancion cancion)
        {
            if (listachica.Contains(cancion.nombre) && listachica.Contains(cancion.artista))
                return false;

            else
                listachica.Add(cancion.genero);
            listachica.Add(cancion.artista);
            listachica.Add(cancion.album);
            listachica.Add(cancion.nombre);
            listagrande.Add(listachica);
            canciones.Add(cancion.informacion());



            return true;



        }

        public void vercanciones()
        {
            foreach (var a in canciones)
                Console.WriteLine(a);
        }



        public string criterio;
        public string valor;
        public List<List<string>> cancionesporcriterio(string criterio, string valor)
        {
            List<List<string>> real = new List<List<string>>();
            switch (criterio)
            {
                case "genero":
                    foreach (var a in listagrande)
                        if (a[0] == valor)
                        {
                            real.Add(a);

                        }
                    break;

                case "artista":

                    foreach (var a in listagrande)
                        if (a[1] == valor)
                        {
                            real.Add(a);

                        }
                    break;




                case "album":

                    foreach (var a in listagrande)
                        if (a[2] == valor)
                        {
                            real.Add(a);

                        }
                    break;


                case "nombre":

                    foreach (var a in listagrande)
                        if (a[3] == valor)
                        {
                            real.Add(a);

                        }
                    break;

            }
            return real;
        }
        public string genero1;
        public string artista1;
        public string album1;
        public string nombre1;
        public string cambio(List<string> lista)
        {
            genero1 = lista[0];
            artista1 = lista[1];
            album1 = lista[2];
            nombre1 = lista[3];

            Cancion cancion4 = new Cancion(genero1, artista1, album1, nombre1);

            return cancion4.informacion();






        }
    }
}
        //public bool generaplaylist(string criterio, string valorcriterio, string nombreplaylist)
        //{
        //List<string> playlist = new List<string>();




