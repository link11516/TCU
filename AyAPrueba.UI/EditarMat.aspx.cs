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
    public partial class EditarMat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigomat.ReadOnly = true;
            if (!Page.IsPostBack)
            {
                string valor = string.Concat(Request.QueryString["id"]);

                IMateriales iMateriales = new AyAPrueba.BL.Clases.MMaterial();
                var editarmat = iMateriales.BuscarMaterial(valor);
                try
                {
                    if (editarmat.codigo_mat == valor)
                    {
                        txtCodigomat.Text = editarmat.codigo_mat;
                        txtDescrip.Text = editarmat.descripcion;
                        txtCantidad.Text = Convert.ToString(editarmat.cantidad);
                        txtUnidad.Text = editarmat.unidad;
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
            try
            {
                IMateriales iMat = new MMaterial();
                DATOS.Material material = new DATOS.Material
                {
                    codigo_mat = txtCodigomat.Text.ToUpper(),
                    descripcion = txtDescrip.Text.ToUpper(),
                    cantidad = Convert.ToInt32(txtCantidad.Text),
                    unidad = txtUnidad.Text.ToUpper(),
                };
                iMat.ActualizarMaterial(material);
                mensaje.Visible = true;
                mensajeError.Visible = false;
                textoMensaje.InnerHtml = "Material actualizado";
                textoMensajeError.InnerHtml = string.Empty;
            }
            catch (Exception)
            {
                
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Material no actualizado";
            }
        }
    }
}