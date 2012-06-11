<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Quaack_web._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Wekom op de Quaack-site
    </h2>
    <p>
      
        <asp:Label ID="Label1" runat="server" Text="ZoekTekst:"></asp:Label>
      
        <asp:TextBox ID="UserIdTextBox" runat="server"></asp:TextBox>
       
      
    </p>
    <p>
  <asp:Button ID="ZoekButton" runat="server" Text="Zoek berichten" 
            onclick="ZoekButton_Click" />
        <asp:GridView ID="BerichtenGridView" runat="server">
        </asp:GridView>
    </p>
</asp:Content>
