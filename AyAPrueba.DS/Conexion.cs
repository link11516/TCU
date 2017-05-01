using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;

namespace AyAPrueba.DS
{
    public class Conexion
    {
        public static OrmLiteConnectionFactory CrearConexion()
        {
            return new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
        }
    }
}
