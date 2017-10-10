using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.OBJ;
using Generales;

namespace Common.DAL
{
    public class RolManager
    {
        private readonly PetaPoco.Database _db = new PetaPoco.Database("ICBA.Properties.Settings.conStr");

        public List<clsRoles> SeleccionarTodos(string orderBy)
        {
            try
            {
                var sql = PetaPoco.Sql.Builder.Append("");
                if (!string.IsNullOrEmpty(orderBy))
                    sql.OrderBy(orderBy);
                var lista = _db.Fetch<clsRoles>(sql);
                return lista;
            }
            catch (Exception ex)
            {
                Utiles.WriteErrorLog(ex.Message);
                return null;
            }
        }


        public List<clsRoles> TraerRolPorUsuario(clsUsuario user)
        {
            try
            {
                var sql = PetaPoco.Sql.Builder.Append("");
                if (user != null)
                    sql.Where("");
                var lista = _db.Fetch<clsRoles>(sql);
                return lista;

            }
            catch (Exception)
            {
                
                throw;
            }

            return null;
            //if()
        }
    }
}
