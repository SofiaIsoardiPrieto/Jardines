using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Entidades.Entidades
{
    public class Proveedor:ICloneable
    {
        public int ProveedorId { get; set; }
        public string NombreProveedor { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public int PaisId { get; set; }
        public int CiudadId { get; set; }
        public Pais Pais { get; set; }
        public Ciudad Ciudad { get; set; }
        public string Email { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
