<%@ Page Title="Edición del usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="AyAPrueba.UI.EditarUsuario" %>
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
        <asp:Label ID="lblIdUsuario" runat="server" Text="ID: "></asp:Label>
        <asp:TextBox ID="txtIdUsuarioE" runat="server" class="form-control"></asp:TextBox>

        <asp:Label ID="lblCedula" runat="server" Text="Cedula: "></asp:Label>
        <asp:TextBox ID="txtCedulaE" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombreE" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblApellido1" runat="server" Text="Primer apellido: "></asp:Label>
        <asp:TextBox ID="txtApellido1E" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblApellido2" runat="server" Text="Segundo apellido: "></asp:Label>
        <asp:TextBox ID="txtApellido2E" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblUser" runat="server" Text="Nombre de usuario: "></asp:Label>
        <asp:TextBox ID="txtUserE" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblClave" runat="server" Text="Contraseña: "></asp:Label>
        <asp:TextBox ID="txtClaveE" runat="server" class="form-control" required="true"></asp:TextBox>

        <asp:Label ID="lblSelectRol" runat="server" Text="Seleccione un rol: "></asp:Label>
        <br />
        <asp:Label ID="lblRolAdmin" runat="server" Text="Administrador "></asp:Label>
        <asp:CheckBox ID="ckbxAdminE" runat="server" />
        <br />
        <asp:Label ID="lblRolBodega" runat="server" Text="Gestor de bodega "></asp:Label>
        <asp:CheckBox ID="ckbxBodegaE" runat="server" />
        <br />
        <asp:Label ID="lblRolLectura" runat="server" Text="Lectura "></asp:Label>
        <asp:CheckBox ID="ckbxLecturaE" runat="server" />
        <br />
        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-primary" OnClick="btnEditar_Click" />
    </div>


</asp:Content>
