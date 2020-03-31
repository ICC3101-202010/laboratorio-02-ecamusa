using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            espotifai cuchufli = new espotifai();


            Console.WriteLine("bienvenido a espotifai");
            Console.WriteLine("1)ver todas las canciones");
            Console.WriteLine("2)agregar cancion");
            Console.WriteLine("3)buscar cancion");
            Console.WriteLine("4)salir");
            Console.WriteLine();
            string num;
            num = "1";

            while (num != "4")
            {
                string numero;
                numero = Console.ReadLine();

                switch (numero)
                {
                    case "1": cuchufli.vercanciones(); break;

                    case "2":
                        string genero, artista, album, nombre;
                        genero = Console.ReadLine();
                        artista = Console.ReadLine();
                        album = Console.ReadLine();
                        nombre = Console.ReadLine();

                        Cancion cancion3 = new Cancion(genero, artista, album, nombre);

                        cuchufli.agregarcancion(cancion3);

                        break;

                    case "3":

                        string criterio, valor;
                        criterio = Console.ReadLine();
                        valor = Console.ReadLine();
                        List<string> verdadero = new List<string>();
                        foreach (var a in cuchufli.cancionesporcriterio(criterio, valor))
                        {
                            verdadero.Add(cuchufli.cambio(a));

                        }
                        foreach (var b in verdadero)
                            Console.WriteLine(b);
                        break;



                    case "4":; break;

                }
                if (numero == "4")
                    break;

            }



        }
    }
}

