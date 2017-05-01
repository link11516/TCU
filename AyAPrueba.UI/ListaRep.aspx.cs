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
    public partial class ListaRep : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IRepuesto iRepuesto = new MRepuesto();

            if (Session["SesRol"] != null)
            {
                var rol = Session["SesRol"];
                if (Convert.ToInt32(rol) == 1)
                {
                    dgvCodRep.Visible = true;
                    dgvCodRepLectura.Visible = false;
                    dgvCodRep.DataSource = iRepuesto.ListarRepuesto();
                    dgvCodRep.DataBind();
                    dgvCodRep.HeaderRow.Cells[2].Text = "Código";
                    dgvCodRep.HeaderRow.Cells[3].Text = "Marca";
                    dgvCodRep.HeaderRow.Cells[4].Text = "Modelo";
                    dgvCodRep.HeaderRow.Cells[5].Text = "Impresoras";
                    dgvCodRep.HeaderRow.Cells[6].Text = "Tipo";
                    dgvCodRep.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodRep.HeaderRow.Cells[8].Text = "Nuevos";
                    dgvCodRep.HeaderRow.Cells[9].Text = "Usados";
                    dgvCodRep.HeaderRow.Cells[10].Text = "Cantidad total";
                    dgvCodRep.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (Convert.ToInt32(rol) == 2 | Convert.ToInt32(rol) == 3)
                {
                    dgvCodRep.Visible = false;
                    dgvCodRepLectura.Visible = true;
                    dgvCodRepLectura.DataSource = iRepuesto.ListarRepuesto();
                    dgvCodRepLectura.DataBind();
                    dgvCodRepLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodRepLectura.HeaderRow.Cells[1].Text = "Marca";
                    dgvCodRepLectura.HeaderRow.Cells[2].Text = "Modelo";
                    dgvCodRepLectura.HeaderRow.Cells[3].Text = "Impresoras";
                    dgvCodRepLectura.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodRepLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodRepLectura.HeaderRow.Cells[6].Text = "Nuevos";
                    dgvCodRepLectura.HeaderRow.Cells[7].Text = "Usados";
                    dgvCodRepLectura.HeaderRow.Cells[8].Text = "Cantidad total";
                    dgvCodRepLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
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

        protected void dgvCodRep_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string codRep = Convert.ToString(dgvCodRep.DataKeys[e.RowIndex].Value);
                IRepuesto iRepuesto = new BL.Clases.MRepuesto();
                iRepuesto.EliminarRepuesto(codRep);
                dgvCodRep.DataSource = iRepuesto.ListarRepuesto();
                dgvCodRep.DataBind();

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

        protected void dgvCodRep_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string codRep = Convert.ToString(dgvCodRep.DataKeys[e.NewEditIndex].Value);
            Response.Redirect(string.Concat("~/EditarRep.aspx?id=", codRep));
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            IRepuesto iRepuesto = new MRepuesto();
            var rol = Session["SesRol"];
            if (Convert.ToInt32(rol) == 1)
            {
                if (ddlMarcas.SelectedValue == "HP")
                {
                    dgvCodRep.DataSource = iRepuesto.ListarRepuestoHP();
                    dgvCodRep.DataBind();
                    dgvCodRep.HeaderRow.Cells[2].Text = "Código";
                    dgvCodRep.HeaderRow.Cells[3].Text = "Marca";
                    dgvCodRep.HeaderRow.Cells[4].Text = "Modelo";
                    dgvCodRep.HeaderRow.Cells[5].Text = "Impresoras";
                    dgvCodRep.HeaderRow.Cells[6].Text = "Tipo";
                    dgvCodRep.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodRep.HeaderRow.Cells[8].Text = "Nuevos";
                    dgvCodRep.HeaderRow.Cells[9].Text = "Usados";
                    dgvCodRep.HeaderRow.Cells[10].Text = "Cantidad total";
                    dgvCodRep.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Lexmark")
                {
                    dgvCodRep.DataSource = iRepuesto.ListarRepuestoLexmark();
                    dgvCodRep.DataBind();
                    dgvCodRep.HeaderRow.Cells[2].Text = "Código";
                    dgvCodRep.HeaderRow.Cells[3].Text = "Marca";
                    dgvCodRep.HeaderRow.Cells[4].Text = "Modelo";
                    dgvCodRep.HeaderRow.Cells[5].Text = "Impresoras";
                    dgvCodRep.HeaderRow.Cells[6].Text = "Tipo";
                    dgvCodRep.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodRep.HeaderRow.Cells[8].Text = "Nuevos";
                    dgvCodRep.HeaderRow.Cells[9].Text = "Usados";
                    dgvCodRep.HeaderRow.Cells[10].Text = "Cantidad total";
                    dgvCodRep.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Canon")
                {
                    dgvCodRep.DataSource = iRepuesto.ListarRepuestoCanon();
                    dgvCodRep.DataBind();
                    dgvCodRep.HeaderRow.Cells[2].Text = "Código";
                    dgvCodRep.HeaderRow.Cells[3].Text = "Marca";
                    dgvCodRep.HeaderRow.Cells[4].Text = "Modelo";
                    dgvCodRep.HeaderRow.Cells[5].Text = "Impresoras";
                    dgvCodRep.HeaderRow.Cells[6].Text = "Tipo";
                    dgvCodRep.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodRep.HeaderRow.Cells[8].Text = "Nuevos";
                    dgvCodRep.HeaderRow.Cells[9].Text = "Usados";
                    dgvCodRep.HeaderRow.Cells[10].Text = "Cantidad total";
                    dgvCodRep.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Epson")
                {
                    dgvCodRep.DataSource = iRepuesto.ListarRepuestoEpson();
                    dgvCodRep.DataBind();
                    dgvCodRep.HeaderRow.Cells[2].Text = "Código";
                    dgvCodRep.HeaderRow.Cells[3].Text = "Marca";
                    dgvCodRep.HeaderRow.Cells[4].Text = "Modelo";
                    dgvCodRep.HeaderRow.Cells[5].Text = "Impresoras";
                    dgvCodRep.HeaderRow.Cells[6].Text = "Tipo";
                    dgvCodRep.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodRep.HeaderRow.Cells[8].Text = "Nuevos";
                    dgvCodRep.HeaderRow.Cells[9].Text = "Usados";
                    dgvCodRep.HeaderRow.Cells[10].Text = "Cantidad total";
                    dgvCodRep.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Kyocera")
                {
                    dgvCodRep.DataSource = iRepuesto.ListarRepuestoKyocera();
                    dgvCodRep.DataBind();
                    dgvCodRep.HeaderRow.Cells[2].Text = "Código";
                    dgvCodRep.HeaderRow.Cells[3].Text = "Marca";
                    dgvCodRep.HeaderRow.Cells[4].Text = "Modelo";
                    dgvCodRep.HeaderRow.Cells[5].Text = "Impresoras";
                    dgvCodRep.HeaderRow.Cells[6].Text = "Tipo";
                    dgvCodRep.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodRep.HeaderRow.Cells[8].Text = "Nuevos";
                    dgvCodRep.HeaderRow.Cells[9].Text = "Usados";
                    dgvCodRep.HeaderRow.Cells[10].Text = "Cantidad total";
                    dgvCodRep.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Todas las marcas")
                {
                    dgvCodRep.DataSource = iRepuesto.ListarRepuesto();
                    dgvCodRep.DataBind();
                    dgvCodRep.HeaderRow.Cells[2].Text = "Código";
                    dgvCodRep.HeaderRow.Cells[3].Text = "Marca";
                    dgvCodRep.HeaderRow.Cells[4].Text = "Modelo";
                    dgvCodRep.HeaderRow.Cells[5].Text = "Impresoras";
                    dgvCodRep.HeaderRow.Cells[6].Text = "Tipo";
                    dgvCodRep.HeaderRow.Cells[7].Text = "Descripción";
                    dgvCodRep.HeaderRow.Cells[8].Text = "Nuevos";
                    dgvCodRep.HeaderRow.Cells[9].Text = "Usados";
                    dgvCodRep.HeaderRow.Cells[10].Text = "Cantidad total";
                    dgvCodRep.HeaderRow.Cells[11].Text = "Unidad del artículo";
                }
            }
            if (Convert.ToInt32(rol) == 2 | Convert.ToInt32(rol) == 3)
            {
                if (ddlMarcas.SelectedValue == "HP")
                {
                    dgvCodRepLectura.DataSource = iRepuesto.ListarRepuestoHP();
                    dgvCodRepLectura.DataBind();
                    dgvCodRepLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodRepLectura.HeaderRow.Cells[1].Text = "Marca";
                    dgvCodRepLectura.HeaderRow.Cells[2].Text = "Modelo";
                    dgvCodRepLectura.HeaderRow.Cells[3].Text = "Impresoras";
                    dgvCodRepLectura.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodRepLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodRepLectura.HeaderRow.Cells[6].Text = "Nuevos";
                    dgvCodRepLectura.HeaderRow.Cells[7].Text = "Usados";
                    dgvCodRepLectura.HeaderRow.Cells[8].Text = "Cantidad total";
                    dgvCodRepLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Lexmark")
                {
                    dgvCodRepLectura.DataSource = iRepuesto.ListarRepuestoLexmark();
                    dgvCodRepLectura.DataBind();
                    dgvCodRepLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodRepLectura.HeaderRow.Cells[1].Text = "Marca";
                    dgvCodRepLectura.HeaderRow.Cells[2].Text = "Modelo";
                    dgvCodRepLectura.HeaderRow.Cells[3].Text = "Impresoras";
                    dgvCodRepLectura.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodRepLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodRepLectura.HeaderRow.Cells[6].Text = "Nuevos";
                    dgvCodRepLectura.HeaderRow.Cells[7].Text = "Usados";
                    dgvCodRepLectura.HeaderRow.Cells[8].Text = "Cantidad total";
                    dgvCodRepLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Canon")
                {
                    dgvCodRepLectura.DataSource = iRepuesto.ListarRepuestoCanon();
                    dgvCodRepLectura.DataBind();
                    dgvCodRepLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodRepLectura.HeaderRow.Cells[1].Text = "Marca";
                    dgvCodRepLectura.HeaderRow.Cells[2].Text = "Modelo";
                    dgvCodRepLectura.HeaderRow.Cells[3].Text = "Impresoras";
                    dgvCodRepLectura.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodRepLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodRepLectura.HeaderRow.Cells[6].Text = "Nuevos";
                    dgvCodRepLectura.HeaderRow.Cells[7].Text = "Usados";
                    dgvCodRepLectura.HeaderRow.Cells[8].Text = "Cantidad total";
                    dgvCodRepLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Epson")
                {
                    dgvCodRepLectura.DataSource = iRepuesto.ListarRepuestoEpson();
                    dgvCodRepLectura.DataBind();
                    dgvCodRepLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodRepLectura.HeaderRow.Cells[1].Text = "Marca";
                    dgvCodRepLectura.HeaderRow.Cells[2].Text = "Modelo";
                    dgvCodRepLectura.HeaderRow.Cells[3].Text = "Impresoras";
                    dgvCodRepLectura.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodRepLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodRepLectura.HeaderRow.Cells[6].Text = "Nuevos";
                    dgvCodRepLectura.HeaderRow.Cells[7].Text = "Usados";
                    dgvCodRepLectura.HeaderRow.Cells[8].Text = "Cantidad total";
                    dgvCodRepLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Kyocera")
                {
                    dgvCodRepLectura.DataSource = iRepuesto.ListarRepuestoKyocera();
                    dgvCodRepLectura.DataBind();
                    dgvCodRepLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodRepLectura.HeaderRow.Cells[1].Text = "Marca";
                    dgvCodRepLectura.HeaderRow.Cells[2].Text = "Modelo";
                    dgvCodRepLectura.HeaderRow.Cells[3].Text = "Impresoras";
                    dgvCodRepLectura.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodRepLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodRepLectura.HeaderRow.Cells[6].Text = "Nuevos";
                    dgvCodRepLectura.HeaderRow.Cells[7].Text = "Usados";
                    dgvCodRepLectura.HeaderRow.Cells[8].Text = "Cantidad total";
                    dgvCodRepLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
                if (ddlMarcas.SelectedValue == "Todas las marcas")
                {
                    dgvCodRepLectura.DataSource = iRepuesto.ListarRepuesto();
                    dgvCodRepLectura.DataBind();
                    dgvCodRepLectura.HeaderRow.Cells[0].Text = "Código";
                    dgvCodRepLectura.HeaderRow.Cells[1].Text = "Marca";
                    dgvCodRepLectura.HeaderRow.Cells[2].Text = "Modelo";
                    dgvCodRepLectura.HeaderRow.Cells[3].Text = "Impresoras";
                    dgvCodRepLectura.HeaderRow.Cells[4].Text = "Tipo";
                    dgvCodRepLectura.HeaderRow.Cells[5].Text = "Descripción";
                    dgvCodRepLectura.HeaderRow.Cells[6].Text = "Nuevos";
                    dgvCodRepLectura.HeaderRow.Cells[7].Text = "Usados";
                    dgvCodRepLectura.HeaderRow.Cells[8].Text = "Cantidad total";
                    dgvCodRepLectura.HeaderRow.Cells[9].Text = "Unidad del artículo";
                }
            }
        }
    }
}