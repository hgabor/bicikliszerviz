<%@ Page Title="" Language="C#" MasterPageFile="~/SiteWithFeaturedContent.master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="bicikliszerviz.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    Ezen az oldalon lehet kiválasztani, mely felhasználók kezelik a szervízek adatait.
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:CheckBoxList ID="UsersCheckBoxList" runat="server"></asp:CheckBoxList>
    <asp:Button ID="submitButton" Text="Mentés" runat="server" OnClick="submitButton_Click" />
</asp:Content>
