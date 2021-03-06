﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Quaack_web._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welkom op de Quaack-site
    </h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text="ZoekTekst:"></asp:Label>
        <asp:TextBox ID="UserIdTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ZoekButton" runat="server" Text="Zoek berichten" OnClick="ZoekButton_Click" />
        <asp:GridView ID="BerichtenGridView" runat="server">
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="TestAanmakenProfiel" />
    </p>
    <input id="btnTestJQuery" type="button" value="Test jQuery" />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Test ProfielService" />
    <asp:TextBox ID="testProfielTextBox" runat="server" Width="456px"></asp:TextBox>
    <br />
    <asp:HyperLink ID="EigenPagina" runat="server" NavigateUrl="~/EigenPagina.aspx">Eigen Pagina</asp:HyperLink>
</asp:Content>
<asp:Content ID="ScriptContent" runat="server" ContentPlaceHolderID="ScriptContent">
    <script type="text/javascript">

        $(function() {
            $("#btnTestJQuery").click(function() {
                alert("jQuery!");
            });
        });
    </script>
</asp:Content>
