<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Deffault.aspx.cs" Inherits="WebApplication.Deffault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bootstrap 4 Demo</title>
    <%--bootstrap css--%>
        <link href="Contents/css/bootstrap.min.css" rel="stylesheet" />
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
    
    

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <h1>Default</h1>

</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">

</asp:Content>