using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//JUANS SEBASTIAN LOZANO AVILEZ
//PROGRAMA DE INGENIERIA DE SISTEMAS
//Octubre 2022

namespace Videotienda
{
    internal class Operador
    {
        private String nombre;
        private int id;
        

        //METODO CONSTRUCTOR
        public Operador(String nombre, int id)
        {
            this.nombre=nombre;
            this.id = id;
        }

        //METODOS SET & GET
        //METODO NOMBRE
        public string getNombre() { return nombre; }
        public void setNombre(String nombre)  {this.nombre = nombre; }

        //METODO ID
        public int getId() {return id; }
        public void setId(int id) {this.id = id;}
        
        //METODO TO STRING
        override
            public string ToString()
        {
            return "Operador: [id: " + id + "nombre: " + nombre + "]";
        }

    }
}
