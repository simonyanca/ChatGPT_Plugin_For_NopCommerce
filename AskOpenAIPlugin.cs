using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Widgets.AskToOpenAI.Components;
using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.AskToOpenAI
{
    public class AskOpenAIPlugin : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => false;

        public Type GetWidgetViewComponent(string widgetZone)
        {
            return typeof(AskOpenAIViewComponent);
        }

        public async Task<IList<string>> GetWidgetZonesAsync()
        {
            var widgetZones = new List<string> { PublicWidgetZones.ProductDetailsInsideOverviewButtonsAfter};
            return await Task.FromResult(widgetZones);
        }
    }
}
