<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/SiteWithFeaturedContent.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="bicikliszerviz._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            <p>
                To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                If you have any questions about ASP.NET visit
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
            </p>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>A rendszerben lévő biciklik:</h3>
    <ul>
        <% foreach (var b in list) { %>
        <li><%= HttpUtility.HtmlEncode(b.Type) %>,
            tulaj:
            <a href="mailto:<%= HttpUtility.UrlEncode(b.Owner.Email) %>"><%= HttpUtility.HtmlEncode(b.Owner.UserName) %></a>
        </li>
        <% } %>
    </ul>
</asp:Content>
