using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz
{
    public partial class ListService : BasePage
    {
        protected override string[] AllowedRoles
        {
            get
            {
                return new[] { "service" };
            }
        }
        protected List<Bicycle> bicycles;

        protected void Page_Load(object sender, EventArgs e)
        {
            var b = from bi in this.db.Bicycles
                    select bi;
            bicycles = new List<Bicycle>(b);
        }
    }
}