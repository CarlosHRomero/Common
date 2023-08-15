using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.OBJ;
using Generales;

namespace Common.DAL
{
    public class PermisosManager
    {
        private readonly PetaPoco.Database _db = new PetaPoco.Database("ICBA.Properties.Settings.conStr");
        public List<Permiso> ObetnerPermisosPorUsuario(clsUsuario usuario)
        {
            try
            {
                var sql = PetaPoco.Sql.Builder
                    .Append("");
                sql.Where(string.Format("Rol_Id = {0}", usuario.Rol_Id));
                var lista = _db.Fetch<Permiso>(sql);
                return lista;
            }
            catch (Exception ex)
            {
                Utiles.WriteErrorLog(ex.Message);
                return null;
            }
        }

      


        public List<Permiso> ObtenerPermisoPorRol(clsRoles rol)
        {
            try
            {
                var sql = PetaPoco.Sql.Builder
                    .Append("");
                sql.Where(string.Format("Rol_Id = {0}",rol.Rol_Id));
                var lista = _db.Fetch<Permiso>(sql);
                return lista;
            }
            catch (Exception ex)
            {
                Utiles.WriteErrorLog(ex.Message);
                return null;
            }

        }

    }
}
