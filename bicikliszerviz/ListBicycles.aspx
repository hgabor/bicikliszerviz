<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ListBicycles.aspx.cs" Inherits="bicikliszerviz.ListBicycles" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>A rendszerben lévő biciklik</h2>
    <p>Válasszon a listából az adatok ill. az ajánlatok megtekintéséhez.</p>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ArticleContent" runat="server">
    <ul>
        <% foreach (var b in list) { %>
        <li>
            <a href="EditBicycle?bicycleID=<%= HttpUtility.UrlEncode(b.Id.ToString()) %>">
                <%: b.Type %>
            </a>
            <a href="RemoveBicycle?bicycleID=<%= HttpUtility.UrlEncode(b.Id.ToString()) %>">Törlés</a>
            Ajánlatok száma: <%: b.Ajanlats.Count() %>
        </li>
        <% } %>
    </ul>
</asp:Content>
