// Fig. 4.4: LibroCalificaciones.cs
// Declaracion de la clase con un metodo que tiene un parametro.
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosCap4.Figuras.Fig2
{
    public class LibroCalificaciones1
    {
        //muestra un mensaje de bienvenida para el usuario del LibroCalificaciones
        public void MostrarMensaje(string nombreCurso)
        {
            Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!",
                nombreCurso);
        } // fin del metodo MostrarMensaje
    } // fin de la clase LibroCalificaciones
}
