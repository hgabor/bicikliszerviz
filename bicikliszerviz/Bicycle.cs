﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace bicikliszerviz
{
    public partial class Bicycle
    {
        public MembershipUser Owner
        {
            get
            {
                return System.Web.Security.Membership.GetUser(this.UserId);
            }
            set
            {
                this.UserId = (Guid)value.ProviderUserKey;
            }
        }

        public Offer OwnOffer
        {
            get
            {
                var user = System.Web.Security.Membership.GetUser();
                return this.Offers.Where(o => o.ServiceId == (Guid)user.ProviderUserKey).FirstOrDefault();
            }
        }
    }
}