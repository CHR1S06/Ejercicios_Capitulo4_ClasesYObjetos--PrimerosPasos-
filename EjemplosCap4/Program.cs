using EjemplosCap4.Figuras.Fig1;
using EjemplosCap4.Figuras.Fig2;
using EjemplosCap4.Figuras.Fig3;
using EjemplosCap4.Figuras.Fig4;
using EjemplosCap4.Figuras.Fig5;
using System;

namespace EjemplosCap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int RespuestaMenu;
            Console.WriteLine(@"Bienvenido al programa Clases y Objetos

1- (Figura 1) Ejemplo--Fig4_1, Fig4_2.
2- (Figura 2) Ejemplo--Fig4_4, Fig4_5.
3- (Figura 3) Ejemplo--Fig4_7, Fig4_8.
4- (Figura 4) Ejemplo--Fig4_12, Fig4_13.
5- (Figura 5) Ejemplo--Fig4_15, Fig4_16.
6- Salir del programa");

            // Solicitamos al usuario que ingrese su opción
            Console.Write("\nDigite su respuesta aquí: ");

            // Bucle que controla la selección válida del menú
            while (true)
            {
                try
                {
                    // Convertimos la entrada del usuario a entero
                    RespuestaMenu = Convert.ToInt32(Console.ReadLine());

                    // Verificamos si la respuesta está dentro del rango de opciones del menú
                    if (RespuestaMenu >= 1 && RespuestaMenu <= 6)
                    {
                        // Ejecutamos la acción correspondiente a la opción seleccionada
                        switch (RespuestaMenu)
                        {
                            // Opción 1: Ejecuta la aplicación (Figura 1)
                            case 1:
                                Console.Clear(); //Limpia la consola
                                PruebaLibroCalificaciones.MenuFig4_2(); // Llamada al método principal de la figura 1
                                break;

                            // Opción 2: Ejecuta la aplicación (Figura 2)
                            case 2:
                                Console.Clear(); //Limpia la consola
                                LibroPruebaCalificaciones.MenuFig4_5(); // Llamada al método principal de la figura 2
                                break;

                            // Opción 3: Ejecuta la aplicación (Figura 3)
                            case 3:
                                Console.Clear();
                                PruebaLibroCalificaciones2.MenuFig4_8(); // Llamada al método principal de la figura 3
                                break;

                            // Opción 4: Ejecuta la aplicación (Figura 4)
                            case 4:
                                Console.Clear(); //Limpia la consola
                                PruebaLibroCalificaciones3.MenuFig4_13(); // Llamada al método principal de la figura 4
                                break;

                            // Opción 5: Ejecuta la aplicación (Figura 5)
                            case 5:
                                Console.Clear(); //Limpia la consola
                                PruebaCuenta.MenuFig4_16(); // Llamada al método principal de la figura 5
                                break;

                            // Opción 6: Salir del programa
                            case 6:
                                return; //sale del programa

                        }

                        // Rompe el bucle si se seleccionó una opción válida y se ejecutó la acción
                        break;
                    }
                    else
                    {
                        // Mensaje si el usuario ingresó un número fuera del rango
                        Console.WriteLine("Por favor limítese a digitar uno de los números mostrados en pantalla");
                    }
                }
                catch (Exception ex)
                {
                    // Si ocurre una excepción (como ingreso inválido), mostramos el mensaje de error
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
