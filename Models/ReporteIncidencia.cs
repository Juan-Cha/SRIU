using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SRIU.Models
{
    public class ReporteIncidencia
    {
        public int IdReporte { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaReporte { get; set; }
        public bool EstatusAtendido { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public string CodigoZona { get; set; }
        public decimal PresupuestoEstimado { get; set; }
    }
}