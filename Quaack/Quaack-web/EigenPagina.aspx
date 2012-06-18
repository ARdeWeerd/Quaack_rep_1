<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EigenPagina.aspx.cs" Inherits="Quaack_web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table width="100%"><tr><td rowspan="2" style="padding-right: 20px" valign="top" >
        <p class="berichtenLabel">Berichten</p>
        <asp:GridView ID="gvMessages" runat="server" CssClass="MessagesTable" 
            onload="gvMessages_Load" 
            onselectedindexchanged="gvMessages_SelectedIndexChanged">
        </asp:GridView>
        <asp:TreeView ID="TreeView1" runat="server" Width="356px">
        </asp:TreeView>
    </td><td valign="top" align="right" class="PersonalPeopleIRespondedTo">
        <p class="reaktiesLabel">Gereageerd op:</p>
        <asp:GridView ID="GridView2" runat="server" 
            CssClass="PersonalPeopleIRespondedTo">
        </asp:GridView>
    </td></tr><tr><td align="right" class="PersonalPeopleRespondedToMe">
        <p class="reaktiesLabel">Reakties door:</p>
        <asp:GridView ID="GridView3" runat="server" 
            CssClass="PersonalPeopleRespondedToMe">
        </asp:GridView>
    </td></tr></table>
</asp:Content>
