﻿// Fig. 4.15: Cuenta.cs
// La clase Cuenta con un constructor para inicializar la variable de instancia saldo.
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosCap4.Figuras.Fig5
{
    public class Cuenta
    {
        private decimal saldo; //variable de instancia que almacena el saldo 

        //contructor 
        public Cuenta (decimal saldoInicial)
        {
            Saldo = saldoInicial; //establece el saldo usando la propiedad
        }//fin del constructor

        //acredita (suma) un monto a la cuenta
        public void Acredita(decimal monto)
        {
            Saldo = Saldo + monto; //suma monto al saldo
        }//fin del metodo Acredita

        //una propiedad para obtener (get) y establecer (set) el saldo de una cuenta
        public decimal Saldo
        {
            get
            {
                return saldo;
            }//end get
            set
            {
                //valida que el valor sea mayor o igual a 0;
                //si no lo es, el saldo permanece sin cambios
                if(value >= 0)
                saldo = value;
            }//fin de set
        }//fin de la propiedad Saldo
    }//fin de la clase Cuenta
}
