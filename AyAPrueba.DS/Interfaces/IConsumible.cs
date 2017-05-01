using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.DATOS;

namespace AyAPrueba.DS.Interfaces
{
    public interface IConsumible
    {
        List<DATOS.Consumible> ListarConsumible();
        DATOS.Consumible BuscarConsumibleXcodigo(string codigoCon);
        DATOS.Consumible BuscarConsumibleXmodelo(string modeloCon);
        DATOS.Consumible BuscarConsumibleXmarca(string marcaCon);
        void InsertarConsumible(DATOS.Consumible codigoCon);
        void ActualizarConsumible(DATOS.Consumible codigoCon);


        void EliminarConsumible(string codigoCon);
    }
}
