<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AyAPrueba.UI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
       <center><h1>Instituto Costarricense de Acueductos y Alcantarillados</h1> 
        <h2>Soporte Tecnico GAM</h2>
        <p class="lead">Sistema de Inventarios</p></center>
        
    </div>

    <div class="row" id="divlogo">
        
            <img src="img/ayalogo.jpg" />
        
    </div>

    <style>
        #divlogo 
        {
            padding-left: 35%;
            padding-top: 2%;
            padding-bottom: 2%;
        }
    </style>
</asp:Content>
