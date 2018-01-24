using System;
using System.Collections.Generic;
using Common.DAL;
using Common.OBJ;

namespace Common.BLL
{
    public class NextLabBuss
    {
        public List<clsNextLab> ObtenerDatosLaboratorioNextLabs(clsPacNextLab pacNextLab, DateTime antLabF)
        {
            NextLabManager manager = new NextLabManager();
            List<clsNextLab> lista = manager.ObtenerDatosLaboratorioNextLab(pacNextLab, antLabF);
            return lista;
        }

        public List<clsNextLab> ObtenerDatosLaboratorioNextLabsDia(clsPacNextLab pacNextLab, DateTime antLabF)
        {
            NextLabManager manager = new NextLabManager();
            List<clsNextLab> lista = manager.ObtenerDatosLaboratorioNextLabDia(pacNextLab, antLabF);
            return lista;
        }
    }
}
