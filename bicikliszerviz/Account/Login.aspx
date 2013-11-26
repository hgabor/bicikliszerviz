<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="bicikliszerviz.Account.Login" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2>Bejelentkezés</h2>
    <p>Bejelentkezéshez add meg az adataid!</p>
</asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="ArticleContent">
    <asp:Login runat="server" ViewStateMode="Disabled" RenderOuterTable="false">
        <LayoutTemplate>
            <p class="validation-summary-errors">
                <asp:Literal runat="server" ID="FailureText" />
            </p>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="UserName" CssClass="control-label col-md-3">Felhasználónév:</asp:Label>
                    <span class="col-md-4"><asp:TextBox runat="server" ID="UserName" CssClass="form-control" /></span>
                    <span class="col-md-5"><asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="A mező kitöltése kötelező." /></span>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Password" CssClass="control-label col-md-3">Jelszó:</asp:Label>
                    <span class="col-md-4"><asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" /></span>
                    <span class="col-md-5"><asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="A mező kitöltése kötelező." /></span>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="RememberMe" CssClass="checkbox control-label col-md-3">Emlékezz rám:</asp:Label>
                    <span class="col-md-4"><asp:CheckBox runat="server" ID="RememberMe" /></span>
                </div>
                <div class="form-group">
                    <span class="col-md-1 col-md-offset-3">
                        <asp:Button runat="server" CommandName="Login" Text="Bejelentkezés" CssClass="btn btn-default" />
                    </span>
                </div>
            </div>
        </LayoutTemplate>
    </asp:Login>
    <p>
        <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Regisztrálj</asp:HyperLink>
        ha még nincs felhasználói fiókod.
    </p>
</asp:Content>
