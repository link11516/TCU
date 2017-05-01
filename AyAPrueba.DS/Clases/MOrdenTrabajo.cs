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
    public class MOrdenTrabajo: IOrdenTrabajo
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MOrdenTrabajo() 
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<DATOS.Orden_Trabajo> ListarOT()
        {
            return _db.Select<DATOS.Orden_Trabajo>();
        }

        public DATOS.Orden_Trabajo BuscarOT(int idOT)
        {
            DATOS.Orden_Trabajo orden = _db.Select<DATOS.Orden_Trabajo>(x => x.id_orden == idOT).FirstOrDefault();
            return orden;
        }

        public void InsertarOT(DATOS.Orden_Trabajo idOT)
        {
            _db.Insert(idOT);
        }

        public void ActualizarMaterial(DATOS.Material idOT)
        {
            _db.Update(idOT);
        }
    }
}
