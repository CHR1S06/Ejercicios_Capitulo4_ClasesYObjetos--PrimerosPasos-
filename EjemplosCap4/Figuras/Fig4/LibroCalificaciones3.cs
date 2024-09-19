// Fig. 4.12: LibroCalificaciones.cs
// La clase LibroCalificaciones con un constructor para inicializar el nombre del curso.
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosCap4.Figuras.Fig4
{
    public class LibroCalificaciones3
    {
        private string nombreCurso; //nombre del curso para este LibroCalificaciones

        //el constructor inicializa nombreCurso con el objeto string suministrado como argumento
        public LibroCalificaciones3(string nombre)
        {
            NombreCurso = nombre; //inicializa nombreCurso usando la propiedad
        }// fin del constructor

        //propiedad para obtener (get) y establecer (set) el nombre del curso 
        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            }//fin de get
            set
            {
                nombreCurso = value;
            }//fin de set
        }//fin de la propiedad NombreCurso

        //muestra un mensaje de bienvenida para el usuario del LibroCalificaciones
        public void MostrarMensaje()
        {
            //usa la propiedad NombreCurso para obtener el nombre del curso que representa este LibroCalificaciones
            Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!",
                NombreCurso);
        }// fin del metodo MostrarMensaje
    }//fin de la clase LibroCalificaciones
}
