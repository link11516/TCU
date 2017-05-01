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
    public class MConsumible : IConsumible
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MConsumible() 
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }



        public List<DATOS.Consumible> ListarConsumible()
        {
            return _db.Select<DATOS.Consumible>();
        }

        public DATOS.Consumible BuscarConsumibleXcodigo(string codigoCon)
        {
            DATOS.Consumible Xcodigo = _db.Select<DATOS.Consumible>(x => x.codigo_con == codigoCon).FirstOrDefault();
            return Xcodigo;
        }

        public DATOS.Consumible BuscarConsumibleXmodelo(string modeloCon)
        {
            DATOS.Consumible Xmodelo = _db.Select<DATOS.Consumible>(x => x.modelo == modeloCon).FirstOrDefault();
            return Xmodelo;
        }

        public DATOS.Consumible BuscarConsumibleXmarca(string marcaCon)
        {
            DATOS.Consumible Xmarca = _db.Select<DATOS.Consumible>(x => x.marca == marcaCon).FirstOrDefault();
            return Xmarca;
        }

        public void InsertarConsumible(DATOS.Consumible codigoCon)
        {
            _db.Insert(codigoCon);
        }

        public void ActualizarConsumible(DATOS.Consumible codigoCon)
        {
            _db.Update(codigoCon);
        }

        public void EliminarConsumible(string codigoCon)
        {
            _db.Delete<DATOS.Consumible>(x => x.codigo_con == codigoCon);
        }
    }
}
