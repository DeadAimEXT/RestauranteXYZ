﻿using System;
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

        public int EliminarEmpleado(CEEmpleado objE)
        {
            return objE1.EliminarEmpleado(objE);
            
        }
        public string UsuarioNombreEmpleado(int idEmpleado)
        {
            return objE1.UsuarioNombreEmpleado(idEmpleado);
        }

        public DataSet MostrarPorNombre(CEEmpleado objE)
        {
            return objE1.BuscarPorNombre(objE);
        }

        public DataSet MostrarPorId(CEEmpleado objE)
        {
            return objE1.BuscarPorId(objE);
        }
        public int NombreUsuarioEmpleadoId(string userName)
        {
            return objE1.NombreUsuarioEmpleadoId(userName);
        }
        public int IdUsuarioXIdEmpleado(int IdEmpleado)
        {
            return objE1.IdUsuarioXIdEmpleado(IdEmpleado);
        }
    }
}
