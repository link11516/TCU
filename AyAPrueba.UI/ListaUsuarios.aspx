<%@ Page Title="Gestion de usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="AyAPrueba.UI.Inventario" %>

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


    <p>
        <asp:GridView ID="dgvUsuarios" runat="server" CssClass="table table-hover" BackColor="White" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" DataKeyNames="id_usuario" 
            OnRowDeleting="dgvUsuarios_RowDeleting" OnRowEditing="dgvUsuarios_RowEditing">  
           
            <Columns>
                <asp:CommandField ShowDeleteButton="True"  />
                
                <asp:CommandField ShowEditButton="True" />
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
        <asp:Label ID="lblNota" runat="server" Text="**Nota: Los roles de usuario son administrador(1), gestor de bodega(2) y usuario de lectura(3)."></asp:Label>
    </p>
</asp:Content>
