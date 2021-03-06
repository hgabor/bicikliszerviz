﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz.Scripts
{
    public partial class EditBicycle : BasePage
    {
        protected bool HasAcceptedOffer;

        protected override string[] AllowedRoles
        {
            get
            {
                return new[] { "login" };
            }
        }
        private void BindData()
        {
            var currentUser = System.Web.Security.Membership.GetUser();
            var bicycleID = Request.QueryString["bicycleID"];
            List<Offer> offers;
            if (bicycleID != null)
            {
                // Existing bicycle
                var b = (from bi in this.db.Bicycles
                         where
                         bi.UserId == (Guid)currentUser.ProviderUserKey &&
                         bi.Id == Guid.Parse(bicycleID)
                         select bi).FirstOrDefault();
                if (b != null && !IsPostBack)
                {
                    sizeTextBox.Text = b.Size.ToString();
                    typeTextBox.Text = b.Type;
                    faultTextBox.Text = b.Fault;
                }
                var ajanl = from ajanlat in this.db.Offers
                            join bicikli in this.db.Bicycles on ajanlat.BicycleId equals bicikli.Id
                            where bicikli.UserId == (Guid)currentUser.ProviderUserKey
                            select ajanlat;
                offers = new List<Offer>(ajanl);
            }
            else
            {
                offers = new List<Offer>();
            }
            Repeater1.DataSource = offers;
            Repeater1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                Response.Redirect("Account/Login.aspx");
            }
            var bicycleID = Request.QueryString["bicycleID"];
            if (bicycleID != null)
            {
                var currentUser = System.Web.Security.Membership.GetUser();
                Guid g;
                if (!Guid.TryParse(bicycleID, out g)) return;
                var bicycle = (from b in this.db.Bicycles
                               where b.Id == g && b.UserId == (Guid)currentUser.ProviderUserKey
                               select b).FirstOrDefault();
                HasAcceptedOffer = bicycle.Offers.Any(o => o.Selected);
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            BindData();
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
                        select bi).FirstOrDefault();
                if (b == null) return;
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

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Offer a = (Offer)e.Item.DataItem;

                ((Literal)e.Item.FindControl("serviceNameLiteral")).Text = a.Service.Name;
                ((Literal)e.Item.FindControl("offerLiteral")).Text = a.ToString();
                ((Literal)e.Item.FindControl("addressLiteral")).Text = a.Service.Address;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "accept")
            {
                if (HasAcceptedOffer) return;
                int i = e.Item.ItemIndex;
                var list = (List<Offer>)this.Repeater1.DataSource;
                list.ForEach(aj => aj.Selected = false);
                Offer a = list[i];
                a.Selected = true;
                this.db.SubmitChanges();
                Mailer.SendAcceptedOfferToService(a, this.Request);
            }
        }
    }
}
