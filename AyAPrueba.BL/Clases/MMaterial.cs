using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.BL.Interfaces;

namespace AyAPrueba.BL.Clases
{
    public class MMaterial : IMateriales
    {
        private readonly DS.Interfaces.IMateriales _mate;
        public MMaterial()
        {
            _mate = new DS.Clases.MMaterial();
        }

        public List<DATOS.Material> ListarMaterial()
        {
            return _mate.ListarMaterial();
        }

        public DATOS.Material BuscarMaterial(string codigoMat)
        {
            return _mate.BuscarMaterial(codigoMat);
        }

        public void InsertarMaterial(DATOS.Material codigoMat)
        {
            _mate.InsertarMaterial(codigoMat);
        }

        public void ActualizarMaterial(DATOS.Material codigoMat)
        {
            _mate.ActualizarMaterial(codigoMat);
        }

        public void EliminarMaterial(string codigoMat)
        {
            _mate.EliminarMaterial(codigoMat);
        }
    }
}
