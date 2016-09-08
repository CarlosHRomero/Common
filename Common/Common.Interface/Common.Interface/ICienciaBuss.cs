using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface
{
    public interface ICienciaBuss
    {
        int ContarTotalRegistros();
        string ObtenerTipoDato(string tabla, string campo);
        DateTime ObtenerFechaDesde();
        DateTime ObtenerFechaHasta();
        bool InsertarTablaSel(string @where, BackgroundWorker worker);
        Boolean GuardarSel(ICiencia_Seleccion sel);
        Boolean GuardarFiltro(List<ICiencia_Filtro> listaFiltro);
        string ArmarCadenaDeConexion(string nombreArchivo);
        int ContarRegistrosConsulta(string where);

        event EventHandler CopiandoTabla;
        Boolean CopiarBaseDeDatos(string origen, string Destino);
        //Boolean GuardarFiltro(List<ICiencia_Filtro> listaFiltro);
    }
}
