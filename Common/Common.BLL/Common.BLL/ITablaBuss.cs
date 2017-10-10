using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BLL
{
    public interface ITablaBuss
    {
         Boolean Insertar(object obj);
         Boolean Modificar(object obj);
         Boolean Eliminar(object obj);
         Object Leer(int Id);

    }
}
