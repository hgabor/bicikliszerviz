<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="bicikliszerviz.Account.Manage" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>Profil</h2>
    <p>Bejelentkezve, mint:  <strong><%: User.Identity.Name %></strong>.</p>
</asp:Content>
<asp:Content ContentPlaceHolderID="ArticleContent" runat="server">
    <% if (User.IsInRole("service")){ %>
        <h1>A szerviz adatai</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Név:" AssociatedControlID="TextBox1"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br>

            <asp:Label ID="Label2" runat="server" Text="Cím:" AssociatedControlID="TextBox2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
            <asp:Button ID="Button1" runat="server" Text="Mentés" OnClick="Button1_Click" />
        </div>
    <%} %>
    <h1>Jels kezelése</h1>
    <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
        <p class="message-success"><%: SuccessMessage %></p>
    </asp:PlaceHolder>

    <asp:ChangePassword runat="server" CancelDestinationPageUrl="~/" ViewStateMode="Disabled" RenderOuterTable="false" SuccessPageUrl="Manage?m=ChangePwdSuccess">
        <ChangePasswordTemplate>
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
            <p class="validation-summary-errors">
                <asp:Literal runat="server" ID="FailureText" />
            </p>
            <asp:Button runat="server" CommandName="ChangePassword" Text="Jelszó megváltoztatása" ValidationGroup="ChangePassword" />
        </ChangePasswordTemplate>
    </asp:ChangePassword>
</asp:Content>
