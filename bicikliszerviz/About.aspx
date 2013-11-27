<%@ Page Title="Rólunk" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="bicikliszerviz.About" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>Rólunk</h2>
    <p>A honlap készítői és elérhetőségeik:</p>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="ArticleContent">
    <ul>
        <li>        
            Halász Gábor <a href="mailto:hgabor kukac level14 pont hu">E-mail küldése</a> 
        </li>

        <li>        
            Andó Richárd <a href="mailto:ricsdo kukac gmail pont com">E-mail küldése</a> 
        </li>
    </ul>
</asp:Content>