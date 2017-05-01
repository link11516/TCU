using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.BL.Interfaces;

namespace AyAPrueba.BL.Clases
{
    public class MPedido : IPedido
    {
        private readonly DS.Interfaces.IPedido _pedido;
        public MPedido()
        {
            _pedido = new DS.Clases.MPedido();
        }

        public List<DATOS.Pedido> ListarPedido()
        {
            return _pedido.ListarPedido();
        }

        public DATOS.Pedido BuscarPedido(int idPedido)
        {
            return _pedido.BuscarPedido(idPedido);
        }

        public void InsertarPedido(DATOS.Pedido idPedido)
        {
            _pedido.InsertarPedido(idPedido);
        }

        public void ActualizarPedido(DATOS.Pedido idPedido)
        {
            _pedido.ActualizarPedido(idPedido);
        }

        public void EliminarPedido(int idPedido)
        {
            _pedido.EliminarPedido(idPedido);
        }
    }
}
