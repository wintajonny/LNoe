using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razorpages.Pages
{
    public class Demo1Model : PageModel
    {
        public Demo1Model(ILogger<Demo1Model> logger)
        {

        }

        public void OnGet()
        {
        }
    }
}
