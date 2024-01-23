using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videotienda
{
    internal class Tienda
    {
        //ATRIBUTOS 
        private List<Pelicula> peliculas;


        //===========================LISTA DE PELICUILAS============================
        public Tienda()
        {
            peliculas=new List<Pelicula>();

            peliculas.Add(new Pelicula(" THE AVENGERS:END GAME ",0001, " NINGUNO "));
            peliculas.Add(new Pelicula(" ¿QUE PASO AYER? ",0002," NINGUNO "));
            peliculas.Add(new Pelicula(" JUMANGI ", 0003, " NINGUNO "));
            peliculas.Add(new Pelicula(" SON COMO NIÑOS ", 0004, " NINGUNO "));
            peliculas.Add(new Pelicula(" BUSCANDO A NEMO ", 0005, " NINGUNO "));
        }

        //METODO PARA ENLISTAR LAS PELICULAS
        public void listarpeliculas()
        {
            for(int i = 0; i < peliculas.Count; i++)
            {
                Console.WriteLine(peliculas[i]);
            }
        }
        //==========================================================================

        //METODO BUSCAR PELICULAS
        public Pelicula buscarPelicula(int serial)
        {
            Pelicula busca=null;
            bool encuentra = false;

            for (int i = 0; i < peliculas.Count && encuentra == false; i++)
            {
                if (peliculas[i].getSerial() == serial)
                {
                    busca = peliculas[i];
                    encuentra = true;
                }
            }
            return busca;
        }

        //METODO PARA DEVOLUCION DE PELICULA
        public void devPelicula( String nombrepeli, int serial, string novedades)
        {
            Pelicula busca=buscarPelicula(serial);
            if (busca == null)
            {
                Pelicula devolver = new Pelicula(nombrepeli, serial, novedades);
                peliculas.Add(devolver);

                Console.WriteLine("Devolucion exitosa.");
            }
            else
            {
                Console.WriteLine("La pelicula ya fue devuelta");
            }
        }

        //METODO PARA ENTEGA/ALQUILER DE PELICULA
        public void salidaPelicula(int serial)
        {
            Pelicula busca = buscarPelicula(serial);
            if (busca != null)
            {
                peliculas.Remove(busca);
            }
            else
            {
                Console.WriteLine("La pelicula no se encuentra en la base de datos");
            }
        }
    }
}
