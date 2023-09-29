using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuPersonal.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Llama al metodo mensajeBienvenida desde menuImplementacion ( cual se espicfica su funcion)
        /// 27/09/23 - msm
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// Este metodo llama al menu y recoge la respuesta del usuario
        /// 27/09/23 - msm
        /// </summary>

        public int mostrarmostrarMenuYOpciones();
    }
}
