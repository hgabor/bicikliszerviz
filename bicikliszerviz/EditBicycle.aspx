<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="EditBicycle.aspx.cs" Inherits="bicikliszerviz.Scripts.EditBicycle" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>Bicikli</h2>
    <p>Ezen az oldalon lehet új kerékpárt felvenni, vagy egy létezőt megtekinteni. Kérem adja meg a kerékpár adatait!</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ArticleContent" runat="server">
    <div class="form-horizontal">
        <div class="form-group">
            <asp:Label ID="typeLabel" runat="server" Text="Típus:" AssociatedControlID="typeTextBox" CssClass="col-md-3 control-label" />
            <span class="col-md-7"><asp:TextBox ID="typeTextBox" runat="server" CssClass="form-control" /></span>
        </div>
        <div class="form-group">
            <asp:Label ID="sizeLabel" runat="server" Text="Méret:" AssociatedControlID="sizeTextBox" CssClass="col-md-3 control-label" />
            <span class="col-md-7"><asp:TextBox ID="sizeTextBox" runat="server" CssClass="form-control" /></span>
        </div>
        <div class="form-group">
            <asp:Label ID="faultLabel" runat="server" Text="Hiba szöveges leírása" AssociatedControlID="faultTextBox" CssClass="col-md-3 control-label" />
            <span class="col-md-7"><asp:TextBox ID="faultTextBox" runat="server" TextMode="MultiLine" CssClass="form-control" /></span>
        </div>
        <div class="form-group">
            <span class="col-md-1 col-md-offset-3"><asp:Button ID="submitButton" runat="server" Text="Mentés" OnClick="submitButton_Click" CssClass="btn btn-default" /></span>
        </div>
    </div>

    <%  if(Request.QueryString["bicycleID"]!=null){ %>
        <%if(Repeater1.Items.Count==0){ %>
        <p>Eddig még nem érkezett ajánlat az adott kerékpárra.</p>
        <% }%>
        <% else{%>
         <table id="t1" class="table">
            <tr>
                    <th>Serviz neve</th>
                    <th>Ajánlat</th>
                    <th>Szerviz címe</th>
                    <th>Ajánlat elfogadása</th>
            </tr>
             <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <tr>
                    <td><asp:Literal ID="serviceNameLiteral" runat="server"></asp:Literal></td>
                    <td><asp:Literal ID="offerLiteral" runat="server"></asp:Literal></td>
                    <td><asp:Literal ID="addressLiteral" runat="server"></asp:Literal></td>
                    <td>
                        <% if (!HasAcceptedOffer) { %>
                            <asp:Button ID="acceptButton" CommandName="accept" Text="Elfogad" runat="server" CssClass="btn btn-default" />
                        <% } %>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </table>
        <%} %>
    <% }%>
</asp:Content>
