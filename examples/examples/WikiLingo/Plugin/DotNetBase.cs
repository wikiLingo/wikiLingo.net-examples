using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PHP.Core;

namespace WikiLingo.Plugin
{
    public class DotNetBase : Base
    {
        public virtual object render(Expression.Plugin plugin, String body, Renderer renderer, Parser parser)
        {
            var bodyObject = body as object;
            var rendererObject = renderer as object;
            var parserObject = parser as object;

            return base.render(ref plugin,  ref bodyObject, ref rendererObject, ref parserObject);
        }
    }
}