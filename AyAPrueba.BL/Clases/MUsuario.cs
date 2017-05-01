using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.BL.Interfaces;

namespace AyAPrueba.BL.Clases
{
    public class MUsuario : IUsuario
    {
        private readonly DS.Interfaces.IUsuario _usu;
        public MUsuario()
        {
            _usu = new DS.Clases.MUsuario();
        }

        public List<DATOS.Usuario> ListarUsuario()
        {
            return _usu.ListarUsuario();
        }

        public DATOS.Usuario BuscarUsuario(string nombreusuario)
        {
            return _usu.BuscarUsuario(nombreusuario);
        }

        public void InsertarUsuario(DATOS.Usuario usuario)
        {
            _usu.InsertarUsuario(usuario);
        }

        public void ActualizarUsuario(DATOS.Usuario usuario)
        {
            _usu.ActualizarUsuario(usuario);
        }


        public void EliminarUsuario(int idUsuario)
        {
            _usu.EliminarUsuario(idUsuario);
        }


        public DATOS.Usuario BuscarUsuarioXid(int cedul)
        {
            return _usu.BuscarUsuarioXid(cedul);
        }
    }
}
