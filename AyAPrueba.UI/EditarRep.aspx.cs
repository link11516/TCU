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
    public partial class EditarRep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigorep.ReadOnly = true;
            if (!Page.IsPostBack)
            {
                string valor = string.Concat(Request.QueryString["id"]);

                IRepuesto iRepuesto = new AyAPrueba.BL.Clases.MRepuesto();
                var editarrepu = iRepuesto.BuscarRepuestoXcodigo(valor);
                try
                {
                    if (editarrepu.codigo_rep == valor)
                    {
                        txtCodigorep.Text = editarrepu.codigo_rep;
                        
                        txtModelo.Text = editarrepu.modelo;
                        txtTipo.Text = editarrepu.tipo;
                        txtImpresoras.Text = editarrepu.impresoras;
                        txtDescrip.Text = editarrepu.descripcion;
                        txtMarca.Text = editarrepu.marca;
                        txtCantidadN.Text = Convert.ToString(editarrepu.cantidad_nuevos);
                        txtCantidadU.Text = Convert.ToString(editarrepu.cantidad_viejos);
                        txtUnidad.Text = editarrepu.unidad;
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
                IRepuesto iRep = new MRepuesto();
                DATOS.Repuesto repuesto = new DATOS.Repuesto
                {
                    codigo_rep = txtCodigorep.Text.ToUpper(),
                    modelo = txtModelo.Text.ToUpper(),
                    tipo = txtTipo.Text.ToUpper(),
                    impresoras = txtImpresoras.Text.ToUpper(),
                    descripcion = txtDescrip.Text.ToUpper(),
                    marca = txtMarca.Text.ToUpper(),
                    cantidad_nuevos = Convert.ToInt32(txtCantidadN.Text),
                    cantidad_viejos = Convert.ToInt32(txtCantidadU.Text),
                    cantidad_total = Convert.ToInt32(txtCantidadN.Text) + Convert.ToInt32(txtCantidadU.Text),
                    unidad = txtUnidad.Text.ToUpper(),
                };
                iRep.ActualizarRepuesto(repuesto);
                mensaje.Visible = true;
                mensajeError.Visible = false;
                textoMensaje.InnerHtml = "Repuesto actualizado";
                textoMensajeError.InnerHtml = string.Empty;
            }
            catch (Exception)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Repuesto no actualizado";
            }
        }
    }
}