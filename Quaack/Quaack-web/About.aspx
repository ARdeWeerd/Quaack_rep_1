<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="Quaack_web.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        About
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
        </asp:PasswordRecovery>
    </h2>
    <p>
        Put content here.
    </p>
</asp:Content>
