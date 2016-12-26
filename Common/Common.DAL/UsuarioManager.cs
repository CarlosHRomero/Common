using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using Common.OBJ;
using Generales;

namespace Common.DAL
{
    
    public class UsuarioManager:IBaseManager<clsUsuario>
    {
        private PetaPoco.Database db = new PetaPoco.Database("ICBA.Properties.Settings.ConnStr");
        public bool Eliminar(clsUsuario Obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(string Cod)
        {
            throw new NotImplementedException();
        }

        public clsUsuario GetByID(string Cod)
        {
            throw new NotImplementedException();
        }
     
        public clsUsuario Insertar(clsUsuario Obj)
        {
            try
            {
                if (GetByLogOn(Obj.User_LogOn) !=null)
                {
                    throw new UserException();
                }
                Obj.User_Pasw = EncriptarPass(Obj.User_Pasw);
                var res = db.Insert(Obj);
            }
            catch(Exception ex)
            {
                Utiles.WriteErrorLog("En usuarioManager insertar " + ex.Message);
                Obj = null;
            }
            return Obj;
        }

        public bool Modificar(clsUsuario Obj)
        {
           try
           {
               if (GetByLogOn(Obj.User_LogOn) == null)
               {
                   throw new UserException();
               }
               Obj.User_Pasw = EncriptarPass(Obj.User_Pasw);
               var res = db.Update(Obj);
               return true;
           }
           catch (Exception ex)
           {
               Utiles.WriteErrorLog("En usuarioManager actualizar " + ex.Message);
               Obj = null;
               return false;
           }
        }

        public clsUsuario GetByLogOn(String LogOn)
        {
            clsUsuario user;
            List <clsUsuario> lista;
            try
            {
                var sql = PetaPoco.Sql.Builder
                    .Append("SELECT [User_Id], [User_Nombre] , [User_LogOn], [User_Pasw], [User_Pasw_F] ")
                    .Append("FROM [ICBA Cirugia 2003].[cirugia].[User] ")
                    .Append("WHERE User_LogOn =  @pLogOn", new { pLogOn = LogOn });
                
                lista = db.Fetch<clsUsuario>(sql);
                if (lista.Count > 0)
                {
                    user = lista.First();
                    return user;
                }
                else
                {
                    return null;
                }
                
            }
            catch(Exception ex)
            {
                Utiles.WriteErrorLog(ex.Message);
                return null;
            }
//                .Append("[User_Pasw_D], [User_Obs], [User_ContDat], [User_LogOnErr], [User_EnSist], [User_Perf_T], ")
//                .Append("[User_Est_T], [User_Usr_T], [User_Menu], [User_Puesto_T], [User_Cons_T], [User_Nombre_Red]")//
        }

        public clsUsuario GetUsuario(int IdUsuario, int ModuloId)
        {
            clsUsuario user;
            List<clsUsuario> lista;
            try
            {
                var sql = PetaPoco.Sql.Builder
                    .Append("SELECT [User_Id], [Modulo_Id], [Rol_Id], [User_Nombre], [User_LogOn], [User_Pasw], [User_Pasw_F], [User_Pasw_D], [User_Obs], [User_ContDat], [User_LogOnErr], [User_EnSist], [User_Perf_T], [User_Est_T], [User_Usr_T], [User_Menu], [User_Puesto_T], [User_Cons_T], [User_Nombre_Red], [User_ABMv], [User_Prm] ")
                    .Append("FROM [ICBA Cirugia 2003].[cirugia].[Usuario] ")
                    .Append("WHERE [User_Id] =  @IdUsuario and [Modulo_Id] =  @IdModulo", new { IdUsuario = IdUsuario, IdModulo = ModuloId });

                lista = db.Fetch<clsUsuario>(sql);
                if (lista.Count > 0)
                {
                    user = lista.First();
                    return user;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                Utiles.WriteErrorLog(ex.Message);
                return null;
            }
        }

        public clsUsuario Autenticar(clsUsuario user)
        {
            try
            {
                List<clsUsuario> lista;
                string hash = EncriptarPass(user.User_Pasw);
                var sql = PetaPoco.Sql.Builder.Append("");
                 sql.Where("User_LogOn =  @pLogOn AND User_Pasw = @pass", new { pLogOn = user.User_LogOn, pass = hash });

                lista = db.Fetch<clsUsuario>(sql);
                if (lista.Count < 1)
                    return null;
                else
                    return lista.First();
            }
            catch(Exception ex)
            {
                Utiles.WriteErrorLog("Error en UsuarioManager.Autenticar: " + ex.Message);
                return null;
            }
        }

        private String EncriptarPass(String originalPassword)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
            byte[] hash = sha1.ComputeHash(inputBytes);
            sha1.Dispose();
            return Convert.ToBase64String(hash);
        }

        public List<clsUsuario> Seleccionar(string Where, string OrderBy, string Limit)
        {
            List<clsUsuario> Usuarios;
            var sql = PetaPoco.Sql.Builder
                .Append("SELECT [User_Id], [User_Nombre], [User_LogOn], [User_Pasw], [User_Pasw_F], " +
                "[User_Pasw_D] FROM Hemo_User");
            Usuarios = db.Fetch<clsUsuario>(sql);
            return Usuarios;
        }

        public List<clsUsuario>  SeleccionarTodos(String order)
         {
             return Seleccionar("", order,"");
         }

    }
}
