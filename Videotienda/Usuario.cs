using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videotienda
{
    internal class Usuario
    {
        private String nombre;
        private int id;
        private string direccion,cel;


        //METODO NOMBRE
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        //METODO ID
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        //METODO DIRECCION
        public string getDireccion()
        {
            return direccion;
        }
        public void setDireccion(string direccion)
        {
            this.direccion=direccion;
        }

        //METODO CEL
        public string getCel()
        {
            return cel;
        }
        public void setCel(string cel)
        {
            this.cel= cel;
        }


    }
}
