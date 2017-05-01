<%@ Page Title="Agregar Pedido" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarPedido.aspx.cs" Inherits="AyAPrueba.UI.AgregarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>

    <style>
        .gridviewdimension {
            width: 100%;
            height: 400px;
            overflow-x: hidden;
            overflow-y: scroll;
        }
        
    </style>


    <%-- id_pedido
        id_orden
        fecha
        observaciones 
        
        se debe hacer dos gridview uno para que se agreguen los items y otro que los muestre--%>


    <div class="form-group">

        <asp:Label ID="lblIDPedido" runat="server" Text="ID: "></asp:Label>
        <asp:TextBox ID="txtIDPedido" runat="server" class="form-control"></asp:TextBox>

        <asp:Label ID="lblNumPedido" runat="server" Text="Pedido número: "></asp:Label>
        <asp:TextBox ID="txtNumPedido" runat="server" class="form-control"></asp:TextBox>

        <asp:Label ID="lblIDOrden" runat="server" Text="Orden de trabajo:"></asp:Label>
        <asp:TextBox ID="txtIDOrden" runat="server" class="form-control"></asp:TextBox>

        <asp:Label ID="lblFecha" runat="server" Text="Fecha: "></asp:Label>
        <asp:TextBox ID="txtFecha" runat="server" class="form-control" TextMode="Date"></asp:TextBox>

        <asp:Label ID="lblObservaciones" runat="server" Text="Observaciones: "></asp:Label>
        <asp:TextBox ID="txtObservaciones" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
        <br />
        <h3>Selección de materiales</h3>
        <asp:Label ID="lblCantidaddeseada" runat="server" Text="Cantidad deseada: "></asp:Label>
        <asp:TextBox ID="txtCantidadDeseada" runat="server" class="form-control" TextMode="Number" Text="0"></asp:TextBox>
        <div class="gridviewdimension">
            <p>
                <asp:GridView ID="dgvMateriales" runat="server" CssClass="table table-hover" BackColor="White" BorderColor="#999999"
                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" DataKeyNames="codigo_mat" OnRowEditing="dgvMateriales_RowEditing" OnRowUpdating="dgvMateriales_RowUpdating">

                    <Columns>
                        
                        <asp:CommandField EditText="Agregar" ShowEditButton="True" ShowCancelButton="False" />
                        
                    </Columns>

                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </p>
        </div>

        


        <br />
        <h3>Lista del pedido</h3>
        <p>
            <asp:GridView ID="dgvListaPedido" runat="server" CssClass="table table-hover" BackColor="White" BorderColor="#999999"
                BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">

                

                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </p>
        <br />
        <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" CssClass="btn btn-primary" OnClick="btnFinalizar_Click" />
    </div>
</asp:Content>
