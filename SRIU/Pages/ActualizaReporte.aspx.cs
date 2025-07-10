using SRIU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace SRIU.Pages
{
    public partial class ActualizaReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id;
                if (int.TryParse(Request.QueryString["id"], out id))
                {
                    txtIdReporte.Text = id.ToString();
                    CargarDatos(id);
                }
            }
        }        

        private void CargarDatos(int id)
        {
            var dal = new ReporteIncidenciaDAL();
            var reporte = dal.ObtenerPorId(id);
            if (reporte != null)
            {
                txtDescripcion.Text = reporte.Descripcion;
                txtFechaReporte.Text = reporte.FechaReporte.ToString("yyyy-MM-dd");
                txtLatitud.Text = reporte.Latitud.ToString();
                txtLongitud.Text = reporte.Longitud.ToString();
                txtCodigoZona.Text = reporte.CodigoZona;
                txtPresupuesto.Text = reporte.PresupuestoEstimado.ToString("C");
                chkAtendidoHtml.Checked = reporte.EstatusAtendido;

            }
            else
            {
                
            }
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdReporte.Text);
                bool atendido = chkAtendidoHtml.Checked;

                var dal = new ReporteIncidenciaDAL();
                bool actualizado = dal.ActualizarEstatus(id, atendido);

                if (actualizado)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "swalUpdated",
                        "Swal.fire({icon:'success',title:'¡Actualizado!',text:'El estatus fue actualizado correctamente'}).then(()=>{ window.location='ConsultaReporte.aspx'; });",
                        true
                    );
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "swalError",
                        "Swal.fire('Error','No se pudo actualizar','error');",
                        true
                    );
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "swalError2",
                    $"Swal.fire('Error','{ex.Message}','error');", true
                );
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultaReporte.aspx");
        }


    }
}