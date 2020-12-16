<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEmployees.aspx.cs" Inherits="WebApplication.AddEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
   
  <div class="form-group">
    <label for="exampleFormControlInput1">First Name</label>
    <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleFormControlSelect1">Last Name</label>
      <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleFormControlSelect2">Example multiple select</label>
      <asp:DropDownList ID="UserGenderDropDown" runat="server">

      </asp:DropDownList>
  </div>
  <div class="form-group">
    <label for="exampleFormControlTextarea1">Example textarea</label>
    <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
  </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
