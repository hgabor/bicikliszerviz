<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListService.aspx.cs" Inherits="bicikliszerviz.ListService" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>Összes bicikli</h2>
    <p>Válasszon egy biciklit, amelyre ajánlatot szeretne tenni!</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ArticleContent" runat="server">
        <table class="table">
                <tr>
                    <th>Típus</th>
                    <th>Méret</th>
                    <th>Hiba leírása</th>
                </tr>
            <% foreach (var b in bicycles) { %>
                <tr>
                    <td><a href="SetOffer?bicycleID=<%= HttpUtility.UrlEncode(b.Id.ToString()) %>"><%:b.Type %></td>
                    <td><%:b.Size %></td>
                    <td><%:b.Fault %></td>
                </tr>
            <% } %>
        </table>
</asp:Content>
