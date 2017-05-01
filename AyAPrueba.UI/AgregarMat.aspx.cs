using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AyAPrueba.BL.Interfaces;
using System.IO;
using AyAPrueba.DATOS;

namespace AyAPrueba.UI
{
    public partial class AgregarMat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SesRol"] != null)
            {
            btnRefrescar.Enabled = false;
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                IMateriales iMateriales = new AyAPrueba.BL.Clases.MMaterial();
                var datos = txtCodigomat.Text.ToUpper();
                var insertarnuevo = iMateriales.BuscarMaterial(datos);
                if (insertarnuevo.codigo_mat == txtCodigomat.Text.ToUpper())
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensaje.InnerHtml = string.Empty;
                    textoMensajeError.InnerHtml = "El código ya existe";
                    txtDescrip.Text = insertarnuevo.descripcion;
                    txtDescrip.ReadOnly = true;
                    txtCantidad.Text = Convert.ToString(insertarnuevo.cantidad);
                    txtCantidad.ReadOnly = true;
                    txtUnidad.Text = insertarnuevo.unidad;
                    txtUnidad.ReadOnly = true;
                    btnInsertar.Enabled = false;
                    btnVerificar.Enabled = false;
                    btnRefrescar.Enabled = true;
                }
            }
            catch (Exception)
            {
                
                mensaje.Visible = true;
                mensajeError.Visible = false;
                textoMensaje.InnerHtml = "El código no existe";
                textoMensajeError.InnerHtml = string.Empty;
            }
        }

        protected void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtCodigomat.Text = string.Empty;
            txtCodigomat.ReadOnly = false;
            txtDescrip.Text = string.Empty; 
            txtDescrip.ReadOnly = false;
            txtUnidad.Text = string.Empty;
            txtUnidad.ReadOnly = false;
            txtCantidad.Text = "0";
            txtCantidad.ReadOnly = false;
            txtCodigomat.Focus();
            btnVerificar.Enabled = true;
            btnInsertar.Enabled = true;
            mensaje.Visible = false;
            mensajeError.Visible = false;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var mat = new DATOS.Material 
                {
                    codigo_mat = txtCodigomat.Text.ToUpper(),
                    cantidad = Convert.ToInt32(txtCantidad.Text),
                    descripcion = txtDescrip.Text.ToUpper(),
                    unidad = txtUnidad.Text.ToUpper(),
                };

                IMateriales iMateriales = new BL.Clases.MMaterial();
                iMateriales.InsertarMaterial(mat);
                txtCodigomat.Text = string.Empty;
                txtDescrip.Text = string.Empty;
                txtUnidad.Text = string.Empty;
                txtCantidad.Text = "0";
                txtCodigomat.Focus();
                mensaje.Visible = true;
                mensajeError.Visible = false;
                textoMensaje.InnerHtml = "Código ingresado correctamente";
                textoMensajeError.InnerHtml = string.Empty;
                mat.Equals(null);
            }
            catch (Exception)
            {
                
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "El código ya existe o faltan datos necesarios";
            }
        }
    }
}