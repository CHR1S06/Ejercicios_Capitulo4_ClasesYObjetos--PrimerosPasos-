// Fig. 4.5 : LibroCalificaciones.cs
// Crea objeto LibroCalificaciones y pasa una cadena a su metodo MostrarMensaje.
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace EjemplosCap4.Figuras.Fig2
{
    public class LibroPruebaCalificaciones
    {
        //El metodo Main comienza la ejecucion del programa 
        public static void MenuFig4_5()
        {
            // crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones1
            LibroCalificaciones1 miLibroCalificaciones = new LibroCalificaciones1();

            // pide el nombre del curso y lo recibe como entrada 
            Console.Write("Por favor escriba el nombre del curso: ");
            string nombreDelCurso = Console.ReadLine(); //lee una linea de texto 
            Console.WriteLine(); //imprime en pantalla una linea en blanco 

            //llama al metodo MostrarMensaje de miLibroCalificaciones y pasa nombreDelCurso como argumento
            miLibroCalificaciones.MostrarMensaje(nombreDelCurso);
        } //fin de Menu
    } //fin de la clase LibroPruebaCalificaciones
}
