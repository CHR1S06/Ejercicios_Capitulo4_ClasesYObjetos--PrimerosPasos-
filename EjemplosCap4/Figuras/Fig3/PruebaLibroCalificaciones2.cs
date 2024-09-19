// Fig. 4.8: PruebaLibroCalificaciones.cs
// Creacion y manipulacion de un objeto LibroCalificaciones.
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosCap4.Figuras.Fig3
{
    public class PruebaLibroCalificaciones2
    {
        //El metodo MenuFig comienza la ejecucion del programa
        public static void MenuFig4_8()
        {
            //crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
            LibroCalificaciones2 miLibroCalificaciones2 = new LibroCalificaciones2();

            //muestra el valor inicial de NombreCurso
            Console.WriteLine("El nombre inicial del curso es: '{0}'\n",
                miLibroCalificaciones2.NombreCurso);

            //pide y lee el nombre del curso
            Console.WriteLine("Por favor escriba el nombre del curso:");
            string elNombre = Console.ReadLine(); //lee una linea de texto
            miLibroCalificaciones2.NombreCurso = elNombre; //establece el nombre usando una propiedad
            Console.WriteLine(); //imprime en pantalla una linea en blanco

            //muestra el mensaje de bienvenida despues de especificar el nombre del curso
            miLibroCalificaciones2.MostrarMensaje();
        }// fin de MenuFig
    }// fin de la clse PruebaLibroCalificaciones
}
