<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="bicikliszerviz.Account.Verify" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel runat="server" ID="succesPanel">
        <p>A regisztráció sikeres volt. Kattints a Bejelentkezés gobmra az oldal használatához.</p>
    </asp:Panel>
    <asp:Panel runat="server" ID="errorPanel">
        <p>Érvénytelen azonosító!</p>
    </asp:Panel>
</asp:Content>
