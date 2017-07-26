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
        CDEmpleado objE1 = new CDEmpleado();

        public int NuevoEmpleado(CEEmpleado objE)
        {
            return objE1.InsertarEmpleado(objE);
        }


        //Codigo correspondiente de la capaNegocio para modificar alumnos
        public int ModificarEmpleado (CEEmpleado objE)
        {
            return objE1.ModificarEmpleado(objE);
        }

        public DataSet ListarSexo()
        {
            return objE1.ListarSexo();
        }

        public DataSet ListarTipoEmpleado()
        {
            return objE1.ListarTipoEmpleado();
        }

        public DataSet ListarEmpleado()
        {
            return objE1.ListarEmpleados();
        }

 
    }
}
