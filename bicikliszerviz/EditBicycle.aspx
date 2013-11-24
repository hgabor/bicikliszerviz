<%@ Page Title="" Language="C#" MasterPageFile="~/SiteWithFeaturedContent.master" AutoEventWireup="true" CodeBehind="EditBicycle.aspx.cs" Inherits="bicikliszerviz.Scripts.EditBicycle" %>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>Ezen az oldalon lehet új kerékpárt felvenni. Kérem adja meg a kerékpár adatait!</p>
    <asp:Label ID="typeLabel" runat="server" Text="Típus" AssociatedControlID="typeTextBox" />
    <asp:TextBox ID="typeTextBox" runat="server" />

    <asp:Label ID="sizeLabel" runat="server" Text="Méret" AssociatedControlID="sizeTextBox" />
    <asp:TextBox ID="sizeTextBox" runat="server" />

    <asp:Label ID="faultLabel" runat="server" Text="Hiba szöveges leírása" AssociatedControlID="faultTextBox" />
    <asp:TextBox ID="faultTextBox" runat="server" TextMode="MultiLine" />

    <asp:Button ID="submitButton" runat="server" Text="Mentés" OnClick="submitButton_Click" />
    <%  if(Request.QueryString["bicycleID"]!=null){ %>
        <%if(Repeater1.Items.Count==0){ %>
        <p>Eddig még nem érkezett ajánlat az adott kerékpárra.</p>
        <% }%>
        <% else{%>
         <table border="0" id="t1">
            <tr>
                    <th>Serviz neve</th>
                    <th>Árajánlat</th>
                    <th>Javítás időtartama (nap)</th>
                    <th>Szerviz címe</th>
                    <th>Ajánlat elfogadása</th>
            </tr>
             <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <td><asp:Literal ID="serviceNameLiteral" runat="server"></asp:Literal></td>
                <td><asp:Literal ID="offerLiteral" runat="server"></asp:Literal></td>
                <td><asp:Literal ID="timeLiteral" runat="server"></asp:Literal></td>
                <td><asp:Literal ID="addressLiteral" runat="server"></asp:Literal></td>
                <td><asp:Button ID="acceptButton" CommandName="accept" Text="Elfogad" runat="server" /></td>
            </ItemTemplate>
        </asp:Repeater>
        </table>
        <%} %>
    <% }%>
</asp:Content>
