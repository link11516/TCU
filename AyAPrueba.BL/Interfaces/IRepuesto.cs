using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyAPrueba.BL.Interfaces
{
    public interface IRepuesto
    {
        List<DATOS.Repuesto> ListarRepuesto();
        List<DATOS.Repuesto> ListarRepuestoHP();
        List<DATOS.Repuesto> ListarRepuestoLexmark();
        List<DATOS.Repuesto> ListarRepuestoCanon();
        List<DATOS.Repuesto> ListarRepuestoEpson();
        List<DATOS.Repuesto> ListarRepuestoKyocera();
        DATOS.Repuesto BuscarRepuestoXcodigo(string codigoRep);
        DATOS.Repuesto BuscarRepuestoXmodelo(string modeloRep);
        DATOS.Repuesto BuscarRepuestoXmarca(string marcaRep);
        void InsertarRepuesto(DATOS.Repuesto codigoRep);
        void ActualizarRepuesto(DATOS.Repuesto codigoRep);


        void EliminarRepuesto(string codigoRep);
    }
}
