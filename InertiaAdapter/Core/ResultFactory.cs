using InertiaAdapter.Interfaces;
using InertiaAdapter.Models;
using Microsoft.AspNetCore.Html;
using System;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace InertiaAdapter.Core
{
    internal class ResultFactory : IResultFactory
    {
        public object? Share { get; set; }
        private string _rootView = "Views/App.cshtml";
        private object? _version;

        public void SetRootView(string s) => _rootView = s;

        public void Version(string version) => _version = version;

        public void Version(Func<string> version) => _version = version;

        public string? GetVersion() =>
            _version switch
            {
                Func<string> func => func(),
                string s => s,
                _ => null
            };

        public IHtmlContent Html(dynamic model)
        {
            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };
            
            var data = JsonConvert.SerializeObject(model, Formatting.None, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                StringEscapeHandling = StringEscapeHandling.EscapeHtml,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return new HtmlString($"<div id=\"app\" data-page=\'{data}\'></div>");
        }

        public Result Render(string component, object controller) =>
            new Result(new Props { Controller = controller, Share = Share }, component, _rootView, GetVersion());
    }
}