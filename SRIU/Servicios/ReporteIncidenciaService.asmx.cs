﻿using SRIU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SRIU.Servicios
{
    /// <summary>
    /// Descripción breve de ReporteIncidenciaService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ReporteIncidenciaService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        private ReporteIncidenciaDAL dal = new ReporteIncidenciaDAL();

        [WebMethod]
        public List<ReporteIncidencia> ObtenerReportes()
        {
            return dal.ObtenerTodos();
        }

        [WebMethod]
        public bool CrearReporte(ReporteIncidencia reporte)
        {
            return dal.Insertar(reporte);
        }

        [WebMethod]
        public bool ActualizarEstatus(int idReporte, bool atendido)
        {
            return dal.ActualizarEstatus(idReporte, atendido);
        }

        [WebMethod]
        public bool EliminarReporte(int idReporte)
        {
            return dal.Eliminar(idReporte);
        }

        [WebMethod]
        public ReporteIncidencia ObtenerPorId(int idReporte)
        {
            return dal.ObtenerPorId(idReporte);
        }
    }
}
