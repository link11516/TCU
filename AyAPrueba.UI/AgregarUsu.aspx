<%@ Page Title="Agregar usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarUsu.aspx.cs" Inherits="AyAPrueba.UI.Contact" %>

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
        <%--<asp:Label ID="lblIdUsuario" runat="server" Text="ID: "></asp:Label>
        <asp:TextBox ID="txtIdUsuario" runat="server" class="form-control"></asp:TextBox>--%>

        <asp:Label ID="lblCedula" runat="server" Text="Cedula: "></asp:Label>
        <asp:TextBox ID="txtCedula" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblApellido1" runat="server" Text="Primer apellido: "></asp:Label>
        <asp:TextBox ID="txtApellido1" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblApellido2" runat="server" Text="Segundo apellido: "></asp:Label>
        <asp:TextBox ID="txtApellido2" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblUser" runat="server" Text="Nombre de usuario: "></asp:Label>
        <asp:TextBox ID="txtUser" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblClave" runat="server" Text="Contraseña: "></asp:Label>
        <asp:TextBox ID="txtClave" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblSelectRol" runat="server" Text="Seleccione un rol: "></asp:Label>
        <br />
        <asp:Label ID="lblRolAdmin" runat="server" Text="Administrador "></asp:Label>
        <asp:CheckBox ID="ckbxAdmin" runat="server" />
        <br />
        <asp:Label ID="lblRolBodega" runat="server" Text="Gestor de bodega "></asp:Label>
        <asp:CheckBox ID="ckbxBodega" runat="server" />
        <br />
        <asp:Label ID="lblRolLectura" runat="server" Text="Lectura "></asp:Label>
        <asp:CheckBox ID="ckbxLectura" runat="server" />
        <br />
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-primary" OnClick="btnInsertar_Click" />
    </div>
</asp:Content>
