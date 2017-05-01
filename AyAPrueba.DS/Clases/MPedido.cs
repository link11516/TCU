using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.DS.Interfaces;
using ServiceStack.OrmLite;
using System.Data;

namespace AyAPrueba.DS.Clases
{
    public class MPedido : IPedido
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MPedido() 
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<DATOS.Pedido> ListarPedido()
        {
            return _db.Select<DATOS.Pedido>();
        }

        public DATOS.Pedido BuscarPedido(int idPedido)
        {
            DATOS.Pedido Xid = _db.Select<DATOS.Pedido>(x => x.id_pedido == idPedido).FirstOrDefault();
            return Xid;
        }

        public void InsertarPedido(DATOS.Pedido idPedido)
        {
            _db.Insert(idPedido);
        }

        public void ActualizarPedido(DATOS.Pedido idPedido)
        {
            _db.Update(idPedido);
        }

        public void EliminarPedido(int idPedido)
        {
            _db.Delete<DATOS.Pedido>(x => x.id_pedido == idPedido);
        }
    }
}
