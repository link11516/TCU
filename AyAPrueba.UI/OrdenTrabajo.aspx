<%@ Page Title="Generar Orden de Trabajo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrdenTrabajo.aspx.cs" Inherits="AyAPrueba.UI.OrdenTrabajo" %>
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

        <asp:Label ID="lblFecha" runat="server" Text="Fecha: "></asp:Label>
        <asp:TextBox ID="txtFecha" runat="server" class="form-control" required="true" TextMode="DateTime"></asp:TextBox>
        
        <asp:Label ID="lblSolicitante" runat="server" Text="Solicitante: "></asp:Label>
        <asp:TextBox ID="txtSolicitante" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblLugar" runat="server" Text="Destino: "></asp:Label>
        <asp:TextBox ID="txtLugar" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblJustificacion" runat="server" Text="Justificación: "></asp:Label>
        <asp:TextBox ID="txtJustificacion" runat="server" class="form-control" required="true" TextMode="MultiLine"></asp:TextBox>

        <asp:Label ID="lblSelectStatus" runat="server" Text="Seleccione un estado: "></asp:Label>
        <br />
        <asp:Label ID="lblAbierto" runat="server" Text="Abierto "></asp:Label>
        <asp:CheckBox ID="ckbxAbierto" runat="server" />
        <br />
        <asp:Label ID="lblCerrado" runat="server" Text="Cerrado "></asp:Label>
        <asp:CheckBox ID="ckbxCerrado" runat="server" />
        <br />
        <asp:Button ID="btnSolicitar" runat="server" Text="Crear" CssClass="btn btn-primary" OnClick="btnSolicitar_Click" />
    </div>
</asp:Content>
