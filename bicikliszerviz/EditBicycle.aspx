<%@ Page Title="" Language="C#" MasterPageFile="~/SiteWithFeaturedContent.master" AutoEventWireup="true" CodeBehind="EditBicycle.aspx.cs" Inherits="bicikliszerviz.Scripts.EditBicycle" %>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <p>Ezen az oldalon lehet új kerékpárt felvenni. Kérem adja meg a kerékpár adatait!</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="typeLabel" runat="server" Text="Típus" AssociatedControlID="typeTextBox" />
    <asp:TextBox ID="typeTextBox" runat="server" />

    <asp:Label ID="sizeLabel" runat="server" Text="Méret" AssociatedControlID="sizeTextBox" />
    <asp:TextBox ID="sizeTextBox" runat="server" />

    <asp:Label ID="faultLabel" runat="server" Text="Hiba szöveges leírása" AssociatedControlID="faultTextBox" />
    <asp:TextBox ID="faultTextBox" runat="server" TextMode="MultiLine" />

    <asp:Button ID="submitButton" runat="server" Text="Mentés" OnClick="submitButton_Click" />
</asp:Content>
