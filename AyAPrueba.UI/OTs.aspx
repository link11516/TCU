<%@ Page Title="Orden de trabajo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OTs.aspx.cs" Inherits="AyAPrueba.UI.OTs" %>
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


    <div class="form-group">

        <asp:Label ID="lblIDTit" runat="server" Text="Número: "></asp:Label>
        <br />
        <asp:Label ID="lblID" runat="server"  Text=""></asp:Label>
        <br /><br />

        <asp:Label ID="lblFechaCreacionTit" runat="server" Text="Fecha de creación: "></asp:Label>
        <br />
        <asp:Label ID="lblFechaCreacion" runat="server" Text=""></asp:Label>
        <br /><br />
        
        <asp:Label ID="lblSolicitanteTit" runat="server" Text="Solicitante: "></asp:Label>
        <br />
        <asp:Label ID="lblSolicitante" runat="server" Text=""></asp:Label>
        <br /><br />

        <asp:Label ID="lblLugarTit" runat="server" Text="Destino: "></asp:Label>
        <br />
        <asp:Label ID="lblLugar" runat="server" Text=""></asp:Label>
        <br /><br />

        <asp:Label ID="lblJustificacionTit" runat="server" Text="Justificación: "></asp:Label>
        <br />
        <asp:Label ID="lblJustificacion" runat="server" Text=""></asp:Label>
        <br /><br />

        <asp:Label ID="lblSelectStatus" runat="server" Text="Estado de la orden: "></asp:Label>
        <br />
        <asp:Label ID="lblAbierto" runat="server" Text="Abierto "></asp:Label>
        <asp:CheckBox ID="ckbxAbierto" runat="server" />
        <br />
        <asp:Label ID="lblCerrado" runat="server" Text="Cerrado "></asp:Label>
        <asp:CheckBox ID="ckbxCerrado" runat="server" />
        <br />
        <asp:Button ID="btnAgregarPedido" runat="server" Text="Agregar pedido" CssClass="btn btn-primary" OnClick="btnAgregarPedido_Click" />
    </div>
    <br />
    <h2>Lista de Pedidos</h2>
     <p>
        <asp:GridView ID="dgvListaPedidos" runat="server" CssClass="table table-hover" BackColor="White" BorderColor="#999999" 
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


</asp:Content>
