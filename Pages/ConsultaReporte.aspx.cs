using SRIU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SRIU.Pages
{
    public partial class ConsultaReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            
                CargarReportes();
            
                
        }

        private void CargarReportes()
        {
            var dal = new ReporteIncidenciaDAL();
            gvReportes.DataSource = dal.ObtenerTodos();
            gvReportes.DataBind();
        }

        protected void gvReportes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvReportes.PageIndex = e.NewPageIndex;
            CargarReportes();
        }

        protected void gvReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Puedes redirigir al detalle del reporte:
            int idReporte = Convert.ToInt32(gvReportes.SelectedDataKey.Value);
            Response.Redirect($"DetalleReporte.aspx?id={idReporte}");
        }
        protected void gvReportes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int idReporte = Convert.ToInt32(gvReportes.DataKeys[e.NewEditIndex].Value);
            Response.Redirect($"ActualizaReporte.aspx?id={idReporte}");
        }

        protected void gvReportes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int idReporte = Convert.ToInt32(gvReportes.DataKeys[e.RowIndex].Value);
            var dal = new ReporteIncidenciaDAL();
            bool eliminado = dal.Eliminar(idReporte);

            // Puedes agregar aquí un mensaje que luego muestres con SweetAlert2
            if (eliminado)
            {
                // Para SweetAlert2 vía JS, podrías registrar un script aquí
                ClientScript.RegisterStartupScript(this.GetType(), "Eliminado",
                    "Swal.fire('Eliminado','El reporte fue eliminado correctamente','success');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "NoEliminado",
                    "Swal.fire('Error','No se pudo eliminar el reporte','error');", true);
            }

            CargarReportes();
        }

        protected void gvReportes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            // Solo afecta a filas de datos
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Busca el botón de eliminar (está en la última celda por defecto)
                LinkButton btnDelete = e.Row.Cells[e.Row.Cells.Count - 1].Controls[0] as LinkButton;
                if (btnDelete != null && btnDelete.CommandName == "Delete")
                {
                    btnDelete.OnClientClick = "return confirmarEliminacion(this);";
                }
            }
        }

    }
}