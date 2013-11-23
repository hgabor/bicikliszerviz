<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SetOffer.aspx.cs" Inherits="bicikliszerviz.SetOffer" %>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
     <p> Kiválasztás után ajánlattétel </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>Add meg a szervíz árajánlatát:</p>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br>

    <p>Add meg a javítás időtartamát napban:</p>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Mentés"/>
    <br>
</asp:Content>
