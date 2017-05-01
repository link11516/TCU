using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace AyAPrueba.DATOS
{
    public class Usuario
    {
        [AutoIncrement]
        [PrimaryKey]
        public int id_usuario { get; set; }

        public string cedula { get; set; }

        public string nombre { get; set; }

        public string apellido1 { get; set; }

        public string apellido2 { get; set; }

        public string nombre_usuario { get; set; }

        public string clave { get; set; }

        public string rol { get; set; }
    }
}