using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AyAPrueba.BL.Interfaces;
using AyAPrueba.BL.Clases;
using System.IO;

namespace AyAPrueba.UI
{
    public partial class EditarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string valor = string.Concat(Request.QueryString["id"]);
                int valorInt = Convert.ToInt32(valor);
                try
                {
                    IUsuario iUsuario = new AyAPrueba.BL.Clases.MUsuario();
                    var editaruser = iUsuario.BuscarUsuarioXid(valorInt);
                    if (editaruser.id_usuario == valorInt)
                    {
                        txtIdUsuarioE.Text = Convert.ToString(editaruser.id_usuario);
                        txtIdUsuarioE.ReadOnly = true;
                        txtCedulaE.Text = editaruser.cedula;
                        txtNombreE.Text = editaruser.nombre;
                        txtApellido1E.Text = editaruser.apellido1;
                        txtApellido2E.Text = editaruser.apellido2;
                        txtUserE.Text = editaruser.nombre_usuario;
                        txtClaveE.Text = editaruser.clave;
                        if (editaruser.rol == "1")
                        {
                            ckbxAdminE.Checked = true;
                            ckbxBodegaE.Checked = false;
                            ckbxLecturaE.Checked = false;
                        }
                        else if (editaruser.rol == "2")
                        {
                            ckbxAdminE.Checked = false;
                            ckbxBodegaE.Checked = true;
                            ckbxLecturaE.Checked = false;
                        }
                        else if (editaruser.rol == "3")
                        {
                            ckbxAdminE.Checked = false;
                            ckbxBodegaE.Checked = false;
                            ckbxLecturaE.Checked = true;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            
            string id ="", cedu ="", nombree = "", apellidoo1 = "", apellidoo2 = "", nombusuario= "", clavee = "";

            if (ckbxAdminE.Checked == true && ckbxBodegaE.Checked == true)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Solo se admite un rol";
            }
            else if (ckbxAdminE.Checked == true && ckbxLecturaE.Checked == true)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Solo se admite un rol";
            }
            else if (ckbxBodegaE.Checked == true && ckbxLecturaE.Checked == true)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Solo se admite un rol";
            }
            else if (ckbxBodegaE.Checked == true && ckbxLecturaE.Checked == true && ckbxAdminE.Checked == true)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Solo se admite un rol";
            }
            else if (ckbxBodegaE.Checked == false && ckbxLecturaE.Checked == false && ckbxAdminE.Checked == false)
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
                    id = txtIdUsuarioE.Text;
                    cedu = txtCedulaE.Text;
                    nombree = txtNombreE.Text;
                    apellidoo1 = txtApellido1E.Text;
                    apellidoo2 = txtApellido2E.Text;
                    nombusuario = txtUserE.Text;
                    clavee = txtClaveE.Text;
                    
                    var rolselected = "";
                    if (ckbxAdminE.Checked)
                    {
                        rolselected = Convert.ToString(1);
                    }
                    else if (ckbxBodegaE.Checked)
                    {
                        rolselected = Convert.ToString(2);
                    }
                    else
                    {
                        rolselected = Convert.ToString(3);
                    }
                    IUsuario iUser = new MUsuario();
                    DATOS.Usuario usuario = new DATOS.Usuario
                    {
                        id_usuario = Convert.ToInt32(id),
                        cedula = cedu,
                        nombre = nombree,
                        apellido1 = apellidoo1,
                        apellido2 = apellidoo2,
                        nombre_usuario = nombusuario,
                        clave = clavee,
                        rol = rolselected,

                    };
                    
                    iUser.ActualizarUsuario(usuario);
                    mensaje.Visible = true;
                    mensajeError.Visible = false;
                    textoMensaje.InnerHtml = "Usuario actualizado";
                    textoMensajeError.InnerHtml = string.Empty;
                }
                catch (Exception)
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensaje.InnerHtml = string.Empty;
                    textoMensajeError.InnerHtml = "Usuario no actualizado";
                }
            }
        }
    }
}