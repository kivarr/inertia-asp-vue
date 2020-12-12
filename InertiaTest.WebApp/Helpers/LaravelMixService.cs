using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace WebApp.Helpers
{
    public class LaravelMixService
    {
        private readonly IWebHostEnvironment _environment;

        public LaravelMixService(IWebHostEnvironment environment)
        {
            _environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public string GetAsset(string file)
        {
            var manifestPath = _environment.WebRootPath;
            var manifestFilePath = Path.Combine(manifestPath, "mix-manifest.json");

            if (!File.Exists(manifestFilePath))
                return file;

            var manifestRawContent = File.ReadAllText(manifestFilePath);
            var manifestContent = JsonConvert.DeserializeObject<Dictionary<string, string>>(manifestRawContent);

            return manifestContent.ContainsKey(file) ? manifestContent[file] : file;
        }
    }
}