// Fig. 4.2: PruebaLibroCalificaciones.cs
// Crea un objeto LibroCalificaciones y llama a su metodo MostrarMensaje.
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosCap4.Figuras.Fig1
{
    public class PruebaLibroCalificaciones
    {
        //El metodo Menu comienza la ejecucion del programa
        public static void MenuFig4_2()
        {
            //crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();

            //Llama al metodo MostrarMensaje de miLibroCalificaciones
            miLibroCalificaciones.MostrarMensaje();
        } //fin de Menu
    } //fin de la clase PruebaLibroCalificaciones
}
