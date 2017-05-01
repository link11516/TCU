<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AyAPrueba.UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>


    <div class="form-group" id="divlogin">
        <br />
        <asp:Label ID="lbUsuario" runat="server" Text="Nombre de Usuario" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="UsuarioXY"></asp:TextBox>
        <br />
        <asp:Label ID="lbClave" runat="server" Text="Contraseña" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtClave" runat="server" class="form-control" TextMode="Password" placeholder="ContraseñaXY"></asp:TextBox>
        <br />
        <asp:Button ID="BtnLogin" runat="server" Text="Ingresar" cssclass="btn btn-primary" OnClick="BtnLogin_Click"/>
        <br />
    </div>
    <style>
        #divlogin 
        {
            padding-left: 35%;
            padding-top: 6%;
            padding-bottom: 10%;
        }
    </style>
</asp:Content>
