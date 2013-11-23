<%@ Page Title="" Language="C#" MasterPageFile="~/SiteWithFeaturedContent.master" AutoEventWireup="true" CodeBehind="ListBicycles.aspx.cs" Inherits="bicikliszerviz.ListBicycles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h3>A rendszerben lévő biciklik:</h3>
    <ul>
        <% foreach (var b in list) { %>
        <li>
            <a href="EditBicycle?bicycleID=<%= HttpUtility.UrlEncode(b.Id.ToString()) %>">
                <%: b.Type %>
            </a>
            tulaj:
            <a href="mailto:<%= HttpUtility.UrlEncode(b.Owner.Email) %>"><%: b.Owner.UserName %></a>
            <a href="RemoveBicycle?bicycleID=<%= HttpUtility.UrlEncode(b.Id.ToString()) %>">Törlés</a>

            Ajánlatok száma: <%: b.Ajanlats.Count() %>
        </li>
        <% } %>
    </ul>

</asp:Content>
