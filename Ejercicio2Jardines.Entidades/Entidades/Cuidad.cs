﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Entidades.Entidades
{
    public class Ciudad:ICloneable
    {
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


    }
}
