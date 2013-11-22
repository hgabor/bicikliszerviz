using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bicikliszerviz
{
    public partial class ListService : System.Web.UI.Page
    {
        protected List<Bicycle> bicycles;

        protected void Page_Load(object sender, EventArgs e)
        {
            using (var dc = new DataClassesDataContext())
            {
                var b = from bi in dc.Bicycles
                        select bi;
                bicycles = new List<Bicycle>(b);
            }
        }
    }
}