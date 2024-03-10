using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Entidades.Dtos.Compra
{
    public class CompraDto
    {
        public int CompraId { get; set; }
        public DateTime FechaCompra { get; set; }
        public string NombreProveedor { get; set; }
        public decimal Total { get; set; }
    }
}
