using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.OBJ
{
    [PetaPoco.TableName("Seg_Permisos")]
    public class Permiso
    {
        public int Rol_id { get; set; }
        public int Formulario_Id { get; set; }
        public int Tipo_Permiso_Id { get; set; }    
    }
}
