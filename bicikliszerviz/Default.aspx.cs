using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz
{
    public partial class _Default : BasePage
    {
        protected List<Bicycle> list;

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Főoldal";
            var res = from b in this.db.Bicycles
                        select b;
            list = new List<Bicycle>(res);
        }
    }
}