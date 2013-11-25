using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;

namespace bicikliszerviz.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
            
            RegisterUser.MailDefinition.BodyFileName = "~/EmailTemplates/NewAccount.html";
            RegisterUser.MailDefinition.From = Mailer.fromAddress;
            RegisterUser.MailDefinition.Subject = "Bicikliszerviz portál regisztráció";
            RegisterUser.MailDefinition.IsBodyHtml = true;

            RegisterUser.LoginCreatedUser = false;
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            //FormsAuthentication.SetAuthCookie(RegisterUser.UserName, createPersistentCookie: false);

            string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            if (!OpenAuth.IsLocalUrl(continueUrl))
            {
                continueUrl = "~/";
            }
            //Response.Redirect(continueUrl);
        }

        protected void RegisterUser_SendingMail(object sender, MailMessageEventArgs e)
        {
            var user = Membership.GetUser(RegisterUser.UserName);

            var url = Mailer.GetAbsoluteUrl(this.Request, "/Account/Verify.aspx?userid=" + user.ProviderUserKey.ToString());

            e.Message.Body = e.Message.Body.Replace("<%VerifyUrl%>", url);
        }
    }
}