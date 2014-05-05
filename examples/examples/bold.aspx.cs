using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Query.Dynamic;
using System.Web.UI;
using System.Web.UI.WebControls;
using PHP.Core;
using WikiLingo;
using WikiLingo.Utilities;

namespace examples
{
    public partial class bold : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var c = ScriptContext.CurrentContext;
            var scripts = new Scripts(c);
            var parser = new Parser(ref scripts, null, null);
            var output = parser.parse(c, @"
__test__
");

            form1.InnerHtml = (string) output;
        }
    }
}