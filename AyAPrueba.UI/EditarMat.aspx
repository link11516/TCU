<%@ Page Title="Edición de material" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarMat.aspx.cs" Inherits="AyAPrueba.UI.EditarMat" %>
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
        <asp:Label ID="lblCodigomat" runat="server" Text="Codigo: "></asp:Label>
        <asp:TextBox ID="txtCodigomat" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblDescrip" runat="server" Text="Descripción: "></asp:Label>
        <asp:TextBox ID="txtDescrip" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>

        <asp:Label ID="lblCantidad" runat="server" Text="Cantidad: "></asp:Label>
        <asp:TextBox ID="txtCantidad" runat="server" class="form-control" TextMode="Number" Text="0"></asp:TextBox>

        <asp:Label ID="lblUnidad" runat="server" Text="Unidad del artículo: "></asp:Label>
        <asp:TextBox ID="txtUnidad" runat="server" class="form-control" ></asp:TextBox>

        <br />
        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-primary" OnClick="btnEditar_Click" />
    </div>

</asp:Content>
