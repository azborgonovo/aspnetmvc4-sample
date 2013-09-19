using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace Mvc4ApplicationSample
{
    public class DisplayModesConfig
    {
        public static void RegisterDisplayModes(IList<IDisplayMode> displayModes)
        {
            displayModes.Insert(0, new DefaultDisplayMode("iPhone")
            {
                ContextCondition = (context =>
                    context.GetOverriddenUserAgent().IndexOf("iPhone", StringComparison.OrdinalIgnoreCase) >= 0)
            });
        }
    }
}