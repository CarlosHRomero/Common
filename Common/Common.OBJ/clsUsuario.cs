using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace Common.OBJ
{
    [PetaPoco.TableName("Usuario")]
    [PetaPoco.PrimaryKey("User_Id")]
    //prueba de tfs  hgf
    public class clsUsuario
    {
        public int User_Id { get; set; }
        public int Modulo_Id { get; set; }
        public int Rol_Id { get; set; }
        public String User_Nombre { get; set; }
        public String User_LogOn { get; set; }
        public String User_Pasw { get; set; }
        public DateTime User_Pasw_F { get; set; }
        public int User_Pasw_D { get; set; }
        Boolean _User_EnSist = false;
        public Boolean User_EnSist
        {
            get
            { return _User_EnSist; }
            set
            {
                _User_EnSist = value;
            }
        }
        Boolean _User_ContDat = false;
        public Boolean User_ContDat
        {
            get
            { return _User_ContDat; }
            set
            {
                _User_ContDat = value;
            }
        }
        }
}
