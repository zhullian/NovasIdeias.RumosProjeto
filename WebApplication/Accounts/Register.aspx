<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <h1>Register new user</h1>
    <br />
    <br />
    <hr />

    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" ContinueDestinationPageUrl="~/Default.aspx" OnCreatedUser="CreateUserWizard1_CreatedUser">
        <%-- Pa$$w0rd --%>
        <WizardSteps>
            <asp:WizardStep runat="server" Title="NewEmployee">
                <div class="form-group">
                    <label for="exampleFormControlInput1">First Name</label>
                    <asp:TextBox ID="FirstNameTxt" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Last Name</label>
                    <asp:TextBox ID="LastNameTxt" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect2">Example multiple select</label>
                    <asp:DropDownList ID="EmployeeTypeDropDown" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0">Administrator</asp:ListItem>
                        <asp:ListItem Value="1">Staff</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </asp:WizardStep>
            <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
            </asp:CompleteWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>

    <hr />

    <br />
    <br />



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
