using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AyAPrueba.BL.Interfaces;
using AyAPrueba.BL.Clases;

namespace AyAPrueba.UI
{
    public partial class ListaMat : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IMateriales iMateriales = new MMaterial();

            if (Session["SesRol"] != null)
            {
                var rol = Session["SesRol"];
                if (Convert.ToInt32(rol) == 1)
                {
                    dgvCodMat.Visible = true;
                    dgvCodMatLectura.Visible = false;
                    dgvCodMat.DataSource = iMateriales.ListarMaterial();
                    dgvCodMat.DataBind();
                    dgvCodMat.HeaderRow.Cells[2].Text = "Código";
                    dgvCodMat.HeaderRow.Cells[3].Text = "Descripción";
                    dgvCodMat.HeaderRow.Cells[4].Text = "Cantidad";
                    dgvCodMat.HeaderRow.Cells[5].Text = "Unidad del artículo";
                }
                if (Convert.ToInt32(rol) == 2 | Convert.ToInt32(rol) == 3)
                {
                    dgvCodMat.Visible = false;
                    dgvCodMatLectura.Visible = true;
                    dgvCodMatLectura.DataSource = iMateriales.ListarMaterial();
                    dgvCodMatLectura.DataBind();
                    dgvCodMatLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodMatLectura.HeaderRow.Cells[1].Text = "Descripción";
                    dgvCodMatLectura.HeaderRow.Cells[2].Text = "Cantidad";
                    dgvCodMatLectura.HeaderRow.Cells[3].Text = "Unidad del artículo";
                }
            }
        }

        protected void dgvCodMat_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string codMat = Convert.ToString(dgvCodMat.DataKeys[e.RowIndex].Value);
                IMateriales iMaterial = new BL.Clases.MMaterial();
                iMaterial.EliminarMaterial(codMat);
                dgvCodMat.DataSource = iMaterial.ListarMaterial();
                dgvCodMat.DataBind();

                mensaje.Visible = true;
                mensajeError.Visible = false;
                textoMensaje.InnerHtml = "Codigo eliminado correctamente";
                textoMensajeError.InnerHtml = string.Empty;

            }
            catch (Exception)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Codigo no eliminado";
            }
        }

        protected void dgvCodMat_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string codMat = Convert.ToString(dgvCodMat.DataKeys[e.NewEditIndex].Value);
            Response.Redirect(string.Concat("~/EditarMat.aspx?id=", codMat));
        }
    }
}