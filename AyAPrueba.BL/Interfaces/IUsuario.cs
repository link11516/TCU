using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyAPrueba.BL.Interfaces
{
    public interface IUsuario
    {
        List<DATOS.Usuario> ListarUsuario();
        DATOS.Usuario BuscarUsuario(string nombreusuario);
        void InsertarUsuario(DATOS.Usuario usuario);
        void ActualizarUsuario(DATOS.Usuario usuario);
        DATOS.Usuario BuscarUsuarioXid(int cedul);
        void EliminarUsuario(int idUsuario);
    }
}
