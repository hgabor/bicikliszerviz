using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bicikliszerviz
{
    public class BasePage: System.Web.UI.Page
    {
        protected DataClassesDataContext db = new DataClassesDataContext();

        protected virtual string[] AllowedRoles
        {
            get
            {
                return null;
            }
        }

        private bool IsUserAllowed()
        {
            if (AllowedRoles == null)
            {
                return true;
            }
            foreach (var role in AllowedRoles)
            {
                if (System.Web.Security.Roles.IsUserInRole(role))
                {
                    return true;
                }
            }
            return false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!IsUserAllowed())
            {
                if (User.Identity.IsAuthenticated)
                {
                    // If user is logged in, serve a 403 page
                    Response.StatusCode = 403;
                    Response.End();
                }
                else
                {
                    // Else redirect to login page
                    Response.Redirect("/Account/Login");
                }
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            db.Dispose();
        }
    }
}