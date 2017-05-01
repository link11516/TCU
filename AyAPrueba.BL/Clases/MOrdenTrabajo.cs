using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.BL.Interfaces;

namespace AyAPrueba.BL.Clases
{
    public class MOrdenTrabajo : IOrdenTrabajo
    {

        private readonly DS.Interfaces.IOrdenTrabajo _OT;
        public MOrdenTrabajo()
        {
            _OT = new DS.Clases.MOrdenTrabajo();
        }

        public List<DATOS.Orden_Trabajo> ListarOT()
        {
            return _OT.ListarOT();
        }

        public DATOS.Orden_Trabajo BuscarOT(int idOT)
        {
            return _OT.BuscarOT(idOT);
        }

        public void InsertarOT(DATOS.Orden_Trabajo idOT)
        {
            _OT.InsertarOT(idOT);
        }

        public void ActualizarMaterial(DATOS.Material idOT)
        {
            _OT.ActualizarMaterial(idOT);
        }
    }
}
