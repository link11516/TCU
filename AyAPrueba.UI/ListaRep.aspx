<%@ Page Title="Gestión de Codigos para Repuesto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaRep.aspx.cs" Inherits="AyAPrueba.UI.ListaRep" %>
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

    <div class="form-inline">
        <asp:DropDownList ID="ddlMarcas" runat="server" CssClass="form-control"></asp:DropDownList>
        <asp:Button ID="btnFiltrar" runat="server" Text="Seleccionar" CssClass="btn btn-success" OnClick="btnFiltrar_Click"/>
    </div>

    <p>
        <asp:GridView ID="dgvCodRep" runat="server" CssClass="table table-hover" BackColor="White" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" DataKeyNames="codigo_rep" 
            OnRowDeleting="dgvCodRep_RowDeleting" OnRowEditing="dgvCodRep_RowEditing">  

            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
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
   </p>

    <p>
        <asp:GridView ID="dgvCodRepLectura" runat="server" CssClass="table table-hover" BackColor="White" BorderColor="#999999" 
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
