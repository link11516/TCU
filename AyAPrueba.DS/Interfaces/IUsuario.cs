using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.DATOS;

namespace AyAPrueba.DS.Interfaces
{
    public interface IUsuario
    {
        List<DATOS.Usuario> ListarUsuario();
        DATOS.Usuario BuscarUsuario(string nombreusuario);
        DATOS.Usuario BuscarUsuarioXid(int cedul);
        void InsertarUsuario(DATOS.Usuario usuario);
        void ActualizarUsuario(DATOS.Usuario usuario);


        void EliminarUsuario(int idUsuario);
    }
}
