using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRIU.WebForm.ServiceReference1; // Cambia ServiceReference1 por el namespace real si le diste otro nombre

namespace SRIU.WebForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            try
            {
                using (var client = new ReporteIncidenciaWCFClient())
                {
                    var reporte = client.ObtenerPorId(id);
                    if (reporte != null)
                    {
                        txtDescripcion.Text = reporte.Descripcion;
                        txtFecha.Text = reporte.FechaReporte.ToShortDateString();
                        txtLatitud.Text = reporte.Latitud.ToString();
                        txtLongitud.Text = reporte.Longitud.ToString();
                        txtZona.Text = reporte.CodigoZona;
                        txtPresupuesto.Text = reporte.PresupuestoEstimado.ToString("C");
                        chkAtendido.Checked = reporte.EstatusAtendido;
                    }
                    else
                    {
                        MessageBox.Show("Reporte no encontrado.");
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtFecha.Text = "";
            txtLatitud.Text = "";
            txtLongitud.Text = "";
            txtZona.Text = "";
            txtPresupuesto.Text = "";
            chkAtendido.Checked = false;
        }
    }
}
