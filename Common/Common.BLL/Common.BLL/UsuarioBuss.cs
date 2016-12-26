using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.OBJ;
using Common.DAL;

namespace Common.BLL
{
    public class UsuarioBuss
    {
        private UsuarioManager _UManager;
        private UsuarioManager UManager
        {
            get
            {
                if (_UManager == null)
                    _UManager = new UsuarioManager();
                return _UManager;
            }

        }
        public clsUsuario ObtenerUsuario(int IdUsuario, int ModuloId)
        {
            return (UManager.GetUsuario(IdUsuario, ModuloId));
        }

        public clsUsuario ObtenerUsuario(String LogOn)
        {
            return (UManager.GetByLogOn(LogOn));
        }
        public clsUsuario ValidarUsuario(clsUsuario user)
        {
            return (UManager.Autenticar(user));        
        }
        public Boolean NuevoUsuario(clsUsuario user)
        {
                return !(UManager.Insertar(user) == null);
        }
        public Boolean ModificarContraseña(clsUsuario user)
        {
            return UManager.Modificar(user);
        }
    }
}
