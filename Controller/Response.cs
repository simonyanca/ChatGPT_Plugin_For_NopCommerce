using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Widgets.AskToOpenAI.Controller
{
    public class Response : BaseController
    {
        public string apiKey = "Your api key here";
        [HttpGet]
        public string GetResponse(string userQuestion)
        {
            var chatGPTClient = new ChatGPTClient(apiKey);
            if (userQuestion.ToLower() == "exit")
                return "";

            return chatGPTClient.SendMessage(userQuestion);
        }
    }
}
