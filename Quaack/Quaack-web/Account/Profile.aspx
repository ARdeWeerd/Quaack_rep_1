<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Quaack_web.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

                    <h2>
                        Wijzig profiel
                    </h2>
                    <span class="failureNotification">
                        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
                    </span>
                    <asp:ValidationSummary ID="UpdateProfileValidationSummary" runat="server" CssClass="failureNotification"
                        ValidationGroup="UpdateProfileValidationGroup" />
                    <div class="accountInfo">
                    <fieldset>
                        
                        <p>
                            <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">Emailadres:</asp:Label>
                            <asp:TextBox ID="Email" runat="server" CssClass="textEntry"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email"
                                CssClass="failureNotification" ErrorMessage="Emailadres is verplicht." ToolTip="Emailadres is verplicht."
                                ValidationGroup="UpdateProfileValidationGroup"></asp:RequiredFieldValidator>
                        </p>
                        <p>
                            <asp:Label ID="ProfielschetsLabel" runat="server" AssociatedControlID="Profielschets">Profielschets:</asp:Label>
                            <asp:TextBox ID="Profielschets" runat="server" CssClass="multiLineEntry" TextMode="MultiLine"></asp:TextBox>
                        </p>
                        <p>
                            <asp:Label ID="AvatarLabel" runat="server" AssociatedControlID="Avatar">Avatar:</asp:Label>
                            <asp:TextBox ID="Avatar" runat="server" CssClass="textEntry"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="AvatarURLValidator" runat="server"
                                ErrorMessage="Ongeldige avatarlocatie" ControlToValidate="Avatar"
                                ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"
                                ValidationGroup="UpdateProfileValidationGroup"></asp:RegularExpressionValidator>
                        </p>
                        <p>
                            <asp:Label ID="MobileNumberLabel" runat="server" AssociatedControlID="MobileNumber">Mobiel nummer:</asp:Label>
                            <asp:TextBox ID="MobileNumber" runat="server" CssClass="textEntry"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="MobileNumberValidator" runat="server"
                                ErrorMessage="Ongeldig mobiel nummer" ControlToValidate="MobileNumber"
                                ValidationExpression="^06(-)?\d{8}$" ValidationGroup="UpdateProfileValidationGroup"></asp:RegularExpressionValidator>
                        </p>

                        <p class="submitButton">
                            <asp:Button ID="UpdateProfileButton" runat="server" CommandName="MoveNext" Text="Wijzig profiel"
                                ValidationGroup="UpdateProfileValidationGroup" />
                        </p>
                    </fieldset>
                    <h2>
                        Wijzig wachtwoord
                    </h2>
                    <fieldset class="register">
                        <asp:ChangePassword ID="ChangePassword1" runat="server" 
                            ChangePasswordTitleText="" 
                            ConfirmNewPasswordLabelText="Bevestig wachtwoord:" 
                            ConfirmPasswordRequiredErrorMessage="Bevestiging wachtwoord is verplicht." 
                            NewPasswordLabelText="Nieuw wachtwoord" 
                            NewPasswordRequiredErrorMessage="Nieuw wachtwoord is verplicht." 
                            RenderOuterTable="False" ChangePasswordButtonText="Wijzig wachtwoord">
                            <ChangePasswordTemplate>
                            <p>
                                <asp:Label ID="CurrentPasswordLabel" runat="server" 
                                    AssociatedControlID="CurrentPassword">Oud wachtwoord:</asp:Label>
                                <asp:TextBox ID="CurrentPassword" runat="server" CssClass="textEntry" 
                                    TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="CurrentPasswordRequired" runat="server" 
                                    ControlToValidate="CurrentPassword" ErrorMessage="Oud wachtwoord is verplicht." 
                                    ToolTip="Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="NewPasswordLabel" runat="server" 
                                    AssociatedControlID="NewPassword">Nieuw wachtwoord</asp:Label>
                                <asp:TextBox ID="NewPassword" runat="server" CssClass="textEntry" 
                                    TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="NewPasswordRequired" runat="server" 
                                    ControlToValidate="NewPassword" ErrorMessage="Nieuw wachtwoord is verplicht." 
                                    ToolTip="Nieuw wachtwoord is verplicht." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="ConfirmNewPasswordLabel" runat="server" 
                                    AssociatedControlID="ConfirmNewPassword">Bevestig wachtwoord:</asp:Label>
                                <asp:TextBox ID="ConfirmNewPassword" runat="server" CssClass="textEntry" 
                                    TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="ConfirmNewPasswordRequired" runat="server" 
                                    ControlToValidate="ConfirmNewPassword" 
                                    ErrorMessage="Bevestiging wachtwoord is verplicht." 
                                    ToolTip="Bevestiging wachtwoord is verplicht." 
                                    ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:CompareValidator ID="NewPasswordCompare" runat="server" 
                                    ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword" 
                                    Display="Dynamic" 
                                    ErrorMessage="The Confirm New Password must match the New Password entry." 
                                    ValidationGroup="ChangePassword1"></asp:CompareValidator>
                            </p>
                            <p>
                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                            </p>
                            <p class="submitButton">
                                <asp:Button ID="ChangePasswordPushButton" runat="server" 
                                    CommandName="ChangePassword" Text="Wijzig wachtwoord" 
                                    ValidationGroup="ChangePassword1" />
                            </p>
                            </ChangePasswordTemplate>
                            <TextBoxStyle CssClass="textEntry" />
                        </asp:ChangePassword>
                    </fieldset>

                        <fieldset class="register">
                            <p>
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Wachtwoord:</asp:Label>
                                <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                    CssClass="failureNotification" ErrorMessage="Wachtwoord is verplicht." ToolTip="Wachtwoord is verplicht."
                                    ValidationGroup="RegisterUserValidationGroup"></asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Bevestig wachtwoord:</asp:Label>
                                <asp:TextBox ID="ConfirmPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ControlToValidate="ConfirmPassword" CssClass="failureNotification"
                                    Display="Dynamic" ErrorMessage="Bevestiging wachtwoord is verplicht." ID="ConfirmPasswordRequired"
                                    runat="server" ToolTip="Bevestiging wachtwoord is verplicht." ValidationGroup="RegisterUserValidationGroup"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password"
                                    ControlToValidate="ConfirmPassword" CssClass="failureNotification" Display="Dynamic"
                                    ErrorMessage="Wachtwoorden komen niet overeen." ValidationGroup="RegisterUserValidationGroup"></asp:CompareValidator>
                            </p>
                        </fieldset>



                    </div>


</asp:Content>
