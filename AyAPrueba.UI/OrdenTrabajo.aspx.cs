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
    public partial class OrdenTrabajo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SesRol"] != null)
            {
                var rol = Session["SesRol"];
                if (Convert.ToInt32(rol) == 1 | Convert.ToInt32(rol) == 2)
                {
                    var nombre = Session["SesNombre"];
                    var cedula = Session["idUser"];
                    ckbxAbierto.Enabled = false;
                    ckbxCerrado.Enabled = false;
                    ckbxAbierto.Checked = true;
                    txtSolicitante.Text = Convert.ToString(nombre);
                    txtSolicitante.ReadOnly = true;
                    var fech = DateTime.Now;
                    txtFecha.Text = Convert.ToString(fech);                    
                }
                if (Convert.ToInt32(rol) == 3) 
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void btnSolicitar_Click(object sender, EventArgs e)
        {
            var cedula = Session["idUser"];
            if (ckbxAbierto.Checked == true && ckbxCerrado.Checked == true)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Solo se admite una opción";
            }
            else if (ckbxAbierto.Checked == false && ckbxCerrado.Checked == false)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Debe seleccionar una opción";
            }
            else
            {
                try
                {
                    var fech = DateTime.Now;
                    var opcselected = "";
                    if (ckbxAbierto.Checked)
                    {
                        opcselected = Convert.ToString("abierto").ToUpper();
                    }
                    else
                    {
                        opcselected = Convert.ToString("cerrado").ToUpper();
                    }
                    var ordent = new DATOS.Orden_Trabajo
                    {
                        
                        fecha_solicitud = txtFecha.Text,
                        id_usuario = Convert.ToInt32(cedula),
                        lugar = txtLugar.Text.ToUpper(),
                        justificacion_aprovacion = txtJustificacion.Text.ToUpper(),
                        estado = opcselected,
                    };

                    IOrdenTrabajo iOrdenTrabajo = new BL.Clases.MOrdenTrabajo();
                    iOrdenTrabajo.InsertarOT(ordent);
                    mensaje.Visible = true;
                    mensajeError.Visible = false;
                    textoMensaje.InnerHtml = "Orden generada correctamente";
                    textoMensajeError.InnerHtml = string.Empty;
                    txtJustificacion.Text = string.Empty;
                    txtLugar.Text = string.Empty;
                    ckbxAbierto.Checked = false;
                    ckbxCerrado.Checked = false;
                }
                catch (Exception)
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensaje.InnerHtml = string.Empty;
                    textoMensajeError.InnerHtml = "Orden no generada";
                }
            }

        }
    }
}