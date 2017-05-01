using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace AyAPrueba.DATOS
{
    public class Orden_Trabajo
    {
        [AutoIncrement]
        [PrimaryKey]
        public int id_orden { get; set; }

        public string fecha_solicitud { get; set; }

        public int id_usuario { get; set; }

        public string estado { get; set; }

        public string lugar { get; set; }

        public string justificacion_aprovacion { get; set; }

    }
}
