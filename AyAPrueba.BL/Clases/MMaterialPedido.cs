using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.BL.Interfaces;

namespace AyAPrueba.BL.Clases
{
    public class MMaterialPedido : IMaterialPedido
    {
        private readonly DS.Interfaces.IMaterialPedido _mate;
        public MMaterialPedido()
        {
            _mate = new DS.Clases.MMaterialPedido();
        }
        public List<DATOS.MaterialPedido> ListarMaterialXpedido()
        {
            return _mate.ListarMaterialXpedido();
        }

        public DATOS.MaterialPedido BuscarMaterialXpedido(int id_pedido)
        {
            return _mate.BuscarMaterialXpedido(id_pedido);
        }

        public void InsertarMaterialXpedido(DATOS.MaterialPedido codigoMat)
        {
            _mate.InsertarMaterialXpedido(codigoMat);
        }

        public void ActualizarMaterialXpedido(DATOS.MaterialPedido codigoMat)
        {
            _mate.ActualizarMaterialXpedido(codigoMat);
        }

        public void EliminarMaterialXpedido(int id_pedido)
        {
            _mate.EliminarMaterialXpedido(id_pedido);
        }
    }
}
