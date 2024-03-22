﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas.Modelos
{
    class ModeloRangoCantidad
    {
        private string Rango;
        private int Cantidad;

        public string _Rango { get { return Rango; } set { Rango = value; } }
        public int _Cantidad { get { return Cantidad; } set { Cantidad = value; } }

        public ModeloRangoCantidad()
        {
            Rango = "";
            Cantidad = 0;
        }

        public ModeloRangoCantidad(string Rango_, int Cantidad_)
        {
            Rango = Rango_;
            Cantidad = Cantidad_;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}