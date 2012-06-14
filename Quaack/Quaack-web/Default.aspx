<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
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
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" 
            UserNameTitleText="Passwoord vergeten">
            <QuestionTemplate>
                <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                    <tr>
                        <td>
                            <table cellpadding="0">
                                <tr>
                                    <td align="center" colspan="2">
                                        Identity Confirmation</td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2">
                                        Answer the following question to receive your password.</td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        User Name:</td>
                                    <td>
                                        <asp:Literal ID="UserName" runat="server"></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Question:</td>
                                    <td>
                                        <asp:Literal ID="Question" runat="server"></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="AnswerLabel" runat="server" AssociatedControlID="Answer">Answer:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Answer" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" 
                                            ControlToValidate="Answer" ErrorMessage="Answer is required." 
                                            ToolTip="Answer is required." ValidationGroup="PasswordRecovery1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" style="color:Red;">
                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" colspan="2">
                                        <asp:Button ID="SubmitButton" runat="server" CommandName="Submit" Text="Submit" 
                                            ValidationGroup="PasswordRecovery1" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </QuestionTemplate>
        </asp:PasswordRecovery>
    </p>
    <p>
        <asp:Button ID="ZoekButton" runat="server" Text="Zoek berichten" OnClick="ZoekButton_Click" />
        <asp:GridView ID="BerichtenGridView" runat="server">
        </asp:GridView>
    </p>
    <input id="btnTestJQuery" type="button" value="Test jQuery" />
</asp:Content>
<asp:Content ID="ScriptContent" runat="server" ContentPlaceHolderID="ScriptContent">
    $(function() {
        $("#btnTestJQuery").click(function() {
            alert("jQuery!");
        });
    });
</asp:Content>
