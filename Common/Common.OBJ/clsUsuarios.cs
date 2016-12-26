using System;

namespace Common.OBJ
{
    [PetaPoco.TableName("Usuario")]
    [PetaPoco.PrimaryKey("User_Id")]

    public class clsUsuario
    {
        public int User_Id { get; set; }
        [PetaPoco.Column("Modulo_Id")]
        public int ModuloId { get; set; } 
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
