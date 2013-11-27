<%@ Page Title="Összes bicikli" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListService.aspx.cs" Inherits="bicikliszerviz.ListService" %>
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
                    <th>Ajánlat</th>
                </tr>
            <% foreach (var b in bicycles) { %>
                <% if (b.OwnOffer != null) { %>
                <tr>
                    <td><%:b.Type %></td>
                    <td><%:b.Size %></td>
                    <td><%:b.Fault %></td>
                    <td><%:b.OwnOffer.ToString() %></td>
                </tr>
                <% } else { %>
                <tr>
                    <td><a href="SetOffer?bicycleID=<%= HttpUtility.UrlEncode(b.Id.ToString()) %>"><%:b.Type %></td>
                    <td><%:b.Size %></td>
                    <td><%:b.Fault %></td>
                    <td></td>
                </tr>
                <% } %>
            <% } %>
        </table>
</asp:Content>
