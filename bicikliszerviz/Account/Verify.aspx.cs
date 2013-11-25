using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz.Account
{
    public partial class Verify : System.Web.UI.Page
    {
        protected bool OK = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            //GET userid
            var userid = Request.QueryString["userid"];
            if (string.IsNullOrWhiteSpace(userid))
            {
                ShowError();
                return;
            }
            Guid guid;
            if (!Guid.TryParse(userid, out guid))
            {
                ShowError();
                return;
            }
            var user = System.Web.Security.Membership.GetUser(guid);
            if (user == null)
            {
                ShowError();
                return;
            }
            user.IsApproved = true;
            System.Web.Security.Membership.UpdateUser(user);
            ShowSuccess();
        }

        private void ShowError()
        {
            errorPanel.Visible = true;
            succesPanel.Visible = false;
        }

        private void ShowSuccess()
        {
            errorPanel.Visible = false;
            succesPanel.Visible = true;
        }

    }
}