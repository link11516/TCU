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
    public partial class AgregarConsum : Page
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

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            //int nuevo = Convert.ToInt32(txtCantidadN.Text);
            //int usado = Convert.ToInt32(txtCantidadU.Text);
            //int total = nuevo + usado;

            
            try
            {
                var consu = new DATOS.Consumible
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

                IConsumible iConsumible = new BL.Clases.MConsumible();
                iConsumible.InsertarConsumible(consu);
                mensaje.Visible = true;
                mensajeError.Visible = false;
                textoMensaje.InnerHtml = "Código ingresado correctamente";
                textoMensajeError.InnerHtml = string.Empty;
                txtCodigocons.Text = string.Empty;
                txtMarca.Text = string.Empty;
                txtColor.Text = string.Empty;
                txtDescrip.Text = string.Empty;
                txtImpresoras.Text = string.Empty;
                txtModelo.Text = string.Empty;
                txtRendimiento.Text = "0";
                txtTipo.Text = string.Empty;
                txtCantidad.Text = "0";
                txtUnidad.Text = string.Empty;
                consu.Equals(null);
            }
            catch 
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "El código ya existe o faltan datos necesarios";
            }
            
        }

        protected void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                IConsumible iConsumibles = new AyAPrueba.BL.Clases.MConsumible();
                var datos = txtCodigocons.Text.ToUpper();
                var insertarnuevo = iConsumibles.BuscarConsumibleXcodigo(datos);
                if (insertarnuevo.codigo_con == txtCodigocons.Text.ToUpper())
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensaje.InnerHtml = string.Empty;
                    textoMensajeError.InnerHtml = "El código ya existe";
                    txtMarca.Text = insertarnuevo.marca;
                    txtMarca.ReadOnly = true;
                    txtTipo.Text = insertarnuevo.tipo;
                    txtTipo.ReadOnly = true;
                    txtColor.Text = insertarnuevo.color;
                    txtColor.ReadOnly = true;
                    txtCantidad.Text =Convert.ToString(insertarnuevo.cantidad_total);
                    txtCantidad.ReadOnly = true;
                    txtUnidad.Text = insertarnuevo.unidad;
                    txtUnidad.ReadOnly = true;
                    txtRendimiento.Text = Convert.ToString(insertarnuevo.rendimiento);
                    txtRendimiento.ReadOnly = true;
                    txtDescrip.Text = insertarnuevo.descripcion;
                    txtDescrip.ReadOnly = true;
                    txtImpresoras.Text = insertarnuevo.impresoras;
                    txtImpresoras.ReadOnly = true;
                    txtModelo.Text = insertarnuevo.modelo;
                    txtModelo.ReadOnly = true;
                    btnInsertar.Enabled  = false;
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
            txtCodigocons.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtMarca.ReadOnly = false;
            txtColor.Text = string.Empty;
            txtColor.ReadOnly = false;
            txtDescrip.Text = string.Empty;
            txtDescrip.ReadOnly = false;
            txtImpresoras.Text = string.Empty;
            txtImpresoras.ReadOnly = false;
            txtModelo.Text = string.Empty;
            txtModelo.ReadOnly = false;
            txtRendimiento.Text = "0";
            txtRendimiento.ReadOnly = false;
            txtTipo.Text = string.Empty;
            txtTipo.ReadOnly = false;
            txtCantidad.Text = "0";
            txtCantidad.ReadOnly = false;
            txtUnidad.Text = string.Empty;
            txtUnidad.ReadOnly = false;
            txtCodigocons.Focus();
            btnVerificar.Enabled = true;
            btnInsertar.Enabled = true;
            mensaje.Visible = false;
            mensajeError.Visible = false;
        }
    }
}