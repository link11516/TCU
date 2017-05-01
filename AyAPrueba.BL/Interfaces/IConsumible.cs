using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyAPrueba.BL.Interfaces
{
    public interface IConsumible
    {
        List<DATOS.Consumible> ListarConsumible();
        List<DATOS.Consumible> ListarConsumibleHP();
        List<DATOS.Consumible> ListarConsumibleLexmark();
        List<DATOS.Consumible> ListarConsumibleKyocera();
        List<DATOS.Consumible> ListarConsumibleEpson();
        List<DATOS.Consumible> ListarConsumibleCanon();
        DATOS.Consumible BuscarConsumibleXcodigo(string codigoCon);
        DATOS.Consumible BuscarConsumibleXmodelo(string modeloCon);
        DATOS.Consumible BuscarConsumibleXmarca(string marcaCon);
        void InsertarConsumible(DATOS.Consumible codigoCon);
        void ActualizarConsumible(DATOS.Consumible codigoCon);


        void EliminarConsumible(string codigoCon);
    }
}
