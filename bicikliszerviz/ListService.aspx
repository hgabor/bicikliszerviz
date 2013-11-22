<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListService.aspx.cs" Inherits="bicikliszerviz.ListService" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <table border="0">
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
