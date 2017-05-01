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
    public partial class EditarConsum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigocons.ReadOnly = true;
            if (!Page.IsPostBack)
            {
                string valor = string.Concat(Request.QueryString["id"]);

                IConsumible iConsumible = new AyAPrueba.BL.Clases.MConsumible();
                var editarconsu = iConsumible.BuscarConsumibleXcodigo(valor);
                try
                {
                    if (editarconsu.codigo_con == valor)
                    {
                        txtCodigocons.Text = editarconsu.codigo_con;
                        
                        txtModelo.Text = editarconsu.modelo;
                        txtTipo.Text = editarconsu.tipo;
                        txtRendimiento.Text = Convert.ToString(editarconsu.rendimiento);
                        txtImpresoras.Text = editarconsu.impresoras;
                        txtDescrip.Text = editarconsu.descripcion;
                        txtMarca.Text = editarconsu.marca;
                        txtColor.Text = editarconsu.color;
                        txtCantidad.Text = Convert.ToString(editarconsu.cantidad_total);
                        txtUnidad.Text = editarconsu.unidad;
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
                IConsumible iCons = new MConsumible();
                DATOS.Consumible consumible = new DATOS.Consumible 
                {
                    codigo_con = txtCodigocons.Text.ToUpper(),
                    modelo = txtModelo.Text.ToUpper(),
                    tipo = txtTipo.Text.ToUpper(),
                    rendimiento = Convert.ToInt32(txtRendimiento.Text),
                    impresoras = txtImpresoras.Text.ToUpper(),
                    descripcion = txtDescrip.Text.ToUpper(),
                    marca = txtMarca.Text.ToUpper(),
                    color = txtColor.Text.ToUpper(),
                    cantidad_total = Convert.ToInt32(txtCantidad.Text),
                    unidad = txtUnidad.Text.ToUpper(),
                };

                iCons.ActualizarConsumible(consumible);
                mensaje.Visible = true;
                mensajeError.Visible = false;
                textoMensaje.InnerHtml = "Consumible actualizado";
                textoMensajeError.InnerHtml = string.Empty;
            }
            catch (Exception)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Consumible no actualizado";
            }
        }
    }
}