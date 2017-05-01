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
    public partial class Inventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IUsuario iUsuario = new MUsuario();
            dgvUsuarios.DataSource = iUsuario.ListarUsuario();
            dgvUsuarios.DataBind();
            dgvUsuarios.HeaderRow.Cells[2].Text = "ID";
            dgvUsuarios.HeaderRow.Cells[3].Text = "Cédula";
            dgvUsuarios.HeaderRow.Cells[4].Text = "Nombre";
            dgvUsuarios.HeaderRow.Cells[5].Text = "Primer apellido";
            dgvUsuarios.HeaderRow.Cells[6].Text = "Segundo apellido";
            dgvUsuarios.HeaderRow.Cells[7].Text = "Nombre de Usuario";
            dgvUsuarios.HeaderRow.Cells[8].Text = "Clave";
            dgvUsuarios.HeaderRow.Cells[9].Text = "Rol";
        }

        //protected void dgvUsuarios_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        //{
        //    int idUser = Convert.ToInt32(dgvUsuarios.DataKeys[e.NewSelectedIndex].Value);
        //    Response.Redirect(string.Format("~/EditarUsuario.aspx?id={2}", idUser));
        //}

        protected void dgvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int idUser = Convert.ToInt32(dgvUsuarios.DataKeys[e.NewEditIndex].Value);
            Response.Redirect(string.Concat("~/EditarUsuario.aspx?id=", idUser));
        }

        protected void dgvUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int idUser = Convert.ToInt32(dgvUsuarios.DataKeys[e.RowIndex].Value);
                IUsuario iUsuario = new BL.Clases.MUsuario();
                iUsuario.EliminarUsuario(idUser);
                dgvUsuarios.DataSource = iUsuario.ListarUsuario();
                dgvUsuarios.DataBind();

                mensaje.Visible = true;
                mensajeError.Visible = false;
                textoMensaje.InnerHtml = "Usuario eliminado correctamente";
                textoMensajeError.InnerHtml = string.Empty;

            }
            catch (Exception)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Usuario no borrado";
            }
            
        }
    }
}