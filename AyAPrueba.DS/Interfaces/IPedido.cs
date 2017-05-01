using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.DATOS;

namespace AyAPrueba.DS.Interfaces
{
    public interface IPedido
    {
        List<DATOS.Pedido> ListarPedido();
        DATOS.Pedido BuscarPedido(int idPedido);
        void InsertarPedido(DATOS.Pedido idPedido);
        void ActualizarPedido(DATOS.Pedido idPedido);
        void EliminarPedido(int idPedido);
    }
}
