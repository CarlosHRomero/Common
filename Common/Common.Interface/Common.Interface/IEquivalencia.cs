using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface
{
    public interface IEquivalencia
    {
        int valor { get; set; }
        string Texto { get; set; }
        string Equivalente { get; set; }
    }
}
