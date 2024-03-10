using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Entidades.Entidades
{
    public class Venta
    {

        public int VentaId { get; set; }
        public DateTime FechaVenta { get; set; }
        public int ClienteId { get; set; }
        public string TransaccionId { get; set; }
        public decimal Total { get; set; }
        public int EstadoOrden { get; set; }
    }
}
