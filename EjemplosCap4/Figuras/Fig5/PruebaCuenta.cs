// Fig. 4.16: PruebaCuenta.cs
// Creacion y manipulacion de un objeto Cuenta.
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosCap4.Figuras.Fig5
{
    public class PruebaCuenta
    {
        //El metodo MenuFig comienza la ejecucion de la aplicacion de C#
        public static void MenuFig4_16()
        {
            Cuenta cuenta1 = new Cuenta(50.00M); //crea el objeto cuenta
            Cuenta cuenta2 = new Cuenta(-7.53M); //crea el objeto cuenta

            //muestra el saldo inicial de cada objeto usando una propiedad
            Console.WriteLine("Saldo de cuenta1: {0:C}",
                cuenta1.Saldo); //muestra la propiedad Saldo

            Console.WriteLine("Saldo de cuenta2: {0:C}\n",
                cuenta2.Saldo); //muestra la propiedad Saldo

            decimal montoDeposito; //deposita la cantidad que se leyo del usuario

            //pide y obtiene la entrada del usuario
            Console.Write("Escriba el monto a depositar para la cuenta1: ");
            montoDeposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("se sumo {0:C} al saldo de cuenta1\n",
                montoDeposito);
            cuenta1.Acredita(montoDeposito); //se suma al saldo de cuenta1

            //muestra los saldos
            Console.WriteLine("Saldo de cuenta1: {0:C}",
                cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta2: {0:C}\n",
                cuenta2.Saldo);

            //pide y obtiene la entrada del usuario 
            Console.Write("Escribe la cantidad a depositar para la cuenta2: ");
            montoDeposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("se sumo {0:C} al saldo de cuenta2\n",
                montoDeposito);
            cuenta2.Acredita(montoDeposito); //se suma al saldo de cuenta2

            //muestra los saldos
            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta2: {0:C}", cuenta2.Saldo);
        }//fin de MenuFig
    }//fin de la clase PruebaCuenta
}
