using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class CNProducto
    {
        CDProducto prod = new CDProducto();
        public string NombreProducto(int id)
        {
            return prod.NombreProducto(id);
        }
        public decimal PrecioProducto(int id)
        {
            return prod.PrecioProducto(id);
        }
    }
}
