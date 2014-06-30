using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PHP.Core;
using WikiLingo;

namespace WikiLingo.Plugin
{
    public class Simple : DotNetBase
    {
        public Simple(Parser parser)
        {
            htmlTagType = "span";
        }

        public override object render(Expression.Plugin plugin, String body, Renderer renderer, Parser parser)
        {

            body += "(:";
            return base.render(plugin,  body, renderer, parser);
        }
    }
}