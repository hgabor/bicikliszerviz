using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz
{
    public partial class RemoveBicycle : BasePage
    {
        protected Bicycle bicycle;
        protected override string[] AllowedRoles
        {
            get
            {
                return new[] { "login" };
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            var bicycleID = Request.QueryString["bicycleID"];
            if (bicycleID != null)
            {
                // Existing bicycle
                this.bicycle = (from bi in this.db.Bicycles
                            where
                            bi.UserId == (Guid)currentUser.ProviderUserKey &&
                            bi.Id == Guid.Parse(bicycleID)
                            select bi).FirstOrDefault();
            }
        }

        protected void removeButton_Click(object sender, EventArgs e)
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            Bicycle b;
            var bicycleID = Request.QueryString["bicycleID"];
            if (bicycleID != null)
            {
                // Existing bicycle
                b = (from bi in this.db.Bicycles
                                where
                                    bi.UserId == (Guid)currentUser.ProviderUserKey &&
                                    bi.Id == Guid.Parse(bicycleID)
                                select bi).FirstOrDefault();
                if (b == null) return;
            }
            else
            {
                return;
            }
            this.db.Bicycles.DeleteOnSubmit(b);
            this.db.SubmitChanges();
            Response.Redirect("ListBicycles");
        }
    }
}
