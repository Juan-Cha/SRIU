using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SRIU.Models
{
    public class ReporteIncidenciaDAL
    {
        private string connStr = ConfigurationManager.ConnectionStrings["ReportesUrbanosDB"].ConnectionString;

        public List<ReporteIncidencia> ObtenerTodos()
        {
            List<ReporteIncidencia> lista = new List<ReporteIncidencia>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM ReporteIncidencia";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ReporteIncidencia
                        {
                            IdReporte = Convert.ToInt32(dr["IdReporte"]),
                            Descripcion = dr["Descripcion"].ToString(),
                            FechaReporte = Convert.ToDateTime(dr["FechaReporte"]),
                            EstatusAtendido = Convert.ToBoolean(dr["EstatusAtendido"]),
                            Latitud = Convert.ToSingle(dr["Latitud"]),
                            Longitud = Convert.ToSingle(dr["Longitud"]),
                            CodigoZona = dr["CodigoZona"].ToString(),
                            PresupuestoEstimado = Convert.ToDecimal(dr["PresupuestoEstimado"])
                        });
                    }
                }
            }
            return lista;
        }

        public bool Insertar(ReporteIncidencia reporte)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"INSERT INTO ReporteIncidencia 
                                (Descripcion, FechaReporte, EstatusAtendido, Latitud, Longitud, CodigoZona, PresupuestoEstimado)
                                VALUES (@Descripcion, @FechaReporte, @EstatusAtendido, @Latitud, @Longitud, @CodigoZona, @PresupuestoEstimado)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", reporte.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaReporte", reporte.FechaReporte);
                    cmd.Parameters.AddWithValue("@EstatusAtendido", reporte.EstatusAtendido);
                    cmd.Parameters.AddWithValue("@Latitud", reporte.Latitud);
                    cmd.Parameters.AddWithValue("@Longitud", reporte.Longitud);
                    cmd.Parameters.AddWithValue("@CodigoZona", reporte.CodigoZona);
                    cmd.Parameters.AddWithValue("@PresupuestoEstimado", reporte.PresupuestoEstimado);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ActualizarEstatus(int idReporte, bool atendido)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"UPDATE ReporteIncidencia SET EstatusAtendido = @EstatusAtendido WHERE IdReporte = @IdReporte";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EstatusAtendido", atendido);
                    cmd.Parameters.AddWithValue("@IdReporte", idReporte);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Eliminar(int idReporte)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "DELETE FROM ReporteIncidencia WHERE IdReporte = @IdReporte";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdReporte", idReporte);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public ReporteIncidencia ObtenerPorId(int idReporte)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM ReporteIncidencia WHERE IdReporte = @IdReporte";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdReporte", idReporte);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new ReporteIncidencia
                            {
                                IdReporte = Convert.ToInt32(dr["IdReporte"]),
                                Descripcion = dr["Descripcion"].ToString(),
                                FechaReporte = Convert.ToDateTime(dr["FechaReporte"]),
                                EstatusAtendido = Convert.ToBoolean(dr["EstatusAtendido"]),
                                Latitud = Convert.ToSingle(dr["Latitud"]),
                                Longitud = Convert.ToSingle(dr["Longitud"]),
                                CodigoZona = dr["CodigoZona"].ToString(),
                                PresupuestoEstimado = Convert.ToDecimal(dr["PresupuestoEstimado"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool ActualizarReporte(ReporteIncidencia reporte)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"UPDATE ReporteIncidencia 
                         SET Descripcion = @Descripcion, 
                             FechaReporte = @FechaReporte, 
                             EstatusAtendido = @EstatusAtendido, 
                             Latitud = @Latitud, 
                             Longitud = @Longitud, 
                             CodigoZona = @CodigoZona, 
                             PresupuestoEstimado = @PresupuestoEstimado
                         WHERE IdReporte = @IdReporte";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", reporte.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaReporte", reporte.FechaReporte);
                    cmd.Parameters.AddWithValue("@EstatusAtendido", reporte.EstatusAtendido);
                    cmd.Parameters.AddWithValue("@Latitud", reporte.Latitud);
                    cmd.Parameters.AddWithValue("@Longitud", reporte.Longitud);
                    cmd.Parameters.AddWithValue("@CodigoZona", reporte.CodigoZona);
                    cmd.Parameters.AddWithValue("@PresupuestoEstimado", reporte.PresupuestoEstimado);
                    cmd.Parameters.AddWithValue("@IdReporte", reporte.IdReporte);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


    }
}