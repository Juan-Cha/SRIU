using SRIU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SRIU.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReporteIncidenciaWCF" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReporteIncidenciaWCF
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<ReporteIncidencia> ObtenerReportes();

        [OperationContract]
        bool CrearReporte(ReporteIncidencia reporte);

        [OperationContract]
        bool ActualizarEstatus(int idReporte, bool atendido);

        [OperationContract]
        bool EliminarReporte(int idReporte);

        [OperationContract]
        ReporteIncidencia ObtenerPorId(int idReporte);

        [OperationContract]
        bool ActualizarReporte(ReporteIncidencia reporte);
    }
}
