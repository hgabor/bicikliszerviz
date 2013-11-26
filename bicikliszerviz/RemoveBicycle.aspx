<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RemoveBicycle.aspx.cs" Inherits="bicikliszerviz.RemoveBicycle" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>Bicikli törlése</h2>
    <p>Biztosan szeretnéd törölni az alábbi biciklit?</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ArticleContent" runat="server">
    <% if (this.bicycle == null) { %>
        <p>A megadott bicikli nem létezik!</p>
    <% } else { %>
    <p>
        <%: bicycle.Type %> típusú, <%: bicycle.Size %> méretű bicikli. Eddig <%: bicycle.Offers.Count %>
        ajánlat érkezett rá.
    </p>
        <asp:Button ID="removeButton" Text="Igen" OnClick="removeButton_Click" runat="server" CssClass="btn btn-danger" />
    <% } %>
</asp:Content>
