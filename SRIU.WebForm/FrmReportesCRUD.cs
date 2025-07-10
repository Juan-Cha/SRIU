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
    public partial class FrmReportesCRUD : Form
    {

        private ServiceReference1.ReporteIncidenciaWCFClient servicio = new ServiceReference1.ReporteIncidenciaWCFClient();

        public FrmReportesCRUD()
        {
            InitializeComponent();
        }

        private void FrmReportesCRUD_Load(object sender, EventArgs e)
        {
            CargarReportes();
        }

        private void CargarReportes()
        {
            try
            {
                dgvReportes.DataSource = null;
                var lista = servicio.ObtenerReportes();
                dgvReportes.DataSource = lista;
                dgvReportes.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los reportes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ServiceReference1.ReporteIncidencia GetReporteSeleccionado()
        {
            if (dgvReportes.CurrentRow == null) return null;
            return dgvReportes.CurrentRow.DataBoundItem as ServiceReference1.ReporteIncidencia;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new FrmEdicion();
            if (frm.ShowDialog() == DialogResult.OK)
                CargarReportes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var rep = GetReporteSeleccionado();
            if (rep == null)
            {
                MessageBox.Show("Selecciona un reporte para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var frm = new FrmEdicion(rep);
            if (frm.ShowDialog() == DialogResult.OK)
                CargarReportes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var rep = GetReporteSeleccionado();
            if (rep == null)
            {
                MessageBox.Show("Selecciona un reporte para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("¿Eliminar este reporte?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool ok = servicio.EliminarReporte(rep.IdReporte);
                    if (ok)
                        MessageBox.Show("Reporte eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo eliminar el reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarReportes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarReportes();
        }

    }
}
