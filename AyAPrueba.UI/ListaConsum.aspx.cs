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
    public partial class ListaConsum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var nombre = Session["SesNombre"];
            lblNombreUsuario.Text = Convert.ToString(nombre);
            IConsumible iConsumible = new MConsumible();
            if (Session["SesRol"] != null)
            {
                var rol = Session["SesRol"];
                if (Convert.ToInt32(rol) == 1)
                {
                    dgvCodConsu.Visible = true;
                    dgvCodConsuLectura.Visible = false;
                    dgvCodConsu.DataSource = iConsumible.ListarConsumible();
                    dgvCodConsu.DataBind();
                    dgvCodConsu.HeaderRow.Cells[2].Text = "Código";
                    dgvCodConsu.HeaderRow.Cells[3].Text = "Modelo";
                    dgvCodConsu.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodConsu.HeaderRow.Cells[5].Text = "Rendimiento";
                    dgvCodConsu.HeaderRow.Cells[6].Text = "Impresoras";
                    dgvCodConsu.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodConsu.HeaderRow.Cells[8].Text = "Marca";
                    dgvCodConsu.HeaderRow.Cells[9].Text = "Color";
                    dgvCodConsu.HeaderRow.Cells[10].Text = "Cantidad";
                    dgvCodConsu.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (Convert.ToInt32(rol) == 2 | Convert.ToInt32(rol) == 3)
                {
                    dgvCodConsu.Visible = false;
                    dgvCodConsuLectura.Visible = true;
                    dgvCodConsuLectura.DataSource = iConsumible.ListarConsumible();
                    dgvCodConsuLectura.DataBind();
                    dgvCodConsuLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodConsuLectura.HeaderRow.Cells[1].Text = "Modelo";
                    dgvCodConsuLectura.HeaderRow.Cells[2].Text = "Tipo";
                    dgvCodConsuLectura.HeaderRow.Cells[3].Text = "Rendimiento";
                    dgvCodConsuLectura.HeaderRow.Cells[4].Text = "Impresoras";
                    dgvCodConsuLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodConsuLectura.HeaderRow.Cells[6].Text = "Marca";
                    dgvCodConsuLectura.HeaderRow.Cells[7].Text = "Color";
                    dgvCodConsuLectura.HeaderRow.Cells[8].Text = "Cantidad";
                    dgvCodConsuLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }

            if (!IsPostBack)
            {
                List<string> opciones = new List<string>
            {
                "Todas las marcas",
                "Canon",
                "Epson",
                "HP",
                "Lexmark",
                "Kyocera"
            };                
                ddlMarcas.DataSource = opciones;
                ddlMarcas.DataBind();
            }
        }


        protected void dgvCodConsu_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string codCon = Convert.ToString(dgvCodConsu.DataKeys[e.RowIndex].Value);
                IConsumible iConsumible = new BL.Clases.MConsumible();
                iConsumible.EliminarConsumible(codCon);
                dgvCodConsu.DataSource = iConsumible.ListarConsumible();
                dgvCodConsu.DataBind();

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

        protected void dgvCodConsu_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string codCon = Convert.ToString(dgvCodConsu.DataKeys[e.NewEditIndex].Value);
            Response.Redirect(string.Concat("~/EditarConsum.aspx?id=", codCon));
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            IConsumible iConsumible = new MConsumible();
            var rol = Session["SesRol"];
            if (Convert.ToInt32(rol) == 1)
            {
                if (ddlMarcas.SelectedValue == "HP")
                {
                    dgvCodConsu.DataSource = iConsumible.ListarConsumibleHP();
                    dgvCodConsu.DataBind();
                    dgvCodConsu.HeaderRow.Cells[2].Text = "Código";
                    dgvCodConsu.HeaderRow.Cells[3].Text = "Modelo";
                    dgvCodConsu.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodConsu.HeaderRow.Cells[5].Text = "Rendimiento";
                    dgvCodConsu.HeaderRow.Cells[6].Text = "Impresoras";
                    dgvCodConsu.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodConsu.HeaderRow.Cells[8].Text = "Marca";
                    dgvCodConsu.HeaderRow.Cells[9].Text = "Color";
                    dgvCodConsu.HeaderRow.Cells[10].Text = "Cantidad";
                    dgvCodConsu.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Lexmark")
                {
                    dgvCodConsu.DataSource = iConsumible.ListarConsumibleLexmark();
                    dgvCodConsu.DataBind();
                    dgvCodConsu.HeaderRow.Cells[2].Text = "Código";
                    dgvCodConsu.HeaderRow.Cells[3].Text = "Modelo";
                    dgvCodConsu.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodConsu.HeaderRow.Cells[5].Text = "Rendimiento";
                    dgvCodConsu.HeaderRow.Cells[6].Text = "Impresoras";
                    dgvCodConsu.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodConsu.HeaderRow.Cells[8].Text = "Marca";
                    dgvCodConsu.HeaderRow.Cells[9].Text = "Color";
                    dgvCodConsu.HeaderRow.Cells[10].Text = "Cantidad";
                    dgvCodConsu.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Canon")
                {
                    dgvCodConsu.DataSource = iConsumible.ListarConsumibleCanon();
                    dgvCodConsu.DataBind();
                    dgvCodConsu.HeaderRow.Cells[2].Text = "Código";
                    dgvCodConsu.HeaderRow.Cells[3].Text = "Modelo";
                    dgvCodConsu.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodConsu.HeaderRow.Cells[5].Text = "Rendimiento";
                    dgvCodConsu.HeaderRow.Cells[6].Text = "Impresoras";
                    dgvCodConsu.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodConsu.HeaderRow.Cells[8].Text = "Marca";
                    dgvCodConsu.HeaderRow.Cells[9].Text = "Color";
                    dgvCodConsu.HeaderRow.Cells[10].Text = "Cantidad";
                    dgvCodConsu.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Epson")
                {
                    dgvCodConsu.DataSource = iConsumible.ListarConsumibleEpson();
                    dgvCodConsu.DataBind();
                    dgvCodConsu.HeaderRow.Cells[2].Text = "Código";
                    dgvCodConsu.HeaderRow.Cells[3].Text = "Modelo";
                    dgvCodConsu.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodConsu.HeaderRow.Cells[5].Text = "Rendimiento";
                    dgvCodConsu.HeaderRow.Cells[6].Text = "Impresoras";
                    dgvCodConsu.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodConsu.HeaderRow.Cells[8].Text = "Marca";
                    dgvCodConsu.HeaderRow.Cells[9].Text = "Color";
                    dgvCodConsu.HeaderRow.Cells[10].Text = "Cantidad";
                    dgvCodConsu.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Kyocera")
                {
                    dgvCodConsu.DataSource = iConsumible.ListarConsumibleKyocera();
                    dgvCodConsu.DataBind();
                    dgvCodConsu.HeaderRow.Cells[2].Text = "Código";
                    dgvCodConsu.HeaderRow.Cells[3].Text = "Modelo";
                    dgvCodConsu.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodConsu.HeaderRow.Cells[5].Text = "Rendimiento";
                    dgvCodConsu.HeaderRow.Cells[6].Text = "Impresoras";
                    dgvCodConsu.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodConsu.HeaderRow.Cells[8].Text = "Marca";
                    dgvCodConsu.HeaderRow.Cells[9].Text = "Color";
                    dgvCodConsu.HeaderRow.Cells[10].Text = "Cantidad";
                    dgvCodConsu.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Todas las marcas")
                {
                    dgvCodConsu.DataSource = iConsumible.ListarConsumible();
                    dgvCodConsu.DataBind();
                    dgvCodConsu.HeaderRow.Cells[2].Text = "Código";
                    dgvCodConsu.HeaderRow.Cells[3].Text = "Modelo";
                    dgvCodConsu.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodConsu.HeaderRow.Cells[5].Text = "Rendimiento";
                    dgvCodConsu.HeaderRow.Cells[6].Text = "Impresoras";
                    dgvCodConsu.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodConsu.HeaderRow.Cells[8].Text = "Marca";
                    dgvCodConsu.HeaderRow.Cells[9].Text = "Color";
                    dgvCodConsu.HeaderRow.Cells[10].Text = "Cantidad";
                    dgvCodConsu.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
            }
            if (Convert.ToInt32(rol) == 2 | Convert.ToInt32(rol) == 3)
            {
                if (ddlMarcas.SelectedValue == "HP")
                {
                    dgvCodConsuLectura.DataSource = iConsumible.ListarConsumibleHP();
                    dgvCodConsuLectura.DataBind();
                    dgvCodConsuLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodConsuLectura.HeaderRow.Cells[1].Text = "Modelo";
                    dgvCodConsuLectura.HeaderRow.Cells[2].Text = "Tipo";
                    dgvCodConsuLectura.HeaderRow.Cells[3].Text = "Rendimiento";
                    dgvCodConsuLectura.HeaderRow.Cells[4].Text = "Impresoras";
                    dgvCodConsuLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodConsuLectura.HeaderRow.Cells[6].Text = "Marca";
                    dgvCodConsuLectura.HeaderRow.Cells[7].Text = "Color";
                    dgvCodConsuLectura.HeaderRow.Cells[8].Text = "Cantidad";
                    dgvCodConsuLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Lexmark")
                {
                    dgvCodConsuLectura.DataSource = iConsumible.ListarConsumibleLexmark();
                    dgvCodConsuLectura.DataBind();
                    dgvCodConsuLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodConsuLectura.HeaderRow.Cells[1].Text = "Modelo";
                    dgvCodConsuLectura.HeaderRow.Cells[2].Text = "Tipo";
                    dgvCodConsuLectura.HeaderRow.Cells[3].Text = "Rendimiento";
                    dgvCodConsuLectura.HeaderRow.Cells[4].Text = "Impresoras";
                    dgvCodConsuLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodConsuLectura.HeaderRow.Cells[6].Text = "Marca";
                    dgvCodConsuLectura.HeaderRow.Cells[7].Text = "Color";
                    dgvCodConsuLectura.HeaderRow.Cells[8].Text = "Cantidad";
                    dgvCodConsuLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Canon")
                {
                    dgvCodConsuLectura.DataSource = iConsumible.ListarConsumibleCanon();
                    dgvCodConsuLectura.DataBind();
                    dgvCodConsuLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodConsuLectura.HeaderRow.Cells[1].Text = "Modelo";
                    dgvCodConsuLectura.HeaderRow.Cells[2].Text = "Tipo";
                    dgvCodConsuLectura.HeaderRow.Cells[3].Text = "Rendimiento";
                    dgvCodConsuLectura.HeaderRow.Cells[4].Text = "Impresoras";
                    dgvCodConsuLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodConsuLectura.HeaderRow.Cells[6].Text = "Marca";
                    dgvCodConsuLectura.HeaderRow.Cells[7].Text = "Color";
                    dgvCodConsuLectura.HeaderRow.Cells[8].Text = "Cantidad";
                    dgvCodConsuLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Epson")
                {
                    dgvCodConsuLectura.DataSource = iConsumible.ListarConsumibleEpson();
                    dgvCodConsuLectura.DataBind();
                    dgvCodConsuLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodConsuLectura.HeaderRow.Cells[1].Text = "Modelo";
                    dgvCodConsuLectura.HeaderRow.Cells[2].Text = "Tipo";
                    dgvCodConsuLectura.HeaderRow.Cells[3].Text = "Rendimiento";
                    dgvCodConsuLectura.HeaderRow.Cells[4].Text = "Impresoras";
                    dgvCodConsuLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodConsuLectura.HeaderRow.Cells[6].Text = "Marca";
                    dgvCodConsuLectura.HeaderRow.Cells[7].Text = "Color";
                    dgvCodConsuLectura.HeaderRow.Cells[8].Text = "Cantidad";
                    dgvCodConsuLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Kyocera")
                {
                    dgvCodConsuLectura.DataSource = iConsumible.ListarConsumibleKyocera();
                    dgvCodConsuLectura.DataBind();
                    dgvCodConsuLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodConsuLectura.HeaderRow.Cells[1].Text = "Modelo";
                    dgvCodConsuLectura.HeaderRow.Cells[2].Text = "Tipo";
                    dgvCodConsuLectura.HeaderRow.Cells[3].Text = "Rendimiento";
                    dgvCodConsuLectura.HeaderRow.Cells[4].Text = "Impresoras";
                    dgvCodConsuLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodConsuLectura.HeaderRow.Cells[6].Text = "Marca";
                    dgvCodConsuLectura.HeaderRow.Cells[7].Text = "Color";
                    dgvCodConsuLectura.HeaderRow.Cells[8].Text = "Cantidad";
                    dgvCodConsuLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Todas las marcas")
                {
                    dgvCodConsuLectura.DataSource = iConsumible.ListarConsumible();
                    dgvCodConsuLectura.DataBind();
                    dgvCodConsuLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodConsuLectura.HeaderRow.Cells[1].Text = "Modelo";
                    dgvCodConsuLectura.HeaderRow.Cells[2].Text = "Tipo";
                    dgvCodConsuLectura.HeaderRow.Cells[3].Text = "Rendimiento";
                    dgvCodConsuLectura.HeaderRow.Cells[4].Text = "Impresoras";
                    dgvCodConsuLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodConsuLectura.HeaderRow.Cells[6].Text = "Marca";
                    dgvCodConsuLectura.HeaderRow.Cells[7].Text = "Color";
                    dgvCodConsuLectura.HeaderRow.Cells[8].Text = "Cantidad";
                    dgvCodConsuLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
            }
            
            
        }


    }
}