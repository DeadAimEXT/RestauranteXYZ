using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class CEFactura
    {
        public int IdFactura { set; get; }
        public int IdEmpleado { set; get; }
        public string NombreCliente { set; get; }
        public string RTN { set; get; }
        public DateTime Fecha { set; get; }

    }
}
