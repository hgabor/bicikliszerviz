using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.UI.WebControls;

using Microsoft.AspNet.Membership.OpenAuth;

namespace bicikliszerviz.Account
{
    public partial class Manage : BasePage
    {
        protected override string[] AllowedRoles
        {
            get
            {
                return new[] { "login" };
            }
        }
        protected string SuccessMessage
        {
            get;
            private set;
        }

        protected bool CanRemoveExternalLogins
        {
            get;
            private set;
        }

        protected void Page_Load()
        {
            if (!IsPostBack)
            {
                // Determine the sections to render
                var hasLocalPassword = OpenAuth.HasLocalPassword(User.Identity.Name);
                setPassword.Visible = !hasLocalPassword;
                changePassword.Visible = hasLocalPassword;

                CanRemoveExternalLogins = hasLocalPassword;

                // Render success message
                var message = Request.QueryString["m"];
                if (message != null)
                {
                    // Strip the query string from action
                    Form.Action = ResolveUrl("~/Account/Manage");

                    SuccessMessage =
                        message == "ChangePwdSuccess" ? "Your password has been changed."
                        : message == "SetPwdSuccess" ? "Your password has been set."
                        : message == "RemoveLoginSuccess" ? "The external login was removed."
                        : String.Empty;
                    successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
                }
            }


            // Data-bind the list of external accounts
            var accounts = OpenAuth.GetAccountsForUser(User.Identity.Name);
            CanRemoveExternalLogins = CanRemoveExternalLogins || accounts.Count() > 1;
        }

        protected void setPassword_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var result = OpenAuth.AddLocalPassword(User.Identity.Name, password.Text);
                if (result.IsSuccessful)
                {
                    Response.Redirect("~/Account/Manage?m=SetPwdSuccess");
                }
                else
                {

                    newPasswordMessage.Text = result.ErrorMessage;

                }
            }
        }


        protected void externalLoginsList_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {
            var providerName = (string)e.Keys["ProviderName"];
            var providerUserId = (string)e.Keys["ProviderUserId"];
            var m = OpenAuth.DeleteAccount(User.Identity.Name, providerName, providerUserId)
                ? "?m=RemoveLoginSuccess"
                : String.Empty;
            Response.Redirect("~/Account/Manage" + m);
        }

        protected T Item<T>() where T : class
        {
            return GetDataItem() as T ?? default(T);
        }


        protected static string ConvertToDisplayDateTime(DateTime? utcDateTime)
        {
            // You can change this method to convert the UTC date time into the desired display
            // offset and format. Here we're converting it to the server timezone and formatting
            // as a short date and a long time string, using the current thread culture.
            return utcDateTime.HasValue ? utcDateTime.Value.ToLocalTime().ToString("G") : "[never]";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service s;
            s = (from serv in this.db.Services
                 where
                 serv.UserId == (Guid)System.Web.Security.Membership.GetUser().ProviderUserKey
                 select serv).First();
            String name = TextBox1.Text;
            String address = TextBox2.Text;
            if(name.Equals(""))
            {
                name = s.Name;
            }
            if(address.Equals(""))
            {
                address = s.Address;
            }
           s.Name = name;
           s.Address = address;
           this.db.SubmitChanges();
           Response.Redirect("/default.aspx");
        }
    }
}