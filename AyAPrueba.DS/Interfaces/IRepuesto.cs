using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.DATOS;

namespace AyAPrueba.DS.Interfaces
{
    public interface IRepuesto
    {
        List<DATOS.Repuesto> ListarRepuesto();
        DATOS.Repuesto BuscarRepuestoXcodigo(string codigoRep);
        DATOS.Repuesto BuscarRepuestoXmodelo(string modeloRep);
        DATOS.Repuesto BuscarRepuestoXmarca(string marcaRep);
        void InsertarRepuesto(DATOS.Repuesto codigoRep);
        void ActualizarRepuesto(DATOS.Repuesto codigoRep);


        void EliminarRepuesto(string codigoRep);
    }
}
