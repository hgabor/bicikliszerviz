using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bicikliszerviz
{
    public partial class Offer
    {
        public override string ToString()
        {
            string s = string.Format("{0} Ft, {1} munkanap", this.Cost, this.Times);
            if (this.Selected) s += " (elfogadva)";
            return s;
        }
    }
}