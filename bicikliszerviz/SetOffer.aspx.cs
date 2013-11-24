﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz
{
    public partial class SetOffer : BasePage
    {
        protected override string[] AllowedRoles
        {
            get
            {
                return new[] { "service" };
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            var bicycleID = Request.QueryString["bicycleID"];
            if (bicycleID != null)
            {
                // Existing bicycle
                var b = (from bi in this.db.Bicycles
                            where
                            bi.Id == Guid.Parse(bicycleID)
                            select bi).First();
            }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            var bicycleID = Request.QueryString["bicycleID"];
            var currentUser = System.Web.Security.Membership.GetUser();
            Ajanlat a = new Ajanlat();
            if (!string.IsNullOrWhiteSpace(TextBox1.Text) && !string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                a.BicycleId = Guid.Parse(bicycleID);
                a.ServiceId = (Guid)currentUser.ProviderUserKey;
                a.Cost = int.Parse(TextBox1.Text);
                a.Times = int.Parse(TextBox2.Text);

                this.db.Ajanlats.InsertOnSubmit(a);
                this.db.SubmitChanges();
            }
        }
    }
}