using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Entidades.Dtos.Venta
{
    public class VentaDto
    {
        public int VentaId { get; set; }
        public DateTime FechaVenta { get; set; }
        public string NombreCliente { get; set; }
        public decimal Total { get; set; }
    }
}
