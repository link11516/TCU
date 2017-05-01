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
    public class MMaterial : IMateriales
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MMaterial() 
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<DATOS.Material> ListarMaterial()
        {
            return _db.Select<DATOS.Material>();
        }

        public DATOS.Material BuscarMaterial(string codigoMat)
        {
            DATOS.Material Xcodigo = _db.Select<DATOS.Material>(x => x.codigo_mat == codigoMat).FirstOrDefault();
            return Xcodigo;
        }

        public void InsertarMaterial(DATOS.Material codigoMat)
        {
            _db.Insert(codigoMat);
        }

        public void ActualizarMaterial(DATOS.Material codigoMat)
        {
            _db.Update(codigoMat);
        }

        public void EliminarMaterial(string codigoMat)
        {
            _db.Delete<DATOS.Material>(x => x.codigo_mat == codigoMat);
        }


        
    }
}
