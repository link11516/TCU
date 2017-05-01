using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyAPrueba.DATOS
{
    public class Repuesto
    {
        public string codigo_rep { get; set; }

        public string marca { get; set; }

        public string modelo { get; set; }

        public string impresoras { get; set; }

        public string tipo { get; set; }

        public string descripcion { get; set; }

        public int cantidad_nuevos { get; set; }

        public int cantidad_viejos { get; set; }

        public int cantidad_total { get; set; }

        public string unidad { get; set; }

    }
}
