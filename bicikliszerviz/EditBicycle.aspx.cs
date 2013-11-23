using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz.Scripts
{
    public partial class EditBicycle : BasePage
    {
        protected List<Ajanlat> offers;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                Response.Redirect("Account/Login.aspx");
            }

            var currentUser = System.Web.Security.Membership.GetUser();
            var bicycleID = Request.QueryString["bicycleID"];
            if (bicycleID != null)
            {
                // Existing bicycle
                var b = (from bi in this.db.Bicycles
                            where
                            bi.UserId == (Guid)currentUser.ProviderUserKey &&
                            bi.Id == Guid.Parse(bicycleID)
                            select bi).First();
                if (b != null && !IsPostBack)
                {
                    sizeTextBox.Text = b.Size.ToString();
                    typeTextBox.Text = b.Type;
                    faultTextBox.Text = b.Fault;
                }
                var ajanl = from ajanlat in this.db.Ajanlats
                            join bicikli in this.db.Bicycles on ajanlat.BicycleId equals bicikli.Id
                            where bicikli.UserId == (Guid)currentUser.ProviderUserKey
                            select ajanlat;
                offers = new List<Ajanlat>(ajanl);
            }
            else
            {
                offers = new List<Ajanlat>();
            }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            var bicycleID = Request.QueryString["bicycleID"];
            Bicycle b;
            if (bicycleID == null)
            {
                // New bicycle
                b = new Bicycle();
                b.Id = Guid.NewGuid();
                b.Owner = currentUser;
                this.db.Bicycles.InsertOnSubmit(b);
            }
            else
            {
                // Existing bicycle
                b = (from bi in this.db.Bicycles
                        where
                        bi.UserId == (Guid)currentUser.ProviderUserKey &&
                        bi.Id == Guid.Parse(bicycleID)
                        select bi).First();
            }
            b.Size = int.Parse(sizeTextBox.Text);
            b.Type = typeTextBox.Text;
            b.Fault = faultTextBox.Text;
            this.db.SubmitChanges();
            Response.Redirect("ListBicycles");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
