using System;
using System.Collections.Generic;
using Common.OBJ;

namespace Common.DAL
{
    public class NextLabManager
    {
        private readonly PetaPoco.Database _db = new PetaPoco.Database("Electrofisiologia.Properties.Settings.ConnStrNextlab");

        public List<clsNextLab> ObtenerDatosLaboratorioNextLab(clsPacNextLab pacNextLab, DateTime labFecha)
        {
            DateTime labFechaHasta = labFecha.AddDays(1);
            DateTime labFechaDesde = labFecha.Subtract(TimeSpan.FromDays(90));
            String where = "(lisord.cod_pac= " + pacNextLab.cod_pac +
                           " AND lisbitres.sts_det='VA' AND fec_res>='" + labFechaDesde.ToString(@"MM/dd/yyyy") +
                           "' AND fec_res<='" + labFechaHasta.ToString(@"MM/dd/yyyy") + "')";
                           //"' AND (Cod_Det='771' OR Cod_Det='192' OR Cod_Det='192S' OR Cod_Det='771R'))";
            String orderBy = "lisbitres.nro_ord, lisbitres.fec_res";
            List<clsNextLab> lista = Seleccionar(where, orderBy, "");
            if (lista != null && lista.Count > 0)
                return lista;
            return null;
        }

        public List<clsNextLab> ObtenerDatosLaboratorioNextLabDia(clsPacNextLab pacNextLab, DateTime labFecha)
        {
            DateTime labFechaHasta = labFecha.AddDays(1);
            DateTime labFechaDesde = labFecha;
            String where = "(lisord.cod_pac= " + pacNextLab.cod_pac +
                           " AND lisbitres.sts_det='VA' AND fec_res>='" + labFechaDesde.ToString(@"MM/dd/yyyy") +
                           "' AND fec_res<'" + labFechaHasta.ToString(@"MM/dd/yyyy") + "')";
            //"' AND (Cod_Det='771' OR Cod_Det='192' OR Cod_Det='192S' OR Cod_Det='771R'))";
            String orderBy = "lisbitres.nro_ord, lisbitres.fec_res";
            List<clsNextLab> lista = Seleccionar(where, orderBy, "");
            if (lista != null && lista.Count > 0)
                return lista;
            return null;
        }

        public List<clsNextLab> Seleccionar(string @where, string orderBy, string limit)
        {
            List<clsNextLab> lista;
            try
            {
                var sql = PetaPoco.Sql.Builder
                    .Append("SELECT cod_det, res_det")
                    .Append("FROM dbo.lisord INNER JOIN dbo.lisbitres ON dbo.lisord.nro_ord = dbo.lisbitres.nro_ord");
                if (!String.IsNullOrEmpty(@where))
                {
                    sql.Where(@where);
                }
                if (!String.IsNullOrEmpty(orderBy))
                {
                    sql.OrderBy(orderBy);
                }
                lista = _db.Fetch<clsNextLab>(sql);
            }
            catch (Exception e)
            {
                throw new Exception("Error en LaboratorioJMManager.Seleccionar " + e.Message);
                //lista = null;
            }
            return lista;
        }
    }
}
