using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.AskToOpenAI.Components
{
    public class AskOpenAIViewComponent : NopViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone)
        {
            return await Task.FromResult(View("~/Plugins/Widgets.AskToOpenAI/Views/AskOpenAI.cshtml"));
        }
    }
}
