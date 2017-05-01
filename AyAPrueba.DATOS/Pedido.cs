using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace AyAPrueba.DATOS
{
    public class Pedido
    {
        //[AutoIncrement]
        //[PrimaryKey]
        public int id_pedido { get; set; }

        public int id_orden { get; set; }

        public int numero_orden { get; set; }
        //este de arriba es el numero del pedido, el nombre esta mal

        public string fecha { get; set; }

        public string observaciones { get; set; }

    }
}
