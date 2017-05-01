using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyAPrueba.BL.Interfaces
{
    public interface IOrdenTrabajo
    {
        List<DATOS.Orden_Trabajo> ListarOT();
        DATOS.Orden_Trabajo BuscarOT(int idOT);
        void InsertarOT(DATOS.Orden_Trabajo idOT);
        void ActualizarMaterial(DATOS.Material idOT);
    }
}
