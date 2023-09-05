using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Nop.Plugin.Widgets.AskToOpenAI.Controller
{
    public class ChatGPTClient
    {
        private readonly string _apiKey;
        private readonly RestClient _client;
        public ChatGPTClient(string apiKey)
        {
            _apiKey = apiKey;
            _client = new RestClient("https://api.openai.com/v1/engines/text-davinci-003/completions");
        }

        public string SendMessage(string message)
        {
            var request = new RestRequest("", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {_apiKey}");
            var requestBody = new
            {
                prompt = message,
                max_tokens = 100,
                n = 1,
                stop = (string)null,
                temperature = 0.7,
            };

            request.AddJsonBody(JsonConvert.SerializeObject(requestBody));
            var response = _client.Execute(request);
            var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content ?? string.Empty);
            return jsonResponse?.choices[0]?.text?.ToString()?.Trim() ?? string.Empty;
        }
    }
}
