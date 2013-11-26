<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="bicikliszerviz.Account.Verify" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel runat="server" ID="succesPanel">
        <h2>A regisztráció sikeres volt!</h2>
        <p>Kattints a Bejelentkezés gobmra az oldal használatához.</p>
    </asp:Panel>
    <asp:Panel runat="server" ID="errorPanel">
        <h2>Érvénytelen azonosító!</h2>
    </asp:Panel>
</asp:Content>
