using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videotienda
{
    internal class Pelicula
    {
        //PROPIEDADES
        private string nombrepeli, novedades;
        private int serial;
        
        //METODO CONSTRUCTOR
        public Pelicula(String nombrepeli, int serial, string novedades)
        {
            this.nombrepeli = nombrepeli;
            this.serial = serial;
            this.novedades = novedades;
        }

        public Pelicula(String nombrepeli)
        {
            this.nombrepeli = nombrepeli;
            
        }

        //METODO SET & GET

        //METODO NOMBTE DE PELICULA
        public string getNombrepeli() { return nombrepeli; }
        public void setNombrepeli(String nombrepeli) {this.nombrepeli = nombrepeli;}
        
        //METODO SERIAL
        public int getSerial() { return serial; }
        public void setSerial(int serial) { this.serial = serial; }

        //METODO SERIAL
        public String getNovedades() { return novedades; }
        public void setNovedades(String novedades) {this.novedades = novedades;}

        override
        public string ToString()
        {
            return "Pelicula: [Nombre: " + nombrepeli + "serial: " + serial + "\n Novedad: "+ novedades+ "]";
        }
        
    }
}
