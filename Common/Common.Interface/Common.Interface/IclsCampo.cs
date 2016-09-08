using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface
{
    public interface IclsCampo
    {
        string tabla { get; set; }
        string nombre { get; set; }
        List<IEquivalencia> listaEq { get; set; }
        string Func { get; set; }
    }
}
