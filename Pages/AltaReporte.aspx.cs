using SRIU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SRIU.Pages
{
    public partial class AltaReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                bool atendido = Request.Form["chkAtendidoSwitch"] == "on";
                var dal = new ReporteIncidenciaDAL();
                var reporte = new ReporteIncidencia
                {
                    Descripcion = txtDescripcion.Text,
                    FechaReporte = DateTime.Parse(txtFechaReporte.Text),
                    EstatusAtendido = atendido,
                    Latitud = float.Parse(txtLatitud.Text),
                    Longitud = float.Parse(txtLongitud.Text),
                    CodigoZona = txtCodigoZona.Text,
                    PresupuestoEstimado = decimal.Parse(txtPresupuesto.Text)
                };
                if (dal.Insertar(reporte))
                {
                    string script = @"
                        Swal.fire({
                            icon: 'success',
                            title: 'Registro Exitoso',
                            text: '¡Reporte registrado correctamente!',
                            background: '#23272a',
                            color: '#e0e0e0',
                            timer: 1800,
                            timerProgressBar: true,
                            showConfirmButton: false
                        }).then(() => {
                            window.location.href = '/Pages/ConsultaReporte.aspx';
                        });
                        ";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "swalSuccess", script, true);
                }
                else
                {
                    string script = @"
                    Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: 'No se pudo registrar el reporte',
                        background: '#23272a',
                        color: '#e0e0e0'
                    });";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "swalError", script, true);
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}