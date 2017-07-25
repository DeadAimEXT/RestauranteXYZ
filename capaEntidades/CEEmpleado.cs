using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    class CEEmpleado
    {
        //Agregado set and get de entidad Empleado...

        public int IdEmpleado { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Telefono { set; get; }
        public string Correo { set; get; }
        public string Direccion { set; get; }
        public int IdSexo { set; get; }
        public int IdTipoEmpleado { set; get; }

    }
}
