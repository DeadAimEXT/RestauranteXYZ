using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class CNFactura 
    {
        CDFactura objF1 = new CDFactura();

        public int InsertarFactura(CEFactura objF)
        {
            return objF1.InsertarFactura(objF);
        }
        public int ActualizarFactura(CEFactura objF)
        {
            return objF1.ActualizarFactura(objF);
        }
    }
}
