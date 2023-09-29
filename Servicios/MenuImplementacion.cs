using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuPersonal.Servicios
{
    /// <summary>
    /// Implementacion de las acciones del menu
    /// 290923 - msm
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            //Se define la variable, almanenando el valor "Bienvenido Warrior Game
            string saludo = "Bienvenido Warrior Game";
            //Nos imprime por consola dicha varible, usando el identificador (saludo)
            Console.WriteLine(saludo);
        }


        public int mostrarmostrarMenuYOpciones()
        {
            int opcionSeleccionada;
            Console.WriteLine("###############################");
            Console.WriteLine("0. JUGAR");
            Console.WriteLine("1. AJUSTES");
            Console.WriteLine("2. SALIR");
            Console.WriteLine("###############################");
            Console.WriteLine("Seleccione una opcion");

            opcionSeleccionada = Console.ReadKey(true).KeyChar - ('0');

            return opcionSeleccionada;

        }
    }
}
