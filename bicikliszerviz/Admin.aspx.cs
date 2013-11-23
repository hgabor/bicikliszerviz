using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz
{
    public partial class Admin : BasePage
    {
        protected override string[] AllowedRoles
        {
            get
            {
                return new[] { "admin" };
            }
        }

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
                            this.db.Services.InsertOnSubmit(s);
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
                this.db.SubmitChanges();
            }
    }
}