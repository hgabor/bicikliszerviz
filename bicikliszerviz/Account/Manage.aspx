<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="bicikliszerviz.Account.Manage" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>
<%@ Import Namespace="Microsoft.AspNet.Membership.OpenAuth" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <% if (User.IsInRole("service")){ %>
    A szerviz névének és címének megváltoztatása az alábbiakban lehetséges:<br>
    <asp:Label ID="Label1" runat="server" Text="Név:" AssociatedControlID="TextBox1"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br>

    <asp:Label ID="Label2" runat="server" Text="Cím:" AssociatedControlID="TextBox2"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
    <asp:Button ID="Button1" runat="server" Text="Mentés" OnClick="Button1_Click" />
    <%} %>
    <hgroup class="title">
        <h1>Fiók kezelése</h1>
    </hgroup>
    <section id="passwordForm">
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
            <p class="message-success"><%: SuccessMessage %></p>
        </asp:PlaceHolder>

        <p>Bejelentkezve, mint:  <strong><%: User.Identity.Name %></strong>.</p>

        <asp:PlaceHolder runat="server" ID="setPassword" Visible="false">
            <p>
                You do not have a local password for this site. Add a local
                password so you can log in without an external login.
            </p>
            <fieldset>
                <legend>Set Password Form</legend>
                <ol>
                    <li>
                        <asp:Label runat="server" AssociatedControlID="password">Jelszó</asp:Label>
                        <asp:TextBox runat="server" ID="password" TextMode="Password" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="password"
                            CssClass="field-validation-error" ErrorMessage="A jelszó mező kitöltése kötelező."
                            Display="Dynamic" ValidationGroup="SetPassword" />
                        
                        <asp:Label runat="server" ID="newPasswordMessage" CssClass="field-validation-error"
                            AssociatedControlID="password" />
                        
                    </li>
                    <li>
                        <asp:Label runat="server" AssociatedControlID="confirmPassword">Jelszó megerősítése</asp:Label>
                        <asp:TextBox runat="server" ID="confirmPassword" TextMode="Password" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="confirmPassword"
                            CssClass="field-validation-error" Display="Dynamic" ErrorMessage="A megerősítő jelszó mező kitöltése kötelező."
                            ValidationGroup="SetPassword" />
                        <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="confirmPassword"
                            CssClass="field-validation-error" Display="Dynamic" ErrorMessage="A jelszó és a megerősítő jelszó nem egyezik meg."
                            ValidationGroup="SetPassword" />
                    </li>
                </ol>
                <asp:Button runat="server" Text="Set Password" ValidationGroup="SetPassword" OnClick="setPassword_Click" />
            </fieldset>
        </asp:PlaceHolder>

        <asp:PlaceHolder runat="server" ID="changePassword" Visible="false">
            <h3>Change password</h3>
            <asp:ChangePassword runat="server" CancelDestinationPageUrl="~/" ViewStateMode="Disabled" RenderOuterTable="false" SuccessPageUrl="Manage?m=ChangePwdSuccess">
                <ChangePasswordTemplate>
                    <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="FailureText" />
                    </p>
                    <fieldset class="changePassword">
                        <legend>Change password details</legend>
                        <ol>
                            <li>
                                <asp:Label runat="server" ID="CurrentPasswordLabel" AssociatedControlID="CurrentPassword">Jelenlegi jelszó</asp:Label>
                                <asp:TextBox runat="server" ID="CurrentPassword" CssClass="passwordEntry" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="CurrentPassword"
                                    CssClass="field-validation-error" ErrorMessage="A jelenlegi jelszó mező kitöltése kötelező."
                                    ValidationGroup="ChangePassword" />
                            </li>
                            <li>
                                <asp:Label runat="server" ID="NewPasswordLabel" AssociatedControlID="NewPassword">Új jelszó</asp:Label>
                                <asp:TextBox runat="server" ID="NewPassword" CssClass="passwordEntry" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="NewPassword"
                                    CssClass="field-validation-error" ErrorMessage="Az új jelszó mező kitöltése kötelező."
                                    ValidationGroup="ChangePassword" />
                            </li>
                            <li>
                                <asp:Label runat="server" ID="ConfirmNewPasswordLabel" AssociatedControlID="ConfirmNewPassword">Új jelszó megerősítése</asp:Label>
                                <asp:TextBox runat="server" ID="ConfirmNewPassword" CssClass="passwordEntry" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmNewPassword"
                                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Az új jelszó megerősítése mező kitöltése kötelező."
                                    ValidationGroup="ChangePassword" />
                                <asp:CompareValidator runat="server" ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword"
                                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Az új jelszó és a megerősítő jelszó nem egyezik meg."
                                    ValidationGroup="ChangePassword" />
                            </li>
                        </ol>
                        <asp:Button runat="server" CommandName="ChangePassword" Text="Jelszó megváltoztatása" ValidationGroup="ChangePassword" />
                    </fieldset>
                </ChangePasswordTemplate>
            </asp:ChangePassword>
        </asp:PlaceHolder>
    </section>
</asp:Content>
