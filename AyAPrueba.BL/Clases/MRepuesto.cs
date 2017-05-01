using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyAPrueba.BL.Interfaces;

namespace AyAPrueba.BL.Clases
{
    public class MRepuesto : IRepuesto
    {
        private readonly DS.Interfaces.IRepuesto _rep;
        public MRepuesto()
        {
            _rep = new DS.Clases.MRepuesto();
        }

        public List<DATOS.Repuesto> ListarRepuesto()
        {
            List<DATOS.Repuesto> ListarOrden = _rep.ListarRepuesto();
            ListarOrden = ListarOrden.OrderBy(x => x.marca).ToList();
            return ListarOrden;
        }

        public List<DATOS.Repuesto> ListarRepuestoHP()
        {
            List<DATOS.Repuesto> ListarRepuestoHP = _rep.ListarRepuesto();
            ListarRepuestoHP = ListarRepuestoHP.Where(x => x.marca == "HP").ToList();
            return ListarRepuestoHP;
        }

        public List<DATOS.Repuesto> ListarRepuestoLexmark()
        {
            List<DATOS.Repuesto> ListarRepuestoLexmark = _rep.ListarRepuesto();
            ListarRepuestoLexmark = ListarRepuestoLexmark.Where(x => x.marca == "LEXMARK").ToList();
            return ListarRepuestoLexmark;
        }

        public List<DATOS.Repuesto> ListarRepuestoCanon()
        {
            List<DATOS.Repuesto> ListarRepuestoCanon = _rep.ListarRepuesto();
            ListarRepuestoCanon = ListarRepuestoCanon.Where(x => x.marca == "CANON").ToList();
            return ListarRepuestoCanon;
        }

        public List<DATOS.Repuesto> ListarRepuestoEpson()
        {
            List<DATOS.Repuesto> ListarRepuestoEpson = _rep.ListarRepuesto();
            ListarRepuestoEpson = ListarRepuestoEpson.Where(x => x.marca == "EPSON").ToList();
            return ListarRepuestoEpson;
        }

        public List<DATOS.Repuesto> ListarRepuestoKyocera()
        {
            List<DATOS.Repuesto> ListarRepuestoKyocera = _rep.ListarRepuesto();
            ListarRepuestoKyocera = ListarRepuestoKyocera.Where(x => x.marca == "KYOCERA").ToList();
            return ListarRepuestoKyocera;
        }

        public DATOS.Repuesto BuscarRepuestoXcodigo(string codigoRep)
        {
            return _rep.BuscarRepuestoXcodigo(codigoRep);
        }

        public DATOS.Repuesto BuscarRepuestoXmodelo(string modeloRep)
        {
            return _rep.BuscarRepuestoXmodelo(modeloRep);
        }

        public DATOS.Repuesto BuscarRepuestoXmarca(string marcaRep)
        {
            return _rep.BuscarRepuestoXmarca(marcaRep);
        }

        public void InsertarRepuesto(DATOS.Repuesto codigoRep)
        {
            _rep.InsertarRepuesto(codigoRep);
        }

        public void ActualizarRepuesto(DATOS.Repuesto codigoRep)
        {
            _rep.ActualizarRepuesto(codigoRep);
        }

        public void EliminarRepuesto(string codigoRep)
        {
            _rep.EliminarRepuesto(codigoRep);
        }        
    }
}
