<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SetOffer.aspx.cs" Inherits="bicikliszerviz.SetOffer" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Ajánlattétel</h2>
    <p>Mennyi idő alatt és mennyiért tudná a bicikli javítását vállalni?</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ArticleContent" runat="server">
    <p>TODO: bicikli adatai</p>

    <div class="form-horizontal">
        <div class="form-group">
            <label class="col-md-3 control-label">Pénz: </label>
            <span class="col-md-7"><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></span>
            <span class="col-md-2">Ft</span>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">Idő: </label>
            <span class="col-md-7"><asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></span>
            <span class="col-md-2">munkanap</span>
        </div>
        <div class="form-group">
            <span class="col-md2 col-md-offset-3"><asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Mentés" CssClass="btn btn-default"/></span>
        </div>
    </div>

</asp:Content>
