<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="bicikliszerviz.Admin" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Admin</h2>
    <p>Ezen az oldalon lehet kiválasztani, mely felhasználók kezelik a szervízek adatait.</p>
</asp:Content>
<asp:Content ContentPlaceHolderID="ArticleContent" runat="server">
    <asp:CheckBoxList ID="UsersCheckBoxList" runat="server"></asp:CheckBoxList>
    <asp:Button ID="submitButton" Text="Mentés" runat="server" OnClick="submitButton_Click" CssClass="btn btn-default" />
</asp:Content>
