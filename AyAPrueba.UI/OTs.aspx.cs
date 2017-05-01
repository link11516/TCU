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
    public partial class OTs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string valor = string.Concat(Request.QueryString["id"]);
                int valorInt = Convert.ToInt32(valor);
                try
                {
                    IOrdenTrabajo iOrdenTrabajo = new AyAPrueba.BL.Clases.MOrdenTrabajo();
                    var editarorder = iOrdenTrabajo.BuscarOT(valorInt);
                    if (editarorder.id_orden == valorInt)
                    {
                        IUsuario iUsua = new MUsuario();
                        var usuari = iUsua.BuscarUsuarioXid(editarorder.id_usuario);
                
                        lblID.Text = Convert.ToString(editarorder.id_orden);
                        lblFechaCreacion.Text = editarorder.fecha_solicitud;
                        lblSolicitante.Text = usuari.nombre + " " + usuari.apellido1 + " " + usuari.apellido2;
                        lblLugar.Text = editarorder.lugar;
                        lblJustificacion.Text = editarorder.justificacion_aprovacion;
                        if (editarorder.estado == "ABIERTO")
                        {
                            ckbxAbierto.Checked = true;
                            ckbxCerrado.Checked = false;
                        }
                        else if (editarorder.estado == "CERRADO")
                        {
                            ckbxAbierto.Checked = false;
                            ckbxCerrado.Checked = true;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        protected void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            string codOT = string.Concat(Request.QueryString["id"]);
            Response.Redirect(string.Concat("~/AgregarPedido.aspx?id=", codOT));
        }
    }
}