using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz
{
    public partial class RemoveBicycle : System.Web.UI.Page
    {
        Bicycle bicycle;

        protected void Page_Load(object sender, EventArgs e)
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            using (var dc = new DataClassesDataContext())
            {
                var bicycleID = Request.QueryString["bicycleID"];
                if (bicycleID != null)
                {
                    // Existing bicycle
                    this.bicycle = (from bi in dc.Bicycles
                             where
                                bi.UserId == (Guid)currentUser.ProviderUserKey &&
                                bi.Id == Guid.Parse(bicycleID)
                             select bi).First();
                }
            }

        }

        protected void removeButton_Click(object sender, EventArgs e)
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            using (var dc = new DataClassesDataContext())
            {
                Bicycle b;
                var bicycleID = Request.QueryString["bicycleID"];
                if (bicycleID != null)
                {
                    // Existing bicycle
                    b = (from bi in dc.Bicycles
                                    where
                                       bi.UserId == (Guid)currentUser.ProviderUserKey &&
                                       bi.Id == Guid.Parse(bicycleID)
                                    select bi).First();
                }
                else
                {
                    return;
                }
                dc.Bicycles.DeleteOnSubmit(b);
                dc.SubmitChanges();
                Response.Redirect("ListBicycles");
            }
        }
    }
}
