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
    public class CNDetalleFactura
    {
        CDDetalleFactura objDf1 = new CDDetalleFactura();
        public int InsertarDFactura(CEDetalleFactura objDf)
        {
            return objDf1.InsertarDFactura(objDf);
        }
    }
}
