﻿using System;
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

namespace examples
{
    public partial class bold : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var c = ScriptContext.CurrentContext;
            dynamic globals = ScriptContext.CurrentContext.Globals;
            var parser = (WikiLingo.Parser) globals.@namespace.WikiLingo.@class.Parser();
            var output = parser.parse(c, "bold");
            var t = "";
        }
    }
}