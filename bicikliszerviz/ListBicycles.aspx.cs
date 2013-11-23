using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz
{
    public partial class ListBicycles : BasePage
    {
        protected List<Bicycle> list;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                Response.Redirect("Account/Login.aspx");
            }

            var currentUser = System.Web.Security.Membership.GetUser();
            var res = from b in this.db.Bicycles
                        where b.UserId == (Guid)currentUser.ProviderUserKey
                        select b;
            list = new List<Bicycle>(res);
        }
    }
}