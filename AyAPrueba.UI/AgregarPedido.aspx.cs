using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AyAPrueba.BL.Interfaces;
using AyAPrueba.BL.Clases;
using AyAPrueba.DATOS;

namespace AyAPrueba.UI
{
    public partial class AgregarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string valor = string.Concat(Request.QueryString["id"]);
            txtIDOrden.Text = valor;
            txtIDOrden.ReadOnly = true;
            var fech = DateTime.Now;
            txtFecha.Text = Convert.ToString(fech); 
            if (Session["SesRol"] != null)
            {
                var rol = Session["SesRol"];
                try
                {
                    if (Convert.ToInt32(rol) == 1)
                    {
                        IMateriales iMateriales = new MMaterial();
                        dgvMateriales.DataSource = iMateriales.ListarMaterial();
                        dgvMateriales.DataBind();
                        
                        dgvMateriales.HeaderRow.Cells[1].Text = "Código";
                        dgvMateriales.HeaderRow.Cells[2].Text = "Descripción";
                        dgvMateriales.HeaderRow.Cells[3].Text = "Cantidad en Stock";
                        dgvMateriales.HeaderRow.Cells[4].Text = "Unidad del artículo";


                        TESTConfig.ListaItems = TESTConfig.ListaItems.OrderBy(x => x.codigo_mat).ToList();
                        dgvListaPedido.DataSource = TESTConfig.ListaItems;
                        dgvListaPedido.DataBind();
                    }
                    if (Convert.ToInt32(rol) == 2 | Convert.ToInt32(rol) == 3)
                    {
                        Response.Redirect("~/Default.aspx");
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }
               
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void dgvMateriales_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                if (txtCantidadDeseada.Text == null | Convert.ToInt32(txtCantidadDeseada.Text) <= 0)
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensaje.InnerHtml = string.Empty;
                    textoMensajeError.InnerHtml = "Debe colocar una cantidad mayor a cero";
                    txtCantidadDeseada.Focus();
                }
                else
                {
                    string codCon = Convert.ToString(dgvMateriales.DataKeys[e.NewEditIndex].Value);
                    //Response.Redirect(string.Concat("~/EditarConsum.aspx?id=", codCon));
                    //List<DATOS.MaterialPedido> ListaItems = new List<DATOS.MaterialPedido>();

                    //DATOS.MaterialPedido item = new DATOS.MaterialPedido
                    //{
                    //    id_pedido = Convert.ToInt32(txtIDOrden.Text),
                    //    codigo_mat = codCon,
                    //    cantidad = Convert.ToInt32(txtCantidadDeseada.Text)
                        
                    //};
                    //ListaItems.Add(item);
                    //dgvListaPedido.DataSource = ListaItems;
                    //dgvListaPedido.DataBind();
                    MaterialPedido item = new MaterialPedido
                    {
                        id_pedido = Convert.ToInt32(txtIDOrden.Text),
                        codigo_mat = codCon,
                        cantidad = Convert.ToInt32(txtCantidadDeseada.Text)
                        
                    };
                    
                    TESTConfig.ListaItems.Add(item);
                    txtCantidadDeseada.Text = "0";
                    txtCantidadDeseada.Focus();
                    dgvListaPedido.DataSource = TESTConfig.ListaItems;
                    dgvListaPedido.DataBind();

                    
                }

                
            }
            catch (Exception)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "No toca el boton";
            }
        }

        protected void dgvMateriales_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            mensaje.Visible = false;
            mensajeError.Visible = true;
            textoMensaje.InnerHtml = string.Empty;
            textoMensajeError.InnerHtml = "No toca el boton";
        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = string.Concat(Request.QueryString["id"]);
                var mat = new DATOS.Pedido
                {
                    id_pedido = Convert.ToInt32(txtIDPedido.Text),
                    id_orden = Convert.ToInt32(txtIDOrden.Text),
                    numero_orden = Convert.ToInt32(txtNumPedido.Text),
                    fecha = txtFecha.Text,
                    observaciones = txtObservaciones.Text.ToUpper()
                };
                IPedido Pedido = new BL.Clases.MPedido();
                Pedido.InsertarPedido(mat);

                IMaterialPedido MatsPedido = new BL.Clases.MMaterialPedido();
                foreach (var item in TESTConfig.ListaItems)
                {

                    var rowslista = new DATOS.MaterialPedido
                    {
                        id_pedido = item.id_pedido,
                        codigo_mat = item.codigo_mat,
                        cantidad = item.cantidad

                    };
                   
                    MatsPedido.InsertarMaterialXpedido(rowslista);
                    
                }

                TESTConfig.ListaItems.Clear();

                Response.Redirect(string.Concat("~/OTs.aspx?id=", valor));
            }
            catch (Exception)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensaje.InnerHtml = string.Empty;
                textoMensajeError.InnerHtml = "Error al agregar Pedido";
            }
            
        }
    }
}