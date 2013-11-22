<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RemoveBicycle.aspx.cs" Inherits="bicikliszerviz.RemoveBicycle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Biztosan szeretnéd törölni az alábbi biciklit?</h1>
    <%: "Ide jön" %>

    <asp:Button ID="removeButton" Text="Igen" OnClick="removeButton_Click" runat="server" />
</asp:Content>
