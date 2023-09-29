using menuPersonal.Servicios;

namespace menuPersonal
{
    /// <summary>
    /// Clase Principal de la aplicacion
    /// 27/09/23 - msm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo de la entrada de la aplicacion, donde se guardara todo el procedimiento
        /// 27/09/23 - msm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Hace una copia del menuInterfaz donde añade el menuImplementacion y a traves del objeto llama al metodo para que saque por consola el mensaje

            MenuInterfaz objetoInterfaz = new MenuImplementacion();
            objetoInterfaz.mensajeBienvenida();

            //Es una variable que controla la entrada y el cierre del bucle, si esta false indicamos que no queremos cerrar el bucle
            bool cerrarMenu = false;

            //almacenara la opcion que escoga el usuario, en esta linea se que crea la variable
            int opcionSeleccionada;

            //En esta parte ejecutara las intrucciones que contega siempre que el valor sea true, en este caso al tener ! el valor sera true
            while (!cerrarMenu)
            {
                opcionSeleccionada = objetoInterfaz.mostrarmostrarMenuYOpciones();

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("Cargando Partida..");
                        break;
                    case 1:
                        Console.WriteLine("Abriendo ajustes");
                        break;
                    case 2:
                        Console.WriteLine("Gracias por jugar");
                        cerrarMenu = true;
                        break;
                    default:
                        Console.WriteLine("Esa opcion no existe");
                        break;

                }

            }

        }

    }
}