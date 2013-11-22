using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Felhasználók kezelése";

            if (!IsPostBack)
            {
                var users = Membership.GetAllUsers();
                UsersCheckBoxList.DataSource = new System.Collections.ArrayList(users);
                UsersCheckBoxList.DataBind();

                foreach (MembershipUser u in users)
                {
                    if (Roles.IsUserInRole(u.UserName, "service"))
                    {
                        UsersCheckBoxList.Items.FindByValue(u.UserName).Selected = true;
                    }
                }
            }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            using (var dc = new DataClassesDataContext())
            {
                foreach (ListItem v in UsersCheckBoxList.Items)
                {
                    if (v.Selected)
                    {
                        if (!Roles.IsUserInRole(v.Value, "service"))
                        {
                            Roles.AddUserToRole(v.Value, "service");
                            Service s = new Service();
                            s.UserId = (Guid)Membership.GetUser(v.Value).ProviderUserKey;
                            s.Address = "";
                            s.Name = "";
                            dc.Services.InsertOnSubmit(s);
                        }
                    }
                    else
                    {
                        if (Roles.IsUserInRole(v.Value, "service"))
                        {
                            Roles.RemoveUserFromRole(v.Value, "service");
                        }
                    }
                }
                dc.SubmitChanges();
            }
        }
    }
}