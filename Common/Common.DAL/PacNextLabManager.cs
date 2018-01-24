using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.OBJ;

namespace Common.DAL
{
    public class PacNextLabManager
    {
        private readonly PetaPoco.Database _db = new PetaPoco.Database("Electrofisiologia.Properties.Settings.ConnStrNextlab");

        public List<clsPacNextLab> ObtenerDatosPacientesNextLab(clsPacNextLab paciente)
        {
            String where = "(ape_pac Like '%" + paciente.ape_pac.Trim() + "%' AND nom_pac Like '%" + paciente.nom_pac.Trim() + "%' AND year(fna_pac) = " + paciente.fna_pac.Value.Year + " AND month(fna_pac) = " + paciente.fna_pac.Value.Month + " AND day(fna_pac) = " + paciente.fna_pac.Value.Day + ")";
            String orderBy = "Cod_Pac";
            List<clsPacNextLab> lista = Seleccionar(where, orderBy, "");
            return lista;
        }

        public List<clsPacNextLab> Seleccionar(string @where, string orderBy, string limit)
        {
            List<clsPacNextLab> lista;
            try
            {
                var sql = PetaPoco.Sql.Builder;
             
                if (!String.IsNullOrEmpty(@where))
                {
                    sql.Where(@where);
                }
                if (!String.IsNullOrEmpty(orderBy))
                {
                    sql.OrderBy(orderBy);
                }

                lista = _db.Fetch<clsPacNextLab>(sql);
            }
            catch (Exception e)
            {
                throw new Exception("Error en PacNextLabManager.Seleccionar " + e.Message);
                lista = null;
            }
            return lista;
        }
    }
}
