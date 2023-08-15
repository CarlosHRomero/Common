using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DAL;
using Common.OBJ;

namespace Common.BLL
{
    public class PacNextLabBuss
    {
        public clsPacNextLab Leer(int codPac) => new PacNextLabManager().GetByID(codPac.ToString());
        //public List<clsPacNextLab> ObtenerHistoriaPaciente(clsPaciente paciente)
        //{
        //    PacNextLabManager manager = new PacNextLabManager();
        //    List<clsPacNextLab> lista = manager.ObtenerDatosPacientesNextLab(paciente);
        //    return lista;
        //}
    }
}
