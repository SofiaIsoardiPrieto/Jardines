﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Entidades
{
    public class Pais:ICloneable
    {
        public int PaisId { get; set; }
        public string NombrePais { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
