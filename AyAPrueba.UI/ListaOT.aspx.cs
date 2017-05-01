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
    public partial class ListaOT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IOrdenTrabajo iOrdenTrabajo = new MOrdenTrabajo();
            //dgvListaOT.Visible = true;
            //dgvListaOT.Visible = false;
            dgvListaOT.DataSource = iOrdenTrabajo.ListarOT();
            dgvListaOT.DataBind();
            dgvListaOT.HeaderRow.Cells[1].Text = "ID";
            dgvListaOT.HeaderRow.Cells[2].Text = "Creación";
            dgvListaOT.HeaderRow.Cells[3].Text = "ID del Solicitante";
            dgvListaOT.HeaderRow.Cells[4].Text = "Estado";
            dgvListaOT.HeaderRow.Cells[5].Text = "Lugar";
            dgvListaOT.HeaderRow.Cells[6].Text = "Justificación";
        }

        protected void dgvListaOT_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int idOT = Convert.ToInt32(dgvListaOT.DataKeys[e.NewEditIndex].Value);
            Response.Redirect(string.Concat("~/OTs.aspx?id=", idOT));
        }
    }
}