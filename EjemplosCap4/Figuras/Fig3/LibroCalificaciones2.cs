// Fig. 4.7 : LibroCalificaciones.cs
// Clase LibroCalificaciones que contiene una variable de instancia cursoNombre y una propiedad para obtener (get) y establecer (set) su valor.
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosCap4.Figuras.Fig3
{
    public class LibroCalificaciones2
    {
        private string nombreCurso; //nombre del curso para este LibroCalificaciones

        //propiedad para obtener (get) y establecer (set) el nombre del curso
        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            }// fin de get
            set
            {
                nombreCurso = value;
            }//fin de set
        }//fin de la propiedad NombreCurso

        //muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
        public void MostrarMensaje()
        {
            //usa la propiedad NombreCurso para obtener el nombre del curso que representa este LibroCalificaciones
            Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!",
                NombreCurso); //muestra la propieda NombreCurso
        }// fin del metodo MostrarMensaje
    }//fin de la clase LibroCalificaciones
}
