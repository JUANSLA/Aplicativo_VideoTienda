using System;
using Videotienda;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LLAMADA DE CLASES
            DateTime dat1 = new DateTime();
            Usuario usuario = new Usuario();
            //Pelicula pelis = new Pelicula();
            Tienda videotienda = new Tienda();




            Console.WriteLine("==========MENU DE INGRESO===========");
            Console.WriteLine("1.REGISTRO DE USUARIO");
            Console.WriteLine("2.SARLI DEL MENU");
            int user = int.Parse(Console.ReadLine());
            Console.Clear();

            if (user == 1) 
            {
                Console.WriteLine("========INGRESE SUS DATOS========");
                Console.WriteLine("Nombre: ");
                String nomuser=Console.ReadLine();
                usuario.setNombre(nomuser);

                Console.WriteLine("Numero ID: ");
                int id=int.Parse(Console.ReadLine());
                usuario.setId(id);
                
                Console.WriteLine("TELEFONO: ");
                string cel=Console.ReadLine();
                usuario.setCel(cel);

                Console.WriteLine("Direccion de recidencia: ");
                string direccion=Console.ReadLine();
                usuario.setDireccion(direccion);

                int salir = 2;
                while (salir == 2)
                {
                    Console.WriteLine("BENVENIDO A LA VIDEO_TIENDA");
                    Console.WriteLine("==========MENU==============");
                    Console.WriteLine("1. VER LISTA DE PELICULAS DISPONIBLES");
                    Console.WriteLine("2. BUSCAR PELICULA");
                    Console.WriteLine("3. DEVOLVER PELICULA");
                    Console.WriteLine("4. ALQUILAR PELICULA");

                    Console.WriteLine("\n SELECCIONE EL # SEGUN SU OPCION: ");

                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 0:
                            {

                            }
                            break;
                        case 1:
                            {
                                Console.WriteLine("1. LISTA DE PELICULAS DISPONIBLES");
                                videotienda.listarpeliculas();
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("2. BUSCAR PELICULA \n ESCRIBRE EL SERIAL DE LA PELICULA QUE BUSCAS:");
                                int serial = int.Parse(Console.ReadLine());
                                videotienda.buscarPelicula(serial);

                            }
                            break;
                        case 3:
                            {
                                Console.Clear();
                                Console.WriteLine("3. DEVOLUCION DE PELICULA");
                                Console.WriteLine("ingrese los datos de la pelicula \n serial: ");
                                int serial = int.Parse(Console.ReadLine());

                                Console.WriteLine("nombre: ");
                                String nombrepeli = Console.ReadLine();

                                Console.WriteLine("Si hay alguna novedad mecionela: ");
                                string novedades = Console.ReadLine();
                            }
                            break;
                        case 4:
                            {
                                
                                Console.WriteLine("4. ALQUILER DE PELICULA");
                                Console.WriteLine("Ingrese el serial de la pelicula segun la lista");
                                int serial = int.Parse(Console.ReadLine());

                                Console.Clear();
                                Console.WriteLine("===============ALQUILER DE PELICULA================");
                                Console.WriteLine("PELICULA: " + videotienda.buscarPelicula(serial));
                                Console.WriteLine("SERIAL:........... " + serial);
                                Console.WriteLine("COSTO:...........$ 4500");

                                Console.WriteLine(DateTime.Now);

                                break;
                            }
                    }
                    Console.WriteLine("si desea volver al menu ingrese el [ 2 ]");
                    Console.WriteLine("de lo contrario presiones [ 0 ]");
                    salir = int.Parse(Console.ReadLine());

                    if (salir == 0) ;

                    Console.Clear();

                    { Console.WriteLine("====================GRACIAS" +usuario.getNombre + "VUELVA PRONTO===================== "); }

                }
            }
            else
            {
                Console.ReadKey();
            }


            Console.WriteLine("HA SALIDO");
        }
    }
}