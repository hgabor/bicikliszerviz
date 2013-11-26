<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SetOffer.aspx.cs" Inherits="bicikliszerviz.SetOffer" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Ajánlattétel</h2>
    <p>Mennyi idő alatt és mennyiért tudná a bicikli javítását vállalni?</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ArticleContent" runat="server">
    <p>TODO: bicikli adatai</p>

    Pénz: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    Idő: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Mentés"/>
</asp:Content>
