<%@ Page Title="Profil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="bicikliszerviz.Account.Manage" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>Profil</h2>
    <p>Bejelentkezve, mint:  <strong><%: User.Identity.Name %></strong>.</p>
</asp:Content>
<asp:Content ContentPlaceHolderID="ArticleContent" runat="server">
    <% if (User.IsInRole("service")){ %>
        <h1>A szerviz adatai</h1>
        <div class="form-horizontal">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Név:" AssociatedControlID="TextBox1" CssClass="col-md-3 control-label"></asp:Label>
                <span class="col-md-7"><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></span>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Cím:" AssociatedControlID="TextBox2" CssClass="col-md-3 control-label"></asp:Label>
                <span class="col-md-7"><asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></span>
            </div>
            <div class="form-group">
                <span class="col-md-1 col-md-offset-3"><asp:Button ID="Button1" runat="server" Text="Mentés" OnClick="Button1_Click" CssClass="btn btn-default" /></span>
            </div>
        </div>
    <%} %>
    <h1>Jelszó kezelése</h1>
    <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
        <p class="message-success"><%: SuccessMessage %></p>
    </asp:PlaceHolder>

    <asp:ChangePassword runat="server" CancelDestinationPageUrl="~/" ViewStateMode="Disabled" RenderOuterTable="false" SuccessPageUrl="Manage?m=ChangePwdSuccess">
        <ChangePasswordTemplate>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" ID="CurrentPasswordLabel" AssociatedControlID="CurrentPassword" CssClass="col-md-3 control-label">Jelenlegi jelszó:</asp:Label>
                    <span class="col-md-4"><asp:TextBox runat="server" ID="CurrentPassword" CssClass="passwordEntry form-control" TextMode="Password" /></span>
                    <span class="col-md-5"><asp:RequiredFieldValidator runat="server" ControlToValidate="CurrentPassword"
                        CssClass="field-validation-error" ErrorMessage="A mező kitöltése kötelező."
                        ValidationGroup="ChangePassword" /></span>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" ID="NewPasswordLabel" AssociatedControlID="NewPassword" CssClass="col-md-3 control-label">Új jelszó:</asp:Label>
                    <span class="col-md-4"><asp:TextBox runat="server" ID="NewPassword" CssClass="passwordEntry form-control" TextMode="Password" /></span>
                    <span class="col-md-5"><asp:RequiredFieldValidator runat="server" ControlToValidate="NewPassword"
                        CssClass="field-validation-error" ErrorMessage="A mező kitöltése kötelező."
                        ValidationGroup="ChangePassword" /></span>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" ID="ConfirmNewPasswordLabel" AssociatedControlID="ConfirmNewPassword" CssClass="col-md-3 control-label">Új jelszó megerősítése:</asp:Label>
                    <span class="col-md-4"><asp:TextBox runat="server" ID="ConfirmNewPassword" CssClass="passwordEntry form-control" TextMode="Password" /></span>
                    <span class="col-md-5">
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmNewPassword"
                            CssClass="field-validation-error" Display="Dynamic" ErrorMessage="A mező kitöltése kötelező."
                            ValidationGroup="ChangePassword" />
                        <asp:CompareValidator runat="server" ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword"
                            CssClass="field-validation-error" Display="Dynamic" ErrorMessage="A két jelszó nem egyezik meg."
                            ValidationGroup="ChangePassword" /></span>
                </div>
                <div class="form-group">
                    <span class="validation-summary-errors col-md7 col-md-offset-3">
                        <asp:Literal runat="server" ID="FailureText" />
                    </span>
                </div>
                <div class="form-group">
                    <span class="col-md-1 col-md-offset-3"><asp:Button runat="server" CommandName="ChangePassword" Text="Jelszó megváltoztatása" ValidationGroup="ChangePassword" CssClass="btn btn-default" /></span>
                </div>
            </div>
        </ChangePasswordTemplate>
    </asp:ChangePassword>
</asp:Content>
