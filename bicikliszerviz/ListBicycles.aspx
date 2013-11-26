<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ListBicycles.aspx.cs" Inherits="bicikliszerviz.ListBicycles" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>A rendszerben lévő biciklik</h2>
    <p>Válasszon a listából az adatok ill. az ajánlatok megtekintéséhez.</p>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ArticleContent" runat="server">
    <table class="table">
        <tr>
            <th>Típus</th>
            <th>Ajánlatok száma</th>
            <th>Törlés</th>
        </tr>
        <% foreach (var b in list) { %>
        <tr>
            <td><a href="EditBicycle?bicycleID=<%= HttpUtility.UrlEncode(b.Id.ToString()) %>">
                <%: b.Type %>
            </a></td>
            <td><%: b.Offers.Count() %> ajánlat</td>
            <td><a href="RemoveBicycle?bicycleID=<%= HttpUtility.UrlEncode(b.Id.ToString()) %>">Törlés</a></td>
        </tr>
        <% } %>
    </table>
</asp:Content>
