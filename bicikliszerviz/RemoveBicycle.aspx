<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RemoveBicycle.aspx.cs" Inherits="bicikliszerviz.RemoveBicycle" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>Bicikli törlése</h2>
    <p>Biztosan szeretnéd törölni az alábbi biciklit?</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ArticleContent" runat="server">
    <p>TODO: bicikli adatai</p>
    <asp:Button ID="removeButton" Text="Igen" OnClick="removeButton_Click" runat="server" />
</asp:Content>
