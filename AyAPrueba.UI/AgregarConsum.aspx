﻿<%@ Page Title="Agregar Codigo de Consumible" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarConsum.aspx.cs" Inherits="AyAPrueba.UI.AgregarConsum" %>

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
        <asp:Label ID="lblCodigocons" runat="server" Text="Codigo: "></asp:Label>
        <asp:TextBox ID="txtCodigocons" runat="server" class="form-control" required="true"></asp:TextBox>
        <asp:Button ID="btnVerificar" runat="server" Text="Verificar" CssClass="btn btn-secondary" OnClick="btnVerificar_Click" />
         <asp:Button ID="btnRefrescar" runat="server" Text="Refrescar" CssClass="btn btn-secondary" OnClick="btnRefrescar_Click" />

        <br />
        <asp:Label ID="lblModelo" runat="server" Text="Modelo: "></asp:Label>
        <asp:TextBox ID="txtModelo" runat="server" class="form-control" ></asp:TextBox>

        <asp:Label ID="lblTipo" runat="server" Text="Tipo:"></asp:Label>
        <asp:TextBox ID="txtTipo" runat="server" class="form-control" ></asp:TextBox>

        <asp:Label ID="lblRendimiento" runat="server" Text="Rendimiento: "></asp:Label>
        <asp:TextBox ID="txtRendimiento" runat="server" class="form-control"  TextMode="Number" Text="0"></asp:TextBox>

        <asp:Label ID="lblImpresoras" runat="server" Text="Impresoras: "></asp:Label>
        <asp:TextBox ID="txtImpresoras" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>

        <asp:Label ID="lblDescrip" runat="server" Text="Descripción: "></asp:Label>
        <asp:TextBox ID="txtDescrip" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>

        <asp:Label ID="lblMarca" runat="server" Text="Marca: "></asp:Label>
        <asp:TextBox ID="txtMarca" runat="server" class="form-control" ></asp:TextBox>

        <asp:Label ID="lblColor" runat="server" Text="Color: "></asp:Label>
        <asp:TextBox ID="txtColor" runat="server" class="form-control" ></asp:TextBox>

        <asp:Label ID="lblCantidad" runat="server" Text="Cantidad: "></asp:Label>
        <asp:TextBox ID="txtCantidad" runat="server" class="form-control" TextMode="Number" Text="0"></asp:TextBox>

        <asp:Label ID="lblUnidad" runat="server" Text="Unidad del artículo: "></asp:Label>
        <asp:TextBox ID="txtUnidad" runat="server" class="form-control" ></asp:TextBox>

        <br />
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-primary" OnClick="btnInsertar_Click" />
    </div>


</asp:Content>
