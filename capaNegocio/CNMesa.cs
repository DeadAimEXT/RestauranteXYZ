﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;
using System.Data;

namespace capaNegocio
{
    public class CNMesa
    {
        CDMesa mesa = new CDMesa();

        public int ActualizarEstadoMesa(CEMesa objM, int estado)
        {
           return mesa.ActualizarEstadoMesa(objM, estado);
        }
        public int EstadoMesa(CEMesa objM)
        {
            return mesa.EstadoMesa(objM);
        }
        public DataSet MostrarMesaId(CEMesa objM)
        {
            return mesa.MostrarMesaId(objM);
        }
    }
}
