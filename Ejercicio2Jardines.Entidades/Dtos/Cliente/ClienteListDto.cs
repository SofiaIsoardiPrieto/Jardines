using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Entidades.Dtos.Cliente
{
    public class ClienteListDto:ICloneable
    {

        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public int PaisId { get; set; }
        public int CiudadId { get; set; }
        public string NombrePais { get; set; }
        public string NombreCiudad { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Apellido},{Nombres}";
        }
    }
}
