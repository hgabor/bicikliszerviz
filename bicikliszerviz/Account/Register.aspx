<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="bicikliszerviz.Account.Register" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>Regisztráció</h2>
    <p>Regisztrációhoz add meg a szükséges adatokat!</p>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="ArticleContent">
    <asp:CreateUserWizard runat="server" ID="RegisterUser" ViewStateMode="Disabled" OnCreatedUser="RegisterUser_CreatedUser" DisableCreatedUser="true" OnSendingMail="RegisterUser_SendingMail">
        <LayoutTemplate>
            <asp:PlaceHolder runat="server" ID="wizardStepPlaceholder" />
            <asp:PlaceHolder runat="server" ID="navigationPlaceholder" />
        </LayoutTemplate>
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server" ID="RegisterUserWizardStep">
                <ContentTemplate>
                    <p class="message-info">
                        A jelszónak minimum <%: Membership.MinRequiredPasswordLength %> karakter hosszúnak kell lennie.
                    </p>

                    <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>

                    <div class="form-horizontal">
                        <div class="form-group">
                            <asp:Label runat="server" AssociatedControlID="UserName" CssClass="control-label col-md-3">Felhasználónév:</asp:Label>
                            <span class="col-md-4"><asp:TextBox runat="server" ID="UserName" CssClass="form-control" /></span>
                            <span class="col-md-5"><asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="field-validation-error" ErrorMessage="A mező kitöltése kötelező." /></span>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server" AssociatedControlID="Email" CssClass="control-label col-md-3">E-mail cím:</asp:Label>
                            <span class="col-md-4"><asp:TextBox runat="server" ID="Email" CssClass="form-control" /></span>
                            <span class="col-md-5"><asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                CssClass="field-validation-error" ErrorMessage="A mező kitöltése kötelező." /></span>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server" AssociatedControlID="Password" CssClass="control-label col-md-3">Jelszó:</asp:Label>
                            <span class="col-md-4"><asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" /></span>
                            <span class="col-md-5"><asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                CssClass="field-validation-error" ErrorMessage="A mező kitöltése kötelező." /></span>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="control-label col-md-3">Jelszó megerősítése:</asp:Label>
                            <span class="col-md-4"><asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" /></span>
                            <span class="col-md-5">
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="A  mező kitöltése kötelező." />
                                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="A két jelszó nem egyezik meg." />
                            </span>
                        </div>
                        <div class="form-group">
                            <span class="col-md-2 col-md-offset-3"><asp:Button runat="server" CommandName="MoveNext" Text="Regisztráció" CssClass="btn btn-default" /></span>
                        </div>
                    </div>
                </ContentTemplate>
                <CustomNavigationTemplate />
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep>
                <ContentTemplate>
                    <p>A megadott e-mail címre elküldtünk egy levelet, amelyben a linkre kattinva aktiválhatja a fiókját.</p>
                </ContentTemplate>
            </asp:CompleteWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>
</asp:Content>