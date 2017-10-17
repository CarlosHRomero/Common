using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.OBJ
{
     [PetaPoco.TableName("Roles")]
    public class clsRoles
    {
        public int Rol_Id { get; set; }
        public string Rol_Nombre { get; set; }
    }

    
}
