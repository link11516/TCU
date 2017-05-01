using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyAPrueba.BL.Interfaces
{
    public interface IMateriales
    {
        List<DATOS.Material> ListarMaterial();
        DATOS.Material BuscarMaterial(string codigoMat);
        void InsertarMaterial(DATOS.Material codigoMat);
        void ActualizarMaterial(DATOS.Material codigoMat);
        void EliminarMaterial(string codigoMat);
    }
}
