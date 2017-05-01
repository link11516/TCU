using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AyAPrueba.BL.Interfaces;
using System.IO;

namespace AyAPrueba.UI
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            menuwrapper.Visible = false;
            cerrarSes.Visible = false;
            menuTitulo.Visible = false;
            menuTitulo2.Visible = true;
            
            
            if (Session["SesRol"] != null)
            {
                var rol = Session["SesRol"];
                if (Convert.ToInt32(rol) == 1)
                {
                    menuwrapper.Visible = true;
                    cerrarSes.Visible = true;
                    menuTitulo.Visible = true;
                    menuTitulo2.Visible = false;
                    menuUsuario.Visible = true;
                }
                if (Convert.ToInt32(rol) == 2)
                {
                    menuwrapper.Visible = true;
                    cerrarSes.Visible = true;
                    menuTitulo.Visible = true;
                    menuTitulo2.Visible = false;
                    menuUsuario.Visible = false;
                    menuAgregCodConsu.Visible = false;
                    menuEntradaConsu.Visible = false;
                    menuSalidaConsu.Visible = false;
                    menuAgregCodRep.Visible = false;
                    menuEntradaRep.Visible = false;
                    menuSalidaRep.Visible = false;
                    menuAgregCodMat.Visible = false;
                    menuEntradaMat.Visible = false;
                    menuSalidaMat.Visible = false;
                    
                }
                if (Convert.ToInt32(rol) == 3)
                {
                    menuwrapper.Visible = true;
                    cerrarSes.Visible = true;
                    menuTitulo.Visible = true;
                    menuTitulo2.Visible = false;
                    menuUsuario.Visible = false;
                    menuAgregCodConsu.Visible = false;
                    menuEntradaConsu.Visible = false;
                    menuSalidaConsu.Visible = false;
                    menuAgregCodRep.Visible = false;
                    menuEntradaRep.Visible = false;
                    menuSalidaRep.Visible = false;
                    menuAgregCodMat.Visible = false;
                    menuEntradaMat.Visible = false;
                    menuSalidaMat.Visible = false;
                }
            }
        }

        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session["SesRol"] = "";
        }
    }
}