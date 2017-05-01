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
    public class MUsuario : IUsuario
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MUsuario() 
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<DATOS.Usuario> ListarUsuario()
        {
            return _db.Select<DATOS.Usuario>();
        }

        public DATOS.Usuario BuscarUsuario(string nombreusuario)
        {

            DATOS.Usuario login = _db.Select<DATOS.Usuario>(x => x.nombre_usuario == nombreusuario).FirstOrDefault();
            return login;
        }

        public void InsertarUsuario(DATOS.Usuario usuario)
        {
            _db.Insert(usuario);
        }

        public void ActualizarUsuario(DATOS.Usuario usuario)
        {
            _db.Update(usuario);
        }


        public void EliminarUsuario(int idUsuario)
        {
            _db.Delete<DATOS.Usuario>(x => x.id_usuario == idUsuario);
        }


        public DATOS.Usuario BuscarUsuarioXid(int cedul)
        {
            DATOS.Usuario ced = _db.Select<DATOS.Usuario>(x => x.id_usuario == cedul).FirstOrDefault();
            return ced;
        }
    }
}
