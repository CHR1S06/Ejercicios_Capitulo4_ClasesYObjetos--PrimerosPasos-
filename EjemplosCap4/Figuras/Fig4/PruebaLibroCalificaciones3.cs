// Fig. 4.13: PruebaLibroCalificaciones.cs
// El constructor LibroCalificaciones se utiliza para espicificar el nombre del curso cada vez que se crea un objeto LibroCalificaciones.
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosCap4.Figuras.Fig4
{
    public class PruebaLibroCalificaciones3
    {
        //El metodo Menu comienza la ejecucion del programa
        public static void MenuFig4_13()
        {
            //crea el objeto LibroCalificaciones
            LibroCalificaciones3 miLibroCalificaciones3 = new LibroCalificaciones3( //invoca al constructor
            "CS101 Introduccion a la programacion en C#");

            LibroCalificaciones3 miLibroCalificaciones4 = new LibroCalificaciones3( // invoca al constructor
            "CS102 Estructura de datos en C#");

            //muestra el valor inicial de nombreCurso para cada LibroCalificaciones
            Console.WriteLine("El nombre del curso de LibroCalificaciones1 es: {0}",
                miLibroCalificaciones3.NombreCurso);

            Console.WriteLine("El nombre del curso de LibroCalificaciones2 es: {0}",
                miLibroCalificaciones4.NombreCurso);
        }//fin de MenuFig
    }//fin de la clase PruebaLibroCalificaciones
}
