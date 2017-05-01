using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.BL.Interfaces;

namespace AyAPrueba.BL.Clases
{
    public class MConsumible : IConsumible 
    {
        private readonly DS.Interfaces.IConsumible _consu;
        public MConsumible()
        {
            _consu = new DS.Clases.MConsumible();
        }


        public List<DATOS.Consumible> ListarConsumible()
        {
            List<DATOS.Consumible> ListarOrden = _consu.ListarConsumible();
            ListarOrden = ListarOrden.OrderBy(x => x.marca).ToList();
            return ListarOrden;
        }

        public List<DATOS.Consumible> ListarConsumibleHP()
        {
            List<DATOS.Consumible> ListarConsumibleHP = _consu.ListarConsumible();
            ListarConsumibleHP = ListarConsumibleHP.Where(x => x.marca == "HP").ToList();
            return ListarConsumibleHP;
        }

        public List<DATOS.Consumible> ListarConsumibleLexmark()
        {
            List<DATOS.Consumible> ListarConsumibleLexmark = _consu.ListarConsumible();
            ListarConsumibleLexmark = ListarConsumibleLexmark.Where(x => x.marca == "LEXMARK").ToList();
            return ListarConsumibleLexmark;
        }

        public List<DATOS.Consumible> ListarConsumibleKyocera()
        {
            List<DATOS.Consumible> ListarConsumibleKyocera = _consu.ListarConsumible();
            ListarConsumibleKyocera = ListarConsumibleKyocera.Where(x => x.marca == "KYOCERA").ToList();
            return ListarConsumibleKyocera;
        }

        public List<DATOS.Consumible> ListarConsumibleEpson()
        {
            List<DATOS.Consumible> ListarConsumibleEpson = _consu.ListarConsumible();
            ListarConsumibleEpson = ListarConsumibleEpson.Where(x => x.marca == "EPSON").ToList();
            return ListarConsumibleEpson;
        }

        public List<DATOS.Consumible> ListarConsumibleCanon()
        {
            List<DATOS.Consumible> ListarConsumibleCanon = _consu.ListarConsumible();
            ListarConsumibleCanon = ListarConsumibleCanon.Where(x => x.marca == "CANON").ToList();
            return ListarConsumibleCanon;
        }

        public DATOS.Consumible BuscarConsumibleXcodigo(string codigoCon)
        {
            return _consu.BuscarConsumibleXcodigo(codigoCon);
        }

        public DATOS.Consumible BuscarConsumibleXmodelo(string modeloCon)
        {
            return _consu.BuscarConsumibleXmodelo(modeloCon);
        }

        public DATOS.Consumible BuscarConsumibleXmarca(string marcaCon)
        {
            return _consu.BuscarConsumibleXmarca(marcaCon);
        }

        public void InsertarConsumible(DATOS.Consumible codigoCon)
        {
            _consu.InsertarConsumible(codigoCon);
        }

        public void ActualizarConsumible(DATOS.Consumible codigoCon)
        {
            _consu.ActualizarConsumible(codigoCon);
        }

        public void EliminarConsumible(string codigoCon)
        {
            _consu.EliminarConsumible(codigoCon);
        }


        
    }
}
