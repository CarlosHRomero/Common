using System.Collections.Generic;
using System.Runtime.InteropServices;
using Common.DAL;
using Common.OBJ;

namespace Common.BLL
{
    public class PermisosBuss
    {
        private PermisosManager manager = new PermisosManager();
        public List<Permiso> ObetnerPermisosPorUsuario(clsUsuario usuario)
        {
            return manager.ObetnerPermisosPorUsuario(usuario);
        }
    }
}