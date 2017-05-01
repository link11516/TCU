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
    public partial class AgregarRep : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnRefrescar.Enabled = false;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var repu = new DATOS.Repuesto
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

                IRepuesto iRepuesto = new BL.Clases.MRepuesto();
                iRepuesto.InsertarRepuesto(repu);
                mensaje.Visible = true;
                mensajeError.Visible = false;
                textoMensaje.InnerHtml = "Código ingresado correctamente";
                textoMensajeError.InnerHtml = string.Empty;
                txtCodigorep.Text = string.Empty;
                txtMarca.Text = string.Empty;
                txtDescrip.Text = string.Empty;
                txtImpresoras.Text = string.Empty;
                txtModelo.Text = string.Empty;
                txtTipo.Text = string.Empty;
                txtCantidadN.Text = "0";
                txtCantidadU.Text = "0";
                txtUnidad.Text = string.Empty;
                repu.Equals(null);
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
                IRepuesto iRepuesto = new AyAPrueba.BL.Clases.MRepuesto();
                var datos = txtCodigorep.Text.ToUpper();
                var insertarnuevo = iRepuesto.BuscarRepuestoXcodigo(datos);
                if (insertarnuevo.codigo_rep == txtCodigorep.Text.ToUpper())
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensaje.InnerHtml = string.Empty;
                    textoMensajeError.InnerHtml = "El código ya existe";
                    txtMarca.Text = insertarnuevo.marca;
                    txtMarca.ReadOnly = true;
                    txtTipo.Text = insertarnuevo.tipo;
                    txtTipo.ReadOnly = true;
                    txtCantidadN.Text = Convert.ToString(insertarnuevo.cantidad_nuevos);
                    txtCantidadN.ReadOnly = true;
                    txtCantidadU.Text = Convert.ToString(insertarnuevo.cantidad_viejos);
                    txtCantidadU.ReadOnly = true;
                    txtUnidad.Text = insertarnuevo.unidad;
                    txtUnidad.ReadOnly = true;
                    txtDescrip.Text = insertarnuevo.descripcion;
                    txtDescrip.ReadOnly = true;
                    txtImpresoras.Text = insertarnuevo.impresoras;
                    txtImpresoras.ReadOnly = true;
                    txtModelo.Text = insertarnuevo.modelo;
                    txtModelo.ReadOnly = true;
                    btnInsertar.Enabled = false;
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
            txtCodigorep.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtMarca.ReadOnly = false;
            txtDescrip.Text = string.Empty;
            txtDescrip.ReadOnly = false;
            txtImpresoras.Text = string.Empty;
            txtImpresoras.ReadOnly = false;
            txtModelo.Text = string.Empty;
            txtModelo.ReadOnly = false;
            txtTipo.Text = string.Empty;
            txtTipo.ReadOnly = false;
            txtCantidadN.Text = "0";
            txtCantidadN.ReadOnly = false;
            txtCantidadU.Text = "0";
            txtCantidadU.ReadOnly = false;
            txtUnidad.Text = string.Empty;
            txtUnidad.ReadOnly = false;
            txtCodigorep.Focus();
            btnVerificar.Enabled = true;
            btnInsertar.Enabled = true;
            mensaje.Visible = false;
            mensajeError.Visible = false;
        }
    }
}