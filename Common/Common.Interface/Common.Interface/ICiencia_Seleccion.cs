using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface
{
    public interface ICiencia_Seleccion
    {
        //int id;
        DateTime? Sel_fecha { get; set; }
        DateTime? sel_desde { get; set; }
        DateTime? Sel_hasta { get; set; }
        String Sel_usuario { get; set; }
        String Sel_filtro { get; set; }
    }
}
