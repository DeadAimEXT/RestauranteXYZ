using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    class CEProducto
    {

        //Se agregar los setters and getter de la tabla producto...

        public int IdProducto { set; get; }
        public string Nombre { set; get; }
        public decimal Precio { set; get; }
        public int IdTipoProducto { set; get; }

    }
}
