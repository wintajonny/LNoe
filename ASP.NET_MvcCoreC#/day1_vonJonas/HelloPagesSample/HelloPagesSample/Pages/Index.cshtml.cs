using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloPagesSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Greeting { get; set; }
        public void OnGet(
            [FromQuery(Name = "n")]string name,
            [FromHeader(Name = "Accept-Language")]string lang)
        {
            //var name = Request.Query["name"];
            //if (name.Count == 1)
            if (!string.IsNullOrEmpty(name))
            {
                Greeting = $"Hallo, {name!}";
            }
            else
            {
                if (DateTime.Now.Hour < 12)
                    Greeting = "Good Morning";
                else
                    Greeting = "Good Evening";
            }
            Greeting += $"[{lang}]";
            Response.Headers.Add("X-Powered-By-Extra", "PAGES!!!");
        }
        public void OnPost([FromForm] string name)
        {
            Greeting = "Posted: " + name;
        }
    }
}
