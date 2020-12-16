<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <div class="jumbotron">
  <h1 class="display-4">Hello, world!</h1>
  <p class="lead">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
  <hr class="my-4">
  <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
  
    <a class="btn btn-primary btn-lg" href="~/Accounts/Login.aspx" runat="server" role="button">Login</a>
    <a class="btn btn-primary btn-lg" href="~/Accounts/Register.aspx" runat="server" role="button">Register</a>
</div>
    <div>   
        <div class="row">
            <div class="col">
                <h1>Login
                </h1>
            </div>
            <div class="col">
                <h1>Registar</h1>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
