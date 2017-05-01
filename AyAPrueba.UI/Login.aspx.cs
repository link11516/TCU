using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AyAPrueba.BL.Interfaces;
using AyAPrueba.DATOS;

namespace AyAPrueba.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                IUsuario iUsuario = new AyAPrueba.BL.Clases.MUsuario();
                var datos = txtUsuario.Text;
                var login = iUsuario.BuscarUsuario(datos);
                var datosusuario = iUsuario.BuscarUsuario(datos);
                Session["idUser"] = datosusuario.id_usuario;
                Session["SesNombre"] = datosusuario.nombre + " " + datosusuario.apellido1 + " " + datosusuario.apellido2;
                if (login.clave == txtClave.Text)
                {
                    Session["SesRol"] = login.rol;
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Ingreso incorrecto";
                }
            }
            catch (Exception)
            {

                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Ingreso incorrecto";
            }
        }
    }
}