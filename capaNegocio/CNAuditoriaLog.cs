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
    public class CNAuditoriaLog
    {
        CDAuditoriaLog objAL1 = new CDAuditoriaLog();

        public DataSet MostrarAuditoriaLog()
        {
            return objAL1.MostrarAuditoria();
        }

        public DataSet MostrarPorIdAuditLog(CEAuditoriaLog objA)
        {
            return objAL1.BuscarAuditLogId(objA);
        }

        public DataSet MostrarPorIdUsuario(CEAuditoriaLog objA)
        {
            return objAL1.BuscarAuditLogIdUsuario(objA);
        }
        public int InsertarAuditLog(string Descripcion, int idEmpleado, DateTime fecha)
        {
            return objAL1.InsertarAuditLog(Descripcion, idEmpleado, fecha);
        }
    }
}
