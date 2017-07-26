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
    public class CNEmpleado
    {
        CDEmpleado objA1 = new CDEmpleado();

        public int NuevoEmpleado(CEEmpleado objA)
        {
            return objA1.InsertarEmpleado(objA);
        }

        public DataSet ListarSexo()
        {
            return objA1.ListarSexo();
        }

        public DataSet ListarTipoEmpleado()
        {
            return objA1.ListarTipoEmpleado();
        }
    }
}
