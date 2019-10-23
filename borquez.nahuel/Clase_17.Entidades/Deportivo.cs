﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public class Deportivo : Auto,IAFIP
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int hp):base(precio,patente)
        {
            this._caballosFuerza = hp;
        }

        public double CalcularImpuesto()
        {
            //throw new NotImplementedException();
            return _precio * 1.28;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }
        public override void MostrarPatente()
        {
            Console.WriteLine(this._patente);
        }
    }
}
