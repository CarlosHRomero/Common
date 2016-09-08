using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface
{
    public interface ICiencia_Filtro
    {
        int Id { get; set; }
        int IdSel { get; set; }
        string Tabla { get; set; }
        string Campo { get; set; }
        string Operador { get; set; }
        string Dato { get; set; }
    }
}
