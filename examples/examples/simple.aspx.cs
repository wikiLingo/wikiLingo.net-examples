using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PHP.Core;
using WikiLingo.Plugin;

namespace examples
{
    public partial class simple : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var c = ScriptContext.CurrentContext;
            ApplicationContext.Default.AssemblyLoader.Load(typeof(WikiLingo.Parser).Assembly, null);
            ApplicationContext.Default.AssemblyLoader.Load(typeof(Simple).Assembly, null);
            var wikiLingoParser = new WikiLingo.Parser();

            var output = wikiLingoParser.parse(c, @"{SIMPLE()}:){SIMPLE}");

            form1.InnerHtml = output.ToString();
        }
    }
}