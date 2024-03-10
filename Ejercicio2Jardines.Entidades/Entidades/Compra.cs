using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Entidades.Entidades
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime FechaCompra { get; set; }
        public int ProveedorId { get; set; }
        public ProveedorComboDto Proveedor  { get; set; }
        public decimal Total { get; set; }

        
    }
}
