using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Entidades.Dtos
{
    public class ProveedorDto:ICloneable
    {
        public int ProveedorId { get; set; }
        public string NombreProveedor { get; set; }
        public string NombrePais { get; set; }
        public string NombreCiudad { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
