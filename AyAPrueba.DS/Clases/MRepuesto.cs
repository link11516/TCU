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
    public class MRepuesto : IRepuesto
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MRepuesto() 
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<DATOS.Repuesto> ListarRepuesto()
        {
            return _db.Select<DATOS.Repuesto>();
        }

        public DATOS.Repuesto BuscarRepuestoXcodigo(string codigoRep)
        {
            DATOS.Repuesto Xcodigo = _db.Select<DATOS.Repuesto>(x => x.codigo_rep == codigoRep).FirstOrDefault();
            return Xcodigo;
        }

        public DATOS.Repuesto BuscarRepuestoXmodelo(string modeloRep)
        {
            DATOS.Repuesto Xmodelo = _db.Select<DATOS.Repuesto>(x => x.modelo == modeloRep).FirstOrDefault();
            return Xmodelo;
        }

        public DATOS.Repuesto BuscarRepuestoXmarca(string marcaRep)
        {
            DATOS.Repuesto Xmarca = _db.Select<DATOS.Repuesto>(x => x.marca == marcaRep).FirstOrDefault();
            return Xmarca;
        }

        public void InsertarRepuesto(DATOS.Repuesto codigoRep)
        {
            _db.Insert(codigoRep);
        }

        public void ActualizarRepuesto(DATOS.Repuesto codigoRep)
        {
            _db.Update(codigoRep);
        }

        public void EliminarRepuesto(string codigoRep)
        {
            _db.Delete<DATOS.Repuesto>(x => x.codigo_rep == codigoRep);
        }
    }
}
