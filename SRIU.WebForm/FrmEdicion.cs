using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIU.WebForm
{
    public partial class FrmEdicion : Form
    {

        private ServiceReference1.ReporteIncidenciaWCFClient servicio = new ServiceReference1.ReporteIncidenciaWCFClient();
        private ServiceReference1.ReporteIncidencia _reporte;

        public FrmEdicion()
        {
            InitializeComponent();
            _reporte = new ServiceReference1.ReporteIncidencia();
            dtpFecha.Value = DateTime.Now;
        }

        public FrmEdicion(ServiceReference1.ReporteIncidencia rep) : this()
        {
            if (rep != null)
            {
                _reporte = rep;
                txtDescripcion.Text = rep.Descripcion;
                dtpFecha.Value = rep.FechaReporte;
                chkAtendido.Checked = rep.EstatusAtendido;
                txtLatitud.Text = rep.Latitud.ToString();
                txtLongitud.Text = rep.Longitud.ToString();
                txtCodigoZona.Text = rep.CodigoZona;
                txtPresupuesto.Text = rep.PresupuestoEstimado.ToString();
                this.Text = "Editar Reporte";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones simples
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }

            // Permite letras, números, espacios y algunos signos de puntuación/acento
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                    txtDescripcion.Text,
                    @"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑüÜ\s.,:;!¿?¡\-_'()]*$"))
            {
                MessageBox.Show(
                    "La descripción solo puede contener letras, números, espacios y signos básicos de puntuación.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLatitud.Text) || !float.TryParse(txtLatitud.Text, out float lat))
            {
                MessageBox.Show("Latitud inválida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLatitud.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLongitud.Text) || !float.TryParse(txtLongitud.Text, out float lng))
            {
                MessageBox.Show("Longitud inválida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLongitud.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCodigoZona.Text))
            {
                MessageBox.Show("Código de zona obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoZona.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodigoZona.Text, @"^\d{4}$"))
            {
                MessageBox.Show("El código de zona debe contener exactamente 4 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoZona.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPresupuesto.Text) || !decimal.TryParse(txtPresupuesto.Text, out decimal pres))
            {
                MessageBox.Show("Presupuesto inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPresupuesto.Focus();
                return;
            }

            _reporte.Descripcion = txtDescripcion.Text.Trim();
            _reporte.FechaReporte = dtpFecha.Value;
            _reporte.EstatusAtendido = chkAtendido.Checked;
            _reporte.Latitud = lat;
            _reporte.Longitud = lng;
            _reporte.CodigoZona = txtCodigoZona.Text.Trim();
            _reporte.PresupuestoEstimado = pres;

            bool resultado = false;

            try
            {
                if (_reporte.IdReporte == 0)
                {
                    // NUEVO
                    resultado = servicio.CrearReporte(_reporte);
                }
                else
                {
                    // EDICIÓN
                    resultado = servicio.ActualizarReporte(_reporte);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (resultado)
            {
                MessageBox.Show("Guardado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se pudo guardar el reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}