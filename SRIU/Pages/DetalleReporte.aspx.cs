using SRIU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SRIU.Pages
{
    public partial class DetalleReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarDetalle();
        }
        private void MostrarDetalle()
        {
            int id;
            if (int.TryParse(Request.QueryString["id"], out id))
            {
                var dal = new ReporteIncidenciaDAL();
                var reporte = dal.ObtenerPorId(id);
                if (reporte != null)
                {
                    lblId.Text = reporte.IdReporte.ToString();
                    lblDescripcion.Text = reporte.Descripcion;
                    lblFecha.Text = reporte.FechaReporte.ToString("yyyy-MM-dd");
                    lblAtendido.Text = reporte.EstatusAtendido ? "Sí" : "No";
                    lblLatitud.Text = reporte.Latitud.ToString();
                    lblLongitud.Text = reporte.Longitud.ToString();
                    lblCodigoZona.Text = reporte.CodigoZona;
                    lblPresupuesto.Text = reporte.PresupuestoEstimado.ToString("C");
                }
                else
                {
                    lblDescripcion.Text = "Reporte no encontrado.";
                }
            }
            else
            {
                lblDescripcion.Text = "ID no válido.";
            }
        }
    }
}