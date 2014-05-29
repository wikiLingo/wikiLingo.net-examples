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
using PHP.Library;
using WikiLingo;
using WikiLingo.Utilities;
using WikiLingo.Utilities.Parameters;
using WikiLingo.Utilities.Tensor;
using WikiLingo.Expression;
using WikiLingo.Expression.BlockType;

namespace examples
{
    public partial class bold : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var c = ScriptContext.CurrentContext;
            ApplicationContext.Default.AssemblyLoader.Load(typeof(WikiLingo.Parser).Assembly, null);

            var wikiLingoParser = new WikiLingo.Parser();

            var output = wikiLingoParser.parse(c, @"__bold test__");

            form1.InnerHtml = output.ToString();
        }
    }
}