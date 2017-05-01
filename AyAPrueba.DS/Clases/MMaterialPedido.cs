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
    public class MMaterialPedido : IMaterialPedido
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MMaterialPedido() 
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<DATOS.MaterialPedido> ListarMaterialXpedido()
        {
            return _db.Select<DATOS.MaterialPedido>();
        }

        public DATOS.MaterialPedido BuscarMaterialXpedido(int id_pedido)
        {
            DATOS.MaterialPedido XidPedido = _db.Select<DATOS.MaterialPedido>(x => x.id_pedido == id_pedido).FirstOrDefault();
            return XidPedido;
        }

        public void InsertarMaterialXpedido(DATOS.MaterialPedido codigoMat)
        {
            _db.Insert(codigoMat);
        }

        public void ActualizarMaterialXpedido(DATOS.MaterialPedido codigoMat)
        {
            _db.Update(codigoMat);
        }

        public void EliminarMaterialXpedido(int id_pedido)
        {
            _db.Delete<DATOS.MaterialPedido>(x => x.id_pedido == id_pedido);
        }
    }
}
