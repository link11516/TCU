using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyAPrueba.BL.Interfaces
{
    public interface IMaterialPedido
    {
        List<DATOS.MaterialPedido> ListarMaterialXpedido();
        DATOS.MaterialPedido BuscarMaterialXpedido(int id_pedido);
        void InsertarMaterialXpedido(DATOS.MaterialPedido codigoMat);
        void ActualizarMaterialXpedido(DATOS.MaterialPedido codigoMat);
        void EliminarMaterialXpedido(int id_pedido);
    }
}
