﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using PHP;
using PHP.Core;
using PHP.Library;
using WikiLingo;

namespace examples
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var c = ScriptContext.CurrentContext;
            var globals = c.Globals;
            var output = new Literal();;
            ApplicationContext.Default.AssemblyLoader.Load(typeof(WikiLingo.Parser).Assembly, null);


            c.Include("Testify\\Testify.php", true);
            c.Include("test.php", true);
            var testSuite = c.BufferedOutput.GetContent().ToString();
            testSuite = testSuite.Replace("wikiLingo test suite", "wikiLingo.net test suite");
            output.Text = testSuite;
            Page.Controls.Add(output);
        }
    }
}