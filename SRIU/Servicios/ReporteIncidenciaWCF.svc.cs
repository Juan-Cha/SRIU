using SRIU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SRIU.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ReporteIncidenciaWCF" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ReporteIncidenciaWCF.svc o ReporteIncidenciaWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ReporteIncidenciaWCF : IReporteIncidenciaWCF
    {
        public void DoWork()
        {
        }
        private ReporteIncidenciaDAL dal = new ReporteIncidenciaDAL();

        public List<ReporteIncidencia> ObtenerReportes()
        {
            return dal.ObtenerTodos();
        }

        public bool CrearReporte(ReporteIncidencia reporte)
        {
            return dal.Insertar(reporte);
        }

        public bool ActualizarEstatus(int idReporte, bool atendido)
        {
            return dal.ActualizarEstatus(idReporte, atendido);
        }

        public bool EliminarReporte(int idReporte)
        {
            return dal.Eliminar(idReporte);
        }

        public ReporteIncidencia ObtenerPorId(int idReporte)
        {
            return dal.ObtenerPorId(idReporte);
        }

        public bool ActualizarReporte(ReporteIncidencia reporte)
        {
            return dal.ActualizarReporte(reporte);
        }

    }
}
