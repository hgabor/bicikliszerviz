<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="bicikliszerviz.Account.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Bejelentkezés</h1>
    </hgroup>
    <section id="loginForm">
        <h2>Bejelentkezéshez add meg az adataid</h2>
        <asp:Login runat="server" ViewStateMode="Disabled" RenderOuterTable="false">
            <LayoutTemplate>
                <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
                <fieldset>
                    <legend>Bejelentkezési felület</legend>
                    <ol>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="UserName">Felhasználónév</asp:Label>
                            <asp:TextBox runat="server" ID="UserName" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Password">Jelszó</asp:Label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="The password field is required." />
                        </li>
                        <li>
                            <asp:CheckBox runat="server" ID="RememberMe" />
                            <asp:Label runat="server" AssociatedControlID="RememberMe" CssClass="checkbox">Emlékezz rám</asp:Label>
                        </li>
                    </ol>
                    <asp:Button runat="server" CommandName="Login" Text="Bejelentkezés" />
                </fieldset>
            </LayoutTemplate>
        </asp:Login>
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Regisztrálj</asp:HyperLink>
            ha még nincs felhasználói fiókod.
        </p>
    </section>
</asp:Content>
