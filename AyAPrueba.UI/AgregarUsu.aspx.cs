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
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if (ckbxAdmin.Checked == true && ckbxBodega.Checked == true)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Solo se admite un rol";
            }
            else if (ckbxAdmin.Checked == true && ckbxLectura.Checked == true)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Solo se admite un rol";
            }
            else if (ckbxBodega.Checked == true && ckbxLectura.Checked == true)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Solo se admite un rol";
            }
            else if (ckbxBodega.Checked == true && ckbxLectura.Checked == true && ckbxAdmin.Checked == true)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Solo se admite un rol";
            }
            else if (ckbxBodega.Checked == false && ckbxLectura.Checked == false && ckbxAdmin.Checked == false)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Debe seleccionar un rol";
            }
            else
            {
            try
            {
                var rolselected = "";
                if (ckbxAdmin.Checked)
                {
                    rolselected = Convert.ToString(1);
                }
                else if (ckbxBodega.Checked)
                {
                    rolselected = Convert.ToString(2);
                }
                else
                {
                    rolselected = Convert.ToString(3);
                }
                var usuario = new DATOS.Usuario
                {
                    //id_usuario = Convert.ToInt32(txtIdUsuario.Text),
                    cedula = txtCedula.Text,
                    nombre = txtNombre.Text,
                    apellido1 = txtApellido1.Text,
                    apellido2 = txtApellido2.Text,
                    nombre_usuario = txtUser.Text,
                    clave = txtClave.Text,
                    rol = rolselected,
                };
                IUsuario iUsuario = new BL.Clases.MUsuario();
                iUsuario.InsertarUsuario(usuario);
                mensaje.Visible = true;
                mensajeError.Visible = false;
                textoMensaje.InnerHtml = "Usuario ingresado correctamente";
                textoMensajeError.InnerHtml = string.Empty;
                txtApellido1.Text =  string.Empty;
                txtApellido2.Text = string.Empty;
                txtCedula.Text = string.Empty;
                txtClave.Text = string.Empty;
                //txtIdUsuario.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtUser.Text = string.Empty;
                ckbxAdmin.Checked = false;
                ckbxBodega.Checked = false;
                ckbxLectura.Checked = false;
                txtCedula.Focus();
            }
            catch 
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Usuario no ingresado";
            }
           }
        }
    }
}