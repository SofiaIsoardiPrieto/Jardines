using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Entidades.Dtos.Producto
{
    public class ProductoDto:ICloneable
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int UnidadesEnStock { get; set; }
        public bool Suspendido { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
